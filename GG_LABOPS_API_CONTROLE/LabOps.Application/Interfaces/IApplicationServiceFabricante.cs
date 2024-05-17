using LabOps.Application.DTO.DTO;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceFabricante
    {
        Task<IEnumerable<FabricanteDTO>> BuscaTodosFabricantes();
        Task<FabricanteDTO> BuscaFabricantesPeloId(int id);
        void RegistraFabricante(FabricanteDTO obj);
        void AtualizaFabricante(FabricanteDTO obj);
        void RemoveFabricante(FabricanteDTO obj);
    }
}
