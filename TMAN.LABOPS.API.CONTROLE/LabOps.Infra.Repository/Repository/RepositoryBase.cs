using LabOps.Domain.Core.Interfaces;
using LabOps.Infra.Data.DataContext;

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

        public abstract Task<IEnumerable<TEntity>> BuscarTodos();

        public abstract Task<TEntity> BuscarPorId(int id);

        public abstract Task<IEnumerable<TEntity>> BuscarPorParametro(TEntity obj);

        public virtual async void Registrar(TEntity obj)
        {
            await context.AddAsync<TEntity>(obj);
            context.SaveChanges();
        }

        public abstract void Atualizar(TEntity obj);

        public abstract void Remove(TEntity obj);
    }
}