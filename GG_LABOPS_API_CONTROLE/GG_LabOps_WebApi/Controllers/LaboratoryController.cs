using GG_LabOps_Application.Interfaces;
using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;
#pragma warning disable IDE0290 // Use primary constructor

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

        // METODO NÃO ESTA COMPLETO. FALTA CORRIGIR EXCEPTION
        [HttpGet("BuscaTodosCadastro")]
        public async Task<IActionResult> BuscarTudoCadastradoNoLaboratorio()
        {
            try
            {
                var data = await services.GetAllAsync();
                if (data != null)
                {
                    return Ok(data);
                }
                return NotFound("Não foi encontrado nenhum equipamento.");
            }
            catch (ConsultaNoBancoException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // METODO NÃO ESTA COMPLETO. FALTA CORRIGIR EXCEPTION
        [HttpGet("BuscaPeloHostname")]
        public async Task<IActionResult> BuscarEquipamentoPeloHostname(string hostname)
        {
            try
            {
                var data = await services.GetByHostnameAsync(hostname);
                if (data != null)
                {
                    return Ok(data);
                }
                return NotFound("Não foi encontrado nenhum equipamento.");
            }
            catch (ConsultaNoBancoException ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // METODO NÃO ESTA COMPLETO. FALTA CORRIGIR EXCEPTION
        [HttpGet("BuscaPeloInventario")]
        public async Task<IActionResult> BuscarEquipamentoPeloInventario(string inventory)
        {
            try
            {
                var data = await services.GetByInvetoryAsync(inventory);
                if (data != null)
                {
                    return Ok(data);
                }
                return NotFound("Não foi encontrado nenhum equipamento.");
            }
            catch (ConsultaNoBancoException ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // METODO NÃO ESTA COMPLETO.
        [HttpPost("Cadastro")]
        public async Task<IActionResult> CadastraEquipamentoNoLaboratorio(Laboratory laboratory)
        {
            var data = await services.CreateAsync(laboratory);
            if (data != null)
            {
                return Ok();
            }
            return StatusCode(StatusCodes.Status304NotModified);
        }

        // NÃO ESTA COMPLETO.
        [HttpPut("Atualiza/{id:int}")]
        public async Task<IActionResult> AtualizaEquipamentoDoLaboratorio(int id, Laboratory laboratory)
        {
            var data = await services.UpdateAsync(id, laboratory);
            if (data != null)
            {
                return Ok();
            }
            return StatusCode(StatusCodes.Status304NotModified);
        }

        // METODO NÃO ESTA COMPLETO.
        [HttpPut("Desabilita/{id:int}")]
        public IActionResult DesativaEquipamentoDoLaboratorio(int id)
        {
            var data = services.DisableById(id);
            if (data == true)
            {
                return Ok();
            }
            return StatusCode(StatusCodes.Status304NotModified);
        }
    }
}
