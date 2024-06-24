using Auth.LabOps.Application.DTOs.DTOs.Usuario;
using Auth.LabOps.Domain.Entities;
using Auth.LabOps.Infra.CrossCutting.Adapter.Interfaces;


#pragma warning disable IDE0028 // Simplificar a inicialização de coleção

namespace Auth.LabOps.Infra.CrossCutting.Adapter.Map
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
                    IDUsuario = item.IDUsuario,
                    Login = item.Login,
                    Senha = item.Senha,
                    InseridoEm = item.InseridoEm,
                    AtualizadoEm = item.AtualizadoEm,
                };
                UsuarioDTOs.Add(usuarioDTO);
            }
            return UsuarioDTOs;
        }

        public UsuarioDTO MapperToDTO(Usuario usuario)
        {
            UsuarioDTO usuarioDTO = new UsuarioDTO
            {
                IDUsuario = usuario.IDUsuario,
                Login = usuario.Login,
                Senha = usuario.Senha,
                InseridoEm = usuario.InseridoEm,
                AtualizadoEm = usuario.AtualizadoEm,
            };

            return usuarioDTO;
        }

        public Usuario MapperToEntity(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = new Usuario
            {
                IDUsuario = usuarioDTO.IDUsuario,
                Login = usuarioDTO.Login,
                Senha = usuarioDTO.Senha,
                InseridoEm = usuarioDTO.InseridoEm,
                AtualizadoEm = usuarioDTO.AtualizadoEm,
            };
            return usuario;
        }

        public Usuario MapperToEntity(UsuarioLoginDTO usuarioLoginDTO)
        {
            Usuario usuario = new Usuario
            {
                Login = usuarioLoginDTO.Login,
                Senha = usuarioLoginDTO.Senha
            };
            return usuario;
        }

        public Usuario MapperToEntity(CriarUsuarioDTO criarUsuarioDTO)
        {
            Usuario usuario = new Usuario
            {
                Login = criarUsuarioDTO.Login,
                Senha = criarUsuarioDTO.Senha,
            };
            return usuario;
        }

        public UsuarioLogadoDTO MapperToLogadoDTO(Usuario usuario)
        {
            UsuarioLogadoDTO usuarioLogado = new UsuarioLogadoDTO(usuario.Login);
            return usuarioLogado;
        }
    }
}
