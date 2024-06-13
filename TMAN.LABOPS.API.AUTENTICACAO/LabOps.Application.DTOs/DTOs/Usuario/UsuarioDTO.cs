namespace Auth.LabOps.Application.DTOs.DTOs.Usuario
{
    public class UsuarioDTO : ICloneable
    {
        public int IDUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime InseridoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public string Token { get; set; }

        public object Clone()
        {
            return (UsuarioDTO)MemberwiseClone();
        }

        public UsuarioDTO CloneTipado()
        {
            return (UsuarioDTO)Clone();
        }
    }
}
