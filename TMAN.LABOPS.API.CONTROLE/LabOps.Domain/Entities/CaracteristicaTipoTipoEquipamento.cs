using System.ComponentModel.DataAnnotations.Schema;

namespace LabOps.Domain.Entities
{
    public class CaracteristicaTipoTipoEquipamento
    {
        [Column("Cl_IdCaracteristicaTipo")]
        public int IdCaracteristicaTipo { get; set; }
        public CaracteristicaTipo CaracteristicaTipo { get; set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Column("Cl_IdTipoEquipamento")]
        public int IdTipoEquipamento { get; set; }
        public TipoEquipamento TipoEquipamento { get; set; }
        /*-------------------------------------------------------------------------------------------------*/
    }
}