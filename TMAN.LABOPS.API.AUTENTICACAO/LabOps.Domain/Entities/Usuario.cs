using System.ComponentModel.DataAnnotations.Schema;

namespace Auth.LabOps.Domain.Entities
{
    public class Usuario
    {
        public int IDUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime InseridoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        [NotMapped]
        public string Token { get; set; }

        public ICollection<UsuarioXGrupoUsuario> UsuarioXGrupoUsuarios { get; set; }
    }
}
