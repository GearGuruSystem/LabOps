﻿using GG_LabOps_Application.Interfaces;
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
        private readonly IEquipamentService _equipamentService;

#pragma warning disable IDE0290 // Use primary constructor
        public EquipamentController(IEquipamentService equipamentService)
        {
            this._equipamentService = equipamentService;
        }

        [HttpGet("BuscaEquipamentos")]
        public async Task<IActionResult> BuscaTodosEquipamentos()
        {
            try
            {
                var data = await _equipamentService.GetEquipamentsAsync();
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
                var data = await _equipamentService.GetEquipamentsAsync(id);
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
            try
            {
                await _equipamentService.RegisterEquipament(equipamentDTO);
                return Created("api/v1/Equipament", equipamentDTO);
            }
            catch (ErroGenericoException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("AtualizaEquipamento")]
        public async Task<IActionResult> AtualizaEquipamento(int id, UpdateEquipamentDTO equipament)
        {
            try
            {
                var data = await _equipamentService.UpdateEquipament(id, equipament);
                return Ok(data);
            }
            catch (ErroGenericoException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> DesabilitaEquipamento(int id)
        {
            try
            {
                await _equipamentService.DisableEquipament(id);
                return Ok();
            }
            catch (ErroGenericoException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
