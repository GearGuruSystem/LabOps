using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infra.Useful;
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

        public async Task<User> FindByKey(string userKey)
        {
            var response = await _client.GetAsync($"{EndpointsApiClient.UserEndpoint()}/{userKey}");
            return await response.ReadContentAs<User>();
        }
    }
}
