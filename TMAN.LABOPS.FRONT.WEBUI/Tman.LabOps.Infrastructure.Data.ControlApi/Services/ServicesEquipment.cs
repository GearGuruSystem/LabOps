using Newtonsoft.Json;
using System.Net.Http.Json;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Equipamento;
using Tman.LabOps.Infrastructure.CrossCutting.Interfaces;
using Tman.LabOps.Infrastructure.CrossCutting.Response;

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
            var resultClient = await _client.GetAsync("api/v1/Equipamento/BuscarEquipamentos");
            if (resultClient.IsSuccessStatusCode)
            {
                var jsonString = await resultClient.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<ApiResponse<EquipamentoDTO>>(jsonString);
                return jsonData.Data;
            }
            throw new Exception(); //ToDo: Adicionar novos exceptions de retorno.
        }

        public async Task<EquipamentoDTO> GetEquipmentById(int id)
        {
            var resultClient = await _client.GetAsync($"/api/v1/Equipamento/BuscarEquipamentoPeloId/{id}");
            if (resultClient.IsSuccessStatusCode)
            {
                var jsonString = await resultClient.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<EquipamentoDTO>(jsonString);
                return jsonData;
            }
            throw new Exception(); //ToDo: Adicionar novos exceptions de retorno.
        }

        public async Task<bool> RegisterEquipment(NewEquipamentoDTO novoEquipamento)
        {
            var resultClient = await _client.PostAsJsonAsync("api/v1/Equipamento/CadastrarEquipamento", novoEquipamento);
            if (resultClient.IsSuccessStatusCode)
            {
                return true;
            }
            throw new Exception(); //ToDo: Adicionar novos exceptions de retorno.
        }

        public async void UpdateEquipment(EditEquipamentoDTO equipamento)
        {
            var resultClient = await _client.PutAsJsonAsync("api/v1/Equipamento/AtualizarEquipamento", equipamento);
            if (!resultClient.IsSuccessStatusCode)
            {
                throw new Exception(); //ToDo: Adicionar novos exceptions de retorno.
            }
        }
    }
}
