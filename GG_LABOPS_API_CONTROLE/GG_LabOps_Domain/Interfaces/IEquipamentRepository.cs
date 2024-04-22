using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IEquipamentRepository
    {
        Task<IEnumerable<ViewEquipamentDTO>> GetAllAsync();
        Task<ViewEquipamentDTO> GetByIdAsync(int id);
        void CreateAsync(CreateEquipamentDTO equipament);
        Task<UpdateEquipamentDTO> UpdateAsync(int id, UpdateEquipamentDTO entity);
        bool DisableById(int id);
    }
}
