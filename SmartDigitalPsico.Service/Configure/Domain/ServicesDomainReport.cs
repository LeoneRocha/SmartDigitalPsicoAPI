using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.DependeciesCollection;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Service.Infrastructure.Report;
using SmartDigitalPsico.Service.Report.Entity;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    /// <summary>
    /// Classe responsável por ServicesDomainReport.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServicesDomainReport
    { 
        /// <summary>
        /// Método AddDependencies: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddDependencies(IServiceCollection services)
        {
            services.AddScoped<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorService, ExcelGeneratorService>();
            services.AddScoped<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorFactory, SmartDigitalPsico.Core.SDK.Service.Infrastructure.Report.ExcelGeneratorFactory>();

            services.AddScoped<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportAdapterFactory, SmartDigitalPsico.Core.SDK.Service.Infrastructure.Report.PdfReportAdapterFactory>();
            services.AddScoped<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportService, PdfReportService>();
            #region ENTITIES

            services.AddScoped<IPatientReportService, PatientReportService>();

            #endregion

            services.AddScoped<IReportServiceConfig, ReportServiceConfig>();
        }
    }
}
