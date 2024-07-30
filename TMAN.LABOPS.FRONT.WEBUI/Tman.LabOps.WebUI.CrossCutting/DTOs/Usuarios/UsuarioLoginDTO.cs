using System.ComponentModel.DataAnnotations;

namespace Tman.LabOps.Infrastructure.CrossCutting.DTOs.Usuarios
{
    public class UsuarioLoginDTO
    {
        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }

        public string? Nome { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}
