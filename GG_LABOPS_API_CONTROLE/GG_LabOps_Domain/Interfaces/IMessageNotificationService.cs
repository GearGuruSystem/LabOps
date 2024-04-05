namespace GG_LabOps_Domain.Interfaces
{
    public interface IMessageNotificationService
    {
        public void Publish(object data, string routingKey);

    }
}
