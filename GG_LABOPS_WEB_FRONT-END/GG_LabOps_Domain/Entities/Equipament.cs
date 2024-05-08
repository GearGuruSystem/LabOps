using System.ComponentModel.DataAnnotations;

namespace GG_LabOps_Domain.Entities
{
    public class Equipament
    {
        [Required(ErrorMessage = "Informe um ID")]
        public long Id { get; set; }
        public string? Inventario { get; set; }
        public string? Hostname { get; set; }

        [Required(ErrorMessage = "Informe um Numero de Serie valido")]
        public string NumeroSerie { get; set; }

        public bool Ativa { get; set; }

        [Required(ErrorMessage = "Informe uma marca para o equipamento.")]
        public int MarcaId { get; set; }

        [Required(ErrorMessage = "Informe qual tipo é o equipamento.")]
        public int TipoId { get; set; }

        [Required(ErrorMessage = "Informe qual modelo é o equipamento.")]
        public int ModeloId { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
