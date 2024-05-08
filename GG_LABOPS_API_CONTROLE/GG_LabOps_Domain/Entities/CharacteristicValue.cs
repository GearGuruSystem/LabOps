using System.ComponentModel.DataAnnotations;

namespace GG_LabOps_Domain.Entities
{
    public class CharacteristicValue
    {
        public int Id { get; set; }

        [StringLength(120)]
        public string Descricao { get; set; }
    }
}
