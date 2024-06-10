using Auth.LabOps.Domain.Entities;

namespace Auth.LabOps.Domain.Core.Interfaces
{
    public interface IRepositoryUsuario : IRepositoryBase<Usuario>
    {
        public Task<Usuario> Buscar(string chave);
    }
}
