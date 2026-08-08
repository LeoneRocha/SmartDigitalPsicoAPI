using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.Documentation;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Wrapper host: Swagger genérico no Core.SDK com metadados do produto.
    /// </summary>
    public static class ServiceCollectionConfigureDocumentation
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddCoreSwagger(
                title: "SmartDigitalPsico.WebAPI",
                description: "API REST do Smart Digital Psico para gestão clínica, agenda, pacientes e configurações do sistema.",
                version: LogAppHelper.GetAssemblyVersion());
        }
    }
}
