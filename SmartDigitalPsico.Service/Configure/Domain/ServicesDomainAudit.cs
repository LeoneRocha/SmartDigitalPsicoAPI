using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.SystemDomains;
using SmartDigitalPsico.Service.Audit;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainAudit
    {
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