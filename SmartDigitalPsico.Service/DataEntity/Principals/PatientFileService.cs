using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.VO.Patient.PatientFile;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class PatientFileService : EntityBaseService<PatientFile, AddPatientFileVO, UpdatePatientFileVO, GetPatientFileVO, IPatientFileRepository>, IPatientFileService

    {
        private readonly IFilePersistor _filePersistor;
        private readonly IPatientRepository _patientRepository;
        private readonly IUserRepository _userRepository;

        public PatientFileService(IMapper mapper
            , Serilog.ILogger logger
            , IResiliencePolicyConfig policyConfig
            , ICacheService cacheService
            , IApplicationLanguageRepository applicationLanguageRepository
            , IPatientFileRepository entityRepository
            , IUserRepository userRepository
            , IValidator<PatientFile> entityValidator
            , IFilePersistor filePersistor
            , IPatientRepository patientRepository)
            : base(mapper, logger, policyConfig, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _filePersistor = filePersistor;
            _patientRepository = patientRepository;
            _userRepository = userRepository;
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

                entityAdd.CreatedUserId = UserId;
                if (response.Success)
                {
                    entityAdd.FilePath = await _filePersistor.PersistFile(fileData, entityAdd, $"{patient.MedicalId}_{entity.PatientId}");
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

        public async Task<ServiceResponse<List<GetPatientFileVO>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientFileVO>> response = new ServiceResponse<List<GetPatientFileVO>>();

            var listResult = await _entityRepository.FindAllByPatient(patientId);

            var recordsList = new RecordsList<PatientFile>
            {
                UserIdLogged = UserId,
                Records = listResult,

            };
            var validator = new PatientFileSelectListValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(recordsList);

            if (!validationResult.IsValid)
            {
                response.Errors = validator.GetMapErros(validationResult.Errors);
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("ErrorValidator_User_Not_Permission", _applicationLanguageRepository, _cacheService);
                return response;
            }

            if (listResult == null || listResult.Count == 0)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);
                return response;
            }
            response.Data = listResult.Select(c => _mapper.Map<GetPatientFileVO>(c)).ToList();
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsFound", _applicationLanguageRepository, _cacheService);
            return response;

        }

        public override async Task<ServiceResponse<GetPatientFileVO>> FindByID(long id)
        {
            ServiceResponse<GetPatientFileVO> response = new ServiceResponse<GetPatientFileVO>();
            try
            {
                PatientFile entityResponse = await _entityRepository.FindByID(id);

                var recordData = new Record<PatientFile>
                {
                    UserIdLogged = UserId,
                    RecordEntity = entityResponse
                };

                var validator = new PatientFileSelectOneValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordData);
                if (!validationResult.IsValid)
                {
                    response.Errors = validator.GetMapErros(validationResult.Errors);
                    response.Success = false;
                    response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                           ("ErrorValidator_User_Not_Permission", _applicationLanguageRepository, _cacheService);
                    return response;
                }
                response.Data = _mapper.Map<GetPatientFileVO>(entityResponse);
                response.Success = true;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterFind", _applicationLanguageRepository, _cacheService);
            }
            catch (Exception)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }
    }
}