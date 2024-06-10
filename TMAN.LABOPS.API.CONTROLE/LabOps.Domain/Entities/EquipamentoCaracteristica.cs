namespace LabOps.Domain.Entities
{
    public class EquipamentoCaracteristica
    {
        public int IDEquipamentoCaracteristica { get; set; }
        public int IDEquipamento { get; set; }
        public int IDCaracteristicaTipo { get; set; }
        public int? IDCaracteristicaValor { get; set; }
        public string ValorIndividual { get; set; }
        public int UsuarioAtualizacao { get; set; }
        public DateTime AtualizadoEm { get; set; }

        // Navigation properties
        public Equipamento Equipamento { get; set; }

        public CaracteristicaTipo CaracteristicaTipo { get; set; }
        public CaracteristicaValor CaracteristicaValor { get; set; }
    }
}