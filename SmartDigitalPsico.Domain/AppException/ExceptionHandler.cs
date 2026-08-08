using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.AppException
{
    /// <summary>
    /// Classe responsável por ExceptionHandler.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class ExceptionHandler
    {
        /// <summary>
        /// Método GerateListErrorResponse: executa a operação GerateListErrorResponse.
        /// </summary>
        public static List<ErrorResponse> GerateListErrorResponse(Exception ex)
        {
            List<ErrorResponse> result = new List<ErrorResponse>();
            result.Add(new ErrorResponse() { Name = ex.Source ?? "SmartDigitalPsico", Message = ex.Message, ErrorCode = ex.HResult.ToString() });

            return result;
        }

        /// <summary>
        /// Método GetMessage: consulta e retorna dados.
        /// </summary>
        public static string GetMessage(Exception ex)
        {
            return $" {ex.Message} - {ex.InnerException?.Message}";
        }
    }
}
