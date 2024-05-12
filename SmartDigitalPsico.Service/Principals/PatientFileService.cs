using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;
using SmartDigitalPsico.Domain.VO.Domains;
using SmartDigitalPsico.Domain.VO.Patient.PatientFile;
using SmartDigitalPsico.Service.Generic;

namespace SmartDigitalPsico.Service.Principals
{
    public class PatientFileService : EntityBaseService<PatientFile, AddPatientFileVO, UpdatePatientFileVO, GetPatientFileVO, IPatientFileRepository>, IPatientFileService

    {
        private readonly IMapper _mapper;
        IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly IPatientFileRepository _entityRepository;
        private readonly IFileDiskRepository _repositoryFileDisk;
        private readonly LocationSaveFileConfigurationVO _locationSaveFileConfigurationVO;

        public PatientFileService(IMapper mapper, IPatientFileRepository entityRepository, IConfiguration configuration,
            IUserRepository userRepository
            , IValidator<PatientFile> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService
            , IOptions<LocationSaveFileConfigurationVO> locationSaveFileConfigurationVO
            , IFileDiskRepository repositoryFileDisk)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _configuration = configuration;
            _entityRepository = entityRepository;
            _userRepository = userRepository;
            _locationSaveFileConfigurationVO = locationSaveFileConfigurationVO.Value;
            _repositoryFileDisk = repositoryFileDisk;
        }

        public override Task<ServiceResponse<bool>> Delete(long id)
        {
            return base.EnableOrDisable(id);
        }

        public async Task<bool> PostFileAsync(AddPatientFileVO entity)
        {
            ServiceResponse<GetPatientFileVO> response = new ServiceResponse<GetPatientFileVO>();
            if (entity != null)
            {

                IFormFile fileData;

                fileData = entity.FileDetails;
                if (fileData != null)
                {
                    var splitExtension = fileData.ContentType.Split('/').ToList();
                    string extensioFile = splitExtension.Last();
                    entity.FilePath = fileData.FileName;
                    entity.FileContentType = fileData.ContentType;
                    entity.FileExtension = extensioFile.Substring(0, 3);
                    entity.FileSizeKB = fileData.Length / 1024;
                }

                PatientFile entityAdd = _mapper.Map<PatientFile>(entity);
                entityAdd.FileName = entity.FilePath;
                #region Relationship

                entityAdd.PatientId = entity.PatientId;

                #endregion Relationship

                entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
                entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
                entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();
                entityAdd.Enable = true;

                entityAdd.CreatedUserId = this.UserId; 
                if (response.Success)
                {
                    entityAdd.FilePath = await persistFile(entity, fileData, entityAdd);
                    PatientFile entityResponse = await _entityRepository.Create(entityAdd);
                    if (response.Data != null)
                        response.Data.Id = entityResponse.Id;
                }

            }
            return response.Success;
        }

        public async Task<GetPatientFileVO> DownloadFileById(long fileId)
        { 
            var fileEntity = await _entityRepository.FindByID(fileId);
            GetPatientFileVO resultVO = _mapper.Map<GetPatientFileVO>(fileEntity);

            if (fileEntity != null)
            {
                if (_locationSaveFileConfigurationVO.TypeLocationSaveFiles == ETypeLocationSaveFiles.DataBase && fileEntity.TypeLocationSaveFile == ETypeLocationSaveFiles.DataBase)
                {
                    await FileHelper.GetFromByteSaveTemp(fileEntity.FileData, fileEntity.FileName, _configuration);
                }

                if (_locationSaveFileConfigurationVO.TypeLocationSaveFiles == ETypeLocationSaveFiles.Disk && fileEntity.TypeLocationSaveFile == ETypeLocationSaveFiles.Disk)
                {
                    fileEntity.FileData = await getFromDisk(fileEntity);

                    await FileHelper.GetFromByteSaveTemp(fileEntity.FileData, fileEntity.FileName, _configuration);
                }
            }

            return resultVO;
        }

        private async Task<string> persistFile(AddPatientFileVO entity, IFormFile fileData, PatientFile entityAdd)
        {
            ///MUDAR PARA BUSCAR NA TABELAS DE CONFIGURACOES  
            string pathDomainBussines = Path.Combine(Directory.GetCurrentDirectory(), "ResourcesFileSave");
            string? folderDest = Path.Combine(pathDomainBussines, entity.PatientId.ToString());
            var pathSave = Path.Combine(folderDest, fileData.FileName);

            byte[] fileDataSave = await FileHelper.GetByteDataFromIFormFile(fileData);

            if (_locationSaveFileConfigurationVO.TypeLocationSaveFiles == ETypeLocationSaveFiles.DataBase)
            {
                entityAdd.FileData = fileDataSave;
                entityAdd.TypeLocationSaveFile = ETypeLocationSaveFiles.DataBase;
                folderDest = null;
            }
            if (_locationSaveFileConfigurationVO.TypeLocationSaveFiles == ETypeLocationSaveFiles.Disk)
            {
                await _repositoryFileDisk.Save(new FileData()
                {
                    FolderDestination = folderDest,
                    FileData = fileDataSave,
                    FileName = fileData.FileName,
                    FilePath = pathSave,
                    CreatedDate = DataHelper.GetDateTimeNow()
                });
                entityAdd.TypeLocationSaveFile = ETypeLocationSaveFiles.Disk;
            }
            return folderDest ?? string.Empty;
        }

        private async Task<byte[]> getFromDisk(PatientFile fileEntity)
        {
            return await _repositoryFileDisk.Get(new FileData() { FilePath = fileEntity.FilePath, FileName = fileEntity.Description, CreatedDate = DataHelper.GetDateTimeNow() });
        }

    }
}