using System.ComponentModel.DataAnnotations;

namespace GG_LabOps_Domain.Entities
{
    public class Laboratory : BaseEntity
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        public User? IdUsuarioResponsavel { get; set; }

        [StringLength(45)]
        public User? ChaveResponsavel { get; set; }
    }
}
