namespace GG_LabOps_Application.DTOs
{
    public class CreateEquipamentDTO
    {
        public long Id { get; set; }
        public long LaboratoryId { get; set; }
        public string? Inventory { get; set; }
        public string? Hostname { get; set; }
        public string SerialNumber { get; set; }
        public bool IsActive { get; set; }
        public long BrandId { get; set; }
        public long TypeId { get; set; }
        public long ModelId { get; set; }
        public DateTime DateRegister { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
