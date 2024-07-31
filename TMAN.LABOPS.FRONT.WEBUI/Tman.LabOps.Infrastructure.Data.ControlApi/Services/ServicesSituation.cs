using Newtonsoft.Json;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Situacao;
using Tman.LabOps.Infrastructure.CrossCutting.Interfaces;
using Tman.LabOps.Infrastructure.CrossCutting.Response;

#pragma warning disable IDE0290

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
            using var response = await _client.GetAsync("api/v1/Situacao/BuscarTodasSituacoes");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonContent = JsonConvert.DeserializeObject<ApiResponse<SituacaoDTO>>(jsonString);
                return jsonContent.Data;
            }
            throw new HttpRequestException(response.ReasonPhrase);
        }
    }
}
