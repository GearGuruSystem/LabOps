using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Usuarios;
using Tman.LabOps.Infrastructure.CrossCutting.Response;

namespace Tman.LabOps.Infrastructure.CrossCutting.DTOs.Fabricante
{
    public class FabricanteDTO : ApiResponse<FabricanteDTO>
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }
    }
}
