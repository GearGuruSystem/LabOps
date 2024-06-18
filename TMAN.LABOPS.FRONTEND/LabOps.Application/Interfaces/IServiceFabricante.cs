using LabOps.Application.DTOs.Fabricante;
using LabOps.Application.Requests;

namespace LabOps.Application.Interfaces
{
    public interface IServicesFabricante
    {
        Task<IEnumerable<Fabricante>> BuscaTodosFabricantes();
        Task<Request<Fabricante>> BuscaFabricantesPeloId(int id);
        Task<Fabricante> RegistraFabricante(CriarNovo novoFabricante);
        void AtualizaFabricante(Fabricante fabricante);
        void RemoveFabricante(Fabricante fabricante);
    }
}
