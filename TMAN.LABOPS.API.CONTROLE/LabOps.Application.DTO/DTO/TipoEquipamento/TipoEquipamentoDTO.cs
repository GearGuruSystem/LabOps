namespace LabOps.Application.DTO.DTO
{
    public class TipoEquipamentoDTO
    {
        public int IDTipoEquipamento { get; set; }
        public string Descricao { get; set; }
        public int UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }
    }
}