using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabOps.Domain.Entities
{
    public class Fabricante
    {
        [Required, Column("Cl_IdFabricante")]
        public int Id { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, MaxLength(25), Column("Cl_Nome")] 
        public string Nome { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, MaxLength(30), Column("Cl_UsuarioAtualizacao")]
        public string UsuarioAtualizacao { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, MaxLength(10), Column("Cl_AtualizadoEm")]
        public DateTime? AtualizadoEm { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        public ICollection<Equipamento> Equipamentos { get; set; }
        /*-------------------------------------------------------------------------------------------------*/
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
            Id = idFabricante;
            Nome = nome;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }

    }
}