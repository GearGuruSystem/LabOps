using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IUserServices
    {
        Task<Usuario> SearchUserByKey(string userKey);
        Task<UserLoggedDTO> LoginUser(UserLoginDTO userDTO);
    }
}
