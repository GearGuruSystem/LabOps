using LabOps.Application.DTO.DTO.Equipamentos;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceEquipamento
    {
        Task<IEnumerable<BuscarEquipamentos>> BuscaTodosEquipamentos();
        Task<BuscarEquipamentos> BuscaPeloId(int id);
        void RegistraEquipamento(CriarNovo obj);
        void AtualizaEquipamento(EquipamentoDTO obj);
        void RemoveEquipamento(EquipamentoDTO obj);
        Task<IEnumerable<EquipamentoDTO>> BuscaTodosPorPagina(int pageNumber, int pageSize);
    }
}