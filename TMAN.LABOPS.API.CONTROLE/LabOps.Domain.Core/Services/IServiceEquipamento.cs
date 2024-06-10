using LabOps.Domain.Entities;

namespace LabOps.Domain.Core.Services
{
    public interface IServiceEquipamento : IServiceBase<Equipamento>
    {
        Task<ICollection<Equipamento>> BuscarTodosPorPagina(int pageNumber, int pageSize);
    }

    // ADICIONAR METODOSO PROPRIOS
}