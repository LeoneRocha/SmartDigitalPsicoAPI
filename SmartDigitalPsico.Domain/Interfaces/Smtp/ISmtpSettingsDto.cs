namespace SmartDigitalPsico.Domain.Interfaces.Smtp
{
    public interface ISmtpSettingsDto
    {
        string Password { get; set; }
        int Port { get; set; }
        string SenderEmail { get; set; }
        string SenderName { get; set; }
        string Server { get; set; }
        string Username { get; set; }
    }
}