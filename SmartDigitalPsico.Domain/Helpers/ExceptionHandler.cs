using SmartDigitalPsico.Domain.Hypermedia.Utils;

namespace SmartDigitalPsico.Domain.Helpers
{
    public static class ExceptionHandler
    {
        public static List<ErrorResponse> GerateListErrorResponse(Exception ex)
        {
            List<ErrorResponse> result = new List<ErrorResponse>();
            result.Add(new ErrorResponse() { Name = ex.Source ?? "SmartDigitalPsico", Message = ex.Message, ErrorCode = ex.HResult.ToString() });

            return result;
        }

        public static string GetMessage(Exception ex)
        {
            return $" {ex.Message} - {ex.InnerException?.Message}";
        }
    }
}
