using LabOps.Application.DTO.DTO.TipoEquipamento;

namespace LabOps.Application.Interfaces
{
    public interface IApplicationServiceTipoEquipamento
    {
        public Task<IEnumerable<TipoEquipamentoDTO>> BuscarTodosTiposDeEquipamentos();
        public void RegistraNovoTipoEquipamento(RegistroNovoTipoEquipamentoDTO registroNovo);
    }
}