namespace LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Equipamentos
{
    public class EquipamentoSimplesDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Hostname { get; set; }
        public string SerialNumber { get; set; }
        public string UsuarioInsercao { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public string SituacaoDescricao { get; set; }
        public string TipoEquipamentoDescricao { get; set; }
        public string FabricanteNome { get; set; }
    }
}
