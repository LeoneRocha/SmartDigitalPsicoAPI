using System.Security.Claims;
using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Service.Security;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces;

/// <summary>
/// Contrato genérico de emissão/validação de JWT — herda <see cref="Sch.IJwtAccessTokenService"/>.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Security.IJwtAccessTokenService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IJwtAccessTokenService (assinatura compatível + TryGetUserId).")]
public interface ITokenService : Sch.IJwtAccessTokenService
{
}
