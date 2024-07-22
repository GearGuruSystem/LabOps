using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Fabricantes;

namespace LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiControle
{
    public interface IServicesFabricante
    {
        Task<IEnumerable<FabricanteDTO>> BuscaTodosFabricantes();
        Task<FabricanteDTO> BuscaFabricantesPeloId(int id);
        Task<FabricanteDTO> CadastraFabricante(CriarNovoFDTO novoFabricante);
        void AtualizaFabricante(FabricanteDTO fabricante);
        void RemoveFabricante(FabricanteDTO fabricante);
    }
}
