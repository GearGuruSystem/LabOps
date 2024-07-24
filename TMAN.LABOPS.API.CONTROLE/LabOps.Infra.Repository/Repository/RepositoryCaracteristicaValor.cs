using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataContext;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.Repository.Repository
{
    public class RepositoryCaracteristicaValor : RepositoryBase<CaracteristicaValor>, IRepositoryCaracteristicaValor
    {
        public RepositoryCaracteristicaValor(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<CaracteristicaValor>> BuscarCaracteristicaValor()
        {
            return await base.BuscarTodos();
        }

        public async Task RegistrarCaracteristicaValor(CaracteristicaValor caracteristicaValor)
        {
            await base.Registrar(caracteristicaValor);
        }
    }
}
