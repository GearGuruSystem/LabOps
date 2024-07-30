using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Fabricante;

namespace Tman.LabOps.Infrastructure.CrossCutting.Interfaces
{
    public interface IServicesManufacturer
    {
        Task<IEnumerable<FabricanteDTO>> GetAllManufacturers();
        Task<FabricanteDTO> GetManufacturerById(int id);
        Task<FabricanteDTO> RegisterManufacturer(NewFabricanteDTO novoFabricante);
        void UpdateManufacturer(FabricanteDTO fabricante);
    }
}
