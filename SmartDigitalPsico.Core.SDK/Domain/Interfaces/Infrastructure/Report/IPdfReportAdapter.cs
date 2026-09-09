using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Report;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;

/// <summary>
/// Contrato PDF adapter — surface SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportAdapter",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de contrato; Generate usa ReportPageContentDto em Domain.DTO.Report.")]
public interface IPdfReportAdapter
{
    byte[] Generate(ReportPageContentDto content);

    Task Generate(ReportPageContentDto content, string filePath);
}
