using LabOps.Application.DTO.DTO.Fabricantes;
using LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebAPI.Controllers
{
    [ApiController]
    [Consumes("application/json")]
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class FabricanteController : ControllerBase
    {
        private readonly IApplicationServiceFabricante applicationService;
        private readonly ILogger<FabricanteController> logger;

        public FabricanteController(IApplicationServiceFabricante applicationService, ILogger<FabricanteController> logger)
        {
            this.applicationService = applicationService;
            this.logger = logger;
        }

        /// <summary>
        /// Criado por Guian Rocha 14/06/2024 → Falta testes
        /// </summary>
        /// <returns>
        /// Todos Fabricantes cadastrados.
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("BuscarTodosFabricantes")]
        public async Task<IActionResult> BuscarTodosFabricantes()
        {
            logger.LogInformation("Iniciando processo para buscar informações no banco");
            try
            {
                var data = await applicationService.BuscaTodosFabricantes();
                logger.LogInformation("Quantidade de dados retornados: [{@Dados}]", data.Count());
                return Ok(data);
            }
            catch (Exception ex)
            {
                logger.LogError("Ocorreu um erro: [{@Mensagem}]", ex.Message);
                return StatusCode(StatusCodes.Status404NotFound, "Ocorreu um erro ao buscar os fabricantes cadastrados.");
            }
        }

        [HttpGet("BuscarFabricantePeloId/{id:int}")]
        public async Task<IActionResult> BuscarFabricantePeloId(int id)
        {
            logger.LogInformation("Iniciando processo para buscar informações no banco");
            try
            {
                var data = await applicationService.BuscaFabricantesPeloId(id);
                logger.LogInformation("Encontrado o seguinte fabricante: [{@Dados}]", data.Nome);
                return Ok(data);
            }
            catch (Exception ex)
            {
                logger.LogError("Ocorreu um erro: [{@Mensagem}]", ex.Message);
                return StatusCode(StatusCodes.Status404NotFound, "Ocorreu um erro ao buscar os fabricantes cadastrados.");
            }
        }

        [HttpPost("CadastraFabricante")]
        public IActionResult CadastraFabricante([FromBody] CriarNovo fabricanteDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    applicationService.RegistraFabricante(fabricanteDTO);
                    return Created("api/v1/fabricante", fabricanteDTO);
                }
                catch (Exception ex)
                {
                    logger.LogError("Ocorreu um erro: [{@Mensagem}]", ex.Message);
                    return StatusCode(StatusCodes.Status400BadRequest, "Não foi possivel fazer registro.");
                }
            }
            return StatusCode(StatusCodes.Status400BadRequest);
        }

        [HttpPut("AtualizaFabricante")]
        public IActionResult AtualizarFabricante([FromBody] Atualizar fabricanteDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    applicationService.AtualizaFabricante(fabricanteDTO);
                    return Ok();
                }
                catch (Exception ex)
                {
                    logger.LogError("Ocorreu um erro: [{@Mensagem}]", ex.Message);
                    return StatusCode(StatusCodes.Status400BadRequest, "Não foi possivel realizar atualização.");
                }
            }
            return BadRequest();
        }

        [HttpDelete("RemoveFabricante")]
        public IActionResult RemoveFabricante([FromBody] FabricanteDTO fabricanteDTO)
        {
            try
            {
                applicationService.RemoveFabricante(fabricanteDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError("Ocorreu um erro: [{@Mensagem}]", ex.Message);
                return StatusCode(StatusCodes.Status400BadRequest, "Não foi possivel realizar atualização.");
            }
        }
    }
}