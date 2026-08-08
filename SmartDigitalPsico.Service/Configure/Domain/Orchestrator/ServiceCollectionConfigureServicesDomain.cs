using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SmartDigitalPsico.Core.SDK.Service.Configure.Queue;
using SmartDigitalPsico.Core.SDK.Service.Configure.Security;
using SmartDigitalPsico.Core.SDK.Service.Configure.Smtp;
using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Domain.DependeciesCollection;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Patient;
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
    /// Orquestra DI de domínio do produto + blocos Core.SDK reutilizáveis.
    /// </summary>
    public static class ServiceCollectionConfigureServicesDomain
    {
        public static void Configure(IServiceCollection services, IConfiguration _configuration)
        {
            ServicesDomainRepository.AddDependencies(services);

            ServicesDomainService.AddDependenciesManually(services);

            addDependenciesSingleton(services);

            ServicesDomainValidation.AddDependencies(services);

            services.AddCoreCrypto();

            ServicesDomainNoSql.AddDependencies(services);

            services.AddCoreSmtp();

            services.AddCoreStorageQueue(StorageQueueNameConstants.GeneralQueue);

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
