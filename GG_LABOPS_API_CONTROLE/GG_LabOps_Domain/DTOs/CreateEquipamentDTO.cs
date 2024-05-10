using GG_LabOps_Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace GG_LabOps_Domain.DTOs
{
    public class CreateEquipamentDTO : ICloneable
    {
        [StringLength(120)]
        public string? Nome { get; set; }

        public Situation Situacao { get; private set; }
        public int? SituacaoId { get; set; }

        public TypeEquipament TipoEquipamento { get; private set; }
        public int? TipoEquipamentoId { get; set; }

        public Manufacturer Fabricante { get; private set; }
        public int? FabricanteId { get; set; }

        public Laboratory Laboratorio { get; private set; }
        public int? LaboratorioId { get; set; }

        public object Clone()
        {
            return (CreateEquipamentDTO)MemberwiseClone();
        }

        public CreateEquipamentDTO CloneTyped()
        {
            return (CreateEquipamentDTO)Clone();
        }
    }
}