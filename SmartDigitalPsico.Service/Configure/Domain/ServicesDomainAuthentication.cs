using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Service.Infrastructure.Authentication;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainAuthentication
    {
        public static void AddDependencies(IServiceCollection services)
        {

            services.AddScoped<IUserTokenSessionRepository, UserTokenSessionRepository>();
            services.AddScoped<ITokenSessionPersistenceFactory, TokenSessionPersistenceFactory>();
            services.AddScoped<ITokenSessionPersistenceService, TokenSessionService>();
        }
    }
}
