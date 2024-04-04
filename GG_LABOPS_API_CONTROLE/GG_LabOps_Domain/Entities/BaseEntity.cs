namespace GG_LabOps_Domain.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
