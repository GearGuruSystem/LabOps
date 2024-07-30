using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Application.DTO.Response;
using LabOps.Domain.Entities;

namespace LabOps.Domain.Core.Interfaces
{
    public interface IRepositoryEquipamento : IRepositoryBase<Equipamento>
    {
        new Task<IEnumerable<Equipamento>> BuscarTodos();
        new Task<BuscarEquipamentos> BuscarPorId(int id);
        Task<Equipamento> BuscarComRetornoId(long id);
        Task<IEnumerable<Equipamento>> BuscarTodosPorPagina(int pageNumber, int pageSize);
    }
}