namespace GG_LabOps_Domain.Entities
{
    public sealed class Laboratory : BaseEntity
    {
        public string? Inventory { get; set; }
        public string? Hostname { get; set; }
        public BrandEquipament BrandEquipament { get; set; }
        public int BrandEquipamentId { get; set; }
        public string SerieNumber { get; set; }
        public string EquipamentType { get; set; }
        public string EquipamentModel { get; set; }
        public string Owner {  get; set; }
        public string IdOwner { get; set; }
        public string? Observation { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateRegister { get; set; }
    }
}
