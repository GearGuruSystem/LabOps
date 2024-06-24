using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataContext;
using Microsoft.Extensions.Logging;


namespace LabOps.Infra.Repository.Repository
{
    public class RepositoryTipoEquipamento(AppDbContext context, ILogger<RepositoryTipoEquipamento> logger) : RepositoryBase<TipoEquipamento>(context), IRepositoryTipoEquipamento
    {
        private readonly ILogger<RepositoryTipoEquipamento> logger = logger;

        public override async Task<IEnumerable<TipoEquipamento>> BuscarTodos()
        {
            logger.LogInformation("Executando busca dos tipos de equipamentos cadastrados");
            var resultSql = await base.BuscarTodos();
            if (!resultSql.Any())
            {
                logger.LogError("Não foi encontrado nenhum registro no banco");
                throw new Exception("Não foi encontrado nenhum registro no banco de dados");
            }
            return resultSql.ToList();
        }

        public override void Atualizar(TipoEquipamento obj)
        {
            base.Atualizar(obj);
        }

        public override void Registrar(TipoEquipamento obj)
        {
            base.Registrar(obj);
        }

        public override void Remove(TipoEquipamento obj)
        {
            base.Remove(obj);
        }
    }
}