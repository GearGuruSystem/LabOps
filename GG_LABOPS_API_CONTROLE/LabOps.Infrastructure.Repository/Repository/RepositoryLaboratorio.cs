using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.Repository.Repository
{
    public class RepositoryLaboratorio : RepositoryBase<Laboratorio>, IRepositoryLaboratorio
    {
        public override Task<IEnumerable<Laboratorio>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public override Task<Laboratorio> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<Laboratorio>> BuscarPorParametro(Laboratorio obj)
        {
            throw new NotImplementedException();
        }

        public override void Atualizar(Laboratorio obj)
        {
            throw new NotImplementedException();
        }

        public override void Registrar(Laboratorio obj)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Laboratorio obj)
        {
            throw new NotImplementedException();
        }
    }
}
