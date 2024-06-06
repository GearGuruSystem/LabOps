using LabOps.Application.DTO.DTO.Laboratorio;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperLaboratorio
    {
        IEnumerable<LaboratorioDTO> MapperListaLaboratorios(IEnumerable<Laboratorio> laboratorio);
        LaboratorioDTO MapperToDTO(Laboratorio laboratorio);
        Laboratorio MapperToEntity(LaboratorioDTO laboratorioDTO);
    }
}
