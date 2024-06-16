using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.VO.Patient.PatientNotificationMessage;
using SmartDigitalPsico.Service.Generic;
using SmartDigitalPsico.Service.SystemDomains;

namespace SmartDigitalPsico.Service.Principals
{
    public class PatientNotificationMessageService
        : EntityBaseService<PatientNotificationMessage, AddPatientNotificationMessageVO, UpdatePatientNotificationMessageVO, GetPatientNotificationMessageVO, IPatientNotificationMessageRepository>, IPatientNotificationMessageService

    {  
        private readonly IPatientRepository _patientRepository;
        private readonly IUserRepository _userRepository;

        public PatientNotificationMessageService(IMapper mapper
            , Serilog.ILogger logger
            , IResiliencePolicyConfig policyConfig
            , IPatientNotificationMessageRepository entityRepository
            , IUserRepository userRepository
            , IPatientRepository patientRepository
            , IValidator<PatientNotificationMessage> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(mapper, logger, policyConfig, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {  
            _patientRepository = patientRepository;
            _userRepository = userRepository;
        }
        public override async Task<ServiceResponse<GetPatientNotificationMessageVO>> Create(AddPatientNotificationMessageVO item)
        {
            PatientNotificationMessage entityAdd = _mapper.Map<PatientNotificationMessage>(item);

            #region Relationship

            entityAdd.CreatedUserId = this.UserId;

            Patient patientAdd = await _patientRepository.FindByPatient(new Patient() { Cpf = item.CPF, Rg = item.RG, Email = item.Email }) ?? new Patient();
            entityAdd.PatientId = patientAdd.Id;

            #endregion

            entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();

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

        public override async Task<ServiceResponse<GetPatientNotificationMessageVO>> Update(UpdatePatientNotificationMessageVO item)
        {
            PatientNotificationMessage entityUpdate = await _entityRepository.FindByID(item.Id);

            entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();
            entityUpdate.LastAccessDate = DataHelper.GetDateTimeNow();

            entityUpdate.ModifyUserId = this.UserId;

            #region Columns
            entityUpdate.Enable = item.Enable;
            entityUpdate.MessagePatient = item.Message;

            entityUpdate.IsReaded = item.IsReaded;
            entityUpdate.ReadingDate = item.IsReaded ? DataHelper.GetDateTimeNow() : null;

            entityUpdate.Notified = item.Notified;
            entityUpdate.NotifiedDate = item.Notified ? DataHelper.GetDateTimeNow() : null;

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
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);

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
                    UserIdLogged = base.UserId,
                    RecordEntity = entityResponse
                };

                var validator = new PatientNotificationMessageSelectOneValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordData);
                if (!validationResult.IsValid)
                {
                    response.Errors = validator.GetMapErros(validationResult.Errors);
                    response.Success = false;
                    response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                           ("ErrorValidator_User_Not_Permission", base._applicationLanguageRepository, base._cacheService);
                    return response;
                }
                response.Data = _mapper.Map<GetPatientNotificationMessageVO>(entityResponse);
                response.Success = true;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterFind", base._applicationLanguageRepository, base._cacheService);
            }
            catch (Exception)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);
            }
            return response;
        }
    }
}