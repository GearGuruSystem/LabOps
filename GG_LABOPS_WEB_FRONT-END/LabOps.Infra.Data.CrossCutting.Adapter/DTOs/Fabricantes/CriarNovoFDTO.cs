using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Usuarios;

namespace LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Fabricantes
{
    public class CriarNovoFDTO
    {
        public string Nome { get; set; }
        public UsuarioDTO UsuarioAtualizacao { get; set; }
    }
}
