using Azure.Data.Tables;

namespace SmartDigitalPsico.Domain.Interfaces.TableEntity
{
    public interface IStorageTableServiceFactory
    {
        IStorageTableAdapter<T> Create<T>(string tableName) where T : class, ITableEntity, new(); 
    }
} 