using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Situacao;
using Tman.LabOps.Infrastructure.CrossCutting.Interfaces;
using Tman.LabOps.WebUI.Application.Interfaces;

namespace Tman.LabOps.WebUI.Application.Handlers
{
    public class HandlerSituation : IHandlerSituation
    {
        private readonly IServicesSituation _services;

        public HandlerSituation(IServicesSituation services)
        {
            _services = services;
        }

        public async Task<IEnumerable<SituacaoDTO>> GetAllSituation()
        {
            try
            {
                return await _services.GetAllSituation();
            }
            catch (Exception)
            {
                throw new Exception(); //ToDo: Adicionar novos exceptions de retorno.
            }
        }
    }
}
