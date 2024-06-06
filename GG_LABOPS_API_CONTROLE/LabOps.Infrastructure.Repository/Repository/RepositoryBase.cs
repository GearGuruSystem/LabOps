using LabOps.Domain.Core.Interfaces;
using LabOps.Infrastructure.Data.DataContext;
using Microsoft.EntityFrameworkCore;

namespace LabOps.Infrastructure.Repository.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly AppDbContext context;

        protected RepositoryBase(AppDbContext context)
        {
            this.context = context;
        }

        public abstract Task<IEnumerable<TEntity>> BuscarTodos();

        public virtual async Task<ICollection<TEntity>> BuscarTodosPorPagina(int pageNumber, int pageSize)
        {
            return await context.Set<TEntity>().Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public abstract Task<TEntity> BuscarPorId(int id);

        public abstract Task<IEnumerable<TEntity>> BuscarPorParametro(TEntity obj);

        public abstract void Registrar(TEntity obj);

        public abstract void Atualizar(TEntity obj);

        public abstract void Remove(TEntity obj);
    }
}
