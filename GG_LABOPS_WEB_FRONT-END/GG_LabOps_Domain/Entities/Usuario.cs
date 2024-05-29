namespace GG_LabOps_Domain.Entities
{
    public class Usuario : Notificacao
    {
        public Usuario(Notificacao notificacao)
        {
            Mensagem = notificacao.Mensagem;
        }

        public string MensagemErro()
        {
            return Mensagem.ToString();
        }
    }
}
