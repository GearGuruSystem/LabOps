using System.ComponentModel.DataAnnotations;

namespace GG_LabOps_Domain.Entities
{
    public class CharacteristicType_TypeEquipament
    {
        public CharacteristicType CaracteristicaTipo { get; set; }

        public TypeEquipament TipoEquipamento { get; set; }

        public DateTime InseridoEm { get; set; }

        public DateTime AtualizadoEm { get; set; }
    }
}
