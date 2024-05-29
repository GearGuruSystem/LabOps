using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IUsuarioApiClient
    {
        Task<Usuario> AtualizaUsuario(int id, Usuario usuario);
        Task<Usuario> BuscaPorChave(string chaveUsuario);
        Task<Usuario> BuscaPorId(int id);
        Task<Usuario> BuscaTodos();
        Task<UserLoggedDTO> LoginUsuario(UserLoginDTO usuario);
        Task<Usuario> RegistraUsuario(Usuario usuario);
        Task<bool> ValidUser(UserLoginDTO userDto);
    }
}
