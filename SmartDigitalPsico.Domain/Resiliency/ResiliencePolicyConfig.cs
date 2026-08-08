using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.Resiliency
{
    /// <summary>
    /// Classe responsável por ResiliencePolicyConfig.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class ResiliencePolicyConfig : SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig
    {
        public string PolicyName { get; set; } = string.Empty;
        public int RetryCount { get; set; }
        public int RetryDelayInSeconds { get; set; }
    }
}
