using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Tman.LabOps.Infrastructure.CrossCutting.DTOs.Equipamento
{
    public class NewEquipamentoDTO
    {
        [Required(ErrorMessage = "Informe um nome")]
        [MaxLength(120, ErrorMessage = "Nome maximo de até 120 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a Situação.")]
        public int IdSituacao { get; set; }

        [Required(ErrorMessage = "Informe o Tipo de Equipamento.")]
        public int IdTipoEquipamento { get; set; }

        [Required(ErrorMessage = "Informe o Fabricante.")]
        public int IdFabricante { get; set; }

        [Required(ErrorMessage = "Informe as informações de cadastro no Laboratorio")]
        public int? IdLaboratorio { get; set; }

        [Required]
        public string UsuarioInsercao { get; set; }

        [DisplayName("Hostname")]
        public string? Hostname { get; set; }

        [DisplayName("Inventario")]
        public string? Inventario { get; set; }

        [DisplayName("Numero de serie")]
        public string SerialNumber { get; set; }
        public DateTime? AtualizadoEm { get; set; } = DateTime.Now;
    }
}
