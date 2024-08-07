using Azure.Storage.Blobs;
using Azure.Storage.Sas;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Service.Infrastructure.Azure.Storage
{
    public class AzureStorageClientAdapterService : IStorageClientAdapter

    {
        private readonly BlobServiceClient _blobServiceClient;
        private readonly IConfiguration? _configuration;

        public AzureStorageClientAdapterService(IConfiguration configuration)
        {
            _configuration = configuration;
            _blobServiceClient = new BlobServiceClient(configuration.GetSection("StorageServices:AzureStorage")["ConnectionString"] ?? string.Empty);
        }

        public AzureStorageClientAdapterService(IConfiguration configuration, BlobServiceClient blobServiceClient)
        {
            _configuration = configuration;
            _blobServiceClient = blobServiceClient;
        }

        public async Task<string> UploadFileReturnUrl(BlobFileVO blobFileVO)
        {
            await CreateContainerIfNotExists(blobFileVO.ContainerName);

            var containerClient = _blobServiceClient.GetBlobContainerClient(blobFileVO.ContainerName);

            var blobHttpHeaders = AzureStorageHelper.GetBlobHeaders(blobFileVO.FilePath);
            if (blobFileVO.BlobHeaders != null)
            {
                blobHttpHeaders = blobFileVO.BlobHeaders;
            }
            var blobName = Path.GetFileName(blobFileVO.FilePath);

            if (!string.IsNullOrEmpty(blobFileVO.BlobName))
            {
                blobName = blobFileVO.BlobName;
            }
            var blobClient = containerClient.GetBlobClient(blobName);

            await blobClient.UploadAsync(blobFileVO.FilePath, blobHttpHeaders);

            return blobClient.Uri.AbsoluteUri;
        }

        public async Task CreateContainerIfNotExists(string containerName)
        {
            if (string.IsNullOrWhiteSpace(containerName) || containerName.Length > 63)
            {
                throw new AppWarningException("Container Name invalid");
            }
            BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(containerName);

            await containerClient.CreateIfNotExistsAsync();
        }

        public async Task<string> GetFileStorageUrlPublic(string containerName, string blobName)
        {
            int daysExpireBlobSas;
            if (!int.TryParse(_configuration?.GetSection("StorageServices:AzureStorage")["DaysExpiresBlobSas"], out daysExpireBlobSas))
            {
                daysExpireBlobSas = 15;
            }
            string transcriptTextUrl = string.Empty;

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
                    transcriptTextUrl = sasURI.ToString();
                }
            }
            await Task.Delay(50);
            return transcriptTextUrl;

        }

        public async Task DownloadFile(string containerName, string blobName, string targetPath)
        {
            BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(containerName);

            BlobClient blobClient = containerClient.GetBlobClient(blobName);

            using (FileStream downloadFileStream = File.OpenWrite(targetPath))
            {
                await blobClient.DownloadToAsync(downloadFileStream);
            }
        }
    }


}
