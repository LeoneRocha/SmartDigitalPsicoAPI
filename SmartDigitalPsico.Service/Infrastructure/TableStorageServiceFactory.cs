using Azure.Data.Tables;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsico.Service.Infrastructure
{
    public class TableStorageServiceFactory : IStorageTableServiceFactory
    {
        private readonly IConfiguration _configuration;
        public TableStorageServiceFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IStorageTableAdapter<T> Create<T>(string tableName) where T : class, ITableEntity, new()
        { 
            return new AzureStorageTableAdapter<T>(_configuration, tableName);
        }
    }
}
