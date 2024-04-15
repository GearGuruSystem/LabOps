namespace GG_LabOps_Domain.Entities
{
    public sealed class Laboratory : BaseEntity
    {
        public string Owner { get; set; }
        public string KeyOwner { get; set; }
        public IEnumerable<Equipament> Equipament { get; set; }
        public long EquipamentId { get; set; }
        public string? Observation { get; set; }
    }
}
