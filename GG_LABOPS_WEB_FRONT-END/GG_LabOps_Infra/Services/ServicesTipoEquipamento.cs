using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.TiposEquipamentos;
using LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiControle;
using System.Net.Http.Json;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.ControlApi.Services
{
    public class ServicesTipoEquipamento : IServicesTipoEquipamento
    {
        private readonly HttpClient _client;

        public ServicesTipoEquipamento(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("ApiControl");
        }

        public async Task<IEnumerable<TipoEquipamentoDTO>> BuscaTodosTiposDeEquipamentos()
        {
            var resultClient = await _client.GetAsync("api/v1/TipoEquipamento/BuscarTodosTiposDeEquipamentos");
            return await resultClient.Content.ReadFromJsonAsync<IEnumerable<TipoEquipamentoDTO>>();
        }

        public async Task<TipoEquipamentoDTO> BuscaTipoEquipamentoPeloId(int id)
        {
            var resultClient = await _client.GetAsync($"api/v1/TipoEquipamento/BuscarTipoDeEquipamentoPorId/{id}");
            return await resultClient.Content.ReadFromJsonAsync<TipoEquipamentoDTO>();
        }

        public async Task<TipoEquipamentoDTO> CadastrarTipoEquipamento(CriarNovoTEDTO nTipoEquipamento)
        {
            var resultClient = await _client.PostAsJsonAsync("api/v1/TipoEquipamento/RegistroTipoEquipamento", nTipoEquipamento);
            if (resultClient.IsSuccessStatusCode)
            {
                return new TipoEquipamentoDTO();
            }
            throw new Exception("Ocorreu um erro");
        }

        public void AtualizarTipoEquipamento(TipoEquipamentoDTO tipoEquipamento)
        {
            _client.PutAsJsonAsync("api/v1/Fabricante/AtualizarTipoEquipamento", tipoEquipamento);
        }

        [Obsolete("Metodo esta Obsoleto pois não esta terminado")]
        public void RemoverTipoEquipamento(TipoEquipamentoDTO tipoEquipamento)
        {
            var getType = typeof(TipoEquipamentoDTO);
            _client.DeleteFromJsonAsync("api/v1/Fabricante/RemoverTipoEquipamento", getType);
        }
    }
}
