using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;
using System.Reflection;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service.DependencyInjection.Service
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
            services.AddScoped<Core.SDK.Domain.Interfaces.Service.ICacheService, CacheService>();
            services.AddScoped<INotificationPlatformServiceFactory, NotificationPlatformServiceFactory>();
            services.AddScoped<IFileManagerService, FileManagerService>();

            // Schedule Core — write / read / conflict (CQRS-ready)
            services.AddScoped<IScheduleConflictService, ScheduleConflictService>();
            services.AddScoped<IScheduleCreateService, ScheduleCreateService>();
            services.AddScoped<IScheduleUpdateService, ScheduleUpdateService>();
            services.AddScoped<IScheduleDeleteService, ScheduleDeleteService>();
            services.AddScoped<IScheduleQueryService, ScheduleQueryService>();
            services.AddScoped<IScheduleAvailabilityService, ScheduleAvailabilityService>();
            services.AddScoped<IScheduleAppointmentQueryService, ScheduleAppointmentQueryService>();

            // Medical host — support + action services + thin facade
            services.AddScoped<IScheduleKeyPolicy, MedicalScheduleKeyPolicy>();
            services.AddScoped<MedicalScheduleNotificationAdapter>();
            services.AddScoped<MedicalScheduleConstraintsProvider>();
            services.AddScoped<MedicalScheduleHostSupport>();
            services.AddScoped<IScheduleCalendarFindService, MedicalScheduleFindService>();
            services.AddScoped<IScheduleCalendarCreateService, MedicalScheduleCreateService>();
            services.AddScoped<IScheduleCalendarUpdateService, MedicalScheduleUpdateService>();
            services.AddScoped<IScheduleCalendarDeleteService, MedicalScheduleDeleteService>();
            services.AddScoped<IScheduleCalendarGradeService, MedicalScheduleGradeService>();
            services.AddScoped<IScheduleCalendarAppointmentService, MedicalScheduleAppointmentService>();
            services.AddScoped<IScheduleCalendarFacade, MedicalScheduleCalendarHost>();
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
                typeof(Core.SDK.Domain.Interfaces.Security.ICryptoService),
                typeof(IEmailService),
                typeof(Core.SDK.Domain.Interfaces.ITokenService),
                typeof(IAuditContextService),
                typeof(Core.SDK.Domain.Interfaces.Service.ICacheService),
                typeof(INotificationPlatformServiceFactory),
                typeof(IFileManagerService)
            };
            ignoredInterfaces.AddRange(SmartDigitalPsico.Core.SDK.Domain.Helpers.ServiceCollectionHelper.GetRegisteredInterfaces(services));

            SmartDigitalPsico.Core.SDK.Domain.Helpers.ServiceCollectionHelper.RegisterInterfaces(services, [ServiceSuffix], ignoredInterfaces, assemblies);
        }
    }
}
