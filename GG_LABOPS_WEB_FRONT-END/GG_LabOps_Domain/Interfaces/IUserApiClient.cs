using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IUserApiClient
    {
        Task<User> FindAll();
        Task<User> FindById(int id);
        Task<User> FindByKeyAsync(string userKey);
        Task<UserLoggedDTO> LoginUser(UserLoginDTO user);
        Task<User> RegisterUser(User user);
        Task<User> UpdateUser(int id, User user);
        Task<bool> ValidUser(UserLoginDTO userDto);
    }
}
