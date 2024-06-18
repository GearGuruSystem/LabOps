using LabOps.Application.DTOs.Fabricantes;

namespace LabOps.Application.Interfaces
{
    public interface IServiceFabricante
    {
        void AtualizaFabricante(Fabricante fabricante);
        Task<Fabricante> BuscaFabricantesPeloId(int id);
        Task<IEnumerable<Fabricante>> BuscaTodosFabricantes();
        Task<Fabricante> RegistraFabricante(CriarNovo novoFabricante);
        void RemoveFabricante(Fabricante fabricante);
    }
}
