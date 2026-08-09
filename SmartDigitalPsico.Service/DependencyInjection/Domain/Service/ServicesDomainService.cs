using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Service.FileManager;
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
            services.AddScoped<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService, SmartDigitalPsico.Service.Cache.CacheService>();
            services.AddScoped<INotificationPlatformServiceFactory, NotificationPlatformServiceFactory>();
            services.AddScoped<IFileManagerService, FileManagerService>();

            // Schedule Core — write / read / conflict (CQRS-ready)
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleConflictService, SmartDigitalPsico.Service.Core.Conflict.ScheduleConflictService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCreateService, SmartDigitalPsico.Service.Core.Commands.ScheduleCreateService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleUpdateService, SmartDigitalPsico.Service.Core.Commands.ScheduleUpdateService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleDeleteService, SmartDigitalPsico.Service.Core.Commands.ScheduleDeleteService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleQueryService, SmartDigitalPsico.Service.Core.Queries.ScheduleQueryService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleAvailabilityService, SmartDigitalPsico.Service.Core.Queries.ScheduleAvailabilityService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleAppointmentQueryService, SmartDigitalPsico.Service.Core.Queries.ScheduleAppointmentQueryService>();

            // Medical host — support + action services + thin facade
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleKeyPolicy, SmartDigitalPsico.Service.Medical.MedicalScheduleKeyPolicy>();
            services.AddScoped<SmartDigitalPsico.Service.Medical.MedicalScheduleNotificationAdapter>();
            services.AddScoped<SmartDigitalPsico.Service.Medical.MedicalScheduleConstraintsProvider>();
            services.AddScoped<SmartDigitalPsico.Service.Medical.MedicalScheduleHostSupport>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarFindService, SmartDigitalPsico.Service.Medical.Actions.MedicalScheduleFindService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarCreateService, SmartDigitalPsico.Service.Medical.Actions.MedicalScheduleCreateService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarUpdateService, SmartDigitalPsico.Service.Medical.Actions.MedicalScheduleUpdateService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarDeleteService, SmartDigitalPsico.Service.Medical.Actions.MedicalScheduleDeleteService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarGradeService, SmartDigitalPsico.Service.Medical.Actions.MedicalScheduleGradeService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarAppointmentService, SmartDigitalPsico.Service.Medical.Actions.MedicalScheduleAppointmentService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleCalendarFacade, SmartDigitalPsico.Service.Medical.MedicalScheduleCalendarHost>();
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
