using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using Sch = SmartCoreHub.Core.SDK.Domain.AppException;

namespace SmartDigitalPsico.Core.SDK.Domain.AppException;

/// <summary>
/// Casca ExceptionHandler — delega a SCH; mapeia ErrorResponse SCH → VO SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.AppException.ExceptionHandler",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando ExceptionHandler ao SCH (ErrorResponse VO mapeado).")]
public static class ExceptionHandler
{
    public static List<ErrorResponse> GerateListErrorResponse(Exception ex)
    {
        return Sch.ExceptionHandler.GerateListErrorResponse(ex)
            .Select(e => new ErrorResponse
            {
                Name = e.Name ?? string.Empty,
                Message = e.Message,
                ErrorCode = e.ErrorCode,
                DefaultMessage = e.DefaultMessage ?? string.Empty,
                FullMessage = e.FullMessage ?? string.Empty
            })
            .ToList();
    }

    public static string GetMessage(Exception ex)
        => Sch.ExceptionHandler.GetMessage(ex);
}
