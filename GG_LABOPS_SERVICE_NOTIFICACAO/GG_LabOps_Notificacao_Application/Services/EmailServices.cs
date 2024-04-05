using GG_LabOps_Notificacao_Domain.Interface;

namespace GG_LabOps_Notificacao_Application.Services
{
    public class EmailServices : INotificationService
    {
        public Task Send(IEmailTemplate template)
        {
            throw new NotImplementedException();
        }
    }
}
