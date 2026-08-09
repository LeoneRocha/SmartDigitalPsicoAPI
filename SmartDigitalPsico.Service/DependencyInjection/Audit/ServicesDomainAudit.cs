using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Domain.Validation;

using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Data.Repository;

namespace SmartDigitalPsico.Service.DependencyInjection.Audit
{
    /// <summary>
    /// Classe responsável por ServicesDomainAudit.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServicesDomainAudit
    {
        /// <summary>
        /// Método AddDependencies: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddDependencies(IServiceCollection services)
        {
            services.AddSingleton<IAuditContextService, AuditContextService>();
            services.AddSingleton<IAuditPersistenceServiceFactory, AuditPersistenceServiceFactory>();
            services.AddScoped<AuditPersistenceAzureTableService>();
            services.AddSingleton<AuditPersistenceDataBaseService>();
            services.AddSingleton<AuditPersistenceLogService>();
            services.AddSingleton<AuditContextInterceptor>();

            services.AddScoped<IAuditDataSelectiveEntityLogRepository, AuditDataSelectiveEntityLogRepository>();
            services.AddScoped<IAuditDataSelectiveEntityLogService, AuditDataSelectiveEntityLogService>();
            services.AddScoped<IValidator<AuditDataSelectiveEntityLog>, AuditDataSelectiveEntityLogValidator>();
        }
    }
}
