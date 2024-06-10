using LabOps.Application.DTO.DTO;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceTipoEquipamento
    {
        public Task<IEnumerable<TipoEquipamentoDTO>> BuscarTodosTiposDeEquipamentos(int pageNumber, int pageSize);
    }
}