using GG_LabOps_Application.Interfaces;
using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Exceptions;
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
            try
            {
                var data = await equipamentService.GetEquipamentsAsync();
                if (data != null)
                {
                    return Ok(data);
                }
                return NotFound();
            }
            catch (ConsultaNoBancoException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("BuscaEquipamentoPeloId")]
        public async Task<IActionResult> BuscaEquipamentosPeloId(int id)
        {
            try
            {
                var data = await equipamentService.GetEquipamentsAsync(id);
                if (data != null)
                {
                    return Ok(data);
                }
                return NotFound();
            }
            catch (ConsultaNoBancoException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CadastraEquipamento")]
        public async Task<IActionResult> CadastraEquipamento(CreateEquipamentDTO equipamentDTO)
        {
            await equipamentService.RegisterEquipament(equipamentDTO);
            return Created();
        }

        [HttpPut("AtualizaEquipamento")]
        public async Task<IActionResult> AtualizaEquipamento(int id, UpdateEquipamentDTO equipament)
        {
            var data = await equipamentService.UpdateEquipament(id, equipament);
            return Ok(data);
        }
    }
}
