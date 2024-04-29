using GG_labOps_Domain.Entities;
using GG_LabOps_Services.Interfaces;
using GG_LabOps_Services.Security;

#pragma warning disable IDE0290 // Use primary constructor
namespace GG_LabOps_Services.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _repository;

        public UserServices(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        public async Task<User> AddUserAsync(User user)
        {
            await QueryUser(user);
            GeraHashSenhaUser.ConverteSenhaEmHash(user);
            return await _repository.AddUser(user);
        }

        public Task<User> UpdateUser(int id, User user)
        {
            return _repository.UpdateUser(id, user);
        }

        public async Task<bool> ValidUser(User user)
        {
            await QueryUser(user);
            VerifyHash(user);
            return true;
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
            var verify = GeraHashSenhaUser.ValidUpdateHashAsync(user, user.Senha);
            if (verify == false)
            {
                throw new Exception();
            }
            return true;
        }
    }
}
