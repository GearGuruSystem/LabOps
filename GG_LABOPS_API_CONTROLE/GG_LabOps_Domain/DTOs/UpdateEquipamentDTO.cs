using System.ComponentModel.DataAnnotations;

namespace GG_LabOps_Domain.DTOs
{
    public class UpdateEquipamentDTO
    {
        [StringLength(15)]
        public string? Inventory { get; set; }

        [StringLength(15)]
        public string? Hostname { get; set; }

        [StringLength(15)]
        public string SerialNumber { get; set; }

        [Required(ErrorMessage = "Informe uma marca para o equipamento.")]
        public int BrandId { get; set; }

        [Required(ErrorMessage = "Informe qual tipo é o equipamento.")]
        public int TypeId { get; set; }

        [Required(ErrorMessage = "Informe qual modelo é o equipamento.")]
        public int ModelId { get; set; }

        [Required(ErrorMessage = "Informe se o equipamento está ativo.")]
        public bool IsActive { get; set; }
    }
}
