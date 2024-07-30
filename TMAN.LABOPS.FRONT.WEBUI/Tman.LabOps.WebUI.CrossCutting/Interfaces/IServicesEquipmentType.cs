using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.TiposEquipamentos;

namespace Tman.LabOps.Infrastructure.CrossCutting.Interfaces
{
    public interface IServicesEquipmentType
    {
        Task<IEnumerable<TipoEquipamentoDTO>> GetAllEquipmentType();
        Task<TipoEquipamentoDTO> GetEquipmentTypeById(int id);
        Task<TipoEquipamentoDTO> RegisterEquipmentType(NewTipoEquipamentoDTO nTipoEquipamento);
        void UpdateEquipmentType(TipoEquipamentoDTO tipoEquipamento);
    }
}
