using LabOps.Application.DTOs.Fabricante;
using LabOps.Application.Interfaces;
using LabOps.Application.Requests;
using System.Net.Http.Json;

namespace LabOps.Infra.Data.ControlApi.Services
{
    public class ServiceFabricante(IHttpClientFactory httpClientFactory) : IServicesFabricante
    {
        private readonly HttpClient client = httpClientFactory
            .CreateClient($"{WebConfiguration.HttpClient_Fabricante}");

        public async Task<IEnumerable<Fabricante>> BuscaTodosFabricantes()
        {
            try
            {
                var result = await client.GetFromJsonAsync<List<Fabricante>>(new Uri(WebConfiguration.HttpClient_Fabricante));
                throw new Exception("Erro. não foi encontrado nenhum valor no retorno da API");
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Task<Request<Fabricante>> BuscaFabricantesPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Fabricante> RegistraFabricante(CriarNovo novoFabricante)
        {
            try
            {
                var result = await client.PostAsJsonAsync(new Uri(WebConfiguration.BaseAdressApi), novoFabricante);
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
