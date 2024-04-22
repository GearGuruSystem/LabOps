using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Application.Interfaces
{
    public interface IEquipamentService
    {
        Task<IEnumerable<ViewEquipamentDTO>> GetEquipamentsAsync();
        Task<ViewEquipamentDTO> GetEquipamentsAsync(int id);
        Task RegisterEquipament(CreateEquipamentDTO equipamentDTO);
        Task<UpdateEquipamentDTO> UpdateEquipament(int id, UpdateEquipamentDTO equipament);
    }
}
