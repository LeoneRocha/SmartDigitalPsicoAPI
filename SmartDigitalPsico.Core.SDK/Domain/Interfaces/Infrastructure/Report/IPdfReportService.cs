using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Report;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;

/// <summary>
/// Contrato serviço PDF de orquestração — surface SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de contrato IPdfReportService.")]
public interface IPdfReportService
{
    Task<string> Generate(ReportPageContentDto content);
}
