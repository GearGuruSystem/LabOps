using LabOps.Application.DTO.Responses;

namespace LabOps.Domain.Core.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<PagedResponse<List<TEntity>>> BuscarTodos(int pageNumber, int pageSize);
        Task<TEntity> BuscarPorId(int id);
        Task<IEnumerable<TEntity>> BuscarPorParametro(TEntity obj);
        void Registrar(TEntity obj);
        void Atualizar(TEntity obj);
        void Remove(TEntity obj);
    }
}
