using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataContext;
using Microsoft.EntityFrameworkCore;

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

        public override Task<IEnumerable<Situacao>> BuscarTodos()
        {
            return base.BuscarTodos();
        }

        public override async Task Registrar(Situacao obj)
        {
            await base.Registrar(obj);
        }
        
        public override async Task Atualizar(Situacao obj)
        {
            await base.Atualizar(obj);
        }
    }
}