using SmartCoreHub.Core.SDK.Common.Attributes;
using SchCommon = SmartCoreHub.Core.SDK.Common;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de tipo de banco (target SCH Common.ETypeDataBase).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Common.ETypeDataBase",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho; valores int idênticos ao SCH Common.ETypeDataBase.")]
public enum ETypeDataBase
{
    MSsqlServer = (int)SchCommon.ETypeDataBase.MSsqlServer,
    Mysql = (int)SchCommon.ETypeDataBase.Mysql,
    Postgree = (int)SchCommon.ETypeDataBase.Postgree,
    FireBase = (int)SchCommon.ETypeDataBase.FireBase,
}
