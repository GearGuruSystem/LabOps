namespace LabOps.Domain.Core.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> BuscarTodos();
        Task<TEntity> BuscarPorId(int id);
        void Registrar(TEntity obj);
        void Atualizar(TEntity obj);
        void Remove(TEntity obj);
    }
}
