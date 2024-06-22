using LabOps.Application.DTO.DTO.Fabricantes;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceFabricante
    {
        Task<IEnumerable<FabricanteDTO>> BuscaTodosFabricantes();
        Task<FabricanteDTO> BuscaFabricantesPeloId(int id);
        void RegistraFabricante(CriarNovoFabricanteDTO obj);
        void AtualizaFabricante(AtualizarFabricanteDTO obj);
        void RemoveFabricante(FabricanteDTO obj);
    }
}