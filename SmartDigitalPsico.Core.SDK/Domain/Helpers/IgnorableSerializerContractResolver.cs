using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca IgnorableSerializerContractResolver — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.IgnorableSerializerContractResolver",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IgnorableSerializerContractResolver do SCH.")]
public class IgnorableSerializerContractResolver : SmartCoreHub.Core.SDK.Domain.Helpers.IgnorableSerializerContractResolver
{
    public IgnorableSerializerContractResolver(IEnumerable<string> propertiesToIgnore)
        : base(propertiesToIgnore)
    {
    }
}
