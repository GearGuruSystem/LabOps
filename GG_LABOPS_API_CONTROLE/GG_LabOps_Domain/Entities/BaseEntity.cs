using System.ComponentModel.DataAnnotations;

namespace GG_LabOps_Domain.Entities
{
    public abstract class BaseEntity
    {
        public Technical UsuarioInsercao { get; set; }

        public DateTime InseridoEm { get; set; }

        public Technical UsuarioUltimaAtualizacao { get; set; }
        public int UsuarioUltimaAtualizacaoId { get; set; }

        public DateTime AtualizadoEm { get; set; }
    }
}
