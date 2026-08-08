using SmartDigitalPsico.Service.Infrastructure.Notification;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Service.Helpers;
using SmartDigitalPsico.Service.Infrastructure.CacheManager;
using SmartDigitalPsicoAPI.Core.SDK.Service.Infrastructure.Notification;
using System.Reflection;

namespace SmartDigitalPsico.Service.Configure.Domain
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
            services.AddScoped<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Service.ICacheService, SmartDigitalPsico.Service.Infrastructure.CacheManager.CacheService>();
            services.AddScoped<INotificationPlatformServiceFactory, NotificationPlatformServiceFactory>();

            // Schedule Core — write / read / conflict (CQRS-ready)
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleConflictService, SmartDigitalPsico.Service.Bussines.Schedule.Core.Conflict.ScheduleConflictService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleCreateService, SmartDigitalPsico.Service.Bussines.Schedule.Core.Commands.ScheduleCreateService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleUpdateService, SmartDigitalPsico.Service.Bussines.Schedule.Core.Commands.ScheduleUpdateService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleDeleteService, SmartDigitalPsico.Service.Bussines.Schedule.Core.Commands.ScheduleDeleteService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleQueryService, SmartDigitalPsico.Service.Bussines.Schedule.Core.Queries.ScheduleQueryService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleAvailabilityService, SmartDigitalPsico.Service.Bussines.Schedule.Core.Queries.ScheduleAvailabilityService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleAppointmentQueryService, SmartDigitalPsico.Service.Bussines.Schedule.Core.Queries.ScheduleAppointmentQueryService>();

            // Medical host — support + action services + thin facade
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleKeyPolicy, SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.MedicalScheduleKeyPolicy>();
            services.AddScoped<SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.MedicalScheduleNotificationAdapter>();
            services.AddScoped<SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.MedicalScheduleConstraintsProvider>();
            services.AddScoped<SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.MedicalScheduleHostSupport>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleCalendarFindService, SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions.MedicalScheduleFindService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleCalendarCreateService, SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions.MedicalScheduleCreateService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleCalendarUpdateService, SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions.MedicalScheduleUpdateService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleCalendarDeleteService, SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions.MedicalScheduleDeleteService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleCalendarGradeService, SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions.MedicalScheduleGradeService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleCalendarAppointmentService, SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions.MedicalScheduleAppointmentService>();
            services.AddScoped<SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleCalendarFacade, SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.MedicalScheduleCalendarHost>();
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
                typeof(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Security.ICryptoService),
                typeof(IEmailService),
                typeof(ITokenService),
                typeof(IAuditContextService),
                typeof(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Service.ICacheService),
                typeof(INotificationPlatformServiceFactory)
            }; 
            ignoredInterfaces.AddRange(SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.ServiceCollectionHelper.GetRegisteredInterfaces(services));

            SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.ServiceCollectionHelper.RegisterInterfaces(services, [ServiceSuffix], ignoredInterfaces, assemblies);
        }
    }
}
