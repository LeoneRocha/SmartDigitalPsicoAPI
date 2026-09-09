using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Report;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Report;

/// <summary>
/// DI Reports — surface SDP (registra factories casca). Alias nome alinhado a SCH <c>AddCoreReportInfrastructure</c>.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions.AddCoreReportInfrastructure",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Alias DI AddCoreReportInfrastructure; registra factories SDP (não SCH types).")]
public static class ReportInfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddCoreReportInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IExcelGeneratorFactory, ExcelGeneratorFactory>();
        services.AddScoped<IPdfReportAdapterFactory, PdfReportAdapterFactory>();
        return services;
    }
}
