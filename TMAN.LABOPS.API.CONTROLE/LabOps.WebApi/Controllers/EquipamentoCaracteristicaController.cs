using LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EquipamentoCaracteristicaController : ControllerBase
    {
        private readonly IApplicationServiceEquipamentoCaracteristica _appEquipamentoCaracteristica;

        public EquipamentoCaracteristicaController(IApplicationServiceEquipamentoCaracteristica appService)
        {
            _appEquipamentoCaracteristica = appService;
        }

        [HttpPost]
        public IActionResult CadastrarCaracteristicaEquipamento()
        {
            return NotFound();
        }
    }
}
