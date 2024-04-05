namespace GG_LabOps_Notificacao_Domain.Entities
{
    public class NotificationUpdatedEvent
    {
        public string TrackingCode { get; set; }
        public string ContactEmail { get; set; }
        public string Description { get; set; }
    }
}
