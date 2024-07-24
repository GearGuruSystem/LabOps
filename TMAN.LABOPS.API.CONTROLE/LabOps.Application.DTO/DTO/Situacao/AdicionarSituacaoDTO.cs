using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LabOps.Application.DTO.DTO.Situacao
{
    public class AdicionarSituacaoDTO
    {
        [Required]
        public string Descricao { get; set; }

        [Required]
        public string UsuarioAtualizacao { get; set; }

        [JsonIgnore]
        public DateTime? AtualizadoEm { get; set; } = DateTime.Now.Date;
    }
}