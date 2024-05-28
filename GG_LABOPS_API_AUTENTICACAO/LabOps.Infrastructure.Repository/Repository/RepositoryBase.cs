using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.LabOps.Infrastructure.Repository.Repository
{
    public abstract class RepositoryBase<TEntity> where TEntity : class
    {
        public abstract Task<IEnumerable<TEntity>> BuscarTodos();
        public abstract Task<TEntity> Buscar(int id);
        public abstract void Registrar(TEntity entity);
    }
}
