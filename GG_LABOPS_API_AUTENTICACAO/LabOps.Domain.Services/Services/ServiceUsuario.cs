using Auth.LabOps.Domain.Core.Interfaces;
using Auth.LabOps.Domain.Core.Services;
using Auth.LabOps.Domain.Entities;

#pragma warning disable IDE0290 // Use primary constructor

namespace Auth.LabOps.Domain.Services.Services
{
    public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
    {
        public readonly IRepositoryUsuario repositoryUsuario;
        public ServiceUsuario(IRepositoryUsuario repositoryUsuario) 
            : base(repositoryUsuario)
        {
            this.repositoryUsuario = repositoryUsuario;
        } 
    }
}
