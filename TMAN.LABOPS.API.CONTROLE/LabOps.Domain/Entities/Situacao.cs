using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabOps.Domain.Entities
{
    public class Situacao
    {
        [Key, Required, Column("Cl_IdSituacao")]
        public int Id { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, Column("Cl_Situacao")]
        public string Descricao { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, Column("Cl_UsuarioAtualizacao")]
        public string UsuarioAtualizacao { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, Column("Cl_AtualizadoEm")]
        public DateTime? AtualizadoEm { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        public ICollection<Equipamento> Equipamentos { get; set; }
        /*-------------------------------------------------------------------------------------------------*/

        public Situacao(string descricao, string usuarioAtualizacao)
        {
            AdicionaSituacao(descricao, usuarioAtualizacao);
        }

        public Situacao(int idSituacao, string descricao, string usuarioAtualizacao)
        {
            AdicionaSituacao(idSituacao, descricao, usuarioAtualizacao);
        }

        private void AdicionaSituacao(int idSituacao, string descricao, string usuarioAtualizacao)
        {
            Id = idSituacao;
            Descricao = descricao;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }

        private void AdicionaSituacao(string descricao, string usuarioAtualizacao)
        {
            Descricao = descricao;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now.Date;
        }
    }
}