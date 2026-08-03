using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Classe responsável por ServiceCollectionConfigureHeader.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServiceCollectionConfigureHeader
    {
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
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
