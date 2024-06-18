using LabOps.Application.Requests;

namespace LabOps.Application.DTOs.Fabricante
{
    public class Fabricante : Request<Fabricante>
    {
        public int IDFabricante { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string UsuarioAtualizacao { get; private set; } = string.Empty;
        public DateTime? AtualizadoEm { get; private set; }
    }
}
