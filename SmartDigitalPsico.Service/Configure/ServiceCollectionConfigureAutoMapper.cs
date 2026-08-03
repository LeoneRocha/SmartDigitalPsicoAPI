using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Mapper;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Classe responsável por ServiceCollectionConfigureAutoMapper.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServiceCollectionConfigureAutoMapper
    {
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public static void Configure(IServiceCollection services)
        {
            // AutoMapper 15+: AddAutoMapper requires Action<IMapperConfigurationExpression>.
            // LicenseKey optional here — falls back to AUTOMAPPER_LICENSE_KEY / LUCKYPENNY_LICENSE_KEY.
            services.AddAutoMapper(cfg =>
            {
                cfg.AddMaps(typeof(AutoMapperProfile));
            });
        }
    }
}
