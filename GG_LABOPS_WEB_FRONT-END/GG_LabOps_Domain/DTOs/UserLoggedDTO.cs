namespace GG_LabOps_Domain.DTOs
{
    public class UserLoggedDTO
    {
        public string Nome { get; set; }
        public string ChaveUsuario { get; set; }
        public int Permissao { get; set; }
        public string Token { get; set; }
    }
}
