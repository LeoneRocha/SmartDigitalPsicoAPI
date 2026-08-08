using SmartDigitalPsico.Core.SDK.Domain.DTO;
using SmartDigitalPsico.Core.SDK.Domain.Security;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure
{
    /// <summary>
    /// Interface (contrato) responsável por IStorageBlobAdapter.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IStorageBlobAdapter
    {
        /// <summary>
        /// Método CreateContainerIfNotExists: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task CreateContainerIfNotExists(string containerName);
        /// <summary>
        /// Método DownloadFile: executa a operação DownloadFile.
        /// </summary>
        Task DownloadFile(string containerName, string blobName, string targetPath);
        /// <summary>
        /// Método GetFileStorageUrlPublic: consulta e retorna dados.
        /// </summary>
        Task<string> GetFileStorageUrlPublic(string containerName, string blobName);
        /// <summary>
        /// Método UploadFileReturnUrl: executa a operação UploadFileReturnUrl.
        /// </summary>
        Task<string> UploadFileReturnUrl(BlobFileDto blobFileVO);

        /// <summary>
        /// Método DeleteBlobAsync: remove ou cancela um registro/recurso.
        /// </summary>
        Task DeleteBlobAsync(string containerName, string blobName);
    }
}
