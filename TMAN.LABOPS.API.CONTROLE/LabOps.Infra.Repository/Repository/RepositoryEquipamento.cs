using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataAcess;
using LabOps.Infra.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using static Dapper.SqlMapper;

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

        #region Metodos Base
        public override async Task<IEnumerable<Equipamento>> BuscarTodos()
        {
            var resultSql = await sqlFactory.LoadDataAsync<Equipamento, dynamic>("", new { });
            if (resultSql.IsNullOrEmpty())
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return resultSql;
        }

        public override async Task<IEnumerable<Equipamento>> BuscarPorParametro(Equipamento obj)
        {
            var resultadoSql = await sqlFactory.LoadDataAsync<Equipamento, dynamic>("", new { });
            if (resultadoSql.IsNullOrEmpty())
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return resultadoSql;
        }

        public override async Task<Equipamento> BuscarPorId(int id)
        {
            var resultadoSql = await sqlFactory.LoadDataAsync<Equipamento, dynamic>("", new
            {
                @idParam = id
            });
            if (resultadoSql.Count != 0)
            {
                return resultadoSql.FirstOrDefault();
            }
            throw new Exception("Não foi encontrando nenhum registro no banco.");
        }

        public override void Registrar(Equipamento obj)
        {
            base.Registrar(obj);
        }

        public override async void Atualizar(Equipamento obj)
        {
            var result = await sqlFactory.SaveDataAsync("", new
            {
            });
            if (!result.IsCompleted)
            {
                throw new Exception();
            }
        }

        public override async void Remove(Equipamento obj)
        {
            var result = await sqlFactory.SaveDataAsync("", new
            {
            });
            if (!result.IsCompleted)
            {
                throw new Exception();
            }
        }
        #endregion

        public async Task<ICollection<Equipamento>> BuscarTodosPorPagina(int pageNumber, int pageSize)
        {
            return await context.Equipamentos.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }
    }
}