using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Application.DTO.Response;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceEquipamento
    {
        Task<Response<IEnumerable<EquipamentoDTO>>> BuscaTodosEquipamentos();
        Task<EquipamentoDTO> BuscarEquipamentoRetornoId(int id);
        Task<BuscarEquipamentos> BuscaPeloId(int id);
        void RegistraEquipamento(CriarNovo obj);
        void AtualizaEquipamento(EquipamentoDTO obj);
        void RemoveEquipamento(EquipamentoDTO obj);
        Task<ResponsePaged<IEnumerable<EquipamentoDTO>>> BuscaTodosPorPagina(int pageNumber, int pageSize);
    }
}