namespace LabOps.Domain.Entities
{
    public class Situacao
    {
        public int IDSituacao { get; private set; }
        public string Descricao { get; private set; }
        public string UsuarioAtualizacao { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        #region Navegação de Objetos
        public ICollection<Equipamento> Equipamentos { get; set; }
        #endregion Navegação de Objetos

        public Situacao(string descricao, string usuarioAtualizacao, DateTime? atualizadoEm = null)
        {
            AdicionaSituacao(descricao, usuarioAtualizacao, atualizadoEm);
        }

        public Situacao(int iDSituacao, string descricao, string usuarioAtualizacao, DateTime? atualizadoEm = null)
        {
            AdicionaSituacao(iDSituacao, descricao, usuarioAtualizacao, atualizadoEm);
        }

        private void AdicionaSituacao(int iDSituacao, string descricao, string usuarioAtualizacao, DateTime? atualizadoEm = null)
        {
            IDSituacao = iDSituacao;
            Descricao = descricao;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }

        private void AdicionaSituacao(string descricao, string usuarioAtualizacao, DateTime? atualizadoEm = null)
        {
            Descricao = descricao;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }
    }
}