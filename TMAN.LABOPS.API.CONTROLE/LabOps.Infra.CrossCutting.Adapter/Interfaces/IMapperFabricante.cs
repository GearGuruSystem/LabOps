using LabOps.Application.DTO.DTO.Fabricantes;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperFabricante
    {
        #region Mappers
        IEnumerable<FabricanteDTO> MapperListaFabricantes(IEnumerable<Fabricante> fabricantes);
        FabricanteDTO MapperToDTO(CriarNovoFabricanteDTO cFabricanteDTO);
        FabricanteDTO MapperToDTO(Fabricante fabricante);
        Fabricante MapperToEntity(FabricanteDTO fabricanteDTO);
        Fabricante MapperToEntity(CriarNovoFabricanteDTO cFabricanteDTO);
        Fabricante MapperToEntity(AtualizarFabricanteDTO aFabricanteDTO);
        #endregion Mappers
    }
}