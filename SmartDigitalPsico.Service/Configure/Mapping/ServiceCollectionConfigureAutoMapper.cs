using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.Mapping;
using SmartDigitalPsico.Domain.Mapper;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Wrapper host: registra perfis de produto + IAppMapper via Core.SDK.
    /// </summary>
    public static class ServiceCollectionConfigureAutoMapper
    {
        public static void Configure(IServiceCollection services)
            => services.AddCoreMapper(typeof(AutoMapperProfile));
    }
}
