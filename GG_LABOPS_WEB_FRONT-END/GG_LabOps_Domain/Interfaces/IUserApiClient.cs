using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IUserApiClient
    {
        Task<User> FindByKeyAsync(string userKey);
        Task<User> LoginUser(UserLoginDTO userDto);
        Task<bool> ValidUser(UserLoginDTO userDto);
    }
}
