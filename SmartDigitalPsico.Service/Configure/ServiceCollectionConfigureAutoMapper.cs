using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Mapper;

namespace SmartDigitalPsico.Service.Configure
{
    public static class ServiceCollectionConfigureAutoMapper
    {
        public static void Configure(IServiceCollection services)
        {
            // Auto Mapper 
            services.AddAutoMapper(typeof(AutoMapperProfile));
        } 
    }
}