using Auth.LabOps.Application.DTOs.DTOs.Usuario;
using Auth.LabOps.Domain.Entities;

namespace Auth.LabOps.Application.Interfaces
{
    public interface IApplicationServiceUsuario
    {
        Task<Usuario> Buscar(int id);
        Task<UsuarioDTO> Buscar(string chave);
        Task<IEnumerable<UsuarioDTO>> BuscarTodos();
        Task<UsuarioLogadoDTO> ValidaUsuarioGeraToken(UsuarioLoginDTO usuarioLoginDTO);
        void Criar(CriarUsuarioDTO criarUsuarioDTO);
    }
}
