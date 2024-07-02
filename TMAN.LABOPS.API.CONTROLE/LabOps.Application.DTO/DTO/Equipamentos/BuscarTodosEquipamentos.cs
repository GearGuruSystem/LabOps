namespace LabOps.Application.DTO.DTO.Equipamentos
{
    public class BuscarTodosEquipamentos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Hostname { get; set; }
        public string SerialNumber { get; set; }
        public string UsuarioInsercao { get; set; }
        public DateTime AtualizadoEm {  get; set; }
        public string SituacaoDescricao { get; set; }
        public string TipoEquipamentoDescricao { get; set; }
        public string FabricanteNome { get; set; }

        #region Metodos clone

        public object Clone()
        {
            var equipamento = (BuscarTodosEquipamentos)MemberwiseClone();
            return equipamento;
        }

        public BuscarTodosEquipamentos CloneTipado()
        {
            return (BuscarTodosEquipamentos)Clone();
        }

        #endregion
    }
}