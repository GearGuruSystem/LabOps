namespace Tman.LabOps.Infrastructure.CrossCutting.DTOs.Situacao
{
    public class SituacaoDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }
    }
}
