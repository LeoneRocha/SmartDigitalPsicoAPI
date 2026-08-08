using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Security;
using SmartDigitalPsico.Core.SDK.Service.Configure.Security;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Wrapper host: delega JWT Bearer para o Core.SDK.
    /// </summary>
    public static class ServiceCollectionConfigureSecurity
    {
        public static void Configure(IServiceCollection services, TokenConfigurationDto tokenConfigurations)
            => services.AddCoreJwtBearer(tokenConfigurations);
    }
}
