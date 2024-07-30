using LabOps.Application.DTO.DTO.Fabricantes;
using LabOps.Application.DTO.Response;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceFabricante
    {
        Task<Response<IEnumerable<FabricanteDTO>>> BuscaTodosFabricantes();
        Task<FabricanteDTO> BuscaFabricantesPeloId(int id);
        void RegistraFabricante(CriarNovoFabricanteDTO obj);
        void AtualizaFabricante(AtualizarFabricanteDTO obj);
        void RemoveFabricante(FabricanteDTO obj);
    }
}