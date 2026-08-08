using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.Smtp;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    /// <summary>
    /// Wrapper host: SMTP/e-mail Core.SDK.
    /// </summary>
    public static class ServicesDomainSmtp
    {
        public static void AddDependencies(IServiceCollection services)
            => services.AddCoreSmtp();
    }
}
