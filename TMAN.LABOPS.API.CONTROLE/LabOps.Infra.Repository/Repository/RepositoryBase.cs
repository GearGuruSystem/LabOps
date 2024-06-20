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
            return await context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity> BuscarPorId(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> BuscarPorParametro(TEntity obj)
        {
            return await context.Set<TEntity>().Where(x => x.Equals(obj)).ToListAsync();
        }

        public virtual async void Registrar(TEntity obj)
        {
            await context.AddAsync<TEntity>(obj);
            context.SaveChanges();
        }

        public virtual async void Atualizar(TEntity obj)
        {
            context.Update<TEntity>(obj);
            await context.SaveChangesAsync();
        }

        public virtual async void Remove(TEntity obj)
        {
            context.Remove<TEntity>(obj);
            await context.SaveChangesAsync();
        }
    }
}