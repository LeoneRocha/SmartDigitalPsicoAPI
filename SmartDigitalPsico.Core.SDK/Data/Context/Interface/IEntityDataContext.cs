using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Infrastructure.Data;

namespace SmartDigitalPsico.Core.SDK.Data.Context.Interface;

/// <summary>
/// Casca IEntityDataContext — herda o contrato SCH já portado.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Data.IEntityDataContext",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "AJ.1: casca/wrapper herdando IEntityDataContext do SCH.")]
public interface IEntityDataContext : Sch.IEntityDataContext
{
}
