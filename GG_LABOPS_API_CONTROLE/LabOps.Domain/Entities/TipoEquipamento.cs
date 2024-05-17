namespace LabOps.Domain.Entities
{
    public class TipoEquipamento
    {
        public int IDTipoEquipamento { get; set; }
        public string Descricao { get; set; }
        public int UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }

        // Navigation properties
        public ICollection<Equipamento> Equipamentos { get; set; }
        public ICollection<CaracteristicaTipoTipoEquipamento> CaracteristicaTipoTipoEquipamentos { get; set; }
    }
}
