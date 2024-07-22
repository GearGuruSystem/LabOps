using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.TiposEquipamentos;

namespace LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiControle
{
    public interface IServicesTipoEquipamento
    {
        Task<IEnumerable<TipoEquipamentoDTO>> BuscaTodosTiposDeEquipamentos();
        Task<TipoEquipamentoDTO> BuscaTipoEquipamentoPeloId(int id);
        Task<TipoEquipamentoDTO> CadastrarTipoEquipamento(CriarNovoTEDTO nTipoEquipamento);
        void AtualizarTipoEquipamento(TipoEquipamentoDTO tipoEquipamento);
        void RemoverTipoEquipamento(TipoEquipamentoDTO tipoEquipamento);
    }
}
