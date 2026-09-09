using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;

/// <summary>
/// Casca: contrato de criptografia de alto nível — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Security.ICryptoService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando ICryptoService em SmartCoreHub.Core.SDK.")]
public interface ICryptoService : SmartCoreHub.Core.SDK.Domain.Interfaces.Security.ICryptoService
{
}
