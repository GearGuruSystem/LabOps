using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Equipamento;
using Tman.LabOps.Infrastructure.CrossCutting.Interfaces;
using Tman.LabOps.WebUI.Application.Interfaces;

namespace Tman.LabOps.WebUI.Application.Handlers
{
    public class HandlersEquipment : IHandlersEquipment
    {
        private readonly IServicesEquipment _services;

        public HandlersEquipment(IServicesEquipment services)
        {
            _services = services;
        }

        public async Task<IEnumerable<EquipamentoDTO>> GetAllEquipment()
        {
            try
            {
                return await _services.GetAllEquipment();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<EquipamentoDTO> GetEquipmentById(int id)
        {
            try
            {
                return await _services.GetEquipmentById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> RegisterEquipment(NewEquipamentoDTO criarNovo)
        {
            try
            {
                return await _services.RegisterEquipment(criarNovo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateEquipment(EditEquipamentoDTO equipament)
        {
            try
            {
                _services.UpdateEquipment(equipament);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
