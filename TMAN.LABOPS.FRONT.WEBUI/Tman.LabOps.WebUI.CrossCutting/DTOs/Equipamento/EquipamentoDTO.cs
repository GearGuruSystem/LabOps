using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Fabricante;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Situacao;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.TiposEquipamentos;
using Tman.LabOps.Infrastructure.CrossCutting.Response;

namespace Tman.LabOps.Infrastructure.CrossCutting.DTOs.Equipamento
{
    public class EquipamentoDTO : ApiResponse<EquipamentoDTO>
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Hostname { get; set; } = string.Empty;
        public string Inventario { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public SituacaoDTO SituacaoDto { get; set; } = new SituacaoDTO();
        public TipoEquipamentoDTO TipoEquipamentoDto { get; set; } = new TipoEquipamentoDTO();
        public FabricanteDTO FabricanteDto { get; set; } = new FabricanteDTO();
        public string UsuarioInsercao { get; set; } = string.Empty;
        public DateTime AtualizadoEm { get; set; }
    }
}
