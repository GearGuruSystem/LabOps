using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Application.Interfaces
{
    public interface IApplicationServiceEquipamento
    {
        Task<Equipamento> BuscarPorId(int id);
        Task<Equipamento> BuscarTodos();
    }
}
