using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GG_LabOps_WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EquipamentController : ControllerBase
    {
        private readonly IEquipamentService equipamentService;

#pragma warning disable IDE0290 // Use primary constructor
        public EquipamentController(IEquipamentService equipamentService)
        {
            this.equipamentService = equipamentService;
        }

        [HttpGet("BuscaEquipamentos")]
        public async Task<IActionResult> BuscaTodosEquipamentos()
        {
            return Ok(await equipamentService.GetEquipamentsAsync());
        }

        [HttpPost("CadastraEquipamento")]
        public async Task<IActionResult> CadastraEquipamento(Equipament equipament)
        {
            await equipamentService.RegisterEquipament(equipament);
            return Created();
        }
    }
}
