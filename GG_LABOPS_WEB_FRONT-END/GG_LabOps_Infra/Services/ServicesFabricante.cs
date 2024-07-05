using LabOps.Application.DTOs.Fabricantes;
using LabOps.Application.Interfaces;
using System.Net.Http.Json;

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

        public async Task<IEnumerable<Fabricante>> BuscaTodosFabricantes()
        {
            var resultClient = await _client.GetAsync("api/v1/Fabricante/BuscarTodosFabricantes");
            return await resultClient.Content.ReadFromJsonAsync<IEnumerable<Fabricante>>();
        }

        public async Task<Fabricante> BuscaFabricantesPeloId(int id)
        {
            var resultClient = await _client.GetAsync($"api/v1/Fabricante/BuscarFabricantePeloId/{id}");
            return await resultClient.Content.ReadFromJsonAsync<Fabricante>();
        }

        public async Task<Fabricante> CadastraFabricante(CriarNovo novoFabricante)
        {
            var resultClient = await _client.PostAsJsonAsync("api/v1/Fabricante/CadastraFabricante", novoFabricante);
            if (resultClient.IsSuccessStatusCode)
            {
                return new Fabricante();
            }
            throw new Exception("Ocorreu um erro");
        }

        public void AtualizaFabricante(Fabricante fabricante)
        {
            _client.PutAsJsonAsync("api/v1/Fabricante/AtualizaFabricante", fabricante);
        }

        [Obsolete("Metodo esta Obsoleto pois não esta terminado")]
        public void RemoveFabricante(Fabricante fabricante)
        {
            var getType = typeof(Fabricante);
            _client.DeleteFromJsonAsync("api/v1/Fabricante/RemoveFabricante", getType);
        }
    }
}