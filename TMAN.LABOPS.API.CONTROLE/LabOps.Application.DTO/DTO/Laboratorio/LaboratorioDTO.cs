namespace LabOps.Application.DTO.DTO.Laboratorio
{
    public class LaboratorioDTO
    {
        public long IDLaboratorio { get; set; }
        public string Nome { get; set; }
        public string? UsuarioResponsavel { get; set; }
        public string ChaveResponsavel { get; set; }
        public string UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }
    }
}