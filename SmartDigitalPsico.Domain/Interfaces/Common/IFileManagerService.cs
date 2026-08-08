using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Core.SDK.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Domain.Interfaces.Common
{
    /// <summary>
    /// Contrato de serviço para persistência/download/exclusão de arquivos (disco, DB, Azure).
    /// </summary>
    public interface IFileManagerService
    {
        Task<string> PersistFile(IFormFile? fileData, FileBase entityAdd, string folderContainer, string folderIdentity);
        Task<FileBase?> DownloadFileById(FileBase fileEntity, string folderIdentity);
        Task<bool> DeleteFile(FileBase fileEntity, string folderIdentity);
    }
}
