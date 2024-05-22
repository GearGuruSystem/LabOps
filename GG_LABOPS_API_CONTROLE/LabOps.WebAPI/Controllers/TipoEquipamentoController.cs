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
        public IActionResult BuscarTodosTiposDeEquipamentos()
        {
            try
            {
                var dados = applicationService.BuscarTodosTiposDeEquipamentos();
                return Ok(dados);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
