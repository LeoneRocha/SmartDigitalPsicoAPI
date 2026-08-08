using SmartDigitalPsico.Domain.Interfaces.Notification;

namespace SmartDigitalPsico.Domain.Interfaces.Smtp
{
    /// <summary>
    /// Shim Obsolete — use SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp.IEmailService.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IEmailService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp.IEmailService, INotificationPlatformService
    {
    }
}
