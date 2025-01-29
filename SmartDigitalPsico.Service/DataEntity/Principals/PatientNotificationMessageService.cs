using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.DTO.Patient.PatientNotificationMessage;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Domain.Validation.Helper;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class PatientNotificationMessageService
        : EntityBaseService<PatientNotificationMessage, AddPatientNotificationMessageDto, UpdatePatientNotificationMessageDto, GetPatientNotificationMessageVO, IPatientNotificationMessageRepository>, IPatientNotificationMessageService

    {
        private readonly IPatientRepository _patientRepository;
        private readonly IUserRepository _userRepository;

        public PatientNotificationMessageService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IPatientNotificationMessageRepository entityRepository,
            IPatientRepository patientRepository,
            IValidator<PatientNotificationMessage> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
            _patientRepository = patientRepository;
            _userRepository = sharedRepositories.UserRepository;
        }
        public override async Task<ServiceResponse<GetPatientNotificationMessageVO>> Create(AddPatientNotificationMessageDto item)
        {
            PatientNotificationMessage entityAdd = _mapper.Map<PatientNotificationMessage>(item);

            #region Relationship

            entityAdd.CreatedUserId = UserId;

            Patient patientAdd = await _patientRepository.FindByPatient(new Patient() { Cpf = item.CPF, Rg = item.RG, Email = item.Email }) ?? new Patient();
            entityAdd.PatientId = patientAdd.Id;

            #endregion

            entityAdd.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
            entityAdd.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
            entityAdd.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

            ServiceResponse<GetPatientNotificationMessageVO> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                PatientNotificationMessage entityResponse = await _entityRepository.Create(entityAdd);

                response.Data = _mapper.Map<GetPatientNotificationMessageVO>(entityResponse);
                response.Success = true;
                response.Message = "Patient registred.";
            }
            return response;
        }

        public override async Task<ServiceResponse<GetPatientNotificationMessageVO>> Update(UpdatePatientNotificationMessageDto item)
        {
            PatientNotificationMessage entityUpdate = await _entityRepository.FindByID(item.Id);

            entityUpdate.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
            entityUpdate.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

            entityUpdate.ModifyUserId = UserId;

            #region Columns
            entityUpdate.Enable = item.Enable;
            entityUpdate.MessagePatient = item.Message;

            entityUpdate.IsReaded = item.IsReaded;
            entityUpdate.ReadingDate = item.IsReaded ? DateHelper.GetDateTimeNowFromUtc() : null;

            entityUpdate.Notified = item.Notified;
            entityUpdate.NotifiedDate = item.Notified ? DateHelper.GetDateTimeNowFromUtc() : null;

            #endregion Columns

            ServiceResponse<GetPatientNotificationMessageVO> response = await base.Validate(entityUpdate);

            if (response.Success)
            {
                PatientNotificationMessage entityResponse = await _entityRepository.Update(entityUpdate);

                response.Data = _mapper.Map<GetPatientNotificationMessageVO>(entityResponse);
                response.Message = "Medical updated.";
            }

            return response;
        }
        public async Task<ServiceResponse<List<GetPatientNotificationMessageVO>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientNotificationMessageVO>> response = new ServiceResponse<List<GetPatientNotificationMessageVO>>();

            var listResult = await _entityRepository.FindAllByPatient(patientId);

            if (listResult == null || listResult.Count == 0)
            {
                response.Success = false;
                response.Message = "Patients not found.";
                return response;
            }
            response.Data = listResult.Select(c => _mapper.Map<GetPatientNotificationMessageVO>(c)).ToList();
            response.Success = true;
            response.Message = "Patients finded.";
            return response;
        }

        public async override Task<ServiceResponse<List<GetPatientNotificationMessageVO>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientNotificationMessageVO>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);

            return result;
        }


        public override async Task<ServiceResponse<GetPatientNotificationMessageVO>> FindByID(long id)
        {
            ServiceResponse<GetPatientNotificationMessageVO> response = new ServiceResponse<GetPatientNotificationMessageVO>();
            try
            {
                PatientNotificationMessage entityResponse = await _entityRepository.FindByID(id);

                var recordData = new Record<PatientNotificationMessage>
                {
                    UserIdLogged = UserId,
                    RecordEntity = entityResponse
                };

                var validator = new PatientNotificationMessageSelectOneValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordData);
                if (!validationResult.IsValid)
                {
                    response.Errors = HelperValidation.GetMapErros(validationResult.Errors);
                    response.Success = false;
                    response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                           ("ErrorValidator_User_Not_Permission", _applicationLanguageRepository, _cacheService);
                    return response;
                }
                response.Data = _mapper.Map<GetPatientNotificationMessageVO>(entityResponse);
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