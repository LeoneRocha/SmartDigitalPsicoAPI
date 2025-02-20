using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Service.Helpers;
using SmartDigitalPsico.Service.Infrastructure.CacheManager;
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
        }
        private static void RegisterServices(IServiceCollection services)
        {
            var assemblies = new[]
            {
                Assembly.GetExecutingAssembly(),
                Assembly.Load("SmartDigitalPsico.Domain"),
                Assembly.Load("SmartDigitalPsico.Data")
            };

            var servicesToRegister = ServiceCollectionHelper.GetInterfaces(ServiceSuffix, assemblies);

            var registeredInterfaces = ServiceCollectionHelper.GetRegisteredInterfaces(services).ToArray();

            var ignoredInterfaces = new[]
            {
                typeof(ICryptoService),
                typeof(IEmailService),
                typeof(ITokenService),  
                typeof(IAuditContextService),
            };

            var servicesToAdd = ServiceCollectionHelper.FilterItems(
                servicesToRegister.Select(repo => repo.InterfaceType!).ToArray(),
                registeredInterfaces,
                ignoredInterfaces
            );

            var finalServicesToAdd = servicesToRegister.Where(service => servicesToAdd.Contains(service.InterfaceType)).ToArray();

            foreach (var service in finalServicesToAdd)
            {
                services.AddScoped(service.InterfaceType!, service.ImplementationType!);
            }
        }   
    }
}