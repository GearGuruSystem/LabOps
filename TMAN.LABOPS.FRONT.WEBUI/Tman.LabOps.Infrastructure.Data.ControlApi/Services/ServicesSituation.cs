using System.Net.Http.Json;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Situacao;
using Tman.LabOps.Infrastructure.CrossCutting.Interfaces;

#pragma warning disable IDE0290 // Use primary constructor

namespace Tman.LabOps.Infrastructure.Data.ControlApi.Services
{
    public class ServicesSituation : IServicesSituation
    {
        private readonly HttpClient _client;

        public ServicesSituation(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("ApiControl");
        }

        public async Task<IEnumerable<SituacaoDTO>> GetAllSituation()
        {
            var resultClient = await _client.GetAsync("api/v1/Situacao/BuscarTodasSituacoes");
            return await resultClient.Content.ReadFromJsonAsync<IEnumerable<SituacaoDTO>>();
        }
    }
}
