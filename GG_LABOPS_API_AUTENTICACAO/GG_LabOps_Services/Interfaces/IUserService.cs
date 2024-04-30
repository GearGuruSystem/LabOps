using GG_labOps_Domain.Entities;

namespace GG_LabOps_Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUser(User user);
        Task<User> GetUser(string chaveUsuario);
        Task<User> AddUserAsync(User user);
        Task<User> UpdateUser(int id, User user);
        Task<User> ValidUserAndGeneratesToken(User user);
    }
}
