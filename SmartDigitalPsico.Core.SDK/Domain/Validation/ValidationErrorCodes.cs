namespace SmartDigitalPsico.Core.SDK.Domain.Validation
{
    /// <summary>
    /// FluentValidation error-code convention:
    /// SmartDigitalPsico.{Validator}.{EntityOrDto}.{Field}
    /// or SmartDigitalPsico.{Validator}.{EntityOrDto}.{Field}.{RuleName}
    /// </summary>
    public static class ValidationErrorCodes
    {
        public const string Project = "SmartDigitalPsico";

        public static string For(string validatorName, string typeName, string fieldName)
            => $"{Project}.{validatorName}.{typeName}.{fieldName}";

        public static string For(string validatorName, string typeName, string fieldName, string ruleName)
            => $"{Project}.{validatorName}.{typeName}.{fieldName}.{ruleName}";
    }
}
