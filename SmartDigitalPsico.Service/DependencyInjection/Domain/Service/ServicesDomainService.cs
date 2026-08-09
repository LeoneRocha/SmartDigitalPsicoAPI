using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;
using System.Reflection;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
using SmartDigitalPsico.Domain.EntityModels;
namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe responsável por ServicesDomainService.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServicesDomainService
    {
        private const string ServiceSuffix = "Service";

        /// <summary>
        /// Método AddDependenciesManually: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddDependenciesManually(IServiceCollection services)
        {
            RegisterManuallyAddedServices(services);
        }
        /// <summary>
        /// Método AddDependenciesAuto: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddDependenciesAuto(IServiceCollection services)
        {
            RegisterServices(services);
        }
        private static void RegisterManuallyAddedServices(IServiceCollection services)
        {
            // Bridge host: Core CacheService + ApplicationCacheLog (auditoria de produto).
            services.AddScoped<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService, CacheService>();
            services.AddScoped<INotificationPlatformServiceFactory, NotificationPlatformServiceFactory>();
            services.AddScoped<IFileManagerService, FileManagerService>();

            // Schedule Core — write / read / conflict (CQRS-ready)
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleConflictService, ScheduleConflictService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCreateService, ScheduleCreateService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleUpdateService, ScheduleUpdateService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleDeleteService, ScheduleDeleteService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleQueryService, ScheduleQueryService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleAvailabilityService, ScheduleAvailabilityService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleAppointmentQueryService, ScheduleAppointmentQueryService>();

            // Medical host — support + action services + thin facade
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleKeyPolicy, MedicalScheduleKeyPolicy>();
            services.AddScoped<MedicalScheduleNotificationAdapter>();
            services.AddScoped<MedicalScheduleConstraintsProvider>();
            services.AddScoped<MedicalScheduleHostSupport>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarFindService, MedicalScheduleFindService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarCreateService, MedicalScheduleCreateService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarUpdateService, MedicalScheduleUpdateService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarDeleteService, MedicalScheduleDeleteService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarGradeService, MedicalScheduleGradeService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarAppointmentService, MedicalScheduleAppointmentService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarFacade, MedicalScheduleCalendarHost>();
        }
        private static void RegisterServices(IServiceCollection services)
        {
            var assemblies = new[]
           {
                Assembly.GetExecutingAssembly(),
                Assembly.Load("SmartDigitalPsico.Domain"),
                Assembly.Load("SmartDigitalPsico.Data")
            };

            var ignoredInterfaces = new List<Type>
            {
                typeof(SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ICryptoService),
                typeof(IEmailService),
                typeof(SmartDigitalPsico.Core.SDK.Domain.Interfaces.ITokenService),
                typeof(IAuditContextService),
                typeof(SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService),
                typeof(INotificationPlatformServiceFactory),
                typeof(IFileManagerService)
            };
            ignoredInterfaces.AddRange(SmartDigitalPsico.Core.SDK.Domain.Helpers.ServiceCollectionHelper.GetRegisteredInterfaces(services));

            SmartDigitalPsico.Core.SDK.Domain.Helpers.ServiceCollectionHelper.RegisterInterfaces(services, [ServiceSuffix], ignoredInterfaces, assemblies);
        }
    }
}
