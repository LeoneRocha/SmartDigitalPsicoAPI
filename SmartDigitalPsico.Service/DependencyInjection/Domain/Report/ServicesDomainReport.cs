using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.Report;
using SmartDigitalPsico.Domain.DependeciesCollection;
using SmartDigitalPsico.Service.Report;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.EntityModels;
namespace SmartDigitalPsico.Service
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
