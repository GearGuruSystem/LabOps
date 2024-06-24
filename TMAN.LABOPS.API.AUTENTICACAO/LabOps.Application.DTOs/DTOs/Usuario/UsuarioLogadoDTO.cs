namespace Auth.LabOps.Application.DTOs.DTOs.Usuario
{
    public class UsuarioLogadoDTO
    {
        public string Token { get; private set; }

        public UsuarioLogadoDTO(string token)
        {
            AdicionaToken(token);
        }

        private void AdicionaToken(string token)
        {
            Token = token.Trim();
        }
    }
}
