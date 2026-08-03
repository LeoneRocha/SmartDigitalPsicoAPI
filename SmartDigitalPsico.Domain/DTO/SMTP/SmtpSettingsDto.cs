using SmartDigitalPsico.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Domain.DTO.SMTP
{
    /// <summary>
    /// Classe responsável por SmtpSettingsDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class SmtpSettingsDto : ISmtpSettingsDto
    {
        public string Server { get; set; } = string.Empty;
        public int Port { get; set; }
        public string SenderName { get; set; } = string.Empty;
        public string SenderEmail { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
} 
