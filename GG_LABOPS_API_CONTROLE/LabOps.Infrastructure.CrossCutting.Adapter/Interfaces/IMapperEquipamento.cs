using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Application.DTO.Responses;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperEquipamento
    {
        #region mappers

        IEnumerable<EquipamentoDTO> MapperListaEquipamentos(IEnumerable<Equipamento> equipamentos);
        IEnumerable<EquipamentoDTO> MapperListaPaginaEquipamento(PagedResponse<List<Equipamento>> equipamentoPagina);
        Equipamento MapperToEntity(EquipamentoDTO equipamentoDTO);
        EquipamentoDTO MapperToDTO(Equipamento equipamento);

        #endregion
    }
}
