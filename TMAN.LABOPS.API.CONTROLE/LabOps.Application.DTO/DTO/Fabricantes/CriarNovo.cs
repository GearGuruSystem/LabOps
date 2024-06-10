using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LabOps.Application.DTO.DTO.Fabricantes
{
    public class CriarNovo
    {
        [Required]
        public string Nome { get; private set; }

        [JsonIgnore]
        public string UsuarioAtualizacao { get; private set; }

        [JsonIgnore]
        public DateTime? AtualizadoEm { get; private set; }

        public CriarNovo()
        {
        }

        [JsonConstructor]
        public CriarNovo(string nome, string usuarioAtualizacao, DateTime? atualizadoEm)
        {
            Nome = nome;
            UsuarioAtualizacao = "Guian";
            AtualizadoEm = atualizadoEm;
        }

        #region metodos clone

        public object Clone()
        {
            var fabricante = (CriarNovo)MemberwiseClone();
            return fabricante;
        }

        public CriarNovo CloneTipado()
        {
            return (CriarNovo)Clone();
        }

        #endregion metodos clone
    }
}
