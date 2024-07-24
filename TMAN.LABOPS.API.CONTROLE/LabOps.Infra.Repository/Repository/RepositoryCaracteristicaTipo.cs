using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataContext;

#pragma warning disable IDE0290

namespace LabOps.Infra.Repository.Repository
{
    public class RepositoryCaracteristicaTipo : RepositoryBase<CaracteristicaTipo>, IRepositoryCaracteristicaTipo
    {
        public RepositoryCaracteristicaTipo(AppDbContext context) 
            : base(context)
        {

        }
    }
}
