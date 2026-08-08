namespace SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces
{
    /// <summary>
    /// Interface (contrato) responsÃ¡vel por IResiliencePolicyConfig.
    /// Responsabilidade: contrato de abstraÃ§Ã£o do domÃ­nio.
    /// RelaÃ§Ã£o: implementado nas camadas Data/Service.
    /// </summary>
    public interface IResiliencePolicyConfig
    {
        string PolicyName { get; set; }
        int RetryCount { get; set; }
        int RetryDelayInSeconds { get; set; }
    }
}

