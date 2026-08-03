using Azure.Storage.Blobs;
using Azure.Storage.Sas;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Service.Infrastructure.Azure.Storage
{
    /// <summary>
    /// Classe responsável por AzureStorageBlobAdapter.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class AzureStorageBlobAdapter : IStorageBlobAdapter
    {
        private readonly BlobServiceClient? _blobServiceClient;
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Método AzureStorageBlobAdapter: executa a operação AzureStorageBlobAdapter.
        /// </summary>
        public AzureStorageBlobAdapter(IConfiguration configuration)
        {
            _configuration = configuration;
            string conBSC = ConfigurationAppSettingsHelper.GetStorageServicesAzureStorageConnectionString(configuration);
            if (!string.IsNullOrEmpty(conBSC))
            {
                _blobServiceClient = new BlobServiceClient(conBSC);
            }
        }

        /// <summary>
        /// Método AzureStorageBlobAdapter: executa a operação AzureStorageBlobAdapter.
        /// </summary>
        public AzureStorageBlobAdapter(IConfiguration configuration, BlobServiceClient blobServiceClient)
        {
            _configuration = configuration;
            _blobServiceClient = blobServiceClient;
        }

        /// <summary>
        /// Método UploadFileReturnUrl: executa a operação UploadFileReturnUrl.
        /// </summary>
        public async Task<string> UploadFileReturnUrl(BlobFileDto blobFileVO)
        {
            if (_blobServiceClient == null)
            {
                return string.Empty;
            }

            await CreateContainerIfNotExists(blobFileVO.ContainerName);

            var containerClient = _blobServiceClient.GetBlobContainerClient(blobFileVO.ContainerName);
            var blobName = !string.IsNullOrEmpty(blobFileVO.BlobName) ? blobFileVO.BlobName : Path.GetFileName(blobFileVO.FilePath);
            var blobClient = containerClient.GetBlobClient(blobName);

            await blobClient.UploadAsync(blobFileVO.FilePath, blobFileVO.BlobHeaders);

            return blobClient.Uri.AbsoluteUri;
        }

        /// <summary>
        /// Método CreateContainerIfNotExists: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task CreateContainerIfNotExists(string containerName)
        {
            if (_blobServiceClient == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(containerName) || containerName.Length > 63)
            {
                throw new AppWarningException("Container Name invalid");
            }

            var containerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            await containerClient.CreateIfNotExistsAsync();
        }
        /// <summary>
        /// Método GetFileStorageUrlPublic: consulta e retorna dados.
        /// </summary>
        public async Task<string> GetFileStorageUrlPublic(string containerName, string blobName)
        {
            if (_blobServiceClient == null)
            {
                return string.Empty;
            }

            if (string.IsNullOrWhiteSpace(containerName) || string.IsNullOrWhiteSpace(blobName))
            {
                throw new ArgumentException("Container name and blob name must be provided.");
            }

            int daysExpireBlobSas;
            if (!int.TryParse(ConfigurationAppSettingsHelper.GetStorageServicesAzureStorageDaysExpiresBlobSas(_configuration), out daysExpireBlobSas))
            {
                daysExpireBlobSas = 15;
            }

            var containerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            var blobClient = containerClient.GetBlobClient(blobName);

            if (!blobClient.CanGenerateSasUri)
            {
                return string.Empty;
            }

            var blobSasBuilder = new BlobSasBuilder
            {
                BlobContainerName = containerName,
                BlobName = blobName,
                Resource = "b",
                StartsOn = DateTimeOffset.UtcNow,
                ExpiresOn = DateTimeOffset.UtcNow.AddDays(daysExpireBlobSas),
            };

            blobSasBuilder.SetPermissions(BlobSasPermissions.Read);

            Uri sasUri = blobClient.GenerateSasUri(blobSasBuilder);
            await Task.Delay(1);
            return sasUri?.ToString() ?? string.Empty;
        }
        /// <summary>
        /// Método DownloadFile: executa a operação DownloadFile.
        /// </summary>
        public async Task DownloadFile(string containerName, string blobName, string targetPath)
        {
            if (_blobServiceClient == null)
            {
                return;
            }

            var containerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            var blobClient = containerClient.GetBlobClient(blobName);

            await using (var downloadFileStream = File.OpenWrite(targetPath))
            {
                await blobClient.DownloadToAsync(downloadFileStream);
            }
        }

        /// <summary>
        /// Método DeleteBlobAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task DeleteBlobAsync(string containerName, string blobName)
        {
            if (_blobServiceClient == null)
            {
                throw new InvalidOperationException("BlobServiceClient is not initialized.");
            }

            BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            BlobClient blobClient = containerClient.GetBlobClient(blobName);

            await blobClient.DeleteIfExistsAsync();
        } 
    }
}
