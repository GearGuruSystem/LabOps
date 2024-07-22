using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LabOps.WebUI.Models.Fabricantes
{
    public class CadastroFabricanteModel
    {
        [Required(ErrorMessage = "Informe o nome do fabricante")]
        [DisplayName("Nome do fabricante")]
        public string Nome { get; set; }

        public string? UsuarioAtualizacao { get; set; }
    }
}
