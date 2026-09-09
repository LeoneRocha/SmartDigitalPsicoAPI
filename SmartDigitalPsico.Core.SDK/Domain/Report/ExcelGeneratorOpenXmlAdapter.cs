using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Report;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;

namespace SmartDigitalPsico.Core.SDK.Domain.Report;

/// <summary>
/// Casca Excel OpenXml — herda SCH; bridge <see cref="IExcelGenerator"/> SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Reports.ExcelGeneratorOpenXmlAdapter",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando ExcelGeneratorOpenXmlAdapter; bridge IExcelGenerator SDP.")]
public class ExcelGeneratorOpenXmlAdapter
    : SmartCoreHub.Core.SDK.Infrastructure.Reports.ExcelGeneratorOpenXmlAdapter,
      IExcelGenerator
{
    Task IExcelGenerator.Generate(ReportWorkbookDataDto workbookDataInput, string filePath)
        => base.Generate(workbookDataInput, filePath);
}
