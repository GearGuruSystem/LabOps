using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Domain.Services.Services
{
    public class ServiceTipoEquipamento : ServiceBase<TipoEquipamento>, IServiceTipoEquipamento
    {
        public readonly IRepositoryTipoEquipamento repositoryTipoEquipamento;

        public ServiceTipoEquipamento(IRepositoryTipoEquipamento repositoryTipoEquipamento) :
            base(repositoryTipoEquipamento)
        {
            this.repositoryTipoEquipamento = repositoryTipoEquipamento;
        }
    }
}