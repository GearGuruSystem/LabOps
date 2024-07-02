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
            this._appService = applicationService;
            this._logger = logger;
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

        [HttpGet("BuscaEquipamentosPeloId/{id:int}")]
        public async Task<IActionResult> BuscaEquipamentosPeloId(int id)
        {
            try
            {
                var data = await _appService.BuscaPeloId(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        [HttpPost("CadastraEquipamento")]
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

        [HttpPut("AtualizaEquipamento")]
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

        [HttpDelete("DesabilitaEquipamento")]
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