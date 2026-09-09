using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;

/// <summary>
/// Contrato fábrica PDF — surface SDP com enum <c>Enuns</c>.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportAdapterFactory",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de contrato; Create usa EPdfReportComponentType em Domain.Enuns.")]
public interface IPdfReportAdapterFactory
{
    IPdfReportAdapter Create(EPdfReportComponentType ePdfReportComponentType);
}
