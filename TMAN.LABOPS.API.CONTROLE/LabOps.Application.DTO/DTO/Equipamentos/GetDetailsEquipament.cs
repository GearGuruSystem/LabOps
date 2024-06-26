namespace LabOps.Application.DTO.DTO.Equipamentos
{
    public class GetDetailsEquipament
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public int IdSituacao { get; set; }
        public string Situacao { get; set; }
        public int IdTipoEquipamento { get; set; }
        public string TipoEquipamentoDescricao { get; set; }
        public int IdFabricante { get; set; }
        public string FabricanteNome { get; set; }
        public string UsuarioInsercao { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        //public List<EquipamentoCaracteristicaDTO> Caracteristicas { get; set; }
    }
}
