using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;
using FileData = SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts.FileData;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;
namespace SmartDigitalPsico.Service.Infrastructure.FileManager
{
    /// <summary>
    /// Serviço de arquivos: orquestra disco, banco e Azure Blob.
    /// </summary>
    public class FileManagerService : IFileManagerService
    {
        private readonly IConfiguration _configuration;
        private readonly ILocationSaveFileConfigurationDto _locationSaveFileConfigurationVO;
        private readonly SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IFileDiskRepository _repositoryFileDisk;
        private readonly SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter _storageClientAdapter;

        public FileManagerService(
            IConfiguration configuration,
            ILocationSaveFileConfigurationDto locationSaveFileConfigurationVO,
            SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IFileDiskRepository repositoryFileDisk,
            SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter storageClientAdapter)
        {
            _locationSaveFileConfigurationVO = locationSaveFileConfigurationVO;
            _repositoryFileDisk = repositoryFileDisk;
            _configuration = configuration;
            _storageClientAdapter = storageClientAdapter;
        }

        /// <summary>
        /// Operação PersistFile: executa a operação PersistFile.
        /// </summary>
        public async Task<string> PersistFile(IFormFile? fileData, FileBase entityAdd, string folderContainer, string folderIdentity)
        {
            string folderDest = string.Empty;
            if (fileData != null)
            {
                string pathDomainBussines = Path.Combine(SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretoryTemp(_configuration), "ResourcesFileSave");
                folderDest = Path.Combine(pathDomainBussines, folderContainer, folderIdentity);
                string pathSave = GetFilePath(folderContainer, folderIdentity, fileData.FileName);

                byte[] fileDataSave = await SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetByteDataFromIFormFile(fileData);

                switch (_locationSaveFileConfigurationVO.TypeLocationSaveFiles)
                {
                    case SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.DataBase:
                        SaveToDatabase(entityAdd, fileDataSave);
                        break;
                    case SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.Disk:
                        await SaveToDisk(folderDest, fileData, fileDataSave, pathSave);
                        entityAdd.FilePath = pathSave;
                        entityAdd.TypeLocationSaveFile = SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.Disk;
                        break;
                    case SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.CloudStorageAzure:
                        await SaveToDisk(folderDest, fileData, fileDataSave, pathSave);
                        entityAdd.FilePath = pathSave;
                        await SaveCloudStorageAzure(entityAdd, folderContainer, folderIdentity);
                        await DeleteToDisk(folderDest, fileData.FileName, pathSave);
                        entityAdd.FileData = [];
                        break;
                }
            }
            return folderDest;
        }

        /// <summary>
        /// Operação DownloadFileById: executa a operação DownloadFileById.
        /// </summary>
        public async Task<FileBase?> DownloadFileById(FileBase fileEntity, string folderIdentity)
        {
            if (fileEntity != null)
            {
                switch (fileEntity.TypeLocationSaveFile)
                {
                    case SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.DataBase when _locationSaveFileConfigurationVO.TypeLocationSaveFiles == SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.DataBase:
                        await SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetFromByteSaveTemp(fileEntity.FileData, fileEntity.FileName, _configuration);
                        break;
                    case SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.Disk when _locationSaveFileConfigurationVO.TypeLocationSaveFiles == SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.Disk:
                        fileEntity.FileData = await GetFromDisk(fileEntity);
                        await SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetFromByteSaveTemp(fileEntity.FileData, fileEntity.FileName, _configuration);
                        break;
                    case SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.CloudStorageAzure when _locationSaveFileConfigurationVO.TypeLocationSaveFiles == SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.CloudStorageAzure:
                        await GetFileCloudAzureStorage(fileEntity, folderIdentity);
                        break;
                }
            }
            return fileEntity;
        }

        /// <summary>
        /// Operação DeleteFile: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task<bool> DeleteFile(FileBase fileEntity, string folderIdentity)
        {
            if (fileEntity != null)
            {
                switch (fileEntity.TypeLocationSaveFile)
                {
                    case SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.Disk when _locationSaveFileConfigurationVO.TypeLocationSaveFiles == SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.Disk:
                        await DeleteToDisk(string.Empty, fileEntity.FileName, fileEntity.FilePath);
                        break;
                    case SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.CloudStorageAzure when _locationSaveFileConfigurationVO.TypeLocationSaveFiles == SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.CloudStorageAzure:
                        await DeleteFileCloudAzureStorage(fileEntity, folderIdentity);
                        break;
                }
            }
            return true;
        }

        #region PRIVATES

        private string GetFilePath(string folderContainer, string folderIdentity, string fileName)
        {
            string pathDomainBussines = Path.Combine(SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretoryTemp(_configuration), "ResourcesFileSave");
            string folderDest = Path.Combine(pathDomainBussines, folderContainer, folderIdentity);
            return Path.Combine(folderDest, fileName);
        }

        private async Task<byte[]> GetFromDisk(FileBase fileEntity)
        {
            return await _repositoryFileDisk.Get(new FileData() { FilePath = fileEntity.FilePath, FileName = fileEntity.Description, CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc() }) ?? [];
        }

        private async Task SaveCloudStorageAzure(FileBase fileEntity, string folderContainer, string folderIdentity)
        {
            fileEntity.FileData = [];
            fileEntity.TypeLocationSaveFile = SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.CloudStorageAzure;

            var blobFile = new SmartDigitalPsico.Core.SDK.Domain.DTO.BlobFileDto() { FilePath = fileEntity.FilePath, BlobHeaders = SmartDigitalPsico.Core.SDK.Domain.Helpers.BlobFileHelper.GetBlobHeadersAzure(fileEntity) };
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
            entityAdd.TypeLocationSaveFile = SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.DataBase;
        }

        private async Task SaveToDisk(string folderDest, IFormFile fileData, byte[] fileDataSave, string pathSave)
        {
            await _repositoryFileDisk.Save(new FileData()
            {
                FolderDestination = folderDest,
                FileData = fileDataSave,
                FileName = fileData.FileName,
                FilePath = pathSave,
                CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc()
            });
        }

        private async Task DeleteToDisk(string folderDest, string fileName, string pathSave)
        {
            await _repositoryFileDisk.Delete(new FileData()
            {
                FolderDestination = folderDest,
                FileName = fileName,
                FilePath = pathSave,
                CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc()
            });
        }

        private async Task GetFileCloudAzureStorage(FileBase fileEntity, string folderIdentity)
        {
            fileEntity.FileData = [];
            fileEntity.TypeLocationSaveFile = SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.CloudStorageAzure;

            var blobFile = new SmartDigitalPsico.Core.SDK.Domain.DTO.BlobFileDto() { FilePath = fileEntity.FilePath, BlobHeaders = SmartDigitalPsico.Core.SDK.Domain.Helpers.BlobFileHelper.GetBlobHeadersAzure(fileEntity) };
            blobFile.BlobName = fileEntity.FileBlobName;
            blobFile.ContainerName = fileEntity.FileCloudContainer;

            //Get path
            string pathSave = GetFilePath(blobFile.ContainerName, folderIdentity, string.Empty);
            fileEntity.FilePath = Path.Combine(pathSave, "temp", fileEntity.FileName);

            // Garantir que o diretório de destino exista
            string directoryPath = ResolveDirectoryPath(fileEntity.FilePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            await DeleteFileDirectory(fileEntity.FileName, fileEntity.FilePath);

            var fileTemp = Path.Combine(SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretoryTemp(_configuration), fileEntity.FileName);

            await DeleteFileDirectory(fileEntity.FileName, fileTemp);

            //Get storage and save path
            await _storageClientAdapter.DownloadFile(blobFile.ContainerName, blobFile.BlobName, fileEntity.FilePath);

            //Get by from disk
            fileEntity.FileData = await GetFromDisk(fileEntity);
            await SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetFromByteSaveTemp(fileEntity.FileData, fileEntity.FileName, _configuration);

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
            fileEntity.TypeLocationSaveFile = SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.CloudStorageAzure;

            var blobFile = new SmartDigitalPsico.Core.SDK.Domain.DTO.BlobFileDto() { FilePath = fileEntity.FilePath, BlobHeaders = SmartDigitalPsico.Core.SDK.Domain.Helpers.BlobFileHelper.GetBlobHeadersAzure(fileEntity) };
            blobFile.BlobName = $"{folderIdentity}/{fileEntity.FileName}";
            blobFile.ContainerName = fileEntity.FileCloudContainer;

            await _storageClientAdapter.DeleteBlobAsync(blobFile.ContainerName, blobFile.BlobName);
        }

        internal static string ResolveDirectoryPath(string filePath)
            => Path.GetDirectoryName(filePath) ?? string.Empty;

        #endregion
    }
}
