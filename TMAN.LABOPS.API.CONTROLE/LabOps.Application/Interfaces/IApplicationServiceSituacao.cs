using LabOps.Application.DTO.DTO.Situacao;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceSituacao
    {
        Task<IEnumerable<SituacaoDTO>> BuscaTodasSituacao();

        void CadastraSituacao(SituacaoDTO situacaoDTO);
    }
}