using LabOps.Application.DTOs.Equipamentos;

namespace LabOps.Application.Interfaces.ApiControle
{
    public interface IServicesEquipamento
    {
        void UpdateEquipament(Equipamento equipamento);
        Task<Equipamento> GetEquipamentById(int id);
        Task<IEnumerable<Equipamento>> GetAllEquipament();
        Task<Equipamento> RegisterEquipament(CriarNovoE novoEquipamento);
        void RemoveEquipament(Equipamento equipamento);
    }
}
