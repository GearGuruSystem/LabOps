namespace LabOps.Application.DTO.DTO.Equipamentos
{
    public class EquipamentoDTO : ICloneable
    {
        public int IDEquipamento { get; set; }
        public string Nome { get; set; }
        public string? Hostname { get; set; }
        public string? Inventario { get; set; }
        public string SerialNumber { get; set; }
        public int IDSituacao { get; set; }
        public int IDTipoEquipamento { get; set; }
        public int IDFabricante { get; set; }
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
        #endregion
    }
}