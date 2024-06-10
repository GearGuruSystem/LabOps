using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataAcess;
using LabOps.Infra.Data.DataContext;
using Microsoft.IdentityModel.Tokens;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.Repository.Repository
{
    public class RepositorySituacao : RepositoryBase<Situacao>, IRepositorySituacao
    {
        private readonly SqlFactory sqlFactory;
        private readonly AppDbContext context;

        public RepositorySituacao(SqlFactory sqlFactory, AppDbContext context) : base(context)
        {
            this.sqlFactory = sqlFactory;
            this.context = context;
        }

        #region Metodos Base
        public override async Task<IEnumerable<Situacao>> BuscarTodos()
        {
            var resultadoSql = await sqlFactory.LoadDataAsync<Situacao, dynamic>("", new { });
            if (resultadoSql.IsNullOrEmpty())
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return resultadoSql;
        }

        public override async Task<Situacao> BuscarPorId(int id)
        {
            var resultadoSql = await sqlFactory.LoadDataAsync<Situacao, dynamic>("", new { @ParamId = id });
            if (resultadoSql.IsNullOrEmpty())
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return resultadoSql.FirstOrDefault();
        }
        
        public override Task<IEnumerable<Situacao>> BuscarPorParametro(Situacao obj)
        {
            throw new NotImplementedException();
        }

        public override void Registrar(Situacao obj)
        {
            base.Registrar(obj);
        }

        public override void Atualizar(Situacao obj)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Situacao obj)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}