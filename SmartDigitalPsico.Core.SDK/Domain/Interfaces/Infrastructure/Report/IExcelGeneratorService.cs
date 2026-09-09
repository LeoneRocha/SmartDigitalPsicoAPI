using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Report;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;

/// <summary>
/// Contrato serviço Excel de orquestração — surface SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de contrato IExcelGeneratorService.")]
public interface IExcelGeneratorService
{
    Task<string> Generate(ReportWorkbookDataDto workbook);
}
