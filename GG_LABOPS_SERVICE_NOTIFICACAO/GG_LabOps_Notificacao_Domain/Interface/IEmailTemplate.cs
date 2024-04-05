namespace GG_LabOps_Notificacao_Domain.Interface
{
    public interface IEmailTemplate
    {
        string Subject { get; set; }
        string Content { get; set; }
        string To { get; set; }
    }
}
