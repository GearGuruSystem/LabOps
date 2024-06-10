namespace LabOps.Domain.Entities
{
    public class Situacao
    {
        public int IDSituacao { get; set; }
        public string Descricao { get; set; }
        public int UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }

        #region Navegação de Objetos

        public ICollection<Equipamento> Equipamentos { get; set; }

        #endregion Navegação de Objetos

        public Situacao()
        {
        }

        public Situacao(int iDSituacao, string descricao, int usuarioAtualizacao, DateTime? atualizadoEm)
        {
            IDSituacao = iDSituacao;
            Descricao = descricao;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = atualizadoEm;
        }
    }
}