using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Application.Interfaces
{
    public interface IEquipamentService
    {
        Task<DisableEquipamentDTO> DisableEquipament(int id);
        Task<IEnumerable<ViewEquipamentDTO>> GetEquipamentsAsync();
        Task<ViewEquipamentDTO> GetEquipamentsAsync(int id);
        Task<ViewEquipamentDTO> RegisterEquipament(CreateEquipamentDTO equipamentDTO);
        Task<ViewEquipamentDTO> UpdateEquipament(int id, UpdateEquipamentDTO equipament);
    }
}
