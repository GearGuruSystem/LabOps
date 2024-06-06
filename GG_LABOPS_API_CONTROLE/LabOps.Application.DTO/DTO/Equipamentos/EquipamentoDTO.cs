namespace LabOps.Application.DTO.DTO.Equipamentos
{
    public class EquipamentoDTO : ICloneable
    {
        public int IDEquipamento { get; private set; }
        public string Nome { get; private set; }
        public int IDSituacao { get; private set; }
        public int IDTipoEquipamento { get; private set; }
        public int IDFabricante { get; private set; }
        public int? IDLaboratorio { get; private set; }
        public int UsuarioInsercao { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        #region Contrutor vazio
        public EquipamentoDTO()
        {
        }
        #endregion

        #region Construtor Completo
        public EquipamentoDTO(string nome, int iDSituacao, int iDTipoEquipamento, int iDFabricante, int? iDLaboratorio,
            int usuarioInsercao, DateTime? atualizadoEm)
        {
            Nome = nome;
            IDSituacao = iDSituacao;
            IDTipoEquipamento = iDTipoEquipamento;
            IDFabricante = iDFabricante;
            IDLaboratorio = iDLaboratorio;
            UsuarioInsercao = usuarioInsercao;
            AtualizadoEm = atualizadoEm;
        }
        #endregion

        public object Clone()
        {
            var equipamento = (EquipamentoDTO)MemberwiseClone();
            return equipamento;
        }

        public EquipamentoDTO CloneTipado()
        {
            return (EquipamentoDTO)Clone();
        }
    }
}
