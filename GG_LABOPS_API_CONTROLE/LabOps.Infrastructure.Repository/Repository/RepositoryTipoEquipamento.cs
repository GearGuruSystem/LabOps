using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infrastructure.Data.DataAcess;
using LabOps.Infrastructure.Data.DataContext;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infrastructure.Repository.Repository
{
    public class RepositoryTipoEquipamento : RepositoryBase<TipoEquipamento>, IRepositoryTipoEquipamento
    {
        private readonly SqlFactory sqlFactory;

        public RepositoryTipoEquipamento(SqlFactory sqlFactory, AppDbContext context)
            : base(context)
        {
            this.sqlFactory = sqlFactory;
        }

        public override Task<IEnumerable<TipoEquipamento>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public override Task<ICollection<TipoEquipamento>> BuscarTodosPorPagina(int pageNumber, int pageSize)
        {
            return base.BuscarTodosPorPagina(pageNumber, pageSize);
        }

        public override Task<TipoEquipamento> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<TipoEquipamento>> BuscarPorParametro(TipoEquipamento obj)
        {
            throw new NotImplementedException();
        }

        public override void Atualizar(TipoEquipamento obj)
        {
            throw new NotImplementedException();
        }

        public override void Registrar(TipoEquipamento obj)
        {
            throw new NotImplementedException();
        }

        public override void Remove(TipoEquipamento obj)
        {
            throw new NotImplementedException();
        }
    }
}
