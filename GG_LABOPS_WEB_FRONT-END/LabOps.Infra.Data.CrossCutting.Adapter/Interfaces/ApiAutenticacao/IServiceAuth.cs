using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Usuarios;

namespace LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiAutenticacao
{
    public interface IServiceAuth
    {
        Task<UsuarioDTO> AtualizaUsuario(int id, UsuarioDTO usuario);
        Task<UsuarioDTO> BuscaPorChave(string chaveUsuario);
        Task<UsuarioDTO> BuscaPorId(int id);
        Task<IEnumerable<UsuarioDTO>> BuscaTodosUsuarios();
        Task<UsuarioLogadoDTO> LoginUsuario(UsuarioLoginDTO usuario);
        Task<UsuarioDTO> RegistraUsuario(UsuarioDTO usuario);
        Task<bool> ValidUser(UsuarioLoginDTO userDto);
    }
}
