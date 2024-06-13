namespace Auth.LabOps.Infrastructure.Repository.Repository
{
    public abstract class RepositoryBase<TEntity> where TEntity : class
    {
        public abstract Task<IEnumerable<TEntity>> BuscarTodos();
        public abstract Task<TEntity> Buscar(int id);
        public abstract Task<Task> Registrar(TEntity entity);
    }
}
