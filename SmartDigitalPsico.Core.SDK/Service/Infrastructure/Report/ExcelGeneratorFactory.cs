using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Core.SDK.Domain.Report;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Report;

/// <summary>
/// Casca fábrica Excel — cria adapter SDP (herda SCH).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Reports.ExcelGeneratorFactory",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca ExcelGeneratorFactory; Create retorna ExcelGeneratorOpenXmlAdapter SDP.")]
public class ExcelGeneratorFactory : IExcelGeneratorFactory
{
    public IExcelGenerator Create() => new ExcelGeneratorOpenXmlAdapter();
}
