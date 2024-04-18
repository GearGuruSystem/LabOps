using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IEquipamentService
    {
        Task<Equipament> RegisterEquipament(Equipament equipament);
    }
}
