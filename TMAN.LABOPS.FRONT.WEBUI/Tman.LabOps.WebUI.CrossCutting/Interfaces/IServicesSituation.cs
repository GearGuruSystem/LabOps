using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Situacao;

namespace Tman.LabOps.Infrastructure.CrossCutting.Interfaces
{
    public interface IServicesSituation
    {
        Task<IEnumerable<SituacaoDTO>> GetAllSituation();
    }
}
