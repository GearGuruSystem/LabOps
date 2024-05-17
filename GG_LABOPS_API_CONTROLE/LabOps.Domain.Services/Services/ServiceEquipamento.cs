using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Domain.Services.Services
{
    public class ServiceEquipamento : ServiceBase<Equipamento>, IServiceEquipamento
    {
        public readonly IRepositoryEquipamento repositoryEquipamento;

        public ServiceEquipamento(IRepositoryEquipamento repositoryEquipamento)
            : base(repositoryEquipamento)
        {
            this.repositoryEquipamento = repositoryEquipamento;
        }
    }
}
