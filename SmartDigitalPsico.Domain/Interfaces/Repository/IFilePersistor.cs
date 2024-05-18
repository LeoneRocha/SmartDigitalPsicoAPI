using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;
using SmartDigitalPsico.Domain.VO.Medical.MedicalFile;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IFilePersistor
    {
        Task<string> PersistFile(IFormFile? fileData, FileBase entityAdd, string folderIdentity);

        Task<byte[]> GetFromDisk(FileBase fileEntity);

        Task<FileBase?> DownloadFileById(FileBase fileEntity);
    }
}
