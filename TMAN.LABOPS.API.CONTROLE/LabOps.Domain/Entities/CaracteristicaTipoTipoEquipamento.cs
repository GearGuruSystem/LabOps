namespace LabOps.Domain.Entities
{
    public class CaracteristicaTipoTipoEquipamento
    {
        public int CaracteristicaTipo_ID { get; set; }
        public int TipoEquipamento_ID { get; set; }

        // Navigation properties
        public CaracteristicaTipo CaracteristicaTipo { get; set; }

        public TipoEquipamento TipoEquipamento { get; set; }
    }
}