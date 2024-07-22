namespace LabOps.Domain.Core.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> BuscarTodos();

        Task<TEntity> BuscarPorId(int id);

        Task Registrar(TEntity obj);

        Task Atualizar(TEntity obj);

        Task Deletar(TEntity obj);
    }
}