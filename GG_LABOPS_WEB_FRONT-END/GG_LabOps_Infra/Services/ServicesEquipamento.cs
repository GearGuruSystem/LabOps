using LabOps.Application.DTOs.Equipamentos;
using LabOps.Application.Interfaces.ApiControle;
using System.Net.Http.Json;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.ControlApi.Services
{
    public class ServicesEquipamento : IServicesEquipamento
    {
        private readonly HttpClient _client;

        public ServicesEquipamento(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("ApiControl");
        }

        public async Task<IEnumerable<Equipamento>> GetAllEquipament()
        {
            var resultClient = await _client.GetAsync("api/v1/Equipamento/BuscarEquipamentos");
            return await resultClient.Content.ReadFromJsonAsync<IEnumerable<Equipamento>>();
        }

        public async Task<Equipamento> GetEquipamentById(int id)
        {
            var resultClient = await _client.GetAsync($"/api/v1/Equipamento/BuscaEquipamentosPeloId/{id}");
            return await resultClient.Content.ReadFromJsonAsync<Equipamento>();
        }

        public async Task<Equipamento> RegisterEquipament(CriarNovoE novoEquipamento)
        {
            var resultClient = await _client.PostAsJsonAsync("api/v1/Equipamento/CadastraEquipamento", novoEquipamento);
            if (resultClient.IsSuccessStatusCode)
            {
                return new Equipamento();
            }
            throw new Exception("Ocorreu um erro");
        }

        public void UpdateEquipament(Equipamento equipamento)
        {
            _client.PutAsJsonAsync("api/v1/Equipamento/AtualizaEquipamento", equipamento);
        }

        [Obsolete("Metodo esta Obsoleto pois não esta terminado")]
        public void RemoveEquipament(Equipamento equipamento)
        {
            var getType = typeof(Equipamento);
            _client.DeleteFromJsonAsync("api/v1/Equipamento/DesabilitaEquipamento", getType);
        }
    }
}
