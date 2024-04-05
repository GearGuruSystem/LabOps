namespace GG_LabOps_Domain.Events
{
    public class NotificationUpdatedEvent
    {
        public string TrakingCode { get; set; }
        public string ContactEmail { get; set; }
        public string Description { get; set; }
    }
}
