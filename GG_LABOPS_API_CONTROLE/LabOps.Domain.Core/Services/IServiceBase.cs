using LabOps.Application.DTO.Responses;

namespace LabOps.Domain.Core.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task<PagedResponse<List<TEntity>>> BuscarTodos(int pageNumber, int pageSize);
        Task<TEntity> BuscarPorId(int id);
        Task<IEnumerable<TEntity>> BuscarPorParametro(TEntity obj);
        void Adicionar(TEntity obj);
        void Atualiza(TEntity obj);
        void Remove(TEntity obj);
    }
}
