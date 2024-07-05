using Tman.LabOps.WebUI.Application.DTOs.Equipamento;
using Tman.LabOps.WebUI.Application.Entities;

namespace Tman.LabOps.WebUI.Application.Interfaces
{
    public interface IServiceEquipamento
    {
        Task<IEnumerable<ViewEquipamento>> BuscaTodosEquipamentos();
    }
}
