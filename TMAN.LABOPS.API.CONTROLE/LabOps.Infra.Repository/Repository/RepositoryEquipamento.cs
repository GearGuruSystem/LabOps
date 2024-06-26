using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataAcess;
using LabOps.Infra.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.Repository.Repository
{
    public class RepositoryEquipamento : RepositoryBase<Equipamento>, IRepositoryEquipamento
    {
        private readonly SqlFactory sqlFactory;
        private readonly AppDbContext context;

        public RepositoryEquipamento(SqlFactory sqlFactory, AppDbContext context)
            : base(context)
        {
            this.sqlFactory = sqlFactory;
            this.context = context;
        }

        public override async Task<IEnumerable<Equipamento>> BuscarTodos()
        {
            var resultSql = await sqlFactory.LoadDataAsync<Equipamento, dynamic>("", new { });
            if (resultSql.IsNullOrEmpty())
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return resultSql;
        }

        public override async Task<Equipamento> BuscarPorId(int id)
        {
            var resultadoSql = await sqlFactory.LoadDataAsync<Equipamento, dynamic>("", new
            {
                @idParam = id
            });
            if (resultadoSql.Count < 0)
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return resultadoSql.FirstOrDefault();
        }

        public override void Registrar(Equipamento obj)
        {
            base.Registrar(obj);
        }

        public override void Atualizar(Equipamento obj)
        {
            base.Atualizar(obj);
        }

        public override void Deletar(Equipamento obj)
        {
            base.Deletar(obj);
        }

        public async Task<ICollection<Equipamento>> BuscarTodosPorPagina(int pageNumber, int pageSize)
        {
            return await context.Equipamentos.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }
    }
}