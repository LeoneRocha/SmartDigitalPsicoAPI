using Microsoft.AspNetCore.Http;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class RequestCultureMiddleware : SmartDigitalPsico.Core.SDK.Domain.Helpers.RequestCultureMiddleware
    {
        public RequestCultureMiddleware(RequestDelegate next) : base(next) { }
    }
}
