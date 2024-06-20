using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataAcess;
using LabOps.Infra.Data.DataContext;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.Repository.Repository
{
    public class RepositoryTipoEquipamento : RepositoryBase<TipoEquipamento>, IRepositoryTipoEquipamento
    {
        private readonly SqlFactory sqlFactory;
        private readonly ILogger<RepositoryTipoEquipamento> logger;

        public RepositoryTipoEquipamento(SqlFactory sqlFactory, AppDbContext context, ILogger<RepositoryTipoEquipamento> logger)
            : base(context)
        {
            this.sqlFactory = sqlFactory;
            this.logger = logger;
        }

        #region Metodos base
        public override async Task<IEnumerable<TipoEquipamento>> BuscarTodos()
        {
            logger.LogInformation("Executando procedure para buscar tipos de equipamento.");
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
        #endregion
    }
}