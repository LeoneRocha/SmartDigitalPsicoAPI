using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.Resiliency
{
    public class PolicyConfig : IPolicyConfig
    {
        public string PolicyName { get; set; } = string.Empty;
        public int RetryCount { get; set; }
        public int RetryDelayInSeconds { get; set; }
    }
}