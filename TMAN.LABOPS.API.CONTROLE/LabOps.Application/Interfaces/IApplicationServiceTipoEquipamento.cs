using LabOps.Application.DTO.DTO.TipoEquipamento;
using LabOps.Application.DTO.Response;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceTipoEquipamento
    {
        public Task<Response<IEnumerable<TipoEquipamentoDTO>>> BuscarTodosTiposDeEquipamentos();
        public void RegistraNovoTipoEquipamento(RegistroNovoTipoEquipamentoDTO registroNovo);
    }
}