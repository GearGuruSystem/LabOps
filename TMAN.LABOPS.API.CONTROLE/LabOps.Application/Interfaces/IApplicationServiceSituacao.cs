using LabOps.Application.DTO.DTO.Situacao;
using LabOps.Application.DTO.Response;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceSituacao
    {
        Task<Response<IEnumerable<SituacaoDTO>>> BuscarTodasSituacoes();
        Task<Response<IEnumerable<SituacaoDTO>>> BuscaTodasSituacaoAtiva();
        void CadastraSituacao(AdicionarSituacaoDTO situacaoDTO);
    }
}