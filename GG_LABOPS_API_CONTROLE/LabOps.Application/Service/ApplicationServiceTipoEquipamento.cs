using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Application.Service
{
    public class ApplicationServiceTipoEquipamento : IApplicationServiceTipoEquipamento
    {
        private readonly IServiceTipoEquipamento serviceTipoEquipamento;

        public ApplicationServiceTipoEquipamento(IServiceTipoEquipamento serviceTipoEquipamento)
        {
            this.serviceTipoEquipamento = serviceTipoEquipamento;
        }
    }
}
