using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;

#pragma warning disable IDE0290

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
            return await _userClient.FindByKeyAsync(userKey);
        }

        public async Task<UserLoggedDTO> LoginUser(UserLoginDTO userDTO)
        {
            return await _userClient.LoginUser(userDTO);
        }
    }
}