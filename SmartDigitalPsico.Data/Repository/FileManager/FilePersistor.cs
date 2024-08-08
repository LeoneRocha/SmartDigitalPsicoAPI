using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;
using SmartDigitalPsico.Domain.Security;
using SmartDigitalPsico.Domain.VO.Domains;

namespace SmartDigitalPsico.Data.Repository.FileManager
{

    public class FilePersistor : IFilePersistor
    {
        private readonly IConfiguration _configuration;
        private readonly ILocationSaveFileConfigurationVO _locationSaveFileConfigurationVO;
        private readonly IFileDiskRepository _repositoryFileDisk;
        private readonly IStorageClientAdapter _storageClientAdapter;

        public FilePersistor(IConfiguration configuration
            , ILocationSaveFileConfigurationVO locationSaveFileConfigurationVO
            , IFileDiskRepository repositoryFileDisk, IStorageClientAdapter storageClientAdapter)
        {
            _locationSaveFileConfigurationVO = locationSaveFileConfigurationVO;
            _repositoryFileDisk = repositoryFileDisk;
            _configuration = configuration;
            _storageClientAdapter = storageClientAdapter;
        }

        public async Task<string> PersistFile(IFormFile? fileData, FileBase entityAdd, string folderContainer, string folderIdentity)
        {
            string folderDest = string.Empty;
      

            if (fileData != null)
            {
                string pathDomainBussines = Path.Combine(DirectoryHelper.GetDiretoryTemp(_configuration), "ResourcesFileSave");
                folderDest = Path.Combine(pathDomainBussines, folderContainer, folderIdentity);
                var pathSave = Path.Combine(folderDest, fileData.FileName);

                byte[] fileDataSave = await FileHelper.GetByteDataFromIFormFile(fileData);

                switch (_locationSaveFileConfigurationVO.TypeLocationSaveFiles)
                {
                    case ETypeLocationSaveFiles.DataBase:
                        SaveToDatabase(entityAdd, fileDataSave);
                        break;
                    case ETypeLocationSaveFiles.Disk: 
                        await SaveToDisk(folderDest, fileData, fileDataSave, pathSave);
                        entityAdd.FilePath = pathSave;
                        entityAdd.TypeLocationSaveFile = ETypeLocationSaveFiles.Disk;
                        break;
                    case ETypeLocationSaveFiles.CloudStorageAzure:
                        await SaveToDisk(folderDest, fileData, fileDataSave, pathSave);
                        entityAdd.FilePath = pathSave;
                        await SaveCloudStorageAzure(entityAdd, folderContainer, folderIdentity);
                        await DeleteToDisk(folderDest, fileData, fileDataSave, pathSave);
                        break;
                }
            }
            return folderDest ?? string.Empty;
        }

        private async Task SaveCloudStorageAzure(FileBase fileEntity, string folderContainer, string folderIdentity)
        {
            fileEntity.FileData = [];
            fileEntity.TypeLocationSaveFile = ETypeLocationSaveFiles.CloudStorageAzure;

            var blobFile = new BlobFileVO() { FilePath = fileEntity.FilePath, BlobHeaders = BlobFileHelper.GetBlobHeadersAzure(fileEntity) };
            blobFile.BlobName = $"{folderIdentity}/{fileEntity.FileName}";
            blobFile.ContainerName = folderContainer;
            string fileURL = await _storageClientAdapter.UploadFileReturnUrl(blobFile);

            fileEntity.FilePath = fileURL;
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

        private async Task DeleteToDisk(string folderDest, IFormFile fileData, byte[] fileDataSave, string pathSave)
        {
            await _repositoryFileDisk.Delete(new FileData()
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