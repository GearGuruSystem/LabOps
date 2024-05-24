namespace Auth.LabOps.Domain.Core.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        public Task<IEnumerable<TEntity>> BuscarTodos();
        public Task<TEntity> Buscar();
        public void Registrar(TEntity entity);
    }
}
