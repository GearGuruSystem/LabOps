namespace LabOps.Domain.Core.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task<ICollection<TEntity>> BuscarTodosPorPagina(int pageNumber, int pageSize);
        Task<IEnumerable<TEntity>> BuscarTodosSemRestricao();
        Task<TEntity> BuscarPorId(int id);
        Task<IEnumerable<TEntity>> BuscarPorParametro(TEntity obj);
        void Adicionar(TEntity obj);
        void Atualiza(TEntity obj);
        void Remove(TEntity obj);
    }
}
