using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Interfaces.Mapping;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;

/// <summary>
/// Abstração de mapeamento objeto-objeto — casca SCH <see cref="Sch.IAppMapper"/> (EVO.6).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Mapping.IAppMapper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "EVO.6: herda IAppMapper SCH (= ISmartCoreHubMapper).")]
public interface IAppMapper : Sch.IAppMapper
{
}
