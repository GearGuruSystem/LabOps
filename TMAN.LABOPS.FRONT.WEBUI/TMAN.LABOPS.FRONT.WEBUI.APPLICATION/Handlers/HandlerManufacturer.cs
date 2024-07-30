using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Fabricante;
using Tman.LabOps.Infrastructure.CrossCutting.Interfaces;
using Tman.LabOps.WebUI.Application.Interfaces;

namespace Tman.LabOps.WebUI.Application.Handlers
{
    public class HandlerManufacturer : IHandlerManufacturer
    {
        private readonly IServicesManufacturer _services;

        public HandlerManufacturer(IServicesManufacturer services)
        {
            _services = services;
        }

        public async Task<IEnumerable<FabricanteDTO>> GetAllManufacturers()
        {
            try
            {
                return await _services.GetAllManufacturers();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<FabricanteDTO> GetManufacturerById(int id)
        {
            try
            {
                return await _services.GetManufacturerById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<FabricanteDTO> RegisterManufacturer(NewFabricanteDTO newManufacturer)
        {
            try
            {
                return await _services.RegisterManufacturer(newManufacturer);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateManufacturer(FabricanteDTO manufacturer)
        {
            try
            {
                _services.UpdateManufacturer(manufacturer);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
