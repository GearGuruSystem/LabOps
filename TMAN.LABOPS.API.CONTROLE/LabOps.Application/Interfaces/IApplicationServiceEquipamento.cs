using LabOps.Application.DTO.DTO.Equipamentos;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceEquipamento
    {
        Task<IEnumerable<BuscarTodosEquipamentos>> BuscaTodosEquipamentos();
        Task<EquipamentoDTO> BuscaPeloId(int id);
        void RegistraEquipamento(CriarNovo obj);
        void AtualizaEquipamento(EquipamentoDTO obj);
        void RemoveEquipamento(EquipamentoDTO obj);
        Task<IEnumerable<EquipamentoDTO>> BuscaTodosPorPagina(int pageNumber, int pageSize);
    }
}