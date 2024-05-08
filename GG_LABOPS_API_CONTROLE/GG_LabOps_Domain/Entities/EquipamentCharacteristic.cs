namespace GG_LabOps_Domain.Entities
{
    public class EquipamentCharacteristic : BaseEntity
    {
        public int Id { get; set; }

        public Equipament Equipament { get; set; }

        public CharacteristicType CaracteristicaTipo { get; set; }
        public int CaracteristicaTipoId { get; set; }

        public CharacteristicValue CaracteristicaValor { get; set; }
        public int CaracteristicaValorId { get; set; }

        public int ValorIndividual { get; set; }
    }
}
