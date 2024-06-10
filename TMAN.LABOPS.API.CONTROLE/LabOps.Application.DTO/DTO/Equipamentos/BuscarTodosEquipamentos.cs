namespace LabOps.Application.DTO.DTO.Equipamentos
{
    public class BuscarTodosEquipamentos
    {
        public int IDEquipamento { get; private set; }
        public string Nome { get; private set; }
        public int IDSituacao { get; private set; }
        public int IDTipoEquipamento { get; private set; }
        public int IDFabricante { get; private set; }
        public int? IDLaboratorio { get; private set; }
        public int UsuarioInsercao { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        #region Construtor Completo

        public BuscarTodosEquipamentos(string nome, int iDSituacao, int iDTipoEquipamento, int iDFabricante, int? iDLaboratorio,
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

        #endregion Construtor Completo

        #region Contrutor vazio

        public BuscarTodosEquipamentos()
        {
        }

        #endregion Contrutor vazio

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