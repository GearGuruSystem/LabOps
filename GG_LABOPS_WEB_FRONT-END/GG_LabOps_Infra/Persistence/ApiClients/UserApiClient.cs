using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infra.Useful;
using System.Runtime.CompilerServices;
#pragma warning disable IDE0290 // Use primary constructor

namespace GG_LabOps_Infra.Persistence.ApiClients
{
    public class UserApiClient : IUserApiClient
    {
        private readonly HttpClient _client;

        public UserApiClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<User> FindAll()
        {
            var response = await _client.GetAsync($"{EndpointsApiClient.UserEndpoint()}");
            return await response.ReadContentAs<User>();
        }

        public async Task<User> FindById(int id)
        {
            var response = await _client.GetAsync($"{EndpointsApiClient.UserEndpoint()}/{id}");
            return await response.ReadContentAs<User>();
        }

        public async Task<User> FindByKeyAsync(string userKey)
        {
            var response = await _client.GetAsync($"{EndpointsApiClient.UserEndpoint()}/{userKey}");
            return await response.ReadContentAs<User>();
        }

        public async Task<User> LoginUser(UserLoginDTO user)
        {
            var response = await _client.PostAsJson($"{EndpointsApiClient.UserEndpoint()}/Login", user);
            return await response.ReadContentAs<User>();
        }

        public async Task<User> RegisterUser(User user)
        {
            var response = await _client.PostAsJson($"{EndpointsApiClient.UserEndpoint()}/", user);
            return await response.ReadContentAs<User>();
        }

        public async Task<User> UpdateUser(int id, User user)
        {
            var response = await _client.PutAsJson($"{EndpointsApiClient.UserEndpoint()}/Update/{id}", user);
            return await response.ReadContentAs<User>();
        }

        public Task<bool> ValidUser(UserLoginDTO userDto)
        {
            throw new NotImplementedException();
        }
    }
}
