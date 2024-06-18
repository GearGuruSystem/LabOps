using LabOps.Application.DTOs.Usuario;
using LabOps.Application.Interfaces;
using LabOps.Infra.Data.AuthApi.Usefull;

namespace LabOps.Infra.Data.AuthApi.Services
{
    public class ServiceAuth(IHttpClientFactory httpClientFactory) : IServiceAuth
    {
        private readonly HttpClient _client = httpClientFactory
            .CreateClient($"{WebConfig.HttpClient_Usuario}");

        public async Task<Usuario> BuscaTodosUsuarios()
        {
            try
            {
                var resposta = await _client.GetAsync($"{WebConfig.HttpClient_Usuario}");
                return await resposta.ReadContentAs<Usuario>();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public async Task<Usuario> BuscaPorId(int id)
        {
            var resposta = await _client.GetAsync($"{WebConfig.HttpClient_Usuario}/{id}");
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.ReadContentAs<Usuario>();
            }
            throw new Exception();
        }

        public async Task<Usuario> BuscaPorChave(string chaveUsuario)
        {
            var resposta = await _client.GetAsync($"{WebConfig.HttpClient_Usuario}/{chaveUsuario}");
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.ReadContentAs<Usuario>();
            }
            throw new Exception();
        }

        public async Task<UsuarioLogado> LoginUsuario(UsuarioLogin usuario)
        {
            var resposta = await _client.PostAsJson($"{WebConfig.HttpClient_Usuario}/Login", usuario);
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.ReadContentAs<UsuarioLogado>();
            }
            throw new Exception();
        }

        public async Task<Usuario> RegistraUsuario(Usuario usuario)
        {
            var resposta = await _client.PostAsJson($"{WebConfig.HttpClient_Usuario}/", usuario);
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.ReadContentAs<Usuario>();
            }
            throw new Exception();
        }

        public async Task<Usuario> AtualizaUsuario(int id, Usuario usuario)
        {
            var resposta = await _client.PutAsJson($"{WebConfig.HttpClient_Usuario}/Update/{id}", usuario);
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.ReadContentAs<Usuario>();
            }
            throw new Exception();
        }

        public Task<bool> ValidUser(UsuarioLogin userDto)
        {
            throw new NotImplementedException();
        }
    }
}
