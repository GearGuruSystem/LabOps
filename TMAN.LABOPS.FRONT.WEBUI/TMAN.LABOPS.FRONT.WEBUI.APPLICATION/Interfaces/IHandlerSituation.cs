using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Situacao;

namespace Tman.LabOps.WebUI.Application.Interfaces
{
    public interface IHandlerSituation
    {
        Task<IEnumerable<SituacaoDTO>> GetAllSituation();
    }
}
