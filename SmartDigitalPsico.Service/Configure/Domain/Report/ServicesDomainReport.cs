using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.Report;
using SmartDigitalPsico.Domain.DependeciesCollection;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Service.Infrastructure.Report;
using SmartDigitalPsico.Service.Report.Entity;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    /// <summary>
    /// Factories de relatório no Core; serviços Excel/Pdf/Patient no host.
    /// </summary>
    public static class ServicesDomainReport
    {
        public static void AddDependencies(IServiceCollection services)
        {
            services.AddCoreReportInfrastructure();

            services.AddScoped<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorService, ExcelGeneratorService>();
            services.AddScoped<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportService, PdfReportService>();

            services.AddScoped<IPatientReportService, PatientReportService>();
            services.AddScoped<IReportServiceConfig, ReportServiceConfig>();
        }
    }
}
