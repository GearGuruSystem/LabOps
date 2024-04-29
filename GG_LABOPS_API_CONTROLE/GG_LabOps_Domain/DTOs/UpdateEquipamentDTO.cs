using System.ComponentModel.DataAnnotations;

namespace GG_LabOps_Domain.DTOs
{
    public class UpdateEquipamentDTO : ICloneable
    {
        [StringLength(15)]
        public string? Inventario { get; set; }

        [StringLength(15)]
        public string? Hostname { get; set; }

        [StringLength(15)]
        public string NumeroSerie { get; set; }

        [Required(ErrorMessage = "Informe uma marca para o equipamento.")]
        public int MarcaId { get; set; }

        [Required(ErrorMessage = "Informe qual tipo é o equipamento.")]
        public int TipoId { get; set; }

        [Required(ErrorMessage = "Informe qual modelo é o equipamento.")]
        public int ModeloId { get; set; }

        [Required(ErrorMessage = "Informe se o equipamento está ativo.")]
        public bool Ativa { get; set; }

        public object Clone()
        {
            return (UpdateEquipamentDTO)MemberwiseClone();
        }

        public UpdateEquipamentDTO CloneTyped()
        {
            return (UpdateEquipamentDTO)Clone();
        }
    }
}
