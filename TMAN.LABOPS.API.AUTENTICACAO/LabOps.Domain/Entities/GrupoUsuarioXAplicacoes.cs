namespace Auth.LabOps.Domain.Entities
{
    public class GrupoUsuarioXAplicacoes
    {
        public int IDAplicacao { get; set; }
        public Aplicacao Aplicacao { get; set; }

        public int IDGrupoUsuario { get; set; }
        public GrupoUsuario GrupoUsuario { get; set; }

        public string Permissao { get; set; }
    }
}
