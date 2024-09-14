using Azure.Data.Tables;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Service.Infrastructure.Azure.Storage
{
    public class AzureStorageTableAdapter<T> : IStorageTableContract<T> where T : BaseEntityTable, new()
    {
        private readonly TableClient? _tableClient;
        public AzureStorageTableAdapter(IConfiguration configuration, string tableName)
        {
            string storageConnectionString = ConfigurationAppSettingsHelper.GetStorageServicesAzureStorageConnectionString(configuration);
            
            if (!string.IsNullOrEmpty(storageConnectionString))
            {
                var serviceClient = new TableServiceClient(storageConnectionString);
                _tableClient = serviceClient.GetTableClient(tableName);
                _tableClient.CreateIfNotExists();
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = new List<T>();

            if (_tableClient == null)
            {
                return entities;
            }

            await foreach (var entity in _tableClient.QueryAsync<T>())
            {
                entities.Add(entity);
            }
            return entities;
        }

        public async Task<T> GetByIdAsync(string partitionKey, string rowKey)
        {
            if (_tableClient == null)
            {
                return new T();
            }
            var response = await _tableClient.GetEntityIfExistsAsync<T>(partitionKey, rowKey);
            try
            {
                return response.Value ?? new T();
            }
            catch (Exception)
            {
                return new T();
            }
        }

        public async Task InsertAsync(T entity)
        {
            if (_tableClient == null)
            {
                return;
            }
            await _tableClient.AddEntityAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            if (_tableClient == null)
            {
                return;
            }
            await _tableClient.UpdateEntityAsync(entity, entity.ETag, TableUpdateMode.Replace);
        }

        public async Task DeleteAsync(string partitionKey, string rowKey)
        {
            if (_tableClient == null)
            {
                return;
            }
            await _tableClient.DeleteEntityAsync(partitionKey, rowKey);
        }
    }
} 