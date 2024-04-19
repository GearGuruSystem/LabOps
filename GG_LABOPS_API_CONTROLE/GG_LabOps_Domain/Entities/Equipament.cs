namespace GG_LabOps_Domain.Entities
{
    public class Equipament : BaseEntity
    {
        public long Id { get; set; }
        public int LaboratoryId { get; set; }
        public string? Inventory { get; set; }
        public string? Hostname { get; set; }
        public string SerialNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateRegister { get; set; }
        public BrandEquipament Brand { get; set; }
        public TypeEquipament TypeEquip { get; set; }
        public ModelEquipament Model { get; set; }
    }
}
