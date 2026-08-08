using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Report;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Report
{
    public static class ReportInfrastructureServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreReportInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IExcelGeneratorFactory, ExcelGeneratorFactory>();
            services.AddScoped<IPdfReportAdapterFactory, PdfReportAdapterFactory>();
            return services;
        }
    }
}
