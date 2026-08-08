namespace SmartDigitalPsico.Core.SDK.Domain.Resiliency
{
    /// <summary>
    /// Configuração de política de resiliência (retry) ligada a appsettings.
    /// </summary>
    public class ResiliencePolicyConfig : Interfaces.IResiliencePolicyConfig
    {
        public string PolicyName { get; set; } = string.Empty;
        public int RetryCount { get; set; }
        public int RetryDelayInSeconds { get; set; }
    }
}
