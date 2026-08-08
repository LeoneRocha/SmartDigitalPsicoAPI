using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.AppException
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class ExceptionHandler
    {
        public static List<ErrorResponse> GerateListErrorResponse(Exception ex)
            => SmartDigitalPsico.Core.SDK.Domain.AppException.ExceptionHandler.GerateListErrorResponse(ex);

        public static string GetMessage(Exception ex)
            => SmartDigitalPsico.Core.SDK.Domain.AppException.ExceptionHandler.GetMessage(ex);
    }
}
