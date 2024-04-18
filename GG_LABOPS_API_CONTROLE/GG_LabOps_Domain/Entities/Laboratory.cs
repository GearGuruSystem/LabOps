using System.ComponentModel.DataAnnotations.Schema;

namespace GG_LabOps_Domain.Entities
{
    public sealed class Laboratory : BaseEntity
    {
        [Column("id_lab")]
        public long Id { get; set; }
        [Column("responsavel")]
        public string Owner { get; set; }
        [Column("chaveResponsavel")]
        public string KeyOwner { get; set; }
        [Column("id_equip")]
        public long EquipamentId { get; set; }
        [Column("observacao")]
        public string? Observation { get; set; }
    }
}
