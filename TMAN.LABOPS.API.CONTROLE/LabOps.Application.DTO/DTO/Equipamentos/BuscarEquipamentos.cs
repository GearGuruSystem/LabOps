namespace LabOps.Application.DTO.DTO.Equipamentos
{
    public class BuscarEquipamentos
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
            var equipamento = (BuscarEquipamentos)MemberwiseClone();
            return equipamento;
        }

        public BuscarEquipamentos CloneTipado()
        {
            return (BuscarEquipamentos)Clone();
        }

        #endregion
    }
}