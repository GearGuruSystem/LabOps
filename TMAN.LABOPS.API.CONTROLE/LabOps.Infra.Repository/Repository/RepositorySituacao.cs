using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataAcess;
using LabOps.Infra.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.IdentityModel.Tokens;
using System.Net.Http.Headers;

namespace LabOps.Infra.Repository.Repository
{
    public class RepositorySituacao(AppDbContext context) : RepositoryBase<Situacao>(context), IRepositorySituacao
    {
        private readonly AppDbContext _context = context;

        public async Task<IEnumerable<Situacao>> BuscarTodosComSituacaoAtiva()
        {
            var resultadoSql = await _context.Situacoes.Where(a => a.Descricao.Contains("Ativ")).ToListAsync();
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