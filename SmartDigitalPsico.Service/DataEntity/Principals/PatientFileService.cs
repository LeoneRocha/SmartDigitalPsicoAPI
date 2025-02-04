using FluentValidation;
using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.DTO.Patient.PatientFile;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class PatientFileService : EntityBaseService<PatientFile, AddPatientFileDto, UpdatePatientFileDto, GetPatientFileDto, IPatientFileRepository>, IPatientFileService

    {
        private readonly IFileManager _filePersistor;
        private readonly IPatientRepository _patientRepository;
        private readonly IUserRepository _userRepository;

        public PatientFileService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IPatientFileRepository entityRepository,           
            IValidator<PatientFile> entityValidator,
            IFileManager filePersistor,
            IPatientRepository patientRepository
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
            _filePersistor = filePersistor;
            _patientRepository = patientRepository;
            _userRepository = sharedRepositories.UserRepository;
        }

        public override Task<ServiceResponse<bool>> Delete(long id)
        {
            return base.EnableOrDisable(id);
        }

        public async Task<bool> PostFileAsync(AddPatientFileDto entity)
        {
            ServiceResponse<GetPatientFileDto> response = new ServiceResponse<GetPatientFileDto>();
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

                entityAdd.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
                entityAdd.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                entityAdd.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();
                entityAdd.Enable = true;

                entityAdd.CreatedUserId = UserId;
                if (response.Success)
                {
                    entityAdd.FilePath = await _filePersistor.PersistFile(fileData, entityAdd, "patientfiles", $"{patient.MedicalId}_{entity.PatientId}");
                    PatientFile entityResponse = await _entityRepository.Create(entityAdd);
                    if (response.Data != null)
                        response.Data.Id = entityResponse.Id;
                }

            }
            return response.Success;
        }

        public async Task<GetPatientFileDto> DownloadFileById(long fileId)
        {
            var fileEntity = await _entityRepository.FindByID(fileId);

            #region Relationship
              
            Patient patient = await _patientRepository.FindByID(fileEntity.PatientId);

            #endregion Relationship

            var resultData = await _filePersistor.DownloadFileById(fileEntity, $"{patient.MedicalId}_{fileEntity.PatientId}") as PatientFile;
            if (resultData != null)
            {
                fileEntity.FileData = resultData.FileData;
            }
            GetPatientFileDto resultVO = _mapper.Map<GetPatientFileDto>(fileEntity);

            return resultVO;
        }

        public async Task<ServiceResponse<List<GetPatientFileDto>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientFileDto>> response = new ServiceResponse<List<GetPatientFileDto>>();

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
                response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                response.Success = false;
                response.Message = await GetLocalization(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);
                 
                return response;
            }

            if (listResult == null || listResult.Count == 0)
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);               
                return response;
            }
            response.Data = listResult.Select(c => _mapper.Map<GetPatientFileDto>(c)).ToList();
            response.Success = true;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound); 
            return response;

        }

        public override async Task<ServiceResponse<GetPatientFileDto>> FindByID(long id)
        {
            ServiceResponse<GetPatientFileDto> response = new ServiceResponse<GetPatientFileDto>();
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
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Success = false;
                    response.Message = await GetLocalization(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);
                    return response;
                }
                response.Data = _mapper.Map<GetPatientFileDto>(entityResponse);
                response.Success = true;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);                
            }
            catch (Exception)
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
            }
            return response;
        }
    }
}