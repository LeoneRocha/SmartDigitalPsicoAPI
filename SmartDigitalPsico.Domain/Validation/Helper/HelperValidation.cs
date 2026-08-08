using FluentValidation.Results;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Validation.Helper
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class HelperValidation
    {
        public static ErrorResponse[] GetErrorsMap(ValidationResult? validationResult)
            => SmartDigitalPsico.Core.SDK.Domain.Validation.Helper.HelperValidation.GetErrorsMap(validationResult);

        public static ErrorResponse TranslateErroCode(ErrorResponse errorItem)
            => SmartDigitalPsico.Core.SDK.Domain.Validation.Helper.HelperValidation.TranslateErroCode(errorItem);

        public static string TranslateErroCode(string message, string errorCode)
            => SmartDigitalPsico.Core.SDK.Domain.Validation.Helper.HelperValidation.TranslateErroCode(message, errorCode);

        public static List<ErrorResponse> ConvertValidationFailureListToErroResponse(List<ValidationFailure> errors)
            => SmartDigitalPsico.Core.SDK.Domain.Validation.Helper.HelperValidation.ConvertValidationFailureListToErroResponse(errors);
    }
}
