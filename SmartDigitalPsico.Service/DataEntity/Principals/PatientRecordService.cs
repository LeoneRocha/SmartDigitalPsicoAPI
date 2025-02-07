using Azure;
using MySqlX.XDevAPI.Common;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Patient.PatientRecord;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class PatientRecordService
        : EntityBaseService<PatientRecord, AddPatientRecordDto, UpdatePatientRecordDto, GetPatientRecordDto, IPatientRecordRepository>, IPatientRecordService

    {
        private readonly IUserRepository _userRepository;
        private readonly IMedicalRepository _medicalRepository;
        private readonly IPatientRepository _patientRepository;
        private readonly IPatientRecordServiceConfig _config;
        private readonly IAuditDataSelectiveEntityLogService _auditDataSelectiveEntityLogService;
        public PatientRecordService(IPatientRepositories repositories, IPatientRecordServiceConfig config, IAuditDataSelectiveEntityLogService auditDataSelectiveEntityLogService)
        : base(
              config.SharedServices,
              config.SharedDependenciesConfig,
              config.SharedRepositories,
              repositories.PatientRecordRepository,
              config.EntityValidator)
        {
            _config = config;
            _userRepository = repositories.SharedRepositories.UserRepository;
            _medicalRepository = repositories.MedicalRepository;
            _patientRepository = repositories.PatientRepository;
            _auditDataSelectiveEntityLogService = auditDataSelectiveEntityLogService;

        }
        public override async Task<ServiceResponse<GetPatientRecordDto>> Create(AddPatientRecordDto item)
        {
            PatientRecord entityAdd = _mapper.Map<PatientRecord>(item);

            #region Relationship

            entityAdd.CreatedUserId = UserId;
            entityAdd.PatientId = item.PatientId;

            #endregion Relationship

            entityAdd.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
            entityAdd.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
            entityAdd.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

            ServiceResponse<GetPatientRecordDto> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                var patient = await _patientRepository.FindByID(entityAdd.PatientId);
                var medical = await _medicalRepository.FindByID(patient.MedicalId);
                entityAdd.Annotation = _config.SharedServices.CryptoService.Encrypt(medical.SecurityKey, item.Annotation);

                entityAdd.TableStorageRowKey = Guid.NewGuid().ToString();

                var addTableEntity = CreateTableEntity(entityAdd);

                //Storage Table Example usage
                await _config.StorageTableService.UpdateAsync(addTableEntity);

                entityAdd.TableStorageRowKey = addTableEntity.RowKey;

                PatientRecord entityResponse = await _entityRepository.Create(entityAdd);
                response.Data = _mapper.Map<GetPatientRecordDto>(entityResponse);
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCreated, GeneralLanguageMenssageConstants.RegisterCreated);
            }
            return response;
        }
        public override async Task<ServiceResponse<GetPatientRecordDto>> Update(UpdatePatientRecordDto item)
        {
            PatientRecord entityUpdate = await _entityRepository.FindByID(item.Id);
            string[] propertiesToIgnore = ["Patient", "Patient", "CreatedUser", "ModifyUser"];

            PatientRecord entityOld = AuditLogHelper.DeepClone(entityUpdate, propertiesToIgnore);

            #region Relationship

            #endregion Relationship
            #region Set default fields for bussines

            entityUpdate.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
            entityUpdate.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

            #endregion Set default fields for bussines

            #region User Action

            entityUpdate.ModifyUserId = UserId;
            User userUpdate = await _userRepository.FindByID(UserId);
            entityOld.ModifyUser = userUpdate;
            #endregion User Action

            #region Columns
            entityUpdate.Enable = item.Enable;
            entityUpdate.Annotation = item.Annotation;
            entityUpdate.Description = item.Description;
            entityUpdate.AnnotationDate = item.AnnotationDate;
            entityUpdate.TableStorageRowKey = string.IsNullOrEmpty(entityUpdate.TableStorageRowKey) ? Guid.NewGuid().ToString()
                : entityUpdate.TableStorageRowKey;
            #endregion Columns

            ServiceResponse<GetPatientRecordDto> response = await base.Validate(entityUpdate);
            if (response.Success)
            {
                var medical = await _medicalRepository.FindByID(entityUpdate.Patient?.MedicalId ?? 0);
                entityUpdate.Annotation = _config.SharedServices.CryptoService.Encrypt(medical.SecurityKey, item.Annotation);

                var updateTableEntity = CreateTableEntity(entityUpdate);

                //Storage Table Example usage
                await _config.StorageTableService.UpdateAsync(updateTableEntity);

                entityUpdate.TableStorageRowKey = updateTableEntity.RowKey;

                PatientRecord entityResponse = await _entityRepository.Update(entityUpdate);
                response.Data = _mapper.Map<GetPatientRecordDto>(entityResponse);
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);

                await _auditDataSelectiveEntityLogService.Save(entityOld, entityResponse, "Update", propertiesToIgnore);
            }
            return response;
        }

        private static PatientRecordTableEntity CreateTableEntity(PatientRecord item)
        {
            return new PatientRecordTableEntity()
            {
                PatientId = item.PatientId,
                PatientRecordId = item.Id,
                RowKey = item.TableStorageRowKey,
                Annotation = item.Annotation,
                ETag = ETag.All,
                PartitionKey = string.Concat("PatientRecord-", item.PatientId.ToString()),
                Timestamp = DateHelper.GetDateTimeNowFromUtc(),
            };
        }

        public async Task<ServiceResponse<List<GetPatientRecordDto>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientRecordDto>> response = new ServiceResponse<List<GetPatientRecordDto>>();

            var listResult = await _entityRepository.FindAllByPatient(patientId);

            var recordsList = new RecordsList<PatientRecord>
            {
                UserIdLogged = UserId,
                Records = listResult

            };
            var validator = new PatientRecordSelectListValidator(_userRepository);
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
            response.Data = listResult.Select(c => _mapper.Map<GetPatientRecordDto>(c)).ToList();
            response.Success = true;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);

            return response;
        }
        public async override Task<ServiceResponse<List<GetPatientRecordDto>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientRecordDto>>();
            result.Success = false;
            result.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
            return result;
        }

        public override async Task<ServiceResponse<GetPatientRecordDto>> FindByID(long id)
        {
            ServiceResponse<GetPatientRecordDto> response = new ServiceResponse<GetPatientRecordDto>();
            try
            {
                PatientRecord entityResponse = await _entityRepository.FindByID(id);

                var recordData = new Record<PatientRecord>
                {
                    UserIdLogged = UserId,
                    RecordEntity = entityResponse
                };

                var validator = new PatientRecordSelectOneValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordData);
                if (!validationResult.IsValid)
                {
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Success = false;
                    response.Message = await GetLocalization(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);

                    return response;
                }
                var patient = await _patientRepository.FindByID(entityResponse.PatientId, p => p.Medical ?? new Medical());


                entityResponse.Annotation = _config.SharedServices.CryptoService.Decrypt(patient.Medical?.SecurityKey ?? string.Empty, entityResponse.Annotation);

                response.Data = _mapper.Map<GetPatientRecordDto>(entityResponse);
                response.Success = true;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterFind, GeneralLanguageMenssageConstants.RegisterFind);
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