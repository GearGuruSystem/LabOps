using Auth.LabOps.Application.DTOs.DTOs;
using Auth.LabOps.Domain.Entities;

namespace Auth.LabOps.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperUsuario
    {
        IEnumerable<UsuarioDTO> MapperListaUsuarios(IEnumerable<Usuario> usuarios);
        UsuarioDTO MapperToDTO(Usuario usuario);
        Usuario MapperToEntity(UsuarioDTO usuarioDTO);
    }
}
