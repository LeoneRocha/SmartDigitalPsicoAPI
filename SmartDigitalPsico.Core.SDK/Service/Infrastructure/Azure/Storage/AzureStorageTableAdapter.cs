using Azure.Data.Tables;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage
{
    /// <summary>
    /// Classe responsável por AzureStorageTableAdapter.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class AzureStorageTableAdapter<T> : IStorageTableContract<T> where T : BaseEntityTable, new()
    {
        private readonly TableClient? _tableClient;
        /// <summary>
        /// Método AzureStorageTableAdapter: executa a operação AzureStorageTableAdapter.
        /// </summary>
        public AzureStorageTableAdapter(IConfiguration configuration, string tableName)
        {
            string storageConnectionString = configuration.GetSection("StorageServices:AzureStorage")["ConnectionString"] ?? string.Empty;
            
            if (!string.IsNullOrEmpty(storageConnectionString))
            {
                var serviceClient = new TableServiceClient(storageConnectionString);
                _tableClient = serviceClient.GetTableClient(tableName);
                _tableClient.CreateIfNotExists();
            }
        }

        public AzureStorageTableAdapter(TableClient tableClient)
        {
            _tableClient = tableClient;
        }

        /// <summary>
        /// Método GetAllAsync: consulta e retorna dados.
        /// </summary>
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

        /// <summary>
        /// Método GetByIdAsync: consulta e retorna dados.
        /// </summary>
        public async Task<T> GetByIdAsync(string partitionKey, string rowKey)
        {
            if (_tableClient == null)
            {
                return new T();
            }
            var response = await _tableClient.GetEntityIfExistsAsync<T>(partitionKey, rowKey);
            try
            {
                return response.HasValue ? response.Value ?? new T() : new T();
            }
            catch (Exception)
            {
                return new T();
            }
        }

        /// <summary>
        /// Método InsertAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task InsertAsync(T entity)
        {
            if (_tableClient == null)
            {
                return;
            }
            await _tableClient.AddEntityAsync(entity);
        }

        /// <summary>
        /// Método UpdateAsync: atualiza um registro/recurso existente.
        /// </summary>
        public async Task UpdateAsync(T entity)
        {
            if (_tableClient == null)
            {
                return;
            }
            await _tableClient.UpdateEntityAsync(entity, entity.ETag, TableUpdateMode.Replace);
        }

        /// <summary>
        /// Método DeleteAsync: remove ou cancela um registro/recurso.
        /// </summary>
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
