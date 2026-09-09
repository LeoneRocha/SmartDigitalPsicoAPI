using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Report;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;

/// <summary>
/// Contrato Excel — surface SDP (DTO namespace estável).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGenerator",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de contrato; Generate usa ReportWorkbookDataDto em Domain.DTO.Report.")]
public interface IExcelGenerator
{
    Task Generate(ReportWorkbookDataDto workbookDataInput, string filePath);
}
