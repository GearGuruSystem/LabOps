using System.ComponentModel.DataAnnotations.Schema;

namespace GG_LabOps_Domain.Entities
{
    public class ModelEquipament : BaseEntity
    {
        [Column("id_modelo")]
        public long Id { get; set; }
        [Column("nomeModelo")]
        public string ModelName { get; set; }
    }
}
