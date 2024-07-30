using Tman.LabOps.Infrastructure.CrossCutting.DTOs.TiposEquipamentos;

namespace Tman.LabOps.WebUI.Application.Interfaces
{
    public interface IHandlerEquipmentType
    {
        Task<IEnumerable<TipoEquipamentoDTO>> GetAllEquipmentType();
        Task<TipoEquipamentoDTO> GetEquipmentTypeById(int id);
        Task<TipoEquipamentoDTO> RegisterEquipmentType(NewTipoEquipamentoDTO nTipoEquipamento);
        void UpdateEquipmentType(TipoEquipamentoDTO tipoEquipamento);
    }
}
