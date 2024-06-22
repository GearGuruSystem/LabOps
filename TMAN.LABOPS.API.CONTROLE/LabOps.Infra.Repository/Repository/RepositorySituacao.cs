using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataAcess;
using LabOps.Infra.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Net.Http.Headers;

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
        public async Task<IEnumerable<Situacao>> BuscarTodosComSituacaoAtiva()
        {
            var resultadoSql = await context.Situacoes.Where(a => a.Descricao == "Ativo").ToListAsync();
            if (resultadoSql.Count < 1)
            {
                throw new Exception("Encontrado nenhum registro no banco de dados");
            }
            return resultadoSql;
        }
        public override void Registrar(Situacao obj)
        {
            base.Registrar(obj);
        }

        public override void Atualizar(Situacao obj)
        {
            base.Atualizar(obj);
        }

    }
}