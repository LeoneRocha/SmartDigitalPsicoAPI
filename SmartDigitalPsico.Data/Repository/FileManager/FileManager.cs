using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;
using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Data.Repository.FileManager
{
    public class FileManager : IFileManager
    {
        private readonly IConfiguration _configuration;
        private readonly ILocationSaveFileConfigurationVO _locationSaveFileConfigurationVO;
        private readonly IFileDiskRepository _repositoryFileDisk;
        private readonly IStorageBlobAdapter _storageClientAdapter;

        public FileManager(IConfiguration configuration
            , ILocationSaveFileConfigurationVO locationSaveFileConfigurationVO
            , IFileDiskRepository repositoryFileDisk, IStorageBlobAdapter storageClientAdapter)
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
                string pathSave = GetFilePath(folderContainer, folderIdentity, fileData.FileName);

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
                        await DeleteToDisk(folderDest, fileData.FileName, pathSave);
                        entityAdd.FileData = [];
                        break;
                }
            }
            return folderDest ?? string.Empty;
        }

        public async Task<FileBase?> DownloadFileById(FileBase fileEntity, string folderIdentity)
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
                    case ETypeLocationSaveFiles.CloudStorageAzure when _locationSaveFileConfigurationVO.TypeLocationSaveFiles == ETypeLocationSaveFiles.CloudStorageAzure:
                        await GetFileCloudAzureStorage(fileEntity, folderIdentity);
                        break;
                }
            }
            return fileEntity;
        }

        public async Task<bool> DeleteFile(FileBase fileEntity, string folderIdentity)
        {
            if (fileEntity != null)
            {
                switch (fileEntity.TypeLocationSaveFile)
                {
                    case ETypeLocationSaveFiles.Disk when _locationSaveFileConfigurationVO.TypeLocationSaveFiles == ETypeLocationSaveFiles.Disk:
                        await DeleteToDisk(string.Empty, fileEntity.FileName, fileEntity.FilePath);
                        break;
                    case ETypeLocationSaveFiles.CloudStorageAzure when _locationSaveFileConfigurationVO.TypeLocationSaveFiles == ETypeLocationSaveFiles.CloudStorageAzure:
                        await DeleteFileCloudAzureStorage(fileEntity, folderIdentity);
                        break;
                }
            }
            return true;
        }

        #region PRIVATES

        private string GetFilePath(string folderContainer, string folderIdentity, string fileName)
        {
            string pathDomainBussines = Path.Combine(DirectoryHelper.GetDiretoryTemp(_configuration), "ResourcesFileSave");
            string folderDest = Path.Combine(pathDomainBussines, folderContainer, folderIdentity);
            return Path.Combine(folderDest, fileName);
        }

        private async Task<byte[]> GetFromDisk(FileBase fileEntity)
        {
            return await _repositoryFileDisk.Get(new FileData() { FilePath = fileEntity.FilePath, FileName = fileEntity.Description, CreatedDate = DataHelper.GetDateTimeNow() }) ?? [];
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
            fileEntity.FileCloudContainer = folderContainer;
            fileEntity.FileBlobName = blobFile.BlobName;
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

        private async Task DeleteToDisk(string folderDest, string fileName, string pathSave)
        {
            await _repositoryFileDisk.Delete(new FileData()
            {
                FolderDestination = folderDest ?? string.Empty,
                FileName = fileName,
                FilePath = pathSave,
                CreatedDate = DataHelper.GetDateTimeNow()
            });
        }

        private async Task GetFileCloudAzureStorage(FileBase fileEntity, string folderIdentity)
        {
            fileEntity.FileData = [];
            fileEntity.TypeLocationSaveFile = ETypeLocationSaveFiles.CloudStorageAzure;

            var blobFile = new BlobFileVO() { FilePath = fileEntity.FilePath, BlobHeaders = BlobFileHelper.GetBlobHeadersAzure(fileEntity) };
            blobFile.BlobName = fileEntity.FileBlobName;
            blobFile.ContainerName = fileEntity.FileCloudContainer;

            //Get path
            string pathSave = GetFilePath(blobFile.ContainerName, folderIdentity, string.Empty);
            fileEntity.FilePath = Path.Combine(pathSave, "temp", fileEntity.FileName);

            // Garantir que o diretório de destino exista
            string directoryPath = Path.GetDirectoryName(fileEntity.FilePath) ?? string.Empty;
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            await DeleteFileDirectory(fileEntity.FileName, fileEntity.FilePath);

            var fileTemp = Path.Combine(DirectoryHelper.GetDiretoryTemp(_configuration), fileEntity.FileName);

            await DeleteFileDirectory(fileEntity.FileName, fileTemp);

            //Get storage and save path
            await _storageClientAdapter.DownloadFile(blobFile.ContainerName, blobFile.BlobName, fileEntity.FilePath);

            //Get by from disk
            fileEntity.FileData = await GetFromDisk(fileEntity);
            await FileHelper.GetFromByteSaveTemp(fileEntity.FileData, fileEntity.FileName, _configuration);

            await DeleteFileDirectory(fileEntity.FileName, fileEntity.FilePath);
        }

        private async Task DeleteFileDirectory(string fileName, string filePath)
        {
            if (File.Exists(filePath))
            {
                //Delete  from disk
                await DeleteToDisk(string.Empty, fileName, filePath);
            }
        }

        private async Task DeleteFileCloudAzureStorage(FileBase fileEntity, string folderIdentity)
        {
            fileEntity.FileData = [];
            fileEntity.TypeLocationSaveFile = ETypeLocationSaveFiles.CloudStorageAzure;

            var blobFile = new BlobFileVO() { FilePath = fileEntity.FilePath, BlobHeaders = BlobFileHelper.GetBlobHeadersAzure(fileEntity) };
            blobFile.BlobName = $"{folderIdentity}/{fileEntity.FileName}";
            blobFile.ContainerName = fileEntity.FileCloudContainer;

            await _storageClientAdapter.DeleteBlobAsync(blobFile.ContainerName, blobFile.BlobName);
        }

        #endregion
    }
}