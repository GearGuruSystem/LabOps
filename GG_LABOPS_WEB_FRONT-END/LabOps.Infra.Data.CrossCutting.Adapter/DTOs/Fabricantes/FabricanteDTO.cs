using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Usuarios;

namespace LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Fabricantes
{
    public class FabricanteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public UsuarioDTO UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; } = DateTime.Now;
    }
}
