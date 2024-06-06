using LabOps.Application.DTO.DTO.Fabricantes;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperFabricante
    {
        #region Mappers
        IEnumerable<FabricanteDTO> MapperListaFabricantes(IEnumerable<Fabricante> fabricantes);
        Fabricante MapperToEntity(FabricanteDTO fabricanteDTO);
        FabricanteDTO MapperToDTO(Fabricante fabricante);
        #endregion
    }
}
