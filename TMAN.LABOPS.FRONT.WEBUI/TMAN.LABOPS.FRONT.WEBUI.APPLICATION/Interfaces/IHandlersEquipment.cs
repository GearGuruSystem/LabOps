using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Equipamento;

namespace Tman.LabOps.WebUI.Application.Interfaces
{
    public interface IHandlersEquipment
    {
        Task<IEnumerable<EquipamentoDTO>> GetAllEquipment();
        Task<EquipamentoDTO> GetEquipmentById(int id);
        Task<bool> RegisterEquipment(NewEquipamentoDTO criarNovo);
        void UpdateEquipment(EditEquipamentoDTO equipament);
    }
}
