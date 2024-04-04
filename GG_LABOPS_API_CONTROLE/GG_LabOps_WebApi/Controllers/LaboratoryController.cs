using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GG_LabOps_WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LaboratoryController : Controller
    {
        private readonly ILaboratoryServices services;

        public LaboratoryController(ILaboratoryServices services)
        {
            this.services = services;
        }

        // METODO NÃO ESTA COMPLETO.
        // NÃO IMPLEMENTADO
        [HttpGet("BuscaTodosCadastro")]
        public async Task<IActionResult> BuscarTudoCadastradoNoLaboratorio()
        {
            await services.GetAllAsync();
            return StatusCode(StatusCodes.Status501NotImplemented);
        }

        // METODO NÃO ESTA COMPLETO.
        // NÃO IMPLEMENTADO
        [HttpGet("BuscaPeloHostname")]
        public async Task<IActionResult> BuscarEquipamentoPeloHostname(string hostname)
        {
            await services.GetByHostnameAsync(hostname);
            return StatusCode(StatusCodes.Status501NotImplemented);
        }

        // METODO NÃO ESTA COMPLETO.
        // NÃO IMPLEMENTADO
        [HttpGet("BuscaPeloInventario")]
        public async Task<IActionResult> BuscarEquipamentoPeloInventario(string inventory)
        {
            await services.GetByInvetoryAsync(inventory);
            return StatusCode(StatusCodes.Status501NotImplemented);
        }

        // METODO NÃO ESTA COMPLETO.
        // NÃO IMPLEMENTADO.
        [HttpPost("Cadastro")]
        public async Task<IActionResult> CadastraEquipamentoNoLaboratorio(Laboratory laboratory)
        {
            await services.CreateAsync(laboratory);
            return StatusCode(StatusCodes.Status501NotImplemented);
        }

        // METODO NÃO ESTA COMPLETO.
        // NÃO IMPLEMENTADO.
        [HttpPut("Atualiza/{id:int}")]
        public async Task<IActionResult> AtualizaEquipamentoDoLaboratorio(int id, Laboratory laboratory)
        {
            await services.UpdateAsync(id, laboratory);
            return StatusCode(StatusCodes.Status501NotImplemented);
        }

        // METODO NÃO ESTA COMPLETO.
        // NÃO IMPLEMENTADO.
        [HttpPut("Desabilita/{id:int}")]
        public IActionResult DesativaEquipamentoDoLaboratorio(int id)
        {
            services.DisableById(id);
            return StatusCode(StatusCodes.Status501NotImplemented);
        }
    }
}
