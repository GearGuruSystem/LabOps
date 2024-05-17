namespace LabOps.Domain.Entities
{
    public class CaracteristicaTipo
    {
        public int IDCaracteristicaTipo { get; set; }
        public string Descricao { get; set; }
        public string UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }

        // Navigation properties
        public ICollection<CaracteristicaTipoTipoEquipamento> CaracteristicaTipoTipoEquipamentos { get; set; }
        public ICollection<EquipamentoCaracteristica> EquipamentoCaracteristicas { get; set; }
    }
}
