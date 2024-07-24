using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabOps.Domain.Entities
{
    public class EquipamentoCaracteristica
    {
        [Key, Required, Column("Cl_IdEquipmanetoCaracteristicas")]
        public int Id { get; set; }

        [Required, Column("Cl_Equipamento")]
        public long IdEquipamento { get; set; }
        public Equipamento Equipamento { get; set; }

        [Required, Column("Cl_CaracteristicaTipo")]
        public int IdCaracteristicaTipo { get; set; }
        public CaracteristicaTipo CaracteristicaTipo { get; set; }

        [Column("Cl_CaracteristicaValor")]
        public int? IdCaracteristicaValor { get; set; }
        public CaracteristicaValor CaracteristicaValor { get; set; }

        [Column("Cl_ValorIndividual")]
        public string? ValorIndividual { get; set; }

        [Required, Column("Cl_UsuarioAtualizacao")]
        public string UsuarioAtualizacao { get; set; }

        [Required, Column("Cl_AtualizadoEm")]
        public DateTime AtualizadoEm { get; set; }
    }
}