using SmartDigitalPsico.Domain.Mapper;

namespace SmartDigitalPsico.WebAPI.Configure.Services
{
    public static class ApplicationConfigureAutoMapper
    {
        public static void Configure(IServiceCollection services)
        {
            // Auto Mapper 
            services.AddAutoMapper(typeof(AutoMapperProfile));
        }

    }
}