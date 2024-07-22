using LabOps.Application.DTO.DTO.Situacao;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceSituacao
    {
        Task<IEnumerable<SituacaoDTO>> BuscarTodasSituacoes();
        Task<IEnumerable<SituacaoDTO>> BuscaTodasSituacaoAtiva();
        void CadastraSituacao(AdicionarSituacaoDTO situacaoDTO);
    }
}