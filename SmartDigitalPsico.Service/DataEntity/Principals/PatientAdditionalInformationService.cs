using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.VO.Patient.PatientAdditionalInformation;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class PatientAdditionalInformationService : EntityBaseService<PatientAdditionalInformation, AddPatientAdditionalInformationVO, UpdatePatientAdditionalInformationVO, GetPatientAdditionalInformationVO
        , IPatientAdditionalInformationRepository>, IPatientAdditionalInformationService

    {
        private readonly IUserRepository _userRepository;

        public PatientAdditionalInformationService(IMapper mapper
            , Serilog.ILogger logger
            , IResiliencePolicyConfig policyConfig
            , IPatientAdditionalInformationRepository entityRepository
            , IUserRepository userRepository
            , IValidator<PatientAdditionalInformation> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(mapper, logger, policyConfig, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _userRepository = userRepository;
        }
        public async override Task<ServiceResponse<List<GetPatientAdditionalInformationVO>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientAdditionalInformationVO>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);

            return result;
        }

        public override async Task<ServiceResponse<GetPatientAdditionalInformationVO>> Create(AddPatientAdditionalInformationVO item)
        {
            PatientAdditionalInformation entityAdd = _mapper.Map<PatientAdditionalInformation>(item);

            #region Relationship

            entityAdd.CreatedUserId = UserId;
            entityAdd.PatientId = item.PatientId;

            #endregion

            entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();

            ServiceResponse<GetPatientAdditionalInformationVO> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                PatientAdditionalInformation entityResponse = await _entityRepository.Create(entityAdd);

                response.Data = _mapper.Map<GetPatientAdditionalInformationVO>(entityResponse);
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterCreated", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }

        public override async Task<ServiceResponse<GetPatientAdditionalInformationVO>> Update(UpdatePatientAdditionalInformationVO item)
        {

            PatientAdditionalInformation entityUpdate = await _entityRepository.FindByID(item.Id);

            #region Relationship 
            entityUpdate.ModifyUserId = UserId;

            #endregion Relationship

            entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();
            entityUpdate.LastAccessDate = DataHelper.GetDateTimeNow();

            #region Columns
            entityUpdate.Enable = item.Enable;
            entityUpdate.FollowUp_Neurological = item.FollowUp_Neurological;
            entityUpdate.FollowUp_Psychiatric = item.FollowUp_Psychiatric;
            #endregion Columns

            ServiceResponse<GetPatientAdditionalInformationVO> response = await base.Validate(entityUpdate);

            if (response.Success)
            {
                PatientAdditionalInformation entityResponse = await _entityRepository.Update(entityUpdate);

                response.Data = _mapper.Map<GetPatientAdditionalInformationVO>(entityResponse);
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterUpdated", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetPatientAdditionalInformationVO>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientAdditionalInformationVO>> response = new ServiceResponse<List<GetPatientAdditionalInformationVO>>();

            var listResult = await _entityRepository.FindAllByPatient(patientId);

            var recordsList = new RecordsList<PatientAdditionalInformation>
            {
                UserIdLogged = UserId,
                Records = listResult

            };
            var validator = new PatientAdditionalInformationSelectListValidator(_userRepository);
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
            response.Data = listResult.Select(c => _mapper.Map<GetPatientAdditionalInformationVO>(c)).ToList();
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsFound", _applicationLanguageRepository, _cacheService);
            return response;
        }
        /// <summary>
        /// MODELO SELECT 1 VALIDACAO 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override async Task<ServiceResponse<GetPatientAdditionalInformationVO>> FindByID(long id)
        {
            ServiceResponse<GetPatientAdditionalInformationVO> response = new ServiceResponse<GetPatientAdditionalInformationVO>();
            try
            {
                PatientAdditionalInformation entityResponse = await _entityRepository.FindByID(id);

                var recordData = new Record<PatientAdditionalInformation>
                {
                    UserIdLogged = UserId,
                    RecordEntity = entityResponse
                };

                var validator = new PatientAdditionalInformationSelectOneValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordData);
                if (!validationResult.IsValid)
                {
                    response.Errors = validator.GetMapErros(validationResult.Errors);
                    response.Success = false;
                    response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                           ("ErrorValidator_User_Not_Permission", _applicationLanguageRepository, _cacheService);
                    return response;
                }
                response.Data = _mapper.Map<GetPatientAdditionalInformationVO>(entityResponse);
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