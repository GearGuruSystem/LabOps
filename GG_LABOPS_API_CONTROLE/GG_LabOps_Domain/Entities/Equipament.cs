using System.ComponentModel.DataAnnotations.Schema;

namespace GG_LabOps_Domain.Entities
{
    public class Equipament : BaseEntity
    {
        [Column("id_equip")]
        public long Id { get; set; }
        [Column("inventario")]
        public string? Inventory { get; set; }

        [Column("hostname")]
        public string? Hostname { get; set; }

        [Column("numeroSerie")]
        public string SerialNumber { get; set; }

        [Column("ativo")]
        public bool IsActive { get; set; }

        [Column("dataRegistro")]
        public DateTime DateRegister { get; set; }

        [Column("id_marca")]
        public int BrandId { get; set; }

        [Column("id_tipo")]
        public int TypeId { get; set; }

        [Column("id_modelo")]
        public int ModelId { get; set; }
    }
}
