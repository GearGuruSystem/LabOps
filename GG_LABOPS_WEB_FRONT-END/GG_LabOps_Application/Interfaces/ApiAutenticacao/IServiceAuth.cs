using LabOps.Application.DTOs.Usuario;

namespace LabOps.Application.Interfaces.ApiAutenticacao
{
    public interface IServiceAuth
    {
        Task<Usuario> AtualizaUsuario(int id, Usuario usuario);
        Task<Usuario> BuscaPorChave(string chaveUsuario);
        Task<Usuario> BuscaPorId(int id);
        Task<Usuario> BuscaTodosUsuarios();
        Task<UsuarioLogado> LoginUsuario(UsuarioLogin usuario);
        Task<Usuario> RegistraUsuario(Usuario usuario);
        Task<bool> ValidUser(UsuarioLogin userDto);
    }
}
