namespace SmartDigitalPsico.Domain.Interfaces
{
    public interface IPolicyConfig
    {
        string PolicyName { get; set; }
        int RetryCount { get; set; }
        int RetryDelayInSeconds { get; set; }
    }
}