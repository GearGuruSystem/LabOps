using LabOps.Application.DTO.DTO.Fabricantes;
using LabOps.Application.DTO.DTO.Situacao;
using LabOps.Application.DTO.DTO.TipoEquipamento;

namespace LabOps.Application.DTO.DTO.Equipamentos
{
    public class BuscarEquipamentoPorId
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string? Hostname { get; set; }
        public string? Inventario { get; set; }
        public string SerialNumber { get; set; }
        public SituacaoDTO Situacao { get; set; }
        public TipoEquipamentoDTO TipoEquipamento { get; set; }
        public FabricanteDTO Fabricante { get; set; }
        public string UsuarioInsercao { get; set; }
        public DateTime? AtualizadoEm { get; set; }
    }
}