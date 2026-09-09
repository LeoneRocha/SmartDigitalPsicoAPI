using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;

/// <summary>
/// Contrato fábrica Excel — surface SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorFactory",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de contrato IExcelGeneratorFactory.")]
public interface IExcelGeneratorFactory
{
    IExcelGenerator Create();
}
