using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LabOps.Application.DTO.DTO.Fabricantes
{
    public class Atualizar
    {
        public int IDFabricante { get; set; }

        [MaxLength(25)]
        public string Nome { get; set; }

        [MaxLength(40)]
        public string UsuarioAtualizacao { get; set; }

        [JsonIgnore]
        [MaxLength(10)]
        public DateTime? AtualizadoEm { get; set; }

        [JsonConstructor]
        public Atualizar(int IDFabricante, string Nome, string UsuarioAtualizacao)
        {
            this.IDFabricante = IDFabricante;
            this.Nome = Nome;
            this.UsuarioAtualizacao = UsuarioAtualizacao;
        }
    }
}
