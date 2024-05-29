using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infra.Useful;

#pragma warning disable IDE0290

namespace GG_LabOps_Infra.Persistence.ApiClients
{
    public class UsuarioApiClient : IUsuarioApiClient
    {
        private readonly HttpClient _client;

        public UsuarioApiClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<Usuario> BuscaTodos()
        {
            try
            {
                var resposta = await _client.GetAsync($"{EndpointsApiClient.UserEndpoint()}");
                return await resposta.ReadContentAs<Usuario>();
            }
            catch (Exception ex)
            {
                return new Usuario(new Notificacao($"Ocorreu um erro {ex.Message}"));
            }
        }

        public async Task<Usuario> BuscaPorId(int id)
        {
            var resposta = await _client.GetAsync($"{EndpointsApiClient.UserEndpoint()}/{id}");
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.ReadContentAs<Usuario>();
            }
            throw new Exception();
        }

        public async Task<Usuario> BuscaPorChave(string chaveUsuario)
        {
            var resposta = await _client.GetAsync($"{EndpointsApiClient.UserEndpoint()}/{chaveUsuario}");
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.ReadContentAs<Usuario>();
            }
            throw new Exception();
        }

        public async Task<UserLoggedDTO> LoginUsuario(UserLoginDTO usuario)
        {
            var resposta = await _client.PostAsJson($"{EndpointsApiClient.UserEndpoint()}/Login", usuario);
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.ReadContentAs<UserLoggedDTO>();
            }
            throw new Exception();
        }

        public async Task<Usuario> RegistraUsuario(Usuario usuario)
        {
            var resposta = await _client.PostAsJson($"{EndpointsApiClient.UserEndpoint()}/", usuario);
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.ReadContentAs<Usuario>();
            }
            throw new Exception();
        }

        public async Task<Usuario> AtualizaUsuario(int id, Usuario usuario)
        {
            var resposta = await _client.PutAsJson($"{EndpointsApiClient.UserEndpoint()}/Update/{id}", usuario);
            if (resposta.IsSuccessStatusCode)
            {
                return await resposta.ReadContentAs<Usuario>();
            }
            throw new Exception();
        }

        public Task<bool> ValidUser(UserLoginDTO userDto)
        {
            throw new NotImplementedException();
        }
    }
}
