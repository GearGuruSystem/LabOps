using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Domain.Services.Services
{
    public class ServiceCaracteristicaValor : ServiceBase<CaracteristicaValor>, IServiceCaracteristicaValor
    {
        public readonly IRepositoryCaracteristicaValor _repositoryCaracteristicaValor;

        public ServiceCaracteristicaValor(IRepositoryCaracteristicaValor repositoryCaracteristicaValor) 
            : base(repositoryCaracteristicaValor)
        {
            _repositoryCaracteristicaValor = repositoryCaracteristicaValor;
        }
    }
}
