using Azure;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.VO.Patient.PatientRecord;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class PatientRecordService
        : EntityBaseService<PatientRecord, AddPatientRecordVO, UpdatePatientRecordVO, GetPatientRecordVO, IPatientRecordRepository>, IPatientRecordService

    {
        private readonly IUserRepository _userRepository;
        private readonly ICryptoService _cryptoService;
        private readonly IStorageTableContract<PatientRecordTableEntity> _storageTableService;
        private readonly IMedicalRepository _medicalRepository;
        private readonly IPatientRepository _patientRepository;

        public PatientRecordService(IPatientRepositories repositories, IPatientRecordServiceConfig config)
        : base(
              config.SharedServices,
              config.SharedDependenciesConfig,
              config.SharedRepositories,
              repositories.PatientRecordRepository,
              config.EntityValidator)
        {
            _userRepository = repositories.SharedRepositories.UserRepository;
            _cryptoService = config.SharedServices.CryptoService;
            _storageTableService = config.StorageTableService;
            _medicalRepository = repositories.MedicalRepository;
            _patientRepository = repositories.PatientRepository;
        }
        public override async Task<ServiceResponse<GetPatientRecordVO>> Create(AddPatientRecordVO item)
        {
            PatientRecord entityAdd = _mapper.Map<PatientRecord>(item);

            #region Relationship

            entityAdd.CreatedUserId = UserId;
            entityAdd.PatientId = item.PatientId;

            #endregion Relationship

            entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();

            ServiceResponse<GetPatientRecordVO> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                var patient = await _patientRepository.FindByID(entityAdd.PatientId);
                var medical = await _medicalRepository.FindByID(patient.MedicalId);
                entityAdd.Annotation = _cryptoService.Encrypt(medical.SecurityKey, item.Annotation);

                entityAdd.TableStorageRowKey = Guid.NewGuid().ToString();

                var addTableEntity = CreateTableEntity(entityAdd);
                await _storageTableService.UpdateAsync(addTableEntity);
                entityAdd.TableStorageRowKey = addTableEntity.RowKey;

                PatientRecord entityResponse = await _entityRepository.Create(entityAdd);
                response.Data = _mapper.Map<GetPatientRecordVO>(entityResponse);
                response.Message = "Patient Record registred.";
            }
            return response;
        }
        public override async Task<ServiceResponse<GetPatientRecordVO>> Update(UpdatePatientRecordVO item)
        {
            PatientRecord entityUpdate = await _entityRepository.FindByID(item.Id);

            #region Relationship

            #endregion Relationship
            #region Set default fields for bussines

            entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();
            entityUpdate.LastAccessDate = DataHelper.GetDateTimeNow();

            #endregion Set default fields for bussines

            #region User Action

            entityUpdate.ModifyUserId = UserId;

            #endregion User Action


            #region Columns
            entityUpdate.Enable = item.Enable;
            entityUpdate.Annotation = item.Annotation;
            entityUpdate.Description = item.Description;
            entityUpdate.AnnotationDate = item.AnnotationDate;
            entityUpdate.TableStorageRowKey = string.IsNullOrEmpty(entityUpdate.TableStorageRowKey) ? Guid.NewGuid().ToString()
                : entityUpdate.TableStorageRowKey;
            #endregion Columns

            ServiceResponse<GetPatientRecordVO> response = await base.Validate(entityUpdate);
            if (response.Success)
            {
                var medical = await _medicalRepository.FindByID(entityUpdate.Patient?.MedicalId ?? 0);
                entityUpdate.Annotation = _cryptoService.Encrypt(medical.SecurityKey, item.Annotation);

                var updateTableEntity = CreateTableEntity(entityUpdate);
                await _storageTableService.UpdateAsync(updateTableEntity);
                entityUpdate.TableStorageRowKey = updateTableEntity.RowKey;

                PatientRecord entityResponse = await _entityRepository.Update(entityUpdate);
                response.Data = _mapper.Map<GetPatientRecordVO>(entityResponse);
                response.Message = "Patient Updated.";
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
                Timestamp = DataHelper.GetDateTimeNow(),
            };
        }

        public async Task<ServiceResponse<List<GetPatientRecordVO>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientRecordVO>> response = new ServiceResponse<List<GetPatientRecordVO>>();

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
                response.Errors = validator.GetMapErros(validationResult.Errors);
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("ErrorValidator_User_Not_Permission", _applicationLanguageRepository, _cacheService);
                return response;
            }

            if (listResult == null || listResult.Count == 0)
            {
                response.Success = false;
                response.Message = "Patients not found.";
                return response;
            }
            response.Data = listResult.Select(c => _mapper.Map<GetPatientRecordVO>(c)).ToList();
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsFound", _applicationLanguageRepository, _cacheService);

            return response;
        }
        public async override Task<ServiceResponse<List<GetPatientRecordVO>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientRecordVO>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);

            return result;
        }

        public override async Task<ServiceResponse<GetPatientRecordVO>> FindByID(long id)
        {
            ServiceResponse<GetPatientRecordVO> response = new ServiceResponse<GetPatientRecordVO>();
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
                    response.Errors = validator.GetMapErros(validationResult.Errors);
                    response.Success = false;
                    response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                           ("ErrorValidator_User_Not_Permission", _applicationLanguageRepository, _cacheService);
                    return response;
                }
                var patient = await _patientRepository.FindByID(entityResponse.PatientId, p => p.Medical ?? new Medical());


                entityResponse.Annotation = _cryptoService.Decrypt(patient.Medical?.SecurityKey ?? string.Empty, entityResponse.Annotation);

                response.Data = _mapper.Map<GetPatientRecordVO>(entityResponse);
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