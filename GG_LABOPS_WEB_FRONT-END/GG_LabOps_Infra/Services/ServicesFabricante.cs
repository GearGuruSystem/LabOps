using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Fabricantes;
using LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiControle;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.ControlApi.Services
{
    public class ServicesFabricante : IServicesFabricante
    {
        private readonly HttpClient _client;

        public ServicesFabricante(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("ApiControl");
        }

        public async Task<IEnumerable<FabricanteDTO>> BuscaTodosFabricantes()
        {
            var resultClient = await _client.GetAsync("api/v1/Fabricante/BuscarTodosFabricantes");
            return await resultClient.Content.ReadFromJsonAsync<IEnumerable<FabricanteDTO>>();
        }

        public async Task<FabricanteDTO> BuscaFabricantesPeloId(int id)
        {
            var resultClient = await _client.GetAsync($"api/v1/Fabricante/BuscarFabricantePeloId/{id}");
            return await resultClient.Content.ReadFromJsonAsync<FabricanteDTO>();
        }

        public async Task<FabricanteDTO> CadastraFabricante(CriarNovoFDTO novoFabricante)
        {
            var resultClient = await _client.PostAsJsonAsync("api/v1/Fabricante/CadastraFabricante", novoFabricante);
            if (resultClient.IsSuccessStatusCode)
            {
                return await resultClient.Content.ReadFromJsonAsync<FabricanteDTO>();
            }
            throw new Exception("Ocorreu um erro");
        }

        public void AtualizaFabricante(FabricanteDTO fabricante)
        {
            _client.PutAsJsonAsync("api/v1/Fabricante/AtualizaFabricante", fabricante);
        }

        [Obsolete("Metodo esta Obsoleto pois não esta terminado")]
        public void RemoveFabricante(FabricanteDTO fabricante)
        {
            var getType = typeof(FabricanteDTO);
            _client.DeleteFromJsonAsync("api/v1/Fabricante/RemoveFabricante", getType);
        }
    }
}