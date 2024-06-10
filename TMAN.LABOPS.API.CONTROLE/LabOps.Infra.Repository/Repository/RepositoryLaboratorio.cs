using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataAcess;
using LabOps.Infra.Data.DataContext;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.Repository.Repository
{
    public class RepositoryLaboratorio : RepositoryBase<Laboratorio>, IRepositoryLaboratorio
    {
        private readonly SqlFactory sqlFactory;

        public RepositoryLaboratorio(SqlFactory sqlFactory, AppDbContext context)
            : base(context)
        {
            this.sqlFactory = sqlFactory;
        }
        #region Metodos Base
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
            base.Registrar(obj);
        }

        public override void Remove(Laboratorio obj)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}