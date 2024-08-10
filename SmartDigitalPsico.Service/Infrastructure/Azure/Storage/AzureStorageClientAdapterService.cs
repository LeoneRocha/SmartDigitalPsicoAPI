using Azure.Storage.Blobs;
using Azure.Storage.Sas;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Service.Infrastructure.Azure.Storage
{
    public class AzureStorageClientAdapterService : IStorageClientAdapter
    {
        private readonly BlobServiceClient? _blobServiceClient;
        private readonly IConfiguration? _configuration;

        public AzureStorageClientAdapterService(IConfiguration configuration)
        {
            _configuration = configuration;
            string conBSC = configuration.GetSection("StorageServices:AzureStorage")["ConnectionString"] ?? string.Empty;
            if (!string.IsNullOrEmpty(conBSC))
            {
                _blobServiceClient = new BlobServiceClient(conBSC);
            }
        }

        public AzureStorageClientAdapterService(IConfiguration configuration, BlobServiceClient blobServiceClient)
        {
            _configuration = configuration;
            _blobServiceClient = blobServiceClient;
        }

        public async Task<string> UploadFileReturnUrl(BlobFileVO blobFileVO)
        {
            if (_blobServiceClient != null)
            {
                await CreateContainerIfNotExists(blobFileVO.ContainerName);

                var containerClient = _blobServiceClient.GetBlobContainerClient(blobFileVO.ContainerName);

                var blobName = Path.GetFileName(blobFileVO.FilePath);

                if (!string.IsNullOrEmpty(blobFileVO.BlobName))
                {
                    blobName = blobFileVO.BlobName;
                }
                var blobClient = containerClient.GetBlobClient(blobName);

                await blobClient.UploadAsync(blobFileVO.FilePath, blobFileVO.BlobHeaders);

                return blobClient.Uri.AbsoluteUri;
            }
            return string.Empty;
        }

        public async Task CreateContainerIfNotExists(string containerName)
        {
            if (_blobServiceClient != null)
            {
                if (string.IsNullOrWhiteSpace(containerName) || containerName.Length > 63)
                {
                    throw new AppWarningException("Container Name invalid");
                }
                BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(containerName);

                await containerClient.CreateIfNotExistsAsync();
            }
        }

        public async Task<string> GetFileStorageUrlPublic(string containerName, string blobName)
        {
            if (_blobServiceClient != null)
            {
                int daysExpireBlobSas;
                if (!int.TryParse(_configuration?.GetSection("StorageServices:AzureStorage")["DaysExpiresBlobSas"], out daysExpireBlobSas))
                {
                    daysExpireBlobSas = 15;
                }
                string fileURL = string.Empty;

                BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(containerName);

                BlobClient blobClient = containerClient.GetBlobClient(blobName);

                if (blobClient.CanGenerateSasUri)
                {
                    // Define Sas
                    var blobSasBuilder = new BlobSasBuilder
                    {
                        BlobContainerName = containerName,
                        BlobName = blobName,
                        Resource = "b",
                        StartsOn = DateTimeOffset.UtcNow,
                        ExpiresOn = DateTimeOffset.UtcNow.AddDays(daysExpireBlobSas),
                    };
                    // SetPermissions
                    blobSasBuilder.SetPermissions(BlobSasPermissions.Read);

                    Uri sasURI = blobClient.GenerateSasUri(blobSasBuilder);
                    if (sasURI != null)
                    {
                        fileURL = sasURI.ToString();
                    }
                }
                await Task.Delay(50);
                return fileURL;
            }
            return string.Empty;
        }

        public async Task DownloadFile(string containerName, string blobName, string targetPath)
        {
            if (_blobServiceClient != null)
            {
                BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(containerName);

                BlobClient blobClient = containerClient.GetBlobClient(blobName);

                using (FileStream downloadFileStream = File.OpenWrite(targetPath))
                {
                    await blobClient.DownloadToAsync(downloadFileStream);
                }
            }
        }
        public async Task DeleteBlobAsync(string containerName, string blobName)
        {
            if (_blobServiceClient != null)
            {
                BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(containerName);
                BlobClient blobClient = containerClient.GetBlobClient(blobName);

                await blobClient.DeleteIfExistsAsync();
            }
        }
    }
}