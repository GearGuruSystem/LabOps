using System.ComponentModel.DataAnnotations;

namespace Tman.LabOps.WebUI.Application.DTOs.Fabricante
{
    public class CriarNovoF
    {
        [Required]
        public string Nome { get; set; }

        public string UsuarioAtualizacao { get; set; }
    }
}
