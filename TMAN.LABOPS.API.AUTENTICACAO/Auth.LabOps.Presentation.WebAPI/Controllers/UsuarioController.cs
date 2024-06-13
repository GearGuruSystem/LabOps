using Auth.LabOps.Application.DTOs.DTOs.Usuario;
using Auth.LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace Auth.LabOps.Presentation.WebAPI.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    [Route("api/v1/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IApplicationServiceUsuario applicationServiceUsuario;

        public UsuarioController(IApplicationServiceUsuario applicationServiceUsuario)
        {
            this.applicationServiceUsuario = applicationServiceUsuario;
        }

        [HttpGet("BuscarTodosUsuario")]
        public async Task<IActionResult> BuscarTodosUsuarios()
        {
            try
            {
                var dados = await applicationServiceUsuario.BuscarTodos();
                return Ok(dados);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("BuscarPorId")]
        public async Task<IActionResult> BuscarPorId(int id)
        {
            try
            {
                var dados = await applicationServiceUsuario.Buscar(id);
                return Ok(dados);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("BuscarPelaChave")]
        public async Task<IActionResult> BuscarPelaChave(string chave)
        {
            try
            {
                var dados = await applicationServiceUsuario.Buscar(chave);
                return Ok(dados);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("Login")]
        public async Task<IActionResult> Login([FromBody] UsuarioLoginDTO usuarioDTO)
        {
            try
            {
                UsuarioLogadoDTO usuarioLogado = await applicationServiceUsuario.ValidaUsuarioGeraToken(usuarioDTO);
                return Ok(usuarioLogado);
            }
            catch (Exception ex)
            { 
                return NotFound($"Não foi possivel realizar o login! Erro:{ex.Message}");
            }
        }

        [HttpPost("RegistraUsuario")]
        public IActionResult RegistraUsuario(CriarUsuarioDTO criarUsuarioDTO)
        {
            try
            {
                applicationServiceUsuario.Criar(criarUsuarioDTO);
                return Ok("Usuario criado com sucesso");
            }
            catch (Exception)
            {
                return BadRequest("DEU ERRO");
            }
        }
    }
}
