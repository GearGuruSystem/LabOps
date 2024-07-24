using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataContext;
using Microsoft.Extensions.Logging;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.Repository.Repository
{
    public class RepositoryEquipamentoCaracteristica : RepositoryBase<EquipamentoCaracteristica>, IRepositoryEquipamentoCaracteristica
    {
        private readonly ILogger<EquipamentoCaracteristica> _logger;

        public RepositoryEquipamentoCaracteristica(AppDbContext context, ILogger<EquipamentoCaracteristica> logger) 
            : base(context)
        {
            _logger = logger;
        }

        public EquipamentoCaracteristica BuscarCaracteristicaEquipamento()
        {
            throw new NotImplementedException();
        }

        public void CadastrarCaracteristicaEquipamento(EquipamentoCaracteristica equipamentoCaracteristica)
        {
            throw new NotImplementedException();
        }
    }
}
