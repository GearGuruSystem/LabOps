namespace Auth.LabOps.Domain.Core.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        public Task<IEnumerable<TEntity>> BuscarTodos();
        public Task<TEntity> Buscar(int id);
        public Task<Task> Registrar(TEntity entity);
        public Task<TEntity> Atualizar(TEntity entity);
    }
}
