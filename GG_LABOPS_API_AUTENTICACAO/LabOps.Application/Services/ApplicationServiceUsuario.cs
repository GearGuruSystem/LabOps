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

        public async Task<IEnumerable<Usuario>> BuscarTodos()
        {
            return await service.BuscarTodos();
        }

        public async Task<Usuario> Buscar()
        {
            return await service.Buscar();
        }

        public void Criar(Usuario usuario)
        {
            service.Registrar(usuario);
        }
    }
}
