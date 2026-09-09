using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;

/// <summary>
/// Casca: adapter crypto (typo Adpter preservado) — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Security.ICryptoAdpter",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando ICryptoAdpter em SmartCoreHub.Core.SDK.")]
public interface ICryptoAdpter : SmartCoreHub.Core.SDK.Domain.Interfaces.Security.ICryptoAdpter
{
}
