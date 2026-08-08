using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SmartDigitalPsico.Domain.DependeciesCollection;
using SmartDigitalPsico.Domain.Interfaces.Collection;


namespace SmartDigitalPsico.Service.Configure.Domain
{
    /// <summary>
    /// Classe responsável por ServiceCollectionConfigureServicesDomain.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServiceCollectionConfigureServicesDomain
    {
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public static void Configure(IServiceCollection services, IConfiguration _configuration)
        {
            ServicesDomainRepository.AddDependencies(services);

            ServicesDomainService.AddDependenciesManually(services);

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

            ServicesDomainService.AddDependenciesAuto(services);
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

            services.AddSingleton<SmartDigitalPsico.Core.SDK.Domain.Interfaces.ITokenService, SmartDigitalPsico.Core.SDK.Domain.Security.TokenService>();
            services.AddSingleton<SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig, SmartDigitalPsico.Core.SDK.Domain.Resiliency.ResiliencePolicyConfig>();
            services.AddSingleton<SmartDigitalPsico.Core.SDK.Domain.Interfaces.ILocationSaveFileConfigurationDto, SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.LocationSaveFileConfigurationDto>();
        } 
    }
}
