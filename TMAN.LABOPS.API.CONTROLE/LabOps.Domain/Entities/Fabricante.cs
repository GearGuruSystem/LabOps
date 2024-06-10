using System.ComponentModel.DataAnnotations;

namespace LabOps.Domain.Entities
{
    public class Fabricante
    {
        [Key]
        [Required]
        public int IDFabricante { get; private set; }

        [Required]
        [MaxLength(25)]
        public string Nome { get; private set; }

        [Required]
        [MaxLength(40)]
        public string UsuarioAtualizacao { get; private set; }

        [MaxLength(10)]
        public DateTime? AtualizadoEm { get; private set; }

        #region Navegação de Objetos

        public ICollection<Equipamento> Equipamentos { get; set; }

        #endregion Navegação de Objetos

        public Fabricante()
        {
        }

        public Fabricante(string nome, string usuarioAtualizacao,
            DateTime? atualizadoEm)
        {
            Nome = nome;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = atualizadoEm;
        }

        public Fabricante(int iDFabricante, string nome, string usuarioAtualizacao,
            DateTime? atualizadoEm)
        {
            IDFabricante = iDFabricante;
            Nome = nome;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = atualizadoEm;
        }
    }
}