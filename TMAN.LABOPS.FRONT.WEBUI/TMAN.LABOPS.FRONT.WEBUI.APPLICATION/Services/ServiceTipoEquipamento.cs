using System.Net.Http.Json;
using Tman.LabOps.WebUI.Application.DTOs.TipoEquipamento;
using Tman.LabOps.WebUI.Application.Entities;
using Tman.LabOps.WebUI.Application.Interfaces;

namespace Tman.LabOps.WebUI.Application.Services
{
    public class ServiceTipoEquipamento(IHttpClientFactory httpClientFactory) : IServiceTipoEquipamento
    {
        private readonly HttpClient client = httpClientFactory.CreateClient(
            $"{Configuration.ClientName}");

        const string route = "api/v1/TipoEquipamento";

        public async Task<IEnumerable<TipoEquipamento>> BuscaTodosTipoEquipamento()
        {
            try
            {
                var result = await client.GetFromJsonAsync<IEnumerable<TipoEquipamento>>($"{route}/BuscarTiposEquipamentos");
                return result;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Task<TipoEquipamento> BuscaTipoEquipamentoPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<TipoEquipamento> RegistraTipoEquipamento(CriarNovoTE tipoEquipamento)
        {
            try
            {
                var result = await client.PostAsJsonAsync($"{route}/CadastraTipoEquipamento", tipoEquipamento);
                if (result.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Codigo de retorno {result.StatusCode}");
                    return await result.Content.ReadFromJsonAsync<TipoEquipamento>();
                }
                throw new Exception();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }

        public void AtualizarTipoEquipamento(TipoEquipamento tipoEquipamento)
        {
            throw new NotImplementedException();
        }

        public void RemoveTipoEquipamento(TipoEquipamento tipoEquipamento)
        {
            throw new NotImplementedException();
        }
    }
}
