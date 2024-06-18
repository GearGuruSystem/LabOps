using LabOps.Application.Requests;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LabOps.Application.DTOs.Fabricante
{
    public class CriarNovo : Request<CriarNovo>
    {
        [Required]
        public string Nome { get; set; } = string.Empty;

        [JsonIgnore]
        public string UsuarioAtualizacao { get; set; } = string.Empty;

        [JsonIgnore]
        public DateTime? AtualizadoEm { get; private set; }
    }
}
