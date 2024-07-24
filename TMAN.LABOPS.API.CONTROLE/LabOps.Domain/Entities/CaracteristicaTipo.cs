using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabOps.Domain.Entities
{
    public class CaracteristicaTipo
    {
        [Key, Required, Column("Cl_IdCaracteristicaTipo")]
        public int Id { get; set; }

        [Required, Column("Cl_Descricao")]
        public string Descricao { get; set; }

        [Required, Column("Cl_UsuarioAtualizacao")]
        public string UsuarioAtualizacao { get; set; }

        [Column("Cl_AtualizadoEm")]
        public DateTime? AtualizadoEm { get; set; }

        public ICollection<EquipamentoCaracteristica> EquipamentoCaracteristicas { get; set; }

        public ICollection<CaracteristicaTipoTipoEquipamento> CaracteristicaTipoTipoEquipamentos { get; set; }
    }
}