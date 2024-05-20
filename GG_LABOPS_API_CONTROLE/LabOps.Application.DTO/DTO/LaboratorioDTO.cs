namespace LabOps.Application.DTO.DTO
{
    public class LaboratorioDTO
    {
        public int IDLaboratorio { get; set; }
        public string Nome { get; set; }
        public int? IDUsuarioResponsavel { get; set; }
        public string ChaveResponsavel { get; set; }
        public int UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }
    }
}
