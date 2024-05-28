namespace Auth.LabOps.Domain.Entities
{
    public class GrupoUsuario
    {
        public int IDGrupoUsuario { get; set; }
        public string Descricao { get; set; }
        public int UsuarioInsercao { get; set; }
        public DateTime InseridoEm { get; set; }
        public int UsuarioAtualizacao { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public ICollection<GrupoUsuarioXAplicacoes> GrupoUsuarioXAplicacoes { get; set; }
        public ICollection<UsuarioXGrupoUsuario> UsuarioXGrupoUsuarios { get; set; }
    }
}
