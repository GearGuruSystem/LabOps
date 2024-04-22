namespace GG_LabOps_Domain.DTOs
{
    public class UpdateEquipamentDTO
    {
        public string? Inventory { get; set; }
        public string? Hostname { get; set; }
        public string SerialNumber { get; set; }
        public int BrandId { get; set; }
        public int TypeId { get; set; }
        public int ModelId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; } = DateTime.Now;
    }
}
