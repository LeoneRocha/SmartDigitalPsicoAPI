using SmartDigitalPsico.Domain.Hypermedia.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDigitalPsico.Domain.Helpers
{
    public class HandleException
    {
        public static List<ErrorResponse> GerateListErrorResponse(Exception ex)
        {
            List<ErrorResponse> result = new List<ErrorResponse>();
            result.Add(new ErrorResponse() { Name = ex.Source, Message = ex.Message, ErrorCode = ex.HResult.ToString() });

            return result;
        }

        public static string GetMessage(Exception ex)
        {
            return $" {ex.Message} - {ex.InnerException?.Message}";
        }
    }
}
