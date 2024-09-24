using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.DTO.Patient.PatientAdditionalInformation;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class PatientAdditionalInformationService : EntityBaseService<PatientAdditionalInformation, AddPatientAdditionalInformationDto, UpdatePatientAdditionalInformationDto, GetPatientAdditionalInformationDto
        , IPatientAdditionalInformationRepository>, IPatientAdditionalInformationService

    {
        private readonly IUserRepository _userRepository;

        public PatientAdditionalInformationService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IPatientAdditionalInformationRepository entityRepository,
            IUserRepository userRepository,
            IValidator<PatientAdditionalInformation> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
            _userRepository = userRepository;
        }
        public async override Task<ServiceResponse<List<GetPatientAdditionalInformationDto>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientAdditionalInformationDto>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);

            return result;
        }

        public override async Task<ServiceResponse<GetPatientAdditionalInformationDto>> Create(AddPatientAdditionalInformationDto item)
        {
            PatientAdditionalInformation entityAdd = _mapper.Map<PatientAdditionalInformation>(item);

            #region Relationship

            entityAdd.CreatedUserId = UserId;
            entityAdd.PatientId = item.PatientId;

            #endregion

            entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();

            ServiceResponse<GetPatientAdditionalInformationDto> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                PatientAdditionalInformation entityResponse = await _entityRepository.Create(entityAdd);

                response.Data = _mapper.Map<GetPatientAdditionalInformationDto>(entityResponse);
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterCreated", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }

        public override async Task<ServiceResponse<GetPatientAdditionalInformationDto>> Update(UpdatePatientAdditionalInformationDto item)
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

            ServiceResponse<GetPatientAdditionalInformationDto> response = await base.Validate(entityUpdate);

            if (response.Success)
            {
                PatientAdditionalInformation entityResponse = await _entityRepository.Update(entityUpdate);

                response.Data = _mapper.Map<GetPatientAdditionalInformationDto>(entityResponse);
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterUpdated", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetPatientAdditionalInformationDto>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientAdditionalInformationDto>> response = new ServiceResponse<List<GetPatientAdditionalInformationDto>>();

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
            response.Data = listResult.Select(c => _mapper.Map<GetPatientAdditionalInformationDto>(c)).ToList();
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
        public override async Task<ServiceResponse<GetPatientAdditionalInformationDto>> FindByID(long id)
        {
            ServiceResponse<GetPatientAdditionalInformationDto> response = new ServiceResponse<GetPatientAdditionalInformationDto>();
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
                response.Data = _mapper.Map<GetPatientAdditionalInformationDto>(entityResponse);
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