namespace SmartDigitalPsico.Domain.Interfaces
{
    public interface IResiliencePolicyConfig
    {
        string PolicyName { get; set; }
        int RetryCount { get; set; }
        int RetryDelayInSeconds { get; set; }
    }
}