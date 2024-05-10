using GG_labOps_Domain.Validations;

namespace GG_labOps_Domain.DTOs
{
    public class RegisterUserDTO
    {
        public string Nome { get; set; }

        [KeyUserValidations]
        public string ChaveUsuario { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }
        public int Permissao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}