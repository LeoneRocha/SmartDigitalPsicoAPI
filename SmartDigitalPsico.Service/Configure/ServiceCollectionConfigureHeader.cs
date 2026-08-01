using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;

namespace SmartDigitalPsico.Service.Configure
{
    public static class ServiceCollectionConfigureHeader
    {
        public static void Configure(IServiceCollection services)
        {
            //AcceptHeader 
            services.AddControllers();

            addAddMvc(services);
        }
        private static void addAddMvc(IServiceCollection services)
        {
            // JSON only — XmlSerializerFormatters geravam WRN em DTOs sem setter / FileStream
            services.AddMvc(options =>
            {
                options.RespectBrowserAcceptHeader = true;
                options.FormatterMappings.SetMediaTypeMappingForFormat("json", MediaTypeHeaderValue.Parse("application/json"));
            })
                .AddViewLocalization()
                .AddDataAnnotationsLocalization(); 
        }
    }
} 