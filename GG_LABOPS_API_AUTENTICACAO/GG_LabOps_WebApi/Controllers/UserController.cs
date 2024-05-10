using GG_labOps_Domain.DTOs;
using GG_labOps_Domain.Entities;
using GG_labOps_Domain.Interfaces;
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
        public async Task<IActionResult> CadastrarUsuario([FromBody] RegisterUserDTO user)
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
        public async Task<IActionResult> BuscaUsuarioPelaChave([FromBody] string chaveUsuario)
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
                var userLogged = await _services.ValidUserAndGeneratesToken(user);
                return Ok(userLogged);
            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }
    }
}