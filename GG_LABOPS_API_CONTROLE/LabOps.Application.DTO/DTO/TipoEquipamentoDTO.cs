namespace LabOps.Application.DTO.DTO
{
    public class TipoEquipamentoDTO
    {
        public int IDTipoEquipamento { get; private set; }
        public string Descricao { get; private set; }
        public int UsuarioAtualizacao { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }
    }
}
