using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;

namespace GG_LabOps_Application.Services
{
    internal class LaboratoryServices : ILaboratoryServices
    {
        private readonly ILaboratoryRepository repository;

        public LaboratoryServices(ILaboratoryRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Laboratory>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }
        public async Task<Laboratory> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public Task<Laboratory> GetByHostnameAsync(string hostname)
        {
            return repository.GetByHostnameAsync(hostname);
        }

        public async Task<Laboratory> GetByInvetoryAsync(string inventory)
        {
            return await repository.GetByInvetoryAsync(inventory);
        }

        public async Task<Laboratory> CreateAsync(Laboratory entity)
        {
            return await repository.CreateAsync(entity);
        }

        public async Task<Laboratory> UpdateAsync(int id, Laboratory entity)
        {
            return await repository.UpdateAsync(id, entity);
        }

        public bool DisableById(int id)
        {
            return repository.DisableById(id);
        }
    }
}
