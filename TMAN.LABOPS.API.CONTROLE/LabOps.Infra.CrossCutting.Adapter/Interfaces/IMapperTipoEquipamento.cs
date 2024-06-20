using LabOps.Application.DTO.DTO;
using LabOps.Application.DTO.DTO.TipoEquipamento;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperTipoEquipamento
    {
        #region Mappers

        IEnumerable<TipoEquipamentoDTO> MapperListaTipoEquipamentos(IEnumerable<TipoEquipamento> tipoEquipamento);

        TipoEquipamentoDTO MapperToDTO(TipoEquipamento tipoEquipamento);

        TipoEquipamento MapperToEntity(TipoEquipamentoDTO tipoEquipamentoDTO);
        TipoEquipamento MapperToEntity(RegistroNovo tipoEquipamentoDTO);

        #endregion Mappers
    }
}