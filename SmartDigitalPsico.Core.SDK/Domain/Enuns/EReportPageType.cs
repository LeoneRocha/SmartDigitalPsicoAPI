using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de tipo de página de relatório.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.EReportPageType",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho com valores idênticos a EReportPageType em SmartCoreHub.Core.SDK.")]
public enum EReportPageType
{
    Text = (int)SchEnums.EReportPageType.Text,
    Table = (int)SchEnums.EReportPageType.Table,
}
