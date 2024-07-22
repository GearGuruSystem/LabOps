using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LabOps.Application.DTO.DTO.Fabricantes
{
    public class CriarNovoFabricanteDTO
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string UsuarioAtualizacao { get; set; }

        [JsonIgnore]
        public DateTime? AtualizadoEm { get; set; } = DateTime.Now;

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
