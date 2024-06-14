using LabOps.Application.DTO.DTO.Fabricantes;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperFabricante
    {
        #region Mappers
        IEnumerable<FabricanteDTO> MapperListaFabricantes(IEnumerable<Fabricante> fabricantes);
        FabricanteDTO MapperToDTO(CriarNovo cFabricanteDTO);
        FabricanteDTO MapperToDTO(Fabricante fabricante);
        Fabricante MapperToEntity(FabricanteDTO fabricanteDTO);
        Fabricante MapperToEntity(CriarNovo cFabricanteDTO);
        Fabricante MapperToEntity(Atualizar aFabricanteDTO);
        #endregion Mappers
    }
}