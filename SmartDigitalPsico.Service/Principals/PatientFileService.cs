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
using SmartDigitalPsico.Domain.VO.Domains;
using SmartDigitalPsico.Domain.VO.Patient.PatientFile;
using SmartDigitalPsico.Service.Generic;

namespace SmartDigitalPsico.Service.Principals
{
    public class PatientFileService : EntityBaseSimpleService<PatientFile, AddPatientFileVO, UpdatePatientFileVO, GetPatientFileVO, IPatientFileRepository>, IPatientFileService

    {
        private readonly IMapper _mapper;
        IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly IPatientFileRepository _entityRepository;
        private readonly IPatientRepository _patientRepository;
        private readonly IFileDiskRepository _repositoryFileDisk;
        private readonly LocationSaveFileConfigurationVO _locationSaveFileConfigurationVO;

        public PatientFileService(IMapper mapper, IPatientFileRepository entityRepository, IConfiguration configuration,
            IUserRepository userRepository, IPatientRepository patientRepository
            , IValidator<PatientFile> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService
            , IOptions<LocationSaveFileConfigurationVO> locationSaveFileConfigurationVO)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _configuration = configuration;
            _entityRepository = entityRepository;
            _userRepository = userRepository;
            _patientRepository = patientRepository;
            _locationSaveFileConfigurationVO = locationSaveFileConfigurationVO.Value;
        }

        public override Task<ServiceResponse<bool>> Delete(long id)
        {
            return base.EnableOrDisable(id);
        }

        public async Task<bool> PostFileAsync(AddPatientFileVO entity)
        {
            ServiceResponse<GetPatientFileVO> response = new ServiceResponse<GetPatientFileVO>();

            try
            {

                IFormFile fileData = null;
                if (entity != null)
                {
                    fileData = entity.FileDetails;
                    if (fileData != null)
                    {
                        string extensioFile = fileData.ContentType.Split('/').Last();
                        entity.FilePath = fileData.FileName;
                        entity.FileContentType = fileData.ContentType;
                        entity.FileExtension = extensioFile.Substring(0, 3);
                        entity.FileSizeKB = fileData.Length / 1024;
                    }
                }

                PatientFile entityAdd = _mapper.Map<PatientFile>(entity);
                entityAdd.FileName = entity?.FilePath;
                #region Relationship

                entityAdd.Patient = await _patientRepository.FindByID(entity.PatientId);

                #endregion Relationship

                entityAdd.CreatedDate = DateTime.Now;
                entityAdd.ModifyDate = DateTime.Now;
                entityAdd.LastAccessDate = DateTime.Now;
                entityAdd.Enable = true;

                User userAction = await _userRepository.FindByID(this.UserId);
                entityAdd.CreatedUser = userAction;

                //response = await base.Validate(entityAdd);

                if (response.Success)
                {
                    entityAdd.FilePath = await persistFile(entity, fileData, entityAdd);
                    PatientFile entityResponse = await _entityRepository.Create(entityAdd);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return true;
        }

        public async Task<GetPatientFileVO> DownloadFileById(long fileId)
        {
            var userAutenticated = await _userRepository.FindByID(this.UserId);
            var fileEntity = await _entityRepository.FindByID(fileId);
            GetPatientFileVO resultVO = _mapper.Map<GetPatientFileVO>(fileEntity);

            if (fileEntity != null)
            {
                if (_locationSaveFileConfigurationVO.TypeLocationSaveFiles == ETypeLocationSaveFiles.DataBase && fileEntity.TypeLocationSaveFile == ETypeLocationSaveFiles.DataBase)
                {
                    FileHelper.GetFromByteSaveTemp(fileEntity.FileData, fileEntity.FileName);
                }

                if (_locationSaveFileConfigurationVO.TypeLocationSaveFiles == ETypeLocationSaveFiles.Disk && fileEntity.TypeLocationSaveFile == ETypeLocationSaveFiles.Disk)
                {
                    fileEntity.FileData = await getFromDisk(fileEntity);

                    FileHelper.GetFromByteSaveTemp(fileEntity.FileData, fileEntity.FileName);
                }
            }

            return resultVO;
        }

        private async Task<string?> persistFile(AddPatientFileVO entity, IFormFile fileData, PatientFile entityAdd)
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
                    FilePath = pathSave
                });
                entityAdd.TypeLocationSaveFile = ETypeLocationSaveFiles.Disk;
            }
            return folderDest;
        }

        private async Task<byte[]> getFromDisk(PatientFile fileEntity)
        {
            return await _repositoryFileDisk.Get(new FileData() { FilePath = fileEntity.FilePath, FileName = fileEntity.Description });
        }

    }
}