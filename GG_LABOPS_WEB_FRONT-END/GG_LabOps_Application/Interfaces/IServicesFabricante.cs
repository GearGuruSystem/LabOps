using LabOps.Application.DTOs.Fabricantes;

namespace LabOps.Application.Interfaces
{
    public interface IServicesFabricante
    {
        void AtualizaFabricante(Fabricante fabricante);
        Task<Fabricante> BuscaFabricantesPeloId(int id);
        Task<IEnumerable<Fabricante>> BuscaTodosFabricantes();
        Task<Fabricante> CadastraFabricante(CriarNovo novoFabricante);
        void RemoveFabricante(Fabricante fabricante);
    }
}
