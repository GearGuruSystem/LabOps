using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Domain.Entities;

namespace LabOps.Domain.Core.Interfaces
{
    public interface IRepositoryEquipamento : IRepositoryBase<Equipamento>
    {
        new Task<BuscarEquipamentos> BuscarPorId(int id);
        new Task<IEnumerable<BuscarEquipamentos>> BuscarTodos();
        Task<ICollection<Equipamento>> BuscarTodosPorPagina(int pageNumber, int pageSize);
    }
}