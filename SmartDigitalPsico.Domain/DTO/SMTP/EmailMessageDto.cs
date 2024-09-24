namespace SmartDigitalPsico.Domain.DTO.SMTP
{
    public class EmailMessageDto
    {
        public string Subject { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public List<string> ToEmails { get; set; } = new List<string>();
    }
} 