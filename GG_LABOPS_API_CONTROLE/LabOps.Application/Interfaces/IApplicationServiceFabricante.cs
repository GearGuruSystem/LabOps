using LabOps.Application.DTO.DTO.Fabricantes;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceFabricante
    {
        Task<IEnumerable<FabricanteDTO>> BuscaTodosFabricantes(int pageNumber, int pageSize);
        Task<FabricanteDTO> BuscaFabricantesPeloId(int id);
        void RegistraFabricante(FabricanteDTO obj);
        void AtualizaFabricante(FabricanteDTO obj);
        void RemoveFabricante(FabricanteDTO obj);
    }
}
