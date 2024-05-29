using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IEquipamentoServices
    {
        Task<Equipamento> BuscarPorId(int id);
        Task<Equipamento> BuscarTodos();
    }
}
