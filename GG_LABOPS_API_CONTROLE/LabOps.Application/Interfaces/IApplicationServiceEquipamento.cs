using LabOps.Application.DTO.DTO;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceEquipamento
    {
        Task<IEnumerable<EquipamentoDTO>> BuscaTodosEquipamentos();
        Task<EquipamentoDTO> BuscaEquipamentoPeloId(int id);
        void RegistraEquipamento(EquipamentoDTO obj);
        void AtualizaEquipamento(EquipamentoDTO obj);
        void RemoveEquipamento(EquipamentoDTO obj);
    }
}
