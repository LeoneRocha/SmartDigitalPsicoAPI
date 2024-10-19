using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SmartDigitalPsico.Domain.DependeciesCollection;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Resiliency;
using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServiceCollectionConfigureServicesDomain
    {
        public static void Configure(IServiceCollection services, IConfiguration _configuration)
        {
            ServicesDomainRepository.AddDependencies(services);

            ServicesDomainService.AddDependencies(services);

            addDependenciesSingleton(services);

            ServicesDomainValidation.AddDependencies(services);

            ServicesDomainSecurity.AddDependencies(services);

            ServicesDomainNoSql.AddDependencies(services);

            ServicesDomainSmtp.AddDependencies(services);

            ServicesDomainQueue.AddDependencies(services);

            addCollectionDependencies(services);

            ServicesDomainReport.AddDependencies(services);

            ServicesDomainAudit.AddDependencies(services);

            ServicesDomainAuthentication.AddDependencies(services);
        }
        private static void addCollectionDependencies(IServiceCollection services)
        {
            services.AddScoped<IPatientRecordServiceConfig, PatientRecordServiceConfig>();
            services.AddScoped<IPatientRepositories, PatientRepositories>();
            services.AddScoped<ISharedDependenciesConfig, SharedDependenciesConfig>();
            services.AddScoped<ISharedRepositories, SharedRepositories>();
            services.AddScoped<ISharedServices, SharedServices>();
            services.AddScoped<IMedicalCalendarValidators, MedicalCalendarValidators>();
        } 
        private static void addDependenciesSingleton(IServiceCollection services)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSingleton<ITokenService, TokenService>();
            services.AddSingleton<IResiliencePolicyConfig, ResiliencePolicyConfig>();
            services.AddSingleton<ILocationSaveFileConfigurationDto, LocationSaveFileConfigurationDto>();
        } 
    }
}