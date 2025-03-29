using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Mapper;
using SmartDigitalPsico.Service.Mapper;

namespace SmartDigitalPsico.Service.Configure
{
    public static class ServiceCollectionConfigureAutoMapper
    {
        public static void Configure(IServiceCollection services)
        {
            // Auto Mapper 
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddAutoMapper(typeof(ScheduleBatchProfile));

        }
    }
}