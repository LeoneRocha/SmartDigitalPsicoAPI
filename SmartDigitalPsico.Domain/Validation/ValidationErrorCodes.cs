namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class ValidationErrorCodes
    {
        public const string Project = SmartDigitalPsico.Core.SDK.Domain.Validation.ValidationErrorCodes.Project;

        public static string For(string validatorName, string typeName, string fieldName)
            => SmartDigitalPsico.Core.SDK.Domain.Validation.ValidationErrorCodes.For(validatorName, typeName, fieldName);

        public static string For(string validatorName, string typeName, string fieldName, string ruleName)
            => SmartDigitalPsico.Core.SDK.Domain.Validation.ValidationErrorCodes.For(validatorName, typeName, fieldName, ruleName);
    }
}
