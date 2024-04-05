namespace GG_LabOps_Domain.Events
{
    public class NotificationUpdatedEvent
    {
        public string TrakingCode { get; private set; }
        public string ContactEmail { get; private set; }
        public string Description { get; private set; }

        public NotificationUpdatedEvent(string trakingCode, string contactEmail, string description)
        {
            TrakingCode = trakingCode;
            ContactEmail = contactEmail;
            Description = description;
        }
    }
}
