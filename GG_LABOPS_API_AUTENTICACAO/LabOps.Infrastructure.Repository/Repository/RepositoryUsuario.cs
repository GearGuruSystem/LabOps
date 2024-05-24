using Auth.LabOps.Domain.Core.Interfaces;
using Auth.LabOps.Domain.Entities;
using Auth.LabOps.Infrastructure.Data.DataAcess;

namespace Auth.LabOps.Infrastructure.Repository.Repository
{
    public class RepositoryUsuario : RepositoryBase<Usuario>, IRepositoryUsuario
    {
        private readonly ISqlFactory sqlFactory;

        public RepositoryUsuario(ISqlFactory sqlFactory)
        {
            this.sqlFactory = sqlFactory;
        }

        public override Task<IEnumerable<Usuario>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public override Task<Usuario> Buscar()
        {
            
        }

        public override void Registrar(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
