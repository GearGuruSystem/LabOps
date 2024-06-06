using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infrastructure.Data.DataAcess;
using LabOps.Infrastructure.Data.DataContext;
using Microsoft.IdentityModel.Tokens;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infrastructure.Repository.Repository
{
    public class RepositorySituacao : RepositoryBase<Situacao>, IRepositorySituacao
    {
        private readonly SqlFactory sqlFactory;

        public RepositorySituacao(SqlFactory sqlFactory, AppDbContext context)
    : base(context)
        {
            this.sqlFactory = sqlFactory;
        }

        public override async Task<IEnumerable<Situacao>> BuscarTodos()
        {
            var resultadoSql = await sqlFactory.LoadDataAsync<Situacao, dynamic>("", new { });
            if (resultadoSql.IsNullOrEmpty())
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return resultadoSql;
        }

        public override Task<ICollection<Situacao>> BuscarTodosPorPagina(int pageNumber, int pageSize)
        {
            return base.BuscarTodosPorPagina(pageNumber, pageSize);
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

        public override void Registrar(Situacao obj)
        {
            throw new NotImplementedException();
        }

        public override void Atualizar(Situacao obj)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Situacao obj)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<Situacao>> BuscarPorParametro(Situacao obj)
        {
            throw new NotImplementedException();
        }
    }
}