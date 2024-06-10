using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperEquipamento
    {
        #region mappers

        IEnumerable<EquipamentoDTO> MapperListaEquipamentos(IEnumerable<Equipamento> equipamentos);

        Equipamento MapperToEntity(EquipamentoDTO equipamentoDTO);

        EquipamentoDTO MapperToDTO(Equipamento equipamento);

        #endregion mappers
    }
}