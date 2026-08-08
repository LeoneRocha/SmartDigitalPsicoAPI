using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Security;
using SmartDigitalPsico.Service.Security;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    /// <summary>
    /// Classe responsável por ServicesDomainSecurity.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServicesDomainSecurity
    {
        /// <summary>
        /// Método AddDependencies: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddDependencies(IServiceCollection services)
        { 
            services.AddTransient<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Security.ICryptoAdapterFactory, SmartDigitalPsicoAPI.Core.SDK.Domain.Security.CryptoAdapterFactory>();
            services.AddTransient<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Security.ICryptoService, SmartDigitalPsicoAPI.Core.SDK.Domain.Security.CryptoService>();
        }
    }
}
