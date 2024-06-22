using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LabOps.Application.DTO.DTO.Fabricantes
{
    public record AtualizarFabricanteDTO
    {
        public int IDFabricante { get; init; }

        [MaxLength(25)]
        public string Nome { get; init; }

        [MaxLength(40)]
        public string UsuarioAtualizacao { get; init; }

        [JsonIgnore]
        [MaxLength(10)]
        public DateTime? AtualizadoEm { get; init; }

        [JsonConstructor]
        public AtualizarFabricanteDTO(int IDFabricante, string Nome, string UsuarioAtualizacao)
        {
            this.IDFabricante = IDFabricante;
            this.Nome = Nome;
            this.UsuarioAtualizacao = UsuarioAtualizacao;
        }
    }
}
