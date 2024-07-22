using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Situacao;

namespace LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiControle
{
    public interface IServicesSituacao
    {
        Task<IEnumerable<SituacaoDTO>> BuscarTodasSituacoes();
    }
}
