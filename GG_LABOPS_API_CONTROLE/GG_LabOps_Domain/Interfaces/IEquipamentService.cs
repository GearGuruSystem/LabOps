using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IEquipamentService
    {
        Task<IEnumerable<ViewEquipamentDTO>> GetEquipamentsAsync();
        Task<Equipament> RegisterEquipament(Equipament equipament);
    }
}
