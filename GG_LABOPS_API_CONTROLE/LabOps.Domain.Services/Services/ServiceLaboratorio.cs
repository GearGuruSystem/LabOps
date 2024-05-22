using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Domain.Services.Services
{
    public class ServiceLaboratorio : ServiceBase<Laboratorio>, IServiceLaboratorio
    {
        private readonly IRepositoryLaboratorio repository;
        public ServiceLaboratorio(IRepositoryLaboratorio repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}
