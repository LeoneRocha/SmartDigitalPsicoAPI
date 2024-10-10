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
            //AddMvc
            services.AddMvc(options =>
            {
                options.RespectBrowserAcceptHeader = true;

                options.FormatterMappings.SetMediaTypeMappingForFormat("xml", MediaTypeHeaderValue.Parse("application/xml"));
                options.FormatterMappings.SetMediaTypeMappingForFormat("json", MediaTypeHeaderValue.Parse("application/json"));
            })
                .AddViewLocalization()
                .AddDataAnnotationsLocalization()
                .AddXmlSerializerFormatters(); 
        }
    }
} 