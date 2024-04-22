namespace GG_LabOps_Domain.DTOs
{
    public class ViewEquipamentDTO
    {
        public long Id { get; set; }
        public string? Inventory { get; set; }
        public string? Hostname { get; set; }
        public string SerialNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateRegister { get; set; }
        public string BrandName { get; set; }
        public string TypeName { get; set; }
        public string ModelName { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
