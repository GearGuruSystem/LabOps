namespace Auth.LabOps.Domain.Entities
{
    public class UsuarioXGrupoUsuario
    {
        public int IDUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public int IDGrupoUsuario { get; set; }
        public GrupoUsuario GrupoUsuario { get; set; }
    }
}