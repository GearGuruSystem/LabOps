using GG_labOps_Domain.DTOs;
using GG_labOps_Domain.Entities;

namespace GG_labOps_Domain.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUser(User user);

        Task<User> GetUser(string chaveUsuario);

        Task<User> AddUserAsync(RegisterUserDTO user);

        Task<User> UpdateUser(int id, User user);

        Task<User> ValidUserAndGeneratesToken(User user);
    }
}