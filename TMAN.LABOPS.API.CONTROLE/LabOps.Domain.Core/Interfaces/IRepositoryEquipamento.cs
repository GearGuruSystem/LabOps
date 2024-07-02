using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Domain.Entities;

namespace LabOps.Domain.Core.Interfaces
{
    public interface IRepositoryEquipamento : IRepositoryBase<Equipamento>
    {
        new Task<IEnumerable<BuscarTodosEquipamentos>> BuscarTodos();
        Task<ICollection<Equipamento>> BuscarTodosPorPagina(int pageNumber, int pageSize);
    }
}