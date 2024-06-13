using Auth.LabOps.Application.DTOs.DTOs.Usuario;
using Auth.LabOps.Application.Interfaces;
using Auth.LabOps.Presentation.WebAPI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationTests.Controller
{
    public class UsuarioControllerTest
    {
        private readonly UsuarioController _controller;
        private readonly IApplicationServiceUsuario _service;

        private readonly UsuarioDTO _usuarioDTO;
        private readonly List<UsuarioDTO> _usuariosDTO;

        public UsuarioControllerTest()
        {
            _service = Substitute.For<IApplicationServiceUsuario>();
            _controller = new UsuarioController(_service);
            _usuarioDTO = new UsuarioDTOFaker().Generate();
            _usuariosDTO = new UsuarioDTOFaker().Generate(10);
        }

        [Fact]
        public async Task BuscarTodosUsuarios_OK()
        {
            var controller = new List<UsuarioDTO>();
            _usuariosDTO.ForEach(x => controller.Add(x.CloneTipado()));
            _service.BuscarTodos().Returns(_usuariosDTO);

            ObjectResult result = (ObjectResult)await _controller.BuscarTodosUsuarios();

            await _service.Received().BuscarTodos();
        }
    }
}
