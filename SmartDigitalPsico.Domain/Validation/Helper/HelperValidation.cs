﻿using SmartDigitalPsico.Domain.Hypermedia.Utils;

namespace SmartDigitalPsico.Domain.Validation.Helper
{
    public static class HelperValidation
    {
        public static List<ErrorResponse> GetErrosMap(FluentValidation.Results.ValidationResult validationResult)
        {
            List<ErrorResponse> errorsResult = new List<ErrorResponse>();
            if (!validationResult.IsValid)
            { 
                validationResult.Errors.ForEach(erroItem =>
                {
                    errorsResult.Add(new ErrorResponse()
                    {
                        Message = erroItem.ErrorMessage,
                        ErrorCode = erroItem.ErrorCode,
                        Name = erroItem.PropertyName
                    });
                });
            }
            return errorsResult;
        }

        public static string GetMessage(bool isValid)
        {
            return isValid ? "LangValid" : "LangErrors";
        }

        public static string TranslateErroCode(string message, string errorCode)
        {
            if (!string.IsNullOrEmpty(errorCode))
            {
                message = message.Replace("[MaxLength]", errorCode.Replace("[", "").Replace("]", "").Replace(",", ""));

            }
            return message;
        }
    }
}
