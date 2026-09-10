using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca EnumDescriptionConverter — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.EnumDescriptionConverter`1",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando EnumDescriptionConverter do SCH.")]
public class EnumDescriptionConverter<T> : SmartCoreHub.Core.SDK.Domain.Helpers.EnumDescriptionConverter<T>
    where T : Enum
{
}
