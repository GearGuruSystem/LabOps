using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Equipamento;

namespace Tman.LabOps.Infrastructure.CrossCutting.Interfaces
{
    public interface IServicesEquipment
    {
        Task<IEnumerable<EquipamentoDTO>> GetAllEquipment();
        Task<EquipamentoDTO> GetEquipmentById(int id);
        Task<bool> RegisterEquipment(NewEquipamentoDTO novoEquipamento);
        void UpdateEquipment(EditEquipamentoDTO equipamento);
    }
}
