namespace SmartDigitalPsico.Domain.VO
{
    public class NotificationTemplate
    {
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public List<string> ToEmails { get; set; }
        public List<string> ToPhoneNumbers { get; set; }

        public NotificationTemplate(string subject, string body)
        {
            Subject = subject;
            Body = body;            
            ToEmails = new List<string>();
            ToPhoneNumbers = new List<string>();
        }

        public NotificationTemplate( )
        {
            ToEmails = new List<string>();
            ToPhoneNumbers = new List<string>();
        }
    }

}
