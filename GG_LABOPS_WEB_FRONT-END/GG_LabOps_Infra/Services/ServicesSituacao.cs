using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Situacao;
using LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiControle;
using System.Net.Http.Json;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.ControlApi.Services
{
    public class ServicesSituacao : IServicesSituacao
    {
        private readonly HttpClient _client;

        public ServicesSituacao(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("ApiControl");
        }

        public async Task<IEnumerable<SituacaoDTO>> BuscarTodasSituacoes()
        {
            var resultClient = await _client.GetAsync("api/v1/Situacao/BuscarTodasSituacoes");
            return await resultClient.Content.ReadFromJsonAsync<IEnumerable<SituacaoDTO>>();
        }
    }
}
