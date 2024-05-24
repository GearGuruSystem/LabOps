using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IUserApiClient
    {
        Task<Usuario> FindAll();
        Task<Usuario> FindById(int id);
        Task<Usuario> FindByKeyAsync(string userKey);
        Task<UserLoggedDTO> LoginUser(UserLoginDTO user);
        Task<Usuario> RegisterUser(Usuario user);
        Task<Usuario> UpdateUser(int id, Usuario user);
        Task<bool> ValidUser(UserLoginDTO userDto);
    }
}
