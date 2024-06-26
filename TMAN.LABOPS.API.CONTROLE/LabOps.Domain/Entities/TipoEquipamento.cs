using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabOps.Domain.Entities
{
    public class TipoEquipamento
    {
        [Required, Column("Cl_IdTipoEquipamento")]
        public int Id { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, MaxLength(120), Column("Cl_Descricao")]
        public string Descricao { get; private set; }

        [Required, Column("Cl_UsuarioAtualizacao")]
        public string UsuarioAtualizacao { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, Column("Cl_AtualizadoEm")]
        public DateTime? AtualizadoEm { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        public ICollection<Equipamento> Equipamentos { get; set; }
        /*-------------------------------------------------------------------------------------------------*/
        public ICollection<CaracteristicaTipoTipoEquipamento> CaracteristicaTipoTipoEquipamentos { get; set; }
        /*-------------------------------------------------------------------------------------------------*/

        public TipoEquipamento(int idTipoEquipamento, string descricao, string usuarioAtualizacao)
        {
            AddTipoEquipamento(idTipoEquipamento, descricao, usuarioAtualizacao);
        }

        public TipoEquipamento(string descricao, string usuarioAtualizacao)
        {
            AddTipoEquipamento(descricao, usuarioAtualizacao);
        }

        private void AddTipoEquipamento(int idTipoEquipamento, string descricao, string usuarioAtualizacao)
        {
            Id = idTipoEquipamento;
            Descricao = descricao;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }

        private void AddTipoEquipamento(string descricao, string usuarioAtualizacao)
        {
            Descricao = descricao;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }
    }
}