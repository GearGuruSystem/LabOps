﻿using GG_labOps_Domain.Entities;
using GG_LabOps_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GG_LabOps_WebApi.Controllers
{
#pragma warning disable IDE0290 // Use primary constructor
    public class UserController : ControllerBase
    {

        private readonly IUserService _services;

        public UserController(IUserService Services)
        {
            _services = Services;
        }

        [HttpPost("CadastraUsuario")]
        public async Task<IActionResult> CadastrarUsuario([FromBody] User user)
        {
            try
            {
                return Ok(await _services.AddUserAsync(user));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("BuscaUsuarioPorChave")]
        public async Task<IActionResult> BuscaUsuarioPelaChave(string chaveUsuario)
        {
            try
            {
                return Ok(await _services.GetUser(chaveUsuario));
            }
            catch (Exception)
            {
                return NotFound("Houve um problema");
            }
        }

        [HttpGet("Login")]
        public async Task<IActionResult> LoginUsuario([FromBody] User user)
        {
            try
            {
                return Ok(await _services.ValidUserAndGeneratesToken(user));
            }
            catch (Exception)
            { 
                return Unauthorized();
            }
        }
    }
}
