namespace Tman.LabOps.WebUI.Application.Entities
{
    public class TipoEquipamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }
    }
}