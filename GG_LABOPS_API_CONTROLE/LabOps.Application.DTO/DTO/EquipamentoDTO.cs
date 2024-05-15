namespace LabOps.Application.DTO.DTO
{
    public class EquipamentoDTO : ICloneable
    {
        public long Id { get; set; }
        public string? Inventario { get; set; }
        public string? Hostname { get; set; }
        public string NumeroSerie { get; set; }
        public bool Ativa { get; set; }
        public string MarcaNome { get; set; }
        public string ModeloNome { get; set; }
        public string TipoNome { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime UltimaAtualizacao { get; set; }

        public object Clone()
        {
            var equipamento = (EquipamentoDTO)MemberwiseClone();
            return equipamento;
        }

        public EquipamentoDTO CloneTipado()
        {
            return (EquipamentoDTO)Clone();
        }
    }
}
