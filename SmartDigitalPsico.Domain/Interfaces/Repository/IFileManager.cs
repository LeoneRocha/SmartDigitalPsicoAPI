using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IFileManager
    {
        Task<string> PersistFile(IFormFile? fileData, FileBase entityAdd, string folderContainer, string folderIdentity);
        Task<FileBase?> DownloadFileById(FileBase fileEntity, string folderIdentity);
        Task<bool> DeleteFile(FileBase fileEntity, string folderIdentity);
    }
}
