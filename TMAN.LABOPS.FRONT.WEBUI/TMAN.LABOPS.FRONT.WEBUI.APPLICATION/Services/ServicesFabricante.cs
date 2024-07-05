using System.Net.Http.Json;
using Tman.LabOps.WebUI.Application.DTOs.Fabricante;
using Tman.LabOps.WebUI.Application.Entities;
using Tman.LabOps.WebUI.Application.Interfaces;

namespace Tman.LabOps.WebUI.Application.Services
{
    public class ServiceFabricante(IHttpClientFactory httpClientFactory) : IServiceFabricante
    {
        private readonly HttpClient client = httpClientFactory.CreateClient(
            $"{Configuration.ClientName}");

        public async Task<IEnumerable<Fabricantes>> BuscaTodosFabricantes()
        {
            try
            {
                var result = await client.GetFromJsonAsync<IEnumerable<Fabricantes>>($"api/v1/Fabricante/BuscarTodosFabricantes");
                return result;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Task<Fabricantes> BuscaFabricantesPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Fabricantes> RegistraFabricante(CriarNovoF novoFabricante)
        {
            try
            {
                var result = await client.PostAsJsonAsync($"api/v1/Fabricante/CadastraFabricante", novoFabricante);
                if (result.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Codigo de retorno {result.StatusCode}");
                    return await result.Content.ReadFromJsonAsync<Fabricantes>();
                }
                throw new Exception();
            }
            catch (Exception ex)
            {
                throw new Exception($"XDXD: {ex.Message}");
            }
        }

        public void AtualizaFabricante(Fabricantes fabricante)
        {
            throw new NotImplementedException();
        }

        public void RemoveFabricante(Fabricantes fabricante)
        {
            throw new NotImplementedException();
        }
    }
}
