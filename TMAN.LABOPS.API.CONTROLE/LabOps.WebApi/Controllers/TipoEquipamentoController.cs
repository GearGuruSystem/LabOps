using LabOps.Application.DTO.DTO.TipoEquipamento;
using LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TipoEquipamentoController : ControllerBase
    {
        private readonly IApplicationServiceTipoEquipamento _appService;

        public TipoEquipamentoController(IApplicationServiceTipoEquipamento applicationService)
        {
            _appService = applicationService;
        }

        [HttpGet("BuscarTodosTiposDeEquipamentos")]
        public async Task<IActionResult> BuscarTodosTiposDeEquipamentos()
        {
            try
            {
                var dados = await _appService.BuscarTodosTiposDeEquipamentos();
                return Ok(dados);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("RegistrarTipoEquipamento")]
        public IActionResult RegistraTipoEquipamento([FromBody] RegistroNovoTipoEquipamentoDTO registroNovo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _appService.RegistraNovoTipoEquipamento(registroNovo);
                    return Created();
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, $"{ex.Message}");
                }
            }
            return StatusCode(StatusCodes.Status400BadRequest);
        }
    }
}