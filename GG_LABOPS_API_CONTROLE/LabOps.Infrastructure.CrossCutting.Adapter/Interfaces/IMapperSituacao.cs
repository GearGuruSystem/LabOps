using LabOps.Application.DTO.DTO;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperSituacao
    {
        #region Mappers
        IEnumerable<SituacaoDTO> MapperListaFabricantes(IEnumerable<Situacao> situacoes);
        Situacao MapperToEntity(SituacaoDTO situacaoDTO);
        SituacaoDTO MapperToDTO(Situacao situacao);
        #endregion
    }
}
