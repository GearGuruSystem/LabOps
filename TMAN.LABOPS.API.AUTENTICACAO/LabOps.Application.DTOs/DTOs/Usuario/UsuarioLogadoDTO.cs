namespace Auth.LabOps.Application.DTOs.DTOs.Usuario
{
    public class UsuarioLogadoDTO
    {
        public string Token { get; private set; }

        public UsuarioLogadoDTO()
        {
        }

        public UsuarioLogadoDTO(string token)
        {
            Token = token;
        }
    }
}
