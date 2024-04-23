using GG_LabOps_Domain.DTOs;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IEquipamentRepository
    {
        Task<IEnumerable<ViewEquipamentDTO>> GetAllAsync();
        Task<ViewEquipamentDTO> GetByIdAsync(int id);
        Task<CreateEquipamentDTO> CreateAsync(CreateEquipamentDTO equipament);
        Task<UpdateEquipamentDTO> UpdateAsync(int id, UpdateEquipamentDTO entity);
        Task<bool> DisableById(int id);
    }
}
