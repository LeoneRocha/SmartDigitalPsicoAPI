using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de engine PDF.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.EPdfReportComponentType",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho com valores idênticos a EPdfReportComponentType em SmartCoreHub.Core.SDK.")]
public enum EPdfReportComponentType
{
    QuestPDF = (int)SchEnums.EPdfReportComponentType.QuestPDF,
    PDFsharp = (int)SchEnums.EPdfReportComponentType.PDFsharp,
}
