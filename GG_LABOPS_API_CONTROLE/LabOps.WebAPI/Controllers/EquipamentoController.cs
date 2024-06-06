﻿using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EquipamentoController : ControllerBase
    {
        private readonly IApplicationServiceEquipamento applicationService;

        public EquipamentoController(IApplicationServiceEquipamento applicationService)
        {
            this.applicationService = applicationService;
        }

        /// <summary>
        /// Faz uma varedura do mais recente cadastrado para o mais antigo.
        /// </summary>
        /// <param name="numeroPagina"></param>
        /// <param name="tamanhoPagina"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("BuscarEquipamentos")]
        public async Task<IActionResult> BuscaTodosEquipamentos([FromQuery] int numeroPagina, [FromQuery] int tamanhoPagina)
        {
            try
            {
                var data = await applicationService.BuscaTodosEquipamentos(numeroPagina, tamanhoPagina);
                return Ok(data);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("BuscarEquipamentoPeloId/{id:int}")]
        public async Task<IActionResult> BuscaEquipamentosPeloId(int id)
        {
            try
            {
                var data = await applicationService.BuscaEquipamentoPeloId(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        [HttpPost("CadastraEquipamento")]
        public IActionResult CadastraEquipamento([FromBody] EquipamentoDTO equipamentDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    applicationService.RegistraEquipamento(equipamentDTO);
                    return Created(nameof(BuscaEquipamentosPeloId), equipamentDTO.IDEquipamento);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest();
        }

        [HttpPut("AtualizaEquipamento")]
        public IActionResult AtualizaEquipamento([FromBody] EquipamentoDTO equipament)
        {
            try
            {
                applicationService.AtualizaEquipamento(equipament);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DesabilitaEquipamento")]
        public IActionResult DesabilitaEquipamento(EquipamentoDTO equipamentoDTO)
        {
            try
            {
                applicationService.RemoveEquipamento(equipamentoDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
