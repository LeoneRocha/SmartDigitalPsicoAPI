using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;

namespace SmartDigitalPsico.Core.SDK.Infrastructure.Mapping
{
    /// <summary>
    /// Extensões DI para registrar IAppMapper sobre AutoMapper.
    /// </summary>
    public static class AppMapperServiceCollectionExtensions
    {
        /// <summary>
        /// Registra <see cref="IAppMapper"/> (scoped, alinhado ao <see cref="AutoMapper.IMapper"/> do AddAutoMapper)
        /// adaptando o mapper do container ou o <paramref name="mapper"/> informado.
        /// </summary>
        public static IServiceCollection AddAppMapper(this IServiceCollection services, AutoMapper.IMapper? mapper = null)
        {
            if (mapper is not null)
            {
                services.AddSingleton(mapper);
                services.AddSingleton<IAppMapper>(_ => new AutoMapperAppMapperAdapter(mapper));
                return services;
            }

            services.AddScoped<IAppMapper>(sp =>
                new AutoMapperAppMapperAdapter(sp.GetRequiredService<AutoMapper.IMapper>()));

            return services;
        }
    }
}
