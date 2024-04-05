namespace GG_LabOps_Domain.Entities
{
    public sealed class BrandEquipament : BaseEntity
    {
        public IEnumerable<Laboratory> Laboratory { get; set; }
        public string Name { get; set; }
    }
}
