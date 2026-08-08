using FluentValidation.Results;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Core.SDK.Domain.Validation.Helper
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
                errorAdd.DefaultMessage = parts[1];
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
                var processedMessage = ReplaceTokensInMessage(errorItem.FullMessage);
                var parts = processedMessage.Split('|');
                if (!IsStructuredErrorCode(errorItem.ErrorCode))
                {
                    errorItem.ErrorCode = parts[0];
                }
                errorItem.Message = parts[1];
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
        private static string ReplaceTokensInMessage(string message)
        {
            var parts = message.Split('|');
            if (parts.Length > 2)
            {
                var template = parts[1]; 
                var values = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(parts, 2));
                
                var replacedMessage = template;
                if (values.Length > 0)
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        var token = $"{{{i}}}";
                        if (replacedMessage.Contains(token))
                        {
                            replacedMessage = replacedMessage.Replace(token, values[i]?.ToString() ?? string.Empty);
                        }
                    }
                }

                return $"{parts[0]}|{replacedMessage}";
            }
            return message;
        }
    }
}
