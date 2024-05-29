using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infra.Useful;

namespace GG_LabOps_Infra.Persistence.ApiClients
{
    public class EquipamentoApiClient : IEquipamentoApiClient
    {
        private readonly HttpClient _client;

        public EquipamentoApiClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<Equipamento> BuscarTodos()
        {
            var response = await _client.GetAsync($"{EndpointsApiClient.EquipamentEndpoint()}");
            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<Equipamento>();
            }
            throw new Exception();
        }

        public async Task<Equipamento> BuscaPorId(int id)
        {
            var response = await _client.GetAsync($"{EndpointsApiClient.EquipamentEndpoint()}/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<Equipamento>();
            }
            throw new Exception();
        }

        public async Task<Equipamento> BuscaPeloHostname(string hostname)
        {
            var response = await _client.GetAsync($"{EndpointsApiClient.EquipamentEndpoint()}/{hostname}");
            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<Equipamento>();
            }
            throw new Exception();
        }
    }
}
