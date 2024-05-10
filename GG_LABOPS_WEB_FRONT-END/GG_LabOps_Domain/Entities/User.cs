namespace GG_LabOps_Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ChaveUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }
        public int Permissao { get; set; }
        public string Token {  get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
