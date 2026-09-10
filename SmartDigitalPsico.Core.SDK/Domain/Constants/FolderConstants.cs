using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Constants;

namespace SmartDigitalPsico.Core.SDK.Domain.Constants;

/// <summary>
/// Casca FolderConstants — espelho de constantes SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Constants.FolderConstants",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper espelhando FolderConstants do SCH.")]
public static class FolderConstants
{
    public const string ConstResourcesTemp = Sch.FolderConstants.ConstResourcesTemp;
}
