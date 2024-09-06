namespace SmartDigitalPsico.Domain.VO.SMTP
{
    public class EmailMessageVO
    {
        public string Subject { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public List<string> ToEmails { get; set; } = new List<string>();
    }
} 