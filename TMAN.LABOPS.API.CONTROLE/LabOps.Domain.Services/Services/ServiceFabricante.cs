using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Domain.Services.Services
{
    public class ServiceFabricante : ServiceBase<Fabricante>, IServiceFabricante
    {
        public readonly IRepositoryFabricante repositoryFabricante;

        public ServiceFabricante(IRepositoryFabricante repositoryFabricante)
            : base(repositoryFabricante)
        {
            this.repositoryFabricante = repositoryFabricante;
        }
    }
}