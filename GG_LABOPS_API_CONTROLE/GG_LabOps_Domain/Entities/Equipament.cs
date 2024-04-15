namespace GG_LabOps_Domain.Entities
{
    public sealed class Equipament : BaseEntity
    {
        public Laboratory Laboratory { get; set; }
        public long LaboratoryId { get; set; }

        public string? Inventory { get; set; }
        public string? Hostname { get; set; }
        public string SerialNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateRegister { get; set; }

        public ICollection<BrandEquipament> BrandEquipament { get; set; }
        public long BrandId { get; set; }

        public ICollection<TypeEquipament> TypeEquipament { get; set; }
        public long TypeId { get; set; }

        public ICollection<ModelEquipament> ModelEquipament { get; set; }
        public long ModelId { get; set; }
    }
}
