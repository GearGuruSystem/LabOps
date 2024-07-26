using LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CaracteristicaValorController : ControllerBase
    {

        private readonly IApplicationServiceCaracteristicaValor _appCaracteristicaValor;

        public CaracteristicaValorController(IApplicationServiceCaracteristicaValor appCaracteristicaValor)
        {
            _appCaracteristicaValor = appCaracteristicaValor;
        }

        [HttpGet("BuscarValoresCaracteristica")]
        public IActionResult BuscarCaracteristicasRegistradas()
        {
            return NotFound();
        }
    }
}
