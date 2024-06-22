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

        public TipoEquipamento(int idTipoEquipamento, string descricao, string usuarioAtualizacao)
        {
            AdicionaTipoEquipamento(idTipoEquipamento, descricao, usuarioAtualizacao);
        }

        public TipoEquipamento(string descricao, string usuarioAtualizacao)
        {
            AdicionaTipoEquipamento(descricao, usuarioAtualizacao);
        }

        private void AdicionaTipoEquipamento(int idTipoEquipamento, string descricao, string usuarioAtualizacao)
        {
            IDTipoEquipamento = idTipoEquipamento;
            Descricao = descricao;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }

        private void AdicionaTipoEquipamento(string descricao, string usuarioAtualizacao)
        {
            Descricao = descricao;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }
    }
}