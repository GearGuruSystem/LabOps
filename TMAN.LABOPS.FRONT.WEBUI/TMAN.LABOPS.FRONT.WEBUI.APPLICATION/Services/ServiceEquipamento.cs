using System.Net.Http.Json;
using Tman.LabOps.WebUI.Application.DTOs.Equipamento;
using Tman.LabOps.WebUI.Application.Entities;
using Tman.LabOps.WebUI.Application.Interfaces;

namespace Tman.LabOps.WebUI.Application.Services
{
    public class ServiceEquipamento : IServiceEquipamento
    {
        private readonly HttpClient _client;

        public ServiceEquipamento(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient(
            $"{Configuration.ClientName}");
        }

        public async Task<IEnumerable<ViewEquipamento>> BuscaTodosEquipamentos()
        {
            try
            {
                var client = await _client.GetAsync("api/v1/Equipamento/BuscarTodosEquipamentos");
                return await client.Content.ReadFromJsonAsync<IEnumerable<ViewEquipamento>>();
            }
            catch (Exception)
            {
                return Enumerable.Empty<ViewEquipamento>();
            }
        }

        public async Task<Equipamento> CadastraEquipamento(Equipamento equipamento)
        {
            var client = await _client.PostAsJsonAsync("api/v1/Equipamento/CadastraEquipamentos", equipamento);
            var response = await client.Content.ReadFromJsonAsync<Equipamento>();
            return response;
        }
    }
}
