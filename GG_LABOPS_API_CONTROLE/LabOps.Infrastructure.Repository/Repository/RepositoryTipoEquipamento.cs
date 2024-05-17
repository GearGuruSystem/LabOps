using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infrastructure.Data.DataAcess;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infrastructure.Repository.Repository
{
    public class RepositoryTipoEquipamento : IRepositoryBase<TipoEquipamento>, IRepositoryTipoEquipamento
    {
        private readonly SqlFactory sqlFactory;

        public RepositoryTipoEquipamento(SqlFactory sqlFactory)
        {
            this.sqlFactory = sqlFactory;
        }

        public Task<IEnumerable<TipoEquipamento>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoEquipamento>> BuscarPorParametro(TipoEquipamento obj)
        {
            throw new NotImplementedException();
        }

        public Task<TipoEquipamento> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Registrar(TipoEquipamento obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TipoEquipamento obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(TipoEquipamento obj)
        {
            throw new NotImplementedException();
        }
    }
}
