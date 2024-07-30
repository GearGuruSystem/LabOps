using Tman.LabOps.Infrastructure.CrossCutting.DTOs.TiposEquipamentos;
using Tman.LabOps.Infrastructure.CrossCutting.Interfaces;
using Tman.LabOps.WebUI.Application.Interfaces;

namespace Tman.LabOps.WebUI.Application.Handlers
{
    public class HandlerEquipmentType : IHandlerEquipmentType
    {
        private readonly IServicesEquipmentType _services;

        public HandlerEquipmentType(IServicesEquipmentType services)
        {
            _services = services;
        }

        public async Task<IEnumerable<TipoEquipamentoDTO>> GetAllEquipmentType()
        {
            try
            {
                return await _services.GetAllEquipmentType();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<TipoEquipamentoDTO> GetEquipmentTypeById(int id)
        {
            try
            {
                return await _services.GetEquipmentTypeById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<TipoEquipamentoDTO> RegisterEquipmentType(NewTipoEquipamentoDTO nTipoEquipamento)
        {
            try
            {
                return await _services.RegisterEquipmentType(nTipoEquipamento);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateEquipmentType(TipoEquipamentoDTO tipoEquipamento)
        {
            try
            {
                _services.UpdateEquipmentType(tipoEquipamento);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
