using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Fabricante;

namespace Tman.LabOps.WebUI.Application.Interfaces
{
    public interface IHandlerManufacturer
    {
        Task<IEnumerable<FabricanteDTO>> GetAllManufacturers();
        Task<FabricanteDTO> GetManufacturerById(int id);
        Task<FabricanteDTO> RegisterManufacturer(NewFabricanteDTO newManufacturer);
        Task UpdateManufacturer(EditFabricanteDTO editManufacturer);
    }
}
