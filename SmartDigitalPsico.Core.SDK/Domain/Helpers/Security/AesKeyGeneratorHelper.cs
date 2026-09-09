using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers.Security;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers.Security;

/// <summary>
/// Casca: geração AES — delega a <see cref="Sch.AesKeyGeneratorHelper"/>.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando GenerateKey/GenerateIV ao SCH (elimina impl duplicada).")]
public static class AesKeyGeneratorHelper
{
    public static string GenerateKey() => Sch.AesKeyGeneratorHelper.GenerateKey();

    public static string GenerateIV() => Sch.AesKeyGeneratorHelper.GenerateIV();
}
