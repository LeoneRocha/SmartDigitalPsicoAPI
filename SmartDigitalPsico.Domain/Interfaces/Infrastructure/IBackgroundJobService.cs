namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    public interface IBackgroundJobService
    {
        Task ExecuteNotificationProcessAsync();
    }
}
