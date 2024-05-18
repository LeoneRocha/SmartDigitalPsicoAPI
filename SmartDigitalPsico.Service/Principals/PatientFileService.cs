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
using SmartDigitalPsico.Domain.VO.Medical.MedicalFile;
using SmartDigitalPsico.Domain.VO.Patient.PatientFile;
using SmartDigitalPsico.Service.Generic;

namespace SmartDigitalPsico.Service.Principals
{
    public class PatientFileService : EntityBaseService<PatientFile, AddPatientFileVO, UpdatePatientFileVO, GetPatientFileVO, IPatientFileRepository>, IPatientFileService

    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration; 
        private readonly IPatientFileRepository _entityRepository;        
        private readonly LocationSaveFileConfigurationVO _locationSaveFileConfigurationVO;
        private readonly IFilePersistor _filePersistor;
        private readonly IPatientRepository _patientRepository;
         
        public PatientFileService(IMapper mapper
            , IConfiguration configuration            
            , ICacheService cacheService
            , IApplicationLanguageRepository applicationLanguageRepository
            , IOptions<LocationSaveFileConfigurationVO> locationSaveFileConfigurationVO
            , IPatientFileRepository entityRepository
            , IValidator<PatientFile> entityValidator
            , IFilePersistor filePersistor
            , IPatientRepository patientRepository)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _configuration = configuration;
            _entityRepository = entityRepository; 
            _locationSaveFileConfigurationVO = locationSaveFileConfigurationVO.Value;
            _filePersistor = filePersistor;
            _patientRepository = patientRepository;
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
                    entity.FilePath = fileData.FileName;
                    entity.FileContentType = fileData.ContentType;
                    entity.FileExtension = FileHelper.GetFileExtension(fileData.ContentType);
                    entity.FileSizeKB = fileData.Length / 1024;
                }

                PatientFile entityAdd = _mapper.Map<PatientFile>(entity);
                entityAdd.FileName = entity.FilePath;
                #region Relationship

                entityAdd.PatientId = entity.PatientId;

                Patient patient = await _patientRepository.FindByID(entity.PatientId);

                #endregion Relationship

                entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
                entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
                entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();
                entityAdd.Enable = true;

                entityAdd.CreatedUserId = this.UserId;
                if (response.Success)
                {
                    entityAdd.FilePath = await _filePersistor.PersistFile(  fileData, entityAdd, $"{patient.MedicalId}_{entity.PatientId}" );
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

            var resultData = await _filePersistor.DownloadFileById(fileEntity) as PatientFile;
            if (resultData != null)
            {
                fileEntity.FileData = resultData.FileData;
            }
            GetPatientFileVO resultVO = _mapper.Map<GetPatientFileVO>(fileEntity);
            
            return resultVO;
        } 
    }
}