using AutoMapper;
using Azure;
using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Security;
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
        private readonly ITableEntityRepository<PatientRecordTableEntity> _tableEntityRepository;

        public PatientRecordService(IMapper mapper
            , Serilog.ILogger logger
            , IResiliencePolicyConfig policyConfig
            , IPatientRecordRepository entityRepository
            , IUserRepository userRepository
            , IValidator<PatientRecord> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService
            , ICryptoService cryptoService
            , ITableEntityRepository<PatientRecordTableEntity> tableEntityRepository)
            : base(mapper, logger, policyConfig, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _userRepository = userRepository;
            _cryptoService = cryptoService;
            _tableEntityRepository = tableEntityRepository;
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
                entityAdd.Annotation = _cryptoService.Encrypt(item.Annotation);
                entityAdd.TableStorageRowKey = Guid.NewGuid().ToString();
                 
                var addTableEntity = CreateTableEntity(entityAdd);
                await _tableEntityRepository.UpdateAsync(addTableEntity);
                entityAdd.TableStorageRowKey = addTableEntity.RowKey;

                PatientRecord entityResponse = await _entityRepository.Create(entityAdd);
                response.Data = _mapper.Map<GetPatientRecordVO>(entityResponse);
                response.Message = "Patient registred.";
            }
            return response;
        }
        public override async Task<ServiceResponse<GetPatientRecordVO>> Update(UpdatePatientRecordVO item)
        {
            PatientRecord entityUpdate = await _entityRepository.FindByID(item.Id);

            #region Set default fields for bussines

            entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();
            entityUpdate.LastAccessDate = DataHelper.GetDateTimeNow();

            #endregion Set default fields for bussines

            #region User Action

            entityUpdate.ModifyUserId = UserId;

            #endregion User Action

            #region Relationship 

            #endregion Relationship

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
                entityUpdate.Annotation = _cryptoService.Encrypt(item.Annotation);

                var updateTableEntity = CreateTableEntity(entityUpdate);
                await _tableEntityRepository.UpdateAsync(updateTableEntity);
                entityUpdate.TableStorageRowKey = updateTableEntity.RowKey;

                PatientRecord entityResponse = await _entityRepository.Update(entityUpdate);
                response.Data = _mapper.Map<GetPatientRecordVO>(entityResponse);
                response.Message = "Patient Updated.";
            }
            return response;
        }

        private PatientRecordTableEntity CreateTableEntity(PatientRecord item)
        {
            return new PatientRecordTableEntity()
            {
                PatientId = item.PatientId,
                RowKey = item.TableStorageRowKey,
                Annotation = item.Annotation,
                ETag = ETag.All,
                PartitionKey = string.Concat("PatientRecord-", item.PatientId.ToString()),
                Timestamp = DateTime.Now,
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

                entityResponse.Annotation = _cryptoService.Decrypt(entityResponse.Annotation);

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