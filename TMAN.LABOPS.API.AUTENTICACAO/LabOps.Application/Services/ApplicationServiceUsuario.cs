using Auth.LabOps.Application.DTOs.DTOs.Usuario;
using Auth.LabOps.Application.Interfaces;
using Auth.LabOps.Domain.Core.Services;
using Auth.LabOps.Domain.Entities;
using Auth.LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

#pragma warning disable IDE0290 // Use primary constructor

namespace Auth.LabOps.Application.Services
{
    public class ApplicationServiceUsuario : IApplicationServiceUsuario
    {
        private readonly IServiceUsuario service;
        private readonly IMapperUsuario mapperUsuario;

        public ApplicationServiceUsuario(IServiceUsuario service, IMapperUsuario mapperUsuario)
        {
            this.service = service;
            this.mapperUsuario = mapperUsuario;
        }

        public async Task<IEnumerable<UsuarioDTO>> BuscarTodos()
        {
            var usuarios = await service.BuscarTodos();
            return mapperUsuario.MapperListaUsuarios(usuarios);
        }

        public async Task<Usuario> Buscar(int id)
        {
            return await service.Buscar(id);
        }

        public async Task<UsuarioDTO> Buscar(string chave)
        {
            var usuario = await service.Buscar(chave);
            return mapperUsuario.MapperToDTO(usuario);
        }

        public void Criar(CriarUsuarioDTO criarUsuarioDTO)
        {
            var usuario = mapperUsuario.MapperToEntity(criarUsuarioDTO);
            service.Registrar(usuario);
        }

        public async Task<UsuarioLogadoDTO> ValidaUsuarioGeraToken(UsuarioLoginDTO UsuarioLoginDTO)
        {
            var usuario = mapperUsuario.MapperToEntity(UsuarioLoginDTO);
            await service.ValidaUsuarioGeraToken(usuario);
            return mapperUsuario.MapperToLogadoDTO(usuario);
        }
    }
}
