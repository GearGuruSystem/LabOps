using LabOps.Application.DTO.DTO.TipoEquipamento;
using LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class TipoEquipamentoController : ControllerBase
    {
        private readonly IApplicationServiceTipoEquipamento applicationService;

        public TipoEquipamentoController(IApplicationServiceTipoEquipamento applicationService)
        {
            this.applicationService = applicationService;
        }

        [HttpGet("BuscarTodosTiposDeEquipamentos")]
        public async Task<IActionResult> BuscarTodosTiposDeEquipamentos()
        {
            try
            {
                var dados = await applicationService.BuscarTodosTiposDeEquipamentos();
                return Ok(dados);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("RegistroTipoEquipamento")]
        public async Task<IActionResult> RegistraTipoEquipamento([FromBody] RegistroNovo registroNovo)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            try
            {
                await applicationService.RegistraNovoTipoEquipamento(registroNovo);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, $"{ex.Message}");
            }
        }
    }
}