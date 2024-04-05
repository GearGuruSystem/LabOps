namespace GG_LabOps_Notificacao_Domain.Interface
{
    public interface INotificationService
    {
        Task Send(IEmailTemplate template);
    }
}
