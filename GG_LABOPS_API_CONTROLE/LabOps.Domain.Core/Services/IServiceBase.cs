namespace LabOps.Domain.Core.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> BuscarTodos();
        Task<TEntity> BuscarPorId(int id);
        Task<IEnumerable<TEntity>> BuscarPorParametro(TEntity obj);
        void Adicionar(TEntity obj);
        void Atualiza(TEntity obj);
        void Remove(TEntity obj);
    }
}
