using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IFileManager.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IFileManager
    {
        /// <summary>
        /// Método PersistFile: executa a operação PersistFile.
        /// </summary>
        Task<string> PersistFile(IFormFile? fileData, FileBase entityAdd, string folderContainer, string folderIdentity);
        /// <summary>
        /// Método DownloadFileById: executa a operação DownloadFileById.
        /// </summary>
        Task<FileBase?> DownloadFileById(FileBase fileEntity, string folderIdentity);
        /// <summary>
        /// Método DeleteFile: remove ou cancela um registro/recurso.
        /// </summary>
        Task<bool> DeleteFile(FileBase fileEntity, string folderIdentity);
    }
}
