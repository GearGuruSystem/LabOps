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
            var resultClient = await _client.GetAsync("api/v1/Fabricante/BuscarTodosFabricantes");
            if (resultClient.IsSuccessStatusCode)
            {
                var jsonString = await resultClient.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<ApiResponse<FabricanteDTO>>(jsonString);
                return jsonData.Data;
            }
            throw new Exception(); //ToDo: Adicionar novos exceptions de retorno.
        }

        public async Task<FabricanteDTO> GetManufacturerById(int id)
        {
            var resultClient = await _client.GetAsync($"api/v1/Fabricante/BuscarFabricantePeloId/{id}");
            if (resultClient.IsSuccessStatusCode)
            {
                var jsonString = await resultClient.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<FabricanteDTO>(jsonString);
                return jsonData;
            }
            throw new Exception(); //ToDo: Adicionar novos exceptions de retorno.
        }

        public async Task<FabricanteDTO> RegisterManufacturer(NewFabricanteDTO novoFabricante)
        {
            var resultClient = await _client.PostAsJsonAsync("api/v1/Fabricante/CadastraFabricante", novoFabricante);
            if (resultClient.IsSuccessStatusCode)
            {
                var jsonString = await resultClient.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<FabricanteDTO>(jsonString);
                return jsonData;
            }
            throw new Exception(); //ToDo: Adicionar novos exceptions de retorno.
        }

        public async void UpdateManufacturer(EditFabricanteDTO editFabricante)
        {
            var resultClient = await _client.PutAsJsonAsync("api/v1/Fabricante/AtualizaFabricante", editFabricante);
            if (!resultClient.IsSuccessStatusCode)
            {
                throw new Exception(); //ToDo: Adicionar novos exceptions de retorno. 
            }
        }
    }
}
