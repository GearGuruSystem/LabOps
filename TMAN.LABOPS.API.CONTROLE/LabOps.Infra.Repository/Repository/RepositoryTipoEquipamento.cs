using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataContext;
using Microsoft.Extensions.Logging;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.Repository.Repository
{
    public class RepositoryTipoEquipamento : RepositoryBase<TipoEquipamento>, IRepositoryTipoEquipamento
    {
        private readonly ILogger<RepositoryTipoEquipamento> _logger;

        public RepositoryTipoEquipamento(AppDbContext context, ILogger<RepositoryTipoEquipamento> logger) 
            : base(context) 
        {
            _logger = logger;
        }

        public override async Task<IEnumerable<TipoEquipamento>> BuscarTodos()
        {
            return await base.BuscarTodos();
        }

        public override async Task Atualizar(TipoEquipamento obj)
        {
            await base.Atualizar(obj);
        }

        public override async Task Registrar(TipoEquipamento obj)
        {
            await base.Registrar(obj);
        }

        public override async Task Deletar(TipoEquipamento obj)
        {
            await base.Deletar(obj);
        }
    }
}