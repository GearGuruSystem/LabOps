namespace LabOps.Domain.Entities
{
    public class CaracteristicaValor
    {
        public int IDCaracteristicaValor { get; set; }
        public string Valor { get; set; }
        public int UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }

        public ICollection<EquipamentoCaracteristica> EquipamentoCaracteristicas { get; set; }
    }
}
