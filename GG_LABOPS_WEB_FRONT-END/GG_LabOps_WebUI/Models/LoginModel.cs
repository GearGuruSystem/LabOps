using System.ComponentModel.DataAnnotations;

namespace GG_LabOps_WebUI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }

        public string? Nome {  get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}
