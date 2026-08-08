using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.Validation;
using SmartDigitalPsico.Service.Audit;
using SmartDigitalPsico.Service.Application;
using SmartDigitalPsico.Service.Gender;
using SmartDigitalPsico.Service.Leaves;
using SmartDigitalPsico.Service.Notification;
using SmartDigitalPsico.Service.Office;
using SmartDigitalPsico.Service.RoleGroup;
using SmartDigitalPsico.Service.Specialty;
using SmartDigitalPsico.Service.User;

using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;
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
