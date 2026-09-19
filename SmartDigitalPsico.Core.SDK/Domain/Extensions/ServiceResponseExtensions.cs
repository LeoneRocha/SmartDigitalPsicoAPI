using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Core.SDK.Domain.Extensions;

/// <summary>
/// Extensões do envelope <see cref="ServiceResponse{T}"/> alinhadas à matriz SCH
/// (<c>Success</c> derivado de <see cref="ServiceResponse{T}.Errors"/>).
/// </summary>
public static class ServiceResponseExtensions
{
    /// <summary>
    /// Marca falha adicionando <see cref="ErrorResponse"/> (equivalente ao antigo <c>Success = false</c>).
    /// </summary>
    public static ServiceResponse<T> FailWith<T>(
        this ServiceResponse<T> response,
        string message,
        string? operationName = null,
        string? errorCode = null)
    {
        if (response is null)
            throw new ArgumentNullException(nameof(response));

        response.Message = message;
        if (response.Errors is null)
            response.Errors = new List<ErrorResponse>();

        response.Errors.Add(new ErrorResponse
        {
            Name = operationName ?? string.Empty,
            Message = message,
            ErrorCode = errorCode ?? string.Empty,
            DefaultMessage = message
        });
        return response;
    }
}
