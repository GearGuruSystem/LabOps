using GG_LabOps_Domain.DTOs;
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
            return await _userClient.FindByKeyAsync(userKey);
        }

        public async Task<UserLoggedDTO> LoginUser(UserLoginDTO userDTO)
        {
            await _userClient.FindByKeyAsync(userDTO.ChaveUsuario);
            var uValid = await _userClient.ValidUser(userDTO);
            if (uValid)
            {
                return new UserLoggedDTO
                {
                    ChaveUsuario = userDTO.ChaveUsuario,
                };
            }
            throw new Exception();
        }

        private static UserLoggedDTO ConvertUserInLogged(User user)
        {
            var userDTO = new UserLoggedDTO
            {
                ChaveUsuario = user.ChaveUsuario,
                Permissao = user.Permissao,
                Token = user.Token
            };
            return userDTO;
        }
    }
}
