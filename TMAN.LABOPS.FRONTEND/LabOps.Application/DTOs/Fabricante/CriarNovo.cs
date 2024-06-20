using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LabOps.Application.DTOs.Fabricante
{
    public class CriarNovo
    {
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; } = string.Empty;

        [JsonIgnore]
        public string UsuarioAtualizacao { get; set; } = "Usuario Generico";

        [JsonIgnore]
        public DateTime? AtualizadoEm { get; set; } = DateTime.Now;
    }
}
