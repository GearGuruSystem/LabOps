using Auth.LabOps.Application.DTOs.DTOs.Usuario;
using Auth.LabOps.Domain.Entities;

namespace Auth.LabOps.Infra.CrossCutting.Adapter.Interfaces
{
    public interface IMapperUsuario
    {
        IEnumerable<UsuarioDTO> MapperListaUsuarios(IEnumerable<Usuario> usuarios);
        UsuarioDTO MapperToDTO(Usuario usuario);
        Usuario MapperToEntity(UsuarioDTO usuarioDTO);
        Usuario MapperToEntity(UsuarioLoginDTO usuarioLoginDTO);
        Usuario MapperToEntity(CriarUsuarioDTO criarUsuarioDTO);
        UsuarioLogadoDTO MapperToLogadoDTO(Usuario usuario);
    }
}
