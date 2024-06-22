using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LabOps.Application.DTO.DTO.Fabricantes
{
    public class CriarNovoFabricanteDTO
    {
        [Required]
        public string Nome { get; private set; }

        [JsonIgnore]
        public string UsuarioAtualizacao { get; private set; }

        [JsonIgnore]
        public DateTime? AtualizadoEm { get; private set; }

        public CriarNovoFabricanteDTO()
        {
        }

        [JsonConstructor]
        public CriarNovoFabricanteDTO(string nome, string usuarioAtualizacao, DateTime? atualizadoEm)
        {
            Nome = nome;
            UsuarioAtualizacao = "Guian";
            AtualizadoEm = atualizadoEm;
        }

        #region metodos clone

        public object Clone()
        {
            var fabricante = (CriarNovoFabricanteDTO)MemberwiseClone();
            return fabricante;
        }

        public CriarNovoFabricanteDTO CloneTipado()
        {
            return (CriarNovoFabricanteDTO)Clone();
        }

        #endregion metodos clone
    }
}
