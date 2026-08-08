namespace SmartDigitalPsico.Service.Infrastructure.Notification
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class EmailService : SmartDigitalPsico.Core.SDK.Service.Infrastructure.Notification.EmailService
    {
        public EmailService(Smtp.EmailContext emailContext) : base(emailContext) { }
    }
}
