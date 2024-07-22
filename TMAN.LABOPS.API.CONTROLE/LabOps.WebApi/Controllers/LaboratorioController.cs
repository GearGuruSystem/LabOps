using LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class LaboratorioController : ControllerBase
    {
        private readonly IApplicationServiceLaboratorio _appService;

        public LaboratorioController(IApplicationServiceLaboratorio applicationService)
        {
            _appService = applicationService;
        }

        [HttpGet("BuscarTodosLaboratorios")]
        public IActionResult BuscarTodosLaboratorios()
        {
            try
            {
                var dados = 0;
                return Ok(dados);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}