using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface ILaboratoryServices
    {
        public Task<IEnumerable<Laboratory>> GetAllAsync();
        public Task<Laboratory> GetByIdAsync(int id);
        public Task<IEnumerable<Laboratory>> GetByHostnameAsync(string hostname);
        public Task<Laboratory> GetByInvetoryAsync(string inventory);
        public Task<Laboratory> CreateAsync(Laboratory entity);
        public Task<Laboratory> UpdateAsync(int id, Laboratory entity);
        public bool DisableById(int id);
    }
}
