using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabOps.Domain.Entities
{
    public class TipoEquipamento
    {
        [Required, Column("Cl_IdTipoEquipamento")]
        public int Id { get; private set; }

        [Required, MaxLength(120), Column("Cl_Descricao")]
        public string Descricao { get; private set; }

        [Required, Column("Cl_UsuarioAtualizacao")]
        public string UsuarioAtualizacao { get; private set; }

        [Required, Column("Cl_AtualizadoEm")]
        public DateTime? AtualizadoEm { get; private set; }

        public ICollection<Equipamento>? Equipamentos { get; set; }

        public ICollection<CaracteristicaTipoTipoEquipamento>? CaracteristicaTipoTipoEquipamentos { get; set; }

        public TipoEquipamento()
        {
        }

        public TipoEquipamento(int idTipoEquipamento, string descricao, string usuarioAtualizacao)
        {
            AdicionaTipoEquipamento(idTipoEquipamento, descricao, usuarioAtualizacao);
        }

        public TipoEquipamento(string descricao, string usuarioAtualizacao)
        {
            AdicionaTipoEquipamento(descricao, usuarioAtualizacao);
        }

        private void AdicionaTipoEquipamento(int idTipoEquipamento, string descricao, string usuarioAtualizacao)
        {
            Id = idTipoEquipamento;
            Descricao = descricao;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }

        private void AdicionaTipoEquipamento(string descricao, string usuarioAtualizacao)
        {
            Descricao = descricao;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }
    }
}