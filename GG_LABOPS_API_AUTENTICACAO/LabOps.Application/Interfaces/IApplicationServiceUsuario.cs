using Auth.LabOps.Domain.Entities;

namespace Auth.LabOps.Application.Interfaces
{
    public interface IApplicationServiceUsuario
    {
        Task<Usuario> Buscar();
        Task<IEnumerable<Usuario>> BuscarTodos();
        void Criar(Usuario usuario);
    }
}
