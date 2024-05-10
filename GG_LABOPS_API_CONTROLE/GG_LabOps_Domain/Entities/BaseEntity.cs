namespace GG_LabOps_Domain.Entities
{
    public abstract class BaseEntity
    {
        public User UsuarioInsercao { get; set; }

        public DateTime InseridoEm { get; set; }

        public User UsuarioUltimaAtualizacao { get; set; }

        public DateTime AtualizadoEm { get; set; }
    }
}
