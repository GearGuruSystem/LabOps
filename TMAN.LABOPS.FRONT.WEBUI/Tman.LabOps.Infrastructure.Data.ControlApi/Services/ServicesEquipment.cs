using Newtonsoft.Json;
using System.Net.Http.Json;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Equipamento;
using Tman.LabOps.Infrastructure.CrossCutting.Interfaces;
using Tman.LabOps.Infrastructure.CrossCutting.Response;

#pragma warning disable IDE0290

namespace Tman.LabOps.Infrastructure.Data.ControlApi.Services
{
    public class ServicesEquipment : IServicesEquipment
    {
        private readonly HttpClient _client;

        public ServicesEquipment(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("ApiControl");
        }

        public async Task<IEnumerable<EquipamentoDTO>> GetAllEquipment()
        {
            using var response = await _client.GetAsync("api/v1/Equipamento/BuscarEquipamentos");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<ApiResponse<EquipamentoDTO>>(jsonString);
                return jsonData.Data;
            }
            throw new HttpRequestException(response.ReasonPhrase);
        }

        public async Task<EquipamentoDTO> GetEquipmentById(int id)
        {
            using var response = await _client.GetAsync($"/api/v1/Equipamento/BuscarEquipamentoPeloId/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<EquipamentoDTO>(jsonString);
                return jsonData;
            }
            throw new HttpRequestException(response.ReasonPhrase);
        }

        public async Task<bool> RegisterEquipment(NewEquipamentoDTO novoEquipamento)
        {
            using var response = await _client.PostAsJsonAsync("api/v1/Equipamento/CadastrarEquipamento", novoEquipamento);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            throw new HttpRequestException(response.ReasonPhrase);
        }

        public async void UpdateEquipment(EditEquipamentoDTO equipamento)
        {
            using var response = await _client.PutAsJsonAsync("api/v1/Equipamento/AtualizarEquipamento", equipamento);
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
        }
    }
}