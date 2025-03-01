using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Service.Helpers;
using SmartDigitalPsico.Service.Infrastructure.CacheManager;
using SmartDigitalPsico.Service.Infrastructure.Notification;
using System.Reflection;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainService
    {
        private const string ServiceSuffix = "Service"; 

        public static void AddDependenciesManually(IServiceCollection services)
        {
            RegisterManuallyAddedServices(services);
        }
        public static void AddDependenciesAuto(IServiceCollection services)
        {
            RegisterServices(services);
        }
        private static void RegisterManuallyAddedServices(IServiceCollection services)
        {
            services.AddScoped<ICacheService, CacheService>();
            services.AddScoped<INotificationPlatformServiceFactory, NotificationPlatformServiceFactory>(); 
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
                typeof(ICryptoService),
                typeof(IEmailService),
                typeof(ITokenService),
                typeof(IAuditContextService),
                typeof(ICacheService),
                typeof(INotificationPlatformServiceFactory)
            }; 
            ignoredInterfaces.AddRange(ServiceCollectionHelper.GetRegisteredInterfaces(services));

            ServiceCollectionHelper.RegisterInterfaces(services, [ServiceSuffix], ignoredInterfaces, assemblies);
        }
    }
}