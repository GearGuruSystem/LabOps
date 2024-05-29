using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IEquipamentoApiClient
    {
        Task<Equipamento> BuscaPeloHostname(string hostname);
        Task<Equipamento> BuscaPorId(int id);
        Task<Equipamento> BuscarTodos();
    }
}
