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
using SmartDigitalPsico.Domain.DTO.Patient.PatientHospitalizationInformation;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using Azure;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class PatientHospitalizationInformationService : EntityBaseService<PatientHospitalizationInformation, AddPatientHospitalizationInformationDto, UpdatePatientHospitalizationInformationDto, GetPatientHospitalizationInformationDto, IPatientHospitalizationInformationRepository>, IPatientHospitalizationInformationService

    {
        private readonly IUserRepository _userRepository;

        public PatientHospitalizationInformationService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IPatientHospitalizationInformationRepository entityRepository,
            IValidator<PatientHospitalizationInformation> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
            _userRepository = sharedRepositories.UserRepository;
        }

        public override async Task<ServiceResponse<GetPatientHospitalizationInformationDto>> Create(AddPatientHospitalizationInformationDto item)
        {

            PatientHospitalizationInformation entityAdd = _mapper.Map<PatientHospitalizationInformation>(item);

            #region Relationship

            entityAdd.CreatedUserId = UserId;
            entityAdd.PatientId = item.PatientId;

            #endregion

            entityAdd.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
            entityAdd.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
            entityAdd.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

            ServiceResponse<GetPatientHospitalizationInformationDto> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                PatientHospitalizationInformation entityResponse = await _entityRepository.Create(entityAdd);

                response.Data = _mapper.Map<GetPatientHospitalizationInformationDto>(entityResponse); 
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCreated, GeneralLanguageMenssageConstants.RegisterCreated);
            }

            return response;
        }

        public override async Task<ServiceResponse<GetPatientHospitalizationInformationDto>> Update(UpdatePatientHospitalizationInformationDto item)
        {

            PatientHospitalizationInformation entityUpdate = await _entityRepository.FindByID(item.Id);

            #region Relationship                 
            entityUpdate.ModifyUserId = UserId;
            #endregion

            entityUpdate.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
            entityUpdate.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

            #region Columns
            entityUpdate.Enable = item.Enable;
            entityUpdate.CID = item.CID;
            entityUpdate.Description = item.Description;
            entityUpdate.StartDate = item.StartDate;
            entityUpdate.EndDate = item.EndDate;
            entityUpdate.Observation = item.Observation;
            #endregion Columns

            ServiceResponse<GetPatientHospitalizationInformationDto> response = await base.Validate(entityUpdate);

            if (response.Success)
            {
                PatientHospitalizationInformation entityResponse = await _entityRepository.Update(entityUpdate);

                response.Data = _mapper.Map<GetPatientHospitalizationInformationDto>(entityResponse);                
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
            }

            return response;
        }
        public async Task<ServiceResponse<List<GetPatientHospitalizationInformationDto>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientHospitalizationInformationDto>> response = new ServiceResponse<List<GetPatientHospitalizationInformationDto>>();

            var listResult = await _entityRepository.FindAllByPatient(patientId);

            var recordsList = new RecordsList<PatientHospitalizationInformation>
            {
                UserIdLogged = UserId,
                Records = listResult

            };
            var validator = new PatientHospitalizationInformationSelectListValidator(_userRepository);
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
            response.Data = listResult.Select(c => _mapper.Map<GetPatientHospitalizationInformationDto>(c)).ToList();
            response.Success = true;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);            
            return response;
        }

        public async override Task<ServiceResponse<List<GetPatientHospitalizationInformationDto>>> FindAll()
        {
            var response = new ServiceResponse<List<GetPatientHospitalizationInformationDto>>();
            response.Success = false;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound); 
            return response;
        }
        public override async Task<ServiceResponse<GetPatientHospitalizationInformationDto>> FindByID(long id)
        {
            ServiceResponse<GetPatientHospitalizationInformationDto> response = new ServiceResponse<GetPatientHospitalizationInformationDto>();
            try
            {
                PatientHospitalizationInformation entityResponse = await _entityRepository.FindByID(id);

                var recordData = new Record<PatientHospitalizationInformation>
                {
                    UserIdLogged = UserId,
                    RecordEntity = entityResponse
                };

                var validator = new PatientHospitalizationInformationSelectOneValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordData);
                if (!validationResult.IsValid)
                {
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Success = false;
                    response.Message = await GetLocalization(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);
                    return response;
                }
                response.Data = _mapper.Map<GetPatientHospitalizationInformationDto>(entityResponse);
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