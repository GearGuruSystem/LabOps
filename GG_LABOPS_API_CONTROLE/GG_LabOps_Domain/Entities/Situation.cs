using System.ComponentModel.DataAnnotations;

namespace GG_LabOps_Domain.Entities
{
    public class Situation : BaseEntity
    {
        public int Id { get; set; }

        [StringLength(45)]
        public string Descricao { get; set; }
    }
}
