using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Validation;

namespace SmartDigitalPsico.Core.SDK.Domain.Validation;

/// <summary>
/// Casca: convenção de códigos FluentValidation — forward para SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Validation.ValidationErrorCodes",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando para ValidationErrorCodes em SmartCoreHub.Core.SDK.")]
public static class ValidationErrorCodes
{
    public const string Project = Sch.ValidationErrorCodes.Project;

    public static string For(string validatorName, string typeName, string fieldName)
        => Sch.ValidationErrorCodes.For(validatorName, typeName, fieldName);

    public static string For(string validatorName, string typeName, string fieldName, string ruleName)
        => Sch.ValidationErrorCodes.For(validatorName, typeName, fieldName, ruleName);
}
