using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Application.Interfaces
{
    public interface IApplicationServiceUsuario
    {
        Task<Usuario> SearchUserByKey(string userKey);
        Task<Usuario> LoginUser(Usuario userDTO);
    }
}
