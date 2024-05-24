using Auth.LabOps.Domain.Core.Interfaces;

#pragma warning disable IDE0290 // Use primary constructor

namespace Auth.LabOps.Domain.Services.Services
{
    public class ServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public virtual async Task<IEnumerable<TEntity>> BuscarTodos()
        {
            return await repository.BuscarTodos();
        }

        public virtual async Task<TEntity> Buscar()
        {
            return await repository.Buscar();
        }

        public virtual void Registrar(TEntity entity)
        {
            repository.Registrar(entity);
        }
    }
}
