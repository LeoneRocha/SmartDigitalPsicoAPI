namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp
{
    /// <summary>
    /// Interface (contrato) responsável por ISmtpSettingsDto.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface ISmtpSettingsDto
    {
        string Password { get; set; }
        int Port { get; set; }
        string SenderEmail { get; set; }
        string SenderName { get; set; }
        string Server { get; set; }
        string Username { get; set; }
        bool EnableSsl { get; set; }
    }
}
