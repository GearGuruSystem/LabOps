using LabOps.Application.DTO.DTO.Fabricantes;
using LabOps.Application.DTO.DTO.Situacao;
using LabOps.Application.DTO.DTO.TipoEquipamento;

namespace LabOps.Application.DTO.DTO.Equipamentos
{
    public class EquipamentoDTO : ICloneable
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Hostname { get; set; }
        public string? Inventario { get; set; }
        public string SerialNumber { get; set; }
        public SituacaoDTO SituacaoDto { get; set; }
        public TipoEquipamentoDTO TipoEquipamentoDto { get; set; }
        public FabricanteDTO FabricanteDto { get; set; }
        public string UsuarioInsercao { get; set; }
        public DateTime? AtualizadoEm { get; set; }

        #region metodos clone

        public object Clone()
        {
            var equipamento = (EquipamentoDTO)MemberwiseClone();
            return equipamento;
        }

        public EquipamentoDTO CloneTipado()
        {
            return (EquipamentoDTO)Clone();
        }

        #endregion metodos clone
    }
}