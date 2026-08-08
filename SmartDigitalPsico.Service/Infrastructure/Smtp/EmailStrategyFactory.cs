using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class EmailStrategyFactory : SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp.EmailStrategyFactory
    {
        public EmailStrategyFactory(ISmtpSettingsDto smtpSettings) : base(smtpSettings) { }
    }
}
