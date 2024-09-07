namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    public interface IStorageQueueContract
    {
        Task EnqueueMessageAsync(string message);
        Task<string> DequeueMessageAsync();
        Task DeleteMessageAsync(string messageId, string popReceipt);
    }
}