using GG_labOps_Domain.DTOs;
using GG_labOps_Domain.Entities;
using GG_LabOps_Services.Interfaces;
using GG_LabOps_Services.Security;

#pragma warning disable IDE0290 // Use primary constructor
namespace GG_LabOps_Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IJWTService _jwtService;

        public UserService(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        public async Task<User> GetUser(string chaveUsuario)
        {
            return await QueryUser(chaveUsuario);
        }

        public async Task<User> GetUser(User user)
        {
            return await QueryUser(user);
        }

        public async Task<User> AddUserAsync(User user)
        {
            await QueryUser(user);
            GeneratesHashPasswordUser.ConverteSenhaEmHash(user);
            return await _repository.AddUser(user);
        }

        public Task<User> UpdateUser(int id, User user)
        {
            return _repository.UpdateUser(id, user);
        }

        public async Task<User> ValidUserAndGeneratesToken(User user)
        {
            await QueryUser(user);
            VerifyHash(user);
            SetToken(user);
            return user;
        }

        private async Task<User> QueryUser(string userKey)
        {
            var userConsulted = await _repository.SearchUser(userKey);
            if (userConsulted != null)
            {
                return userConsulted;
            }
            throw new Exception();
        }

        private async Task<User> QueryUser(User user)
        {
            var userConsulted = await _repository.SearchUser(user);
            if (userConsulted != null)
            {
                return userConsulted;
            }
            throw new Exception();
        }

        private static bool VerifyHash(User user)
        {
            var verify = GeneratesHashPasswordUser.ValidUpdateHashAsync(user, user.Senha);
            if (verify == false)
            {
                throw new Exception();
            }
            return true;
        }

        private User SetToken(User user)
        {
            var userDTO = ConvertToDto(user);
            userDTO.Token = _jwtService.GenerateToken(user);
            return user;
        }

        private static UserLoggedDTO ConvertToDto(User user)
        {
            var dto = new UserLoggedDTO
            {
                Login = user.ChaveUsuario,
            };
            return dto;
        }
    }
}
