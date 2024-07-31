using Newtonsoft.Json;
using System.Net.Http.Json;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Fabricante;
using Tman.LabOps.Infrastructure.CrossCutting.Interfaces;
using Tman.LabOps.Infrastructure.CrossCutting.Response;

namespace Tman.LabOps.Infrastructure.Data.ControlApi.Services
{
    public class ServicesManufacturer : IServicesManufacturer
    {
        private readonly HttpClient _client;

        public ServicesManufacturer(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("ApiControl");
        }

        public async Task<IEnumerable<FabricanteDTO>> GetAllManufacturers()
        {
            using var response = await _client.GetAsync("api/v1/Fabricante/BuscarTodosFabricantes");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<ApiResponse<FabricanteDTO>>(jsonString);
                return jsonData.Data;
            }
            throw new HttpRequestException(response.ReasonPhrase);
        }

        public async Task<FabricanteDTO> GetManufacturerById(int id)
        {
            using var response = await _client.GetAsync($"api/v1/Fabricante/BuscarFabricantePeloId/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<FabricanteDTO>(jsonString);
                return jsonData;
            }
            throw new HttpRequestException(response.ReasonPhrase);
        }

        public async Task<FabricanteDTO> RegisterManufacturer(NewFabricanteDTO novoFabricante)
        {
            using var response = await _client.PostAsJsonAsync("api/v1/Fabricante/CadastraFabricante", novoFabricante);
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<FabricanteDTO>(jsonString);
                return jsonData;
            }
            throw new HttpRequestException(response.ReasonPhrase);
        }

        public async void UpdateManufacturer(EditFabricanteDTO editFabricante)
        {
            using var response = await _client.PutAsJsonAsync("api/v1/Fabricante/AtualizaFabricante", editFabricante);
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
        }
    }
}
