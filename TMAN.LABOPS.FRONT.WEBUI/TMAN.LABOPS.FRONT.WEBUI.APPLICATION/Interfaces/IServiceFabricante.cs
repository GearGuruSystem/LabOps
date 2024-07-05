using Tman.LabOps.WebUI.Application.DTOs.Fabricante;
using Tman.LabOps.WebUI.Application.Entities;

namespace Tman.LabOps.WebUI.Application.Interfaces
{
    public interface IServiceFabricante
    {
        Task<IEnumerable<Fabricantes>> BuscaTodosFabricantes();
        Task<Fabricantes> RegistraFabricante(CriarNovoF novoFabricante);
    }
}
