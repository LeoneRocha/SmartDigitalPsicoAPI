using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Mapper;
using SmartDigitalPsico.Service.Mapper;

namespace SmartDigitalPsico.Service.Configure
{
    public static class ServiceCollectionConfigureAutoMapper
    {
        public static void Configure(IServiceCollection services)
        {
            // AutoMapper 15+: AddAutoMapper requires Action<IMapperConfigurationExpression>.
            // LicenseKey optional here — falls back to AUTOMAPPER_LICENSE_KEY / LUCKYPENNY_LICENSE_KEY.
            // Register both profile assemblies in a single call (subsequent AddAutoMapper calls are ignored).
            services.AddAutoMapper(cfg =>
            {
                cfg.AddMaps(typeof(AutoMapperProfile), typeof(ScheduleBatchProfile));
            });
        }
    }
}
