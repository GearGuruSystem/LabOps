using Auth.LabOps.Application.DTOs.DTOs;
using Auth.LabOps.Domain.Entities;
using Auth.LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Auth.LabOps.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperUsuario : IMapperUsuario
    {
        private readonly List<UsuarioDTO> UsuarioDTOs = new List<UsuarioDTO>();

        public IEnumerable<UsuarioDTO> MapperListaUsuarios(IEnumerable<Usuario> usuarios)
        {
            foreach (var item in usuarios)
            {
                UsuarioDTO usuarioDTO = new UsuarioDTO
                {
                    
                };
                UsuarioDTOs.Add(usuarioDTO);
            }
            return UsuarioDTOs;
        }

        public UsuarioDTO MapperToDTO(Usuario usuario)
        {
            UsuarioDTO usuarioDTO = new UsuarioDTO
            {

            };

            return usuarioDTO;
        }

        public Usuario MapperToEntity(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = new Usuario();
            return usuario;
        }
    }
}
