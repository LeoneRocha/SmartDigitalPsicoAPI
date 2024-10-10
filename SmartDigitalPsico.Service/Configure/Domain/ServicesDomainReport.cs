using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.DependeciesCollection;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Service.Infrastructure.Report;
using SmartDigitalPsico.Service.Report.Entity;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainReport
    { 
        public static void AddDependencies(IServiceCollection services)
        {
            services.AddScoped<IExcelGeneratorService, ExcelGeneratorService>();
            services.AddScoped<IExcelGeneratorFactory, ExcelGeneratorFactory>();

            services.AddScoped<IPdfReportAdapterFactory, PdfReportAdapterFactory>();
            services.AddScoped<IPdfReportService, PdfReportService>();
            #region ENTITIES

            services.AddScoped<IPatientReportService, PatientReportService>();

            #endregion

            services.AddScoped<IReportServiceConfig, ReportServiceConfig>();
        }
    }
}