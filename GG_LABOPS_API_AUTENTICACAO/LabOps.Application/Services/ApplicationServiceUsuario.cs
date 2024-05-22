using Auth.LabOps.Application.Interfaces;
using Auth.LabOps.Domain.Core.Services;

#pragma warning disable IDE0290 // Use primary constructor

namespace Auth.LabOps.Application.Services
{
    public class ApplicationServiceUsuario : IApplicationServiceUsuario
    {
        private readonly IServiceUsuario service;

        public ApplicationServiceUsuario(IServiceUsuario service)
        {
            this.service = service;
        }
    }
}
