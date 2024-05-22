using Auth.LabOps.Domain.Core.Interfaces;

#pragma warning disable IDE0290 // Use primary constructor

namespace Auth.LabOps.Domain.Services.Services
{
    public class ServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }
    }
}
