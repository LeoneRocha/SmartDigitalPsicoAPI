using FluentValidation;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Patient;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class PatientService : EntityBaseService<Patient, AddPatientDto, UpdatePatientDto, GetPatientDto, IPatientRepository>, IPatientService

    {
        private readonly IUserRepository _userRepository;
        public PatientService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IPatientRepository entityRepository,           
            IValidator<Patient> entityValidator           
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
            _userRepository = sharedRepositories.UserRepository;
        }
        public override async Task<ServiceResponse<GetPatientDto>> Create(AddPatientDto item)
        {
            Patient entityAdd = _mapper.Map<Patient>(item);

            #region Set default fields for bussines

            entityAdd.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
            entityAdd.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
            entityAdd.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

            #endregion Set default fields for bussines

            #region User Action

            entityAdd.CreatedUserId = UserId;

            #endregion User Action

            ServiceResponse<GetPatientDto> response = await base.Validate(entityAdd);
            if (response.Success)
            {
                #region Relationship 

                entityAdd.MedicalId = item.MedicalId;
                entityAdd.GenderId = item.GenderId;
                #endregion Relationship

                Patient entityResponse = await _entityRepository.Create(entityAdd);
                response.Data = _mapper.Map<GetPatientDto>(entityResponse);
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCreated, GeneralLanguageMenssageConstants.RegisterCreated);
            }
            return response;
        }

        public override async Task<ServiceResponse<GetPatientDto>> Update(UpdatePatientDto item)
        {
            ServiceResponse<GetPatientDto> response = new ServiceResponse<GetPatientDto>();
            Patient? entityUpdate = await _entityRepository.FindByID(item.Id);
            if (entityUpdate != null)
            {
                #region Set default fields for bussines

                entityUpdate.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                entityUpdate.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();

                #endregion Set default fields for bussines

                #region User Action

                entityUpdate.ModifyUserId = UserId;

                #endregion User Action

                #region Relationship

                entityUpdate.GenderId = item.GenderId;

                #endregion Relationship

                #region Columns
                entityUpdate.Enable = item.Enable;
                entityUpdate.Name = item.Name;
                entityUpdate.Email = item.Email;
                entityUpdate.Cpf = item.Cpf;
                entityUpdate.Rg = item.Rg;
                entityUpdate.Education = item.Education;
                entityUpdate.DateOfBirth = item.DateOfBirth;
                entityUpdate.PhoneNumber = item.PhoneNumber;
                entityUpdate.Profession = item.Profession;

                entityUpdate.EmergencyContactName = item.EmergencyContactName;
                entityUpdate.EmergencyContactPhoneNumber = item.EmergencyContactPhoneNumber;

                entityUpdate.AddressCep = item.AddressCep;
                entityUpdate.AddressCity = item.AddressCity;
                entityUpdate.AddressStreet = item.AddressStreet;
                entityUpdate.AddressState = item.AddressState;
                entityUpdate.AddressNeighborhood = item.AddressNeighborhood;

                #endregion Columns

                response = await base.Validate(entityUpdate);
                if (response.Success)
                {
                    Patient entityResponse = await _entityRepository.Update(entityUpdate);
                    response.Data = _mapper.Map<GetPatientDto>(entityResponse);
                    response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);                     
                }
            }
            return response;
        }

        public async Task<ServiceResponse<GetPatientDto>> FindByPatient(GetPatientDto info)
        {
            ServiceResponse<GetPatientDto> response = new ServiceResponse<GetPatientDto>();

            var patientFind = _mapper.Map<Patient>(info);

            var patientFinded = await _entityRepository.FindByPatient(patientFind);

            if (patientFinded == null)
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);                
                return response;
            }
            response.Data = _mapper.Map<GetPatientDto>(patientFinded);
            response.Success = true;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);            
            return response;

        }
        public override async Task<ServiceResponse<List<GetPatientDto>>> FindAll()
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetPatientDto>>> FindAll(long medicalId)
        {
            ServiceResponse<List<GetPatientDto>> response = new ServiceResponse<List<GetPatientDto>>();

            List<Patient> listResult = await _entityRepository.FindAllByMedicalId(medicalId);
            var recordsList = new RecordsList<Patient>
            {
                UserIdLogged = UserId,
                Records = listResult

            };
            var validator = new PatientSelectListValidator(_userRepository);
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
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);   
                return response;
            }
            response.Data = listResult.Select(c => _mapper.Map<GetPatientDto>(c)).ToList();
            response.Success = true;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);
            return response;
        }
        public override async Task<ServiceResponse<GetPatientDto>> FindByID(long id)
        {
            ServiceResponse<GetPatientDto> response = new ServiceResponse<GetPatientDto>();
            try
            {
                Patient entityResponse = await _entityRepository.FindByID(id);

                var recordData = new Record<Patient>
                {
                    UserIdLogged = UserId,
                    RecordEntity = entityResponse
                };

                var validator = new PatientSelectOneValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordData);
                if (!validationResult.IsValid)
                {
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Success = false;
                    response.Message = await GetLocalization(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);                    
                    return response;
                }
                response.Data = _mapper.Map<GetPatientDto>(entityResponse);
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