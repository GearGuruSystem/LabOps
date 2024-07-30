using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Usuarios;

namespace Tman.LabOps.Infrastructure.CrossCutting.DTOs.Fabricante
{
    public class NewFabricanteDTO
    {
        public string Nome { get; set; }
        public UsuarioDTO UsuarioAtualizacao { get; set; }
    }
}
