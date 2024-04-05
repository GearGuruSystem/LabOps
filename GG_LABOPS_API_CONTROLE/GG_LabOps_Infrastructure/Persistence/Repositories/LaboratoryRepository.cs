using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;

namespace GG_LabOps_Infrastructure.Persistence.Repositories
{
    internal class LaboratoryRepository : ILaboratoryRepository
    {
        public Task<IEnumerable<Laboratory>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Laboratory> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Laboratory> GetByHostnameAsync(string hostname)
        {
            throw new NotImplementedException();
        }

        public Task<Laboratory> GetByInvetoryAsync(string inventory)
        {
            throw new NotImplementedException();
        }

        public Task<Laboratory> CreateAsync(Laboratory entity)
        {
            throw new NotImplementedException();
        }

        public Task<Laboratory> UpdateAsync(int id, Laboratory entity)
        {
            throw new NotImplementedException();
        }

        public bool DisableById(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
