using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de formatos de relatório.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.EReportOutputType",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho; valores int idênticos ao SCH.")]
public enum EReportOutputType
{
    Excel = (int)SchEnums.EReportOutputType.Excel,
    Pdf = (int)SchEnums.EReportOutputType.Pdf,
}
