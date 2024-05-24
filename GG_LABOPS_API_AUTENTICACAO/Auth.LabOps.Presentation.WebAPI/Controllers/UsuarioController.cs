using Auth.LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Auth.LabOps.Presentation.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IApplicationServiceUsuario service;

        public UsuarioController(IApplicationServiceUsuario service)
        {
            this.service = service;
        }

        [HttpGet("BuscarTodosUsuario")]
        public async Task<IActionResult> BuscarTodosUsuarios()
        {
            try
            {
                var dados = await service.BuscarTodos();
                return Ok(dados);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
