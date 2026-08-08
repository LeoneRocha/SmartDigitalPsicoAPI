using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.Mvc;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Wrapper host: delega Controllers/MVC JSON para o Core.SDK.
    /// </summary>
    public static class ServiceCollectionConfigureHeader
    {
        public static void Configure(IServiceCollection services)
            => services.AddCoreMvcControllers();
    }
}
