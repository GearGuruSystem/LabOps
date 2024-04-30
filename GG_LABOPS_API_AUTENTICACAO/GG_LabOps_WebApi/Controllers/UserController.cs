using GG_labOps_Domain.Entities;
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

        [HttpGet("BuscaUsuarioPorChave")]
        public async Task<IActionResult> BuscaUsuarioPelaChave(string chaveUsuario)
        {
            var result = await _services.GetUser(chaveUsuario);
            return Ok(result);
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
