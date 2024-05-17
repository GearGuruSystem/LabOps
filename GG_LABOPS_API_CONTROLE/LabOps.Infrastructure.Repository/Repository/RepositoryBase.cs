using LabOps.Domain.Core.Interfaces;

namespace LabOps.Infrastructure.Repository.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        public abstract Task<IEnumerable<TEntity>> BuscarTodos();

        public abstract Task<TEntity> BuscarPorId(int id);

        public abstract Task<IEnumerable<TEntity>> BuscarPorParametro(TEntity obj);

        public abstract void Registrar(TEntity obj);

        public abstract void Atualizar(TEntity obj);

        public abstract void Remove(TEntity obj);
    }
}
