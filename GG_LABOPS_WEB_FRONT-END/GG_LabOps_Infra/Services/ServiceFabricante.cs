using LabOps.Application.DTOs.Fabricantes;
using LabOps.Application.Interfaces;
using System.Net.Http.Json;

namespace LabOps.Infra.ControlApi.Services
{
    public class ServiceFabricante(IHttpClientFactory httpClientFactory) : IServiceFabricante
    {
        private readonly HttpClient client = httpClientFactory
            .CreateClient($"{WebConfig.HttpClient_Fabricante}");

        public async Task<IEnumerable<Fabricante>> BuscaTodosFabricantes()
        {
            try
            {
                var result = await client.GetFromJsonAsync<List<Fabricante>>(new Uri(WebConfig.HttpClient_Fabricante));
                if (result.Count >= 1)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Erro. não foi encontrado nenhum valor no retorno da API");
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public Task<Fabricante> BuscaFabricantesPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Fabricante> RegistraFabricante(CriarNovo novoFabricante)
        {
            try
            {
                var result = await client.PostAsJsonAsync(new Uri(WebConfig.BaseAdressApi), novoFabricante);
                if (result.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Codigo de retorno {result.StatusCode}");
                    return await result.Content.ReadFromJsonAsync<Fabricante>() ?? new Fabricante();
                }
                throw new Exception();
            }
            catch (Exception ex)
            {
                throw new Exception($"BUCETADA: {ex.Message}");
            }
        }

        public void AtualizaFabricante(Fabricante fabricante)
        {
            throw new NotImplementedException();
        }

        public void RemoveFabricante(Fabricante fabricante)
        {
            throw new NotImplementedException();
        }
    }
}