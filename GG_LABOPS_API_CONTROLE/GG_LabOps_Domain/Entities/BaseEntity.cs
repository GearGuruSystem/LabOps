using System.ComponentModel.DataAnnotations.Schema;

namespace GG_LabOps_Domain.Entities
{
    public abstract class BaseEntity
    {
        public DateTime UltimaAtualizacao { get; set; }
    }
}
