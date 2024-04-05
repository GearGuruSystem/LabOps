using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces.Generics;

namespace GG_LabOps_Domain.Interfaces
{
    public interface ILaboratoryRepository : IGenericRepository<Laboratory>
    {
        public Task<Laboratory> GetByInvetoryAsync(string inventory);
        public Task<Laboratory> GetByHostnameAsync(string hostname);
        public bool DisableById(int id);
    }
}
