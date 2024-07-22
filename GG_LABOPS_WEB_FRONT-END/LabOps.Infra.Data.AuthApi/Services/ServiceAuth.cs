using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Usuarios;
using LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiAutenticacao;
using System.Net.Http.Json;

namespace LabOps.Infra.Data.AuthApi.Services
{
    public class ServiceAuth(IHttpClientFactory httpClientFactory) : IServiceAuth
    {
        private readonly HttpClient _client = httpClientFactory
            .CreateClient($"{WebConfig.HttpClient_Usuario}");

        public async Task<IEnumerable<UsuarioDTO>> BuscaTodosUsuarios()
        {
            var resposta = await _client.GetAsync($"{WebConfig.HttpClient_Usuario}");
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.Content.ReadFromJsonAsync<IEnumerable<UsuarioDTO>>();
            }
            throw new Exception();
        }

        public async Task<UsuarioDTO> BuscaPorId(int id)
        {
            var resposta = await _client.GetAsync($"{WebConfig.HttpClient_Usuario}/{id}");
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.Content.ReadFromJsonAsync<UsuarioDTO>();
            }
            throw new Exception();
        }

        public async Task<UsuarioDTO> BuscaPorChave(string chaveUsuario)
        {
            var resposta = await _client.GetAsync($"{WebConfig.HttpClient_Usuario}/{chaveUsuario}");
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.Content.ReadFromJsonAsync<UsuarioDTO>();
            }
            throw new Exception();
        }

        public async Task<UsuarioLogadoDTO> LoginUsuario(UsuarioLoginDTO usuario)
        {
            var resposta = await _client.PostAsJsonAsync($"{WebConfig.HttpClient_Usuario}/Login", usuario);
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.Content.ReadFromJsonAsync<UsuarioLogadoDTO>();
            }
            throw new Exception();
        }

        public async Task<UsuarioDTO> RegistraUsuario(UsuarioDTO usuario)
        {
            var resposta = await _client.PostAsJsonAsync($"{WebConfig.HttpClient_Usuario}/", usuario);
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.Content.ReadFromJsonAsync<UsuarioDTO>();
            }
            throw new Exception();
        }

        public async Task<UsuarioDTO> AtualizaUsuario(int id, UsuarioDTO usuario)
        {
            var resposta = await _client.PutAsJsonAsync($"{WebConfig.HttpClient_Usuario}/Update/{id}", usuario);
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.Content.ReadFromJsonAsync<UsuarioDTO>();
            }
            throw new Exception();
        }

        public Task<bool> ValidUser(UsuarioLoginDTO userDto)
        {
            throw new NotImplementedException();
        }
    }
}
