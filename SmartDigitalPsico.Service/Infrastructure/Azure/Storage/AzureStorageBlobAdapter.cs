using Azure.Storage.Blobs;
using Azure.Storage.Sas;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Service.Infrastructure.Azure.Storage
{
    public class AzureStorageBlobAdapter : IStorageBlobAdapter
    {
        private readonly BlobServiceClient? _blobServiceClient;
        private readonly IConfiguration? _configuration;

        public AzureStorageBlobAdapter(IConfiguration configuration)
        {
            _configuration = configuration;
            string conBSC = configuration.GetSection("StorageServices:AzureStorage")["ConnectionString"] ?? string.Empty;
            if (!string.IsNullOrEmpty(conBSC))
            {
                _blobServiceClient = new BlobServiceClient(conBSC);
            }
        }

        public AzureStorageBlobAdapter(IConfiguration configuration, BlobServiceClient blobServiceClient)
        {
            _configuration = configuration;
            _blobServiceClient = blobServiceClient;
        }

        public async Task<string> UploadFileReturnUrl(BlobFileVO blobFileVO)
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
            if (!int.TryParse(_configuration?.GetSection("StorageServices:AzureStorage")["DaysExpiresBlobSas"], out daysExpireBlobSas))
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