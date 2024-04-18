using System.ComponentModel.DataAnnotations.Schema;

namespace GG_LabOps_Domain.Entities
{
    public abstract class BaseEntity
    {
        [Column("ultimaAtualizacao")]
        public DateTime LastUpdate { get; set; }
    }
}
