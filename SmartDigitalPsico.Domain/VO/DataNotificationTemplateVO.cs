namespace SmartDigitalPsico.Domain.VO
{
    public class DataNotificationTemplateVO
    {
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public List<string> ToEmails { get; set; }
        public List<string> ToPhoneNumbers { get; set; }

        public DataNotificationTemplateVO(string subject, string body)
        {
            Subject = subject;
            Body = body;            
            ToEmails = new List<string>();
            ToPhoneNumbers = new List<string>();
        }

        public DataNotificationTemplateVO( )
        {
            ToEmails = new List<string>();
            ToPhoneNumbers = new List<string>();
        }
    }

}
