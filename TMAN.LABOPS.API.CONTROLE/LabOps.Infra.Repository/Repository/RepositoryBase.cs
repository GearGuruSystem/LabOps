using LabOps.Domain.Core.Interfaces;
using LabOps.Infra.Data.DataContext;
using Microsoft.EntityFrameworkCore;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.Repository.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly AppDbContext context;

        public RepositoryBase(AppDbContext context)
        {
            this.context = context;
        }

        public virtual async Task<IEnumerable<TEntity>> BuscarTodos()
        {
            var result = await context.Set<TEntity>().ToListAsync();
            if (result.Count < 1)
            {
                return Enumerable.Empty<TEntity>();
            }
            return result;
        }

        public virtual async Task<TEntity> BuscarPorId(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public virtual async void Registrar(TEntity obj)
        {
            await context.Set<TEntity>().AddAsync(obj);
            await context.SaveChangesAsync();
        }

        public virtual async void Atualizar(TEntity obj)
        {
            await context.Set<TEntity>().AddAsync(obj);
            await context.SaveChangesAsync();
        }

        public virtual async void Deletar(TEntity obj)
        {
            context.Set<TEntity>().Remove(obj);
            await context.SaveChangesAsync();
        }
    }
}