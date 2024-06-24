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

        public Fabricante(string nome, string usuarioAtualizacao)
        {
            AdicionaFabricante(nome, usuarioAtualizacao);
        }

        public Fabricante(int idFabricante, string nome, string usuarioAtualizacao)
        {
            AdicionaFabricante(idFabricante, nome, usuarioAtualizacao);
        }

        private void AdicionaFabricante(string nome, string usuarioAtualizacao)
        {
            Nome = nome;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }

        private void AdicionaFabricante(int idFabricante, string nome, string usuarioAtualizacao)
        {
            IDFabricante = idFabricante;
            Nome = nome;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }

    }
}