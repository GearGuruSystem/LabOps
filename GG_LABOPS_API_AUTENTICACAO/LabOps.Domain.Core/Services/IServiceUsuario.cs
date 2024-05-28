using Auth.LabOps.Domain.Entities;

namespace Auth.LabOps.Domain.Core.Services
{
    public interface IServiceUsuario : IServiceBase<Usuario>
    {
        Task<Usuario> ValidaUsuarioGeraToken(Usuario usuario);
        Task<Usuario> Buscar(string chave);
    }
}
