using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Fabricantes;
using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Situacao;
using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.TiposEquipamentos;

namespace LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Equipamentos
{
    public class EquipamentoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Hostname { get; set; }
        public string Inventario { get; set; }
        public string SerialNumber { get; set; }
        public SituacaoDTO SituacaoDto { get; set; }
        public TipoEquipamentoDTO TipoEquipamentoDto { get; set; }
        public FabricanteDTO FabricanteDto { get; set; }
        public string UsuarioInsercao { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}
