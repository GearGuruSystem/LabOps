using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IEquipamentRepository
    {
        Task<IEnumerable<ViewEquipamentDTO>> GetAllAsync();
        Task<ViewEquipamentDTO> GetByIdAsync(int id);
        Task<Equipament> CreateAsync(Equipament equipament);
        Task<Equipament> UpdateAsync(int id, Equipament entity);
        Task<bool> DisableById(int id);
    }
}
