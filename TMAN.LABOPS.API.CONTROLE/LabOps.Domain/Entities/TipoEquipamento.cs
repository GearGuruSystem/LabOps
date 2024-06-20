namespace LabOps.Domain.Entities
{
    public class TipoEquipamento
    {
        public int IDTipoEquipamento { get; private set; }
        public string Descricao { get; private set; }
        public string UsuarioAtualizacao { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        #region Navegação de Objetos

        public ICollection<Equipamento> Equipamentos { get; set; }
        public ICollection<CaracteristicaTipoTipoEquipamento> CaracteristicaTipoTipoEquipamentos { get; set; }

        #endregion Navegação de Objetos

        public TipoEquipamento()
        {
        }

        public TipoEquipamento(int iDTipoEquipamento, string descricao, string usuarioAtualizacao, DateTime? atualizadoEm)
        {
            IDTipoEquipamento = iDTipoEquipamento;
            Descricao = descricao;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = atualizadoEm;
        }

        public TipoEquipamento(string descricao, string usuarioAtualizacao, DateTime? atualizadoEm)
        {
            Descricao = descricao;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = atualizadoEm;
        }
    }
}