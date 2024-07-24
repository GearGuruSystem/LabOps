using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LabOps.Application.DTO.DTO.TipoEquipamento
{
    public record RegistroNovoTipoEquipamentoDTO
    {
        [Required(ErrorMessage = "Informe o tipo de equipamento")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe usuario")]
        public string UsuarioAtualizcao { get; set; }

        [JsonIgnore]
        public DateTime? AtualizadoEm { get; set; } = DateTime.Now;
    }
}