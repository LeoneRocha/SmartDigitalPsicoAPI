namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces
{
    /// <summary>
    /// Interface (contrato) responsável por IResiliencePolicyConfig.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IResiliencePolicyConfig
    {
        string PolicyName { get; set; }
        int RetryCount { get; set; }
        int RetryDelayInSeconds { get; set; }
    }
}

