using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Equipamentos;
using LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiControle;
using System.Net.Http.Json;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.ControlApi.Services
{
    public class ServicesEquipamento : IServicesEquipament
    {
        private readonly HttpClient _client;

        public ServicesEquipamento(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("ApiControl");
        }

        public async Task<IEnumerable<EquipamentoSimplesDTO>> GetAllEquipament()
        {
            var resultClient = await _client.GetAsync("api/v1/Equipamento/BuscarEquipamentos");
            return await resultClient.Content.ReadFromJsonAsync<IEnumerable<EquipamentoSimplesDTO>>();
        }

        public async Task<EquipamentoDTO> GetEquipamentById(int id)
        {
            var resultClient = await _client.GetAsync($"/api/v1/Equipamento/BuscarEquipamentoPeloId/{id}");
            return await resultClient.Content.ReadFromJsonAsync<EquipamentoDTO>();
        }

        public async Task<EquipamentoSimplesDTO> RegisterEquipament(CriarNovoEDTO novoEquipamento)
        {
            var resultClient = await _client.PostAsJsonAsync("api/v1/Equipamento/CadastrarEquipamento", novoEquipamento);
            if (resultClient.IsSuccessStatusCode)
            {
                return new EquipamentoSimplesDTO();
            }
            throw new Exception("Ocorreu um erro");
        }

        public void UpdateEquipament(EquipamentoDTO equipamento)
        {
            _client.PutAsJsonAsync("api/v1/Equipamento/AtualizarEquipamento", equipamento);
        }
    }
}
