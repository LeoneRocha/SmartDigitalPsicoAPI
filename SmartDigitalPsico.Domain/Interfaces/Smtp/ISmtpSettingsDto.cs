namespace SmartDigitalPsico.Domain.Interfaces.Smtp
{
    /// <summary>
    /// Interface (contrato) responsável por ISmtpSettingsDto.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
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
