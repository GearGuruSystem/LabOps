using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Equipamentos;

namespace LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiControle
{
    public interface IServicesEquipament
    {
        Task<IEnumerable<EquipamentoSimplesDTO>> GetAllEquipament();
        Task<EquipamentoDTO> GetEquipamentById(int id);
        Task<EquipamentoSimplesDTO> RegisterEquipament(CriarNovoEDTO novoEquipamento);
        void UpdateEquipament(EquipamentoDTO equipamento);
    }
}
