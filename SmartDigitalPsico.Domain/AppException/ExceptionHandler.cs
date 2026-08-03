using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.AppException
{
    /// <summary>
    /// Classe responsável por ExceptionHandler.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
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
