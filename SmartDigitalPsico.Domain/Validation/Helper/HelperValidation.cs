using FluentValidation.Results;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Domain.Validation;

namespace SmartDigitalPsico.Domain.Validation.Helper
{
    /// <summary>
    /// Classe responsável por HelperValidation.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public static class HelperValidation
    {
        /// <summary>
        /// Método GetErrorsMap: consulta e retorna dados.
        /// </summary>
        public static ErrorResponse[] GetErrorsMap(FluentValidation.Results.ValidationResult? validationResult)
        {
            if (validationResult == null || validationResult.IsValid) return Array.Empty<ErrorResponse>();

            return validationResult.Errors.Select(ConvertToErrorResponse).ToArray();
        }

        private static bool IsStructuredErrorCode(string? errorCode)
            => !string.IsNullOrWhiteSpace(errorCode)
               && errorCode.StartsWith(ValidationErrorCodes.Project + ".", StringComparison.Ordinal);

        private static ErrorResponse ConvertToErrorResponse(ValidationFailure errorItem)
        {
            var errorAdd = new ErrorResponse
            {
                FullMessage = errorItem.ErrorMessage,
                DefaultMessage = errorItem.ErrorMessage,
                Message = errorItem.ErrorMessage,
                ErrorCode = errorItem.ErrorCode,
                Name = errorItem.PropertyName
            };

            if (errorAdd.Message.Contains('|') && errorAdd.Message.Contains('_'))
            {
                var parts = errorAdd.Message.Split('|');
                // Keep FluentValidation WithErrorCode when it follows SmartDigitalPsico.* convention
                if (!IsStructuredErrorCode(errorItem.ErrorCode))
                {
                    errorAdd.ErrorCode = parts[0];
                }
                errorAdd.DefaultMessage = parts.Length > 1 ? parts[1] : errorItem.ErrorMessage;
            }
            else if (!IsStructuredErrorCode(errorAdd.ErrorCode) && !errorAdd.Message.Contains('_'))
            {
                errorAdd.ErrorCode = errorAdd.Message.Replace(" ", "_");
            }

            return errorAdd;
        }

        /// <summary>
        /// Método TranslateErroCode: executa a operação TranslateErroCode.
        /// </summary>
        public static ErrorResponse TranslateErroCode(ErrorResponse errorItem)
        {
            if (errorItem.FullMessage.Contains('|') && errorItem.FullMessage.Contains('_'))
            {
                var processedMessage = ApplicationLanguageHelper.ReplaceTokensInMessage(errorItem.FullMessage);
                var parts = processedMessage.Split('|');
                if (!IsStructuredErrorCode(errorItem.ErrorCode))
                {
                    errorItem.ErrorCode = parts[0];
                }
                errorItem.Message = parts.Length > 1 ? parts[1] : errorItem.FullMessage;
            }

            return errorItem;
        }

        /// <summary>
        /// Método TranslateErroCode: executa a operação TranslateErroCode.
        /// </summary>
        public static string TranslateErroCode(string message, string errorCode)
        {
            if (!string.IsNullOrEmpty(errorCode))
            {
                message = message.Replace("[MaxLength]", errorCode.Replace("[", "").Replace("]", "").Replace(",", ""));
            }
            return message;
        }

        /// <summary>
        /// Método ConvertValidationFailureListToErroResponse: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static List<ErrorResponse> ConvertValidationFailureListToErroResponse(List<ValidationFailure> errors)
        {
            return errors.DistinctBy(d => d.PropertyName).Select(er => ConvertToErrorResponse(er)).ToList();
        }
    }
}
