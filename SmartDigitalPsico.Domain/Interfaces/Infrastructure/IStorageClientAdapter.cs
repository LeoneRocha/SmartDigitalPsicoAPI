using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    public interface IStorageClientAdapter
    {
        Task CreateContainerIfNotExists(string containerName);
        Task DownloadFile(string containerName, string blobName, string targetPath);
        Task<string> GetFileStorageUrlPublic(string containerName, string blobName);
        Task<string> UploadFileReturnUrl(BlobFileVO blobFileVO);

        Task DeleteBlobAsync(string containerName, string blobName);
    }
}