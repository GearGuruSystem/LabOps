using Newtonsoft.Json;
using System.Net.Http.Json;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.TiposEquipamentos;
using Tman.LabOps.Infrastructure.CrossCutting.Interfaces;
using Tman.LabOps.Infrastructure.CrossCutting.Response;

#pragma warning disable IDE0290

namespace Tman.LabOps.Infrastructure.Data.ControlApi.Services
{
    public class ServicesEquipmentType : IServicesEquipmentType
    {
        private readonly HttpClient _client;

        public ServicesEquipmentType(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("ApiControl");
        }

        public async Task<IEnumerable<TipoEquipamentoDTO>> GetAllEquipmentType()
        {
            using var response = await _client.GetAsync("api/v1/TipoEquipamento/BuscarTodosTiposDeEquipamentos");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<ApiResponse<TipoEquipamentoDTO>>(jsonString);
                return jsonData.Data;
            }
            throw new HttpRequestException(response.ReasonPhrase);
        }

        public async Task<TipoEquipamentoDTO> GetEquipmentTypeById(int id)
        {
            using var response = await _client.GetAsync($"api/v1/TipoEquipamento/BuscarTipoDeEquipamentoPorId/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<TipoEquipamentoDTO>(jsonString);
                return jsonData;
            }
            throw new HttpRequestException(response.ReasonPhrase);
        }

        public async Task<TipoEquipamentoDTO> RegisterEquipmentType(NewTipoEquipamentoDTO nTipoEquipamento)
        {
            using var response = await _client.PostAsJsonAsync("api/v1/TipoEquipamento/RegistroTipoEquipamento", nTipoEquipamento);
            if (response.IsSuccessStatusCode)
            {
                return new TipoEquipamentoDTO();
            }
            throw new HttpRequestException(response.ReasonPhrase);
        }

        public async void UpdateEquipmentType(TipoEquipamentoDTO tipoEquipamento)
        {
            using var response = await _client.PutAsJsonAsync("api/v1/Fabricante/AtualizarTipoEquipamento", tipoEquipamento);
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
        }
    }
}
