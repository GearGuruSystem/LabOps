using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebAPI.Controllers
{
    [ApiController]
    [Consumes("application/json")]
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class EquipamentoController : ControllerBase
    {
        private readonly IApplicationServiceEquipamento _appService;
        private readonly ILogger<EquipamentoController> _logger;

        public EquipamentoController(IApplicationServiceEquipamento applicationService, ILogger<EquipamentoController> logger)
        {
            _appService = applicationService;
            _logger = logger;
        }

        [HttpGet("BuscarEquipamentos")]
        public async Task<IActionResult> BuscaTodosEquipamentos()
        {
            _logger.LogInformation("Iniciado busca de equipamentos");
            try
            {
                var data = await _appService.BuscaTodosEquipamentos();
                _logger.LogInformation("Retornando 200OK");
                return Ok(data);
            }
            catch (Exception)
            {
                _logger.LogError("Retornando 404NOTFOUND");
                return StatusCode(StatusCodes.Status404NotFound);
            }
        }

        [HttpGet("BuscarEquipamentoPeloId/{id:int}")]
        public async Task<IActionResult> BuscarEquipamentoComRetornoId(int id)
        {
            _logger.LogInformation("Iniciado busca de equipamentos");
            try
            {
                var data = await _appService.BuscarEquipamentoRetornoId(id);
                _logger.LogInformation("Retornando 200OK");
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError("Ocorreu um erro durante a busca. \nMensagem de erro: {error}", ex.Message);
                _logger.LogError("Retornando 404NOTFOUND");
                return StatusCode(StatusCodes.Status404NotFound);
            }
        }

        [HttpPost("CadastrarEquipamento")]
        public IActionResult CadastraEquipamento([FromBody] CriarNovo equipamentoDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _appService.RegistraEquipamento(equipamentoDTO);
                    return Created();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest();
        }

        [HttpPut("AtualizarEquipamento")]
        public IActionResult AtualizaEquipamento([FromBody] EquipamentoDTO equipamento)
        {
            try
            {
                _appService.AtualizaEquipamento(equipamento);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DesabilitarEquipamento")]
        public IActionResult DesabilitaEquipamento([FromBody] EquipamentoDTO equipamentoDTO)
        {
            try
            {
                _appService.RemoveEquipamento(equipamentoDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}