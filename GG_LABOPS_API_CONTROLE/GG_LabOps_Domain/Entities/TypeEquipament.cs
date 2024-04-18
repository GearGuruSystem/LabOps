using System.ComponentModel.DataAnnotations.Schema;

namespace GG_LabOps_Domain.Entities
{
    public sealed class TypeEquipament : BaseEntity
    {
        [Column("id_tipo")]
        public long Id { get; set; }
        [Column("nomeTipo")]
        public string TypeName { get; set; }
    }
}
