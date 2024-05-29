using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;
using SmartDigitalPsico.Domain.VO.Domains;

namespace SmartDigitalPsico.Data.Repository.FileManager
{

    public class FilePersistor : IFilePersistor
    {
        private readonly IConfiguration _configuration;
        private readonly LocationSaveFileConfigurationVO _locationSaveFileConfigurationVO;
        private readonly IFileDiskRepository _repositoryFileDisk;

        public FilePersistor(IConfiguration configuration
            , IOptions<LocationSaveFileConfigurationVO> locationSaveFileConfigurationVO
            , IFileDiskRepository repositoryFileDisk)
        {
            _locationSaveFileConfigurationVO = locationSaveFileConfigurationVO.Value;
            _repositoryFileDisk = repositoryFileDisk;
            _configuration = configuration;
        }

        public async Task<string> PersistFile(IFormFile? fileData, FileBase entityAdd, string folderIdentity)
        {
            string folderDest = string.Empty;
            if (fileData != null)
            {
                string pathDomainBussines = Path.Combine(Directory.GetCurrentDirectory(), "ResourcesFileSave");
                folderDest = Path.Combine(pathDomainBussines, folderIdentity);
                var pathSave = Path.Combine(folderDest, fileData.FileName);

                byte[] fileDataSave = await FileHelper.GetByteDataFromIFormFile(fileData);

                switch (_locationSaveFileConfigurationVO.TypeLocationSaveFiles)
                {
                    case ETypeLocationSaveFiles.DataBase:
                        SaveToDatabase(entityAdd, fileDataSave);
                        break;
                    case ETypeLocationSaveFiles.Disk:
                        await SaveToDisk(folderDest, fileData, fileDataSave, pathSave);
                        entityAdd.TypeLocationSaveFile = ETypeLocationSaveFiles.Disk;
                        break;
                }
            }
            return folderDest ?? string.Empty;
        }

        public async Task<byte[]> GetFromDisk(FileBase fileEntity)
        {
            return await _repositoryFileDisk.Get(new FileData() { FilePath = fileEntity.FilePath, FileName = fileEntity.Description, CreatedDate = DataHelper.GetDateTimeNow() }) ?? [];



        }
        private static void SaveToDatabase(FileBase entityAdd, byte[] fileDataSave)
        {
            entityAdd.FileData = fileDataSave;
            entityAdd.TypeLocationSaveFile = ETypeLocationSaveFiles.DataBase;
        }

        private async Task SaveToDisk(string folderDest, IFormFile fileData, byte[] fileDataSave, string pathSave)
        {
            await _repositoryFileDisk.Save(new FileData()
            {
                FolderDestination = folderDest ?? string.Empty,
                FileData = fileDataSave,
                FileName = fileData.FileName,
                FilePath = pathSave,
                CreatedDate = DataHelper.GetDateTimeNow()
            });
        }

        public async Task<FileBase?> DownloadFileById(FileBase fileEntity)
        {
            if (fileEntity != null)
            {
                switch (fileEntity.TypeLocationSaveFile)
                {
                    case ETypeLocationSaveFiles.DataBase when _locationSaveFileConfigurationVO.TypeLocationSaveFiles == ETypeLocationSaveFiles.DataBase:
                        await FileHelper.GetFromByteSaveTemp(fileEntity.FileData, fileEntity.FileName, _configuration);
                        break;
                    case ETypeLocationSaveFiles.Disk when _locationSaveFileConfigurationVO.TypeLocationSaveFiles == ETypeLocationSaveFiles.Disk:
                        fileEntity.FileData = await GetFromDisk(fileEntity);
                        await FileHelper.GetFromByteSaveTemp(fileEntity.FileData, fileEntity.FileName, _configuration);
                        break;
                }
            }
            return fileEntity;
        }
    }
}