using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Application.Service
{
    public class ApplicationServiceLaboratorio : IApplicationServiceLaboratorio
    {
        private readonly IServiceLaboratorio service;

        public ApplicationServiceLaboratorio(IServiceLaboratorio service)
        {
            this.service = service;
        }
    }
}