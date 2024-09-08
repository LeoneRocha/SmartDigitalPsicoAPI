using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    public interface IStorageQueueRepositoryFactory
    {
        IStorageQueueContract Create(EStorageAdapterType eStorageAdapterType, string queueName); 
    }
}