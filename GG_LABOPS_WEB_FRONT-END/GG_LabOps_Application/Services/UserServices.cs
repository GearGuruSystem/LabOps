using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;
#pragma warning disable IDE0290 // Use primary constructor

namespace GG_LabOps_Application.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserApiClient _userClient;

        public UserServices(IUserApiClient userClient)
        {
            _userClient = userClient;
        }

        public async Task<User> SearchUserByKey(string userKey)
        {
            return await _userClient.FindByKey(userKey);
        }
    }
}
