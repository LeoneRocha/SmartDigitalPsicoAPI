using FluentValidation;
using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Patient.ADD;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Domain.DTO.Patient.UPDATE;
using SmartDigitalPsico.Domain.DTO.Patient.Common;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Validation;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    /// <summary>
    /// Classe responsável por PatientService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class PatientService : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<Patient, GetPatientDto>, IPatientService

    {
        private readonly IUserRepository _userRepository;
        /// <summary>
        /// Método PatientService: executa a operação PatientService.
        /// </summary>
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
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public override async Task<ServiceResponse<GetPatientDto>> Create(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
        {
            var dto = (AddPatientDto)item;
            Patient entityAdd = _mapper.Map<Patient>(dto);

            #region Set default fields for bussines

            entityAdd.CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

            #endregion Set default fields for bussines

            #region User Action

            entityAdd.CreatedUserId = UserId;

            #endregion User Action

            ServiceResponse<GetPatientDto> response = await base.Validate(entityAdd);
            if (response.Success)
            {
                #region Relationship 

                entityAdd.MedicalId = dto.MedicalId;
                entityAdd.GenderId = dto.GenderId;
                #endregion Relationship

                Patient entityResponse = await ((IPatientRepository)_entityRepository).Create(entityAdd);
                response.Data = _mapper.Map<GetPatientDto>(entityResponse);
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCreated, GeneralLanguageMenssageConstants.RegisterCreated);
            }
            return response;
        }

        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public override async Task<ServiceResponse<GetPatientDto>> Update(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDto item)
        {
            var dto = (UpdatePatientDto)item;
            ServiceResponse<GetPatientDto> response = new ServiceResponse<GetPatientDto>();
            Patient? entityUpdate = await ((IPatientRepository)_entityRepository).FindByID(dto.Id);
            if (entityUpdate != null)
            {
                #region Set default fields for bussines

                entityUpdate.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entityUpdate.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

                #endregion Set default fields for bussines

                #region User Action

                entityUpdate.ModifyUserId = UserId;

                #endregion User Action

                #region Relationship

                entityUpdate.GenderId = dto.GenderId;

                #endregion Relationship

                #region Columns
                entityUpdate.Enable = dto.Enable;
                entityUpdate.Name = dto.Name;
                entityUpdate.Email = dto.Email;
                entityUpdate.Cpf = dto.Cpf;
                entityUpdate.Rg = dto.Rg;
                entityUpdate.Education = dto.Education;
                entityUpdate.DateOfBirth = dto.DateOfBirth;
                entityUpdate.PhoneNumber = dto.PhoneNumber;
                entityUpdate.Profession = dto.Profession;

                entityUpdate.EmergencyContactName = dto.EmergencyContactName;
                entityUpdate.EmergencyContactPhoneNumber = dto.EmergencyContactPhoneNumber;

                entityUpdate.AddressCep = dto.AddressCep;
                entityUpdate.AddressCity = dto.AddressCity;
                entityUpdate.AddressStreet = dto.AddressStreet;
                entityUpdate.AddressState = dto.AddressState;
                entityUpdate.AddressNeighborhood = dto.AddressNeighborhood;

                #endregion Columns

                response = await base.Validate(entityUpdate);
                if (response.Success)
                {
                    Patient entityResponse = await ((IPatientRepository)_entityRepository).Update(entityUpdate);
                    response.Data = _mapper.Map<GetPatientDto>(entityResponse);
                    response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);                     
                }
            }
            return response;
        }

        /// <summary>
        /// Método FindByPatient: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<GetPatientDto>> FindByPatient(GetPatientDto info)
        {
            ServiceResponse<GetPatientDto> response = new ServiceResponse<GetPatientDto>();

            var patientFind = _mapper.Map<Patient>(info);

            var patientFinded = await ((IPatientRepository)_entityRepository).FindByPatient(patientFind);

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
        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<List<GetPatientDto>>> FindAll()
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método PatientSearch: executa a operação PatientSearch.
        /// </summary>
        public async Task<ServiceResponse<List<GetPatientDto>>> PatientSearch(PatientSearchCriteriaDto patientSearchCriteriaDto)
        {
            ServiceResponse<List<GetPatientDto>> response = new ServiceResponse<List<GetPatientDto>>();

            List<Patient> listResult = await ((IPatientRepository)_entityRepository).PatientSearch(patientSearchCriteriaDto);
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
            if (listResult.Count == 0)
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                return response;
            }
            response.Data = listResult.Select(c => _mapper.Map<GetPatientDto>(c))
                .OrderBy(e => e.Name)
                .ToList();

            response.Success = true;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);
            return response;
        }

        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<List<GetPatientDto>>> FindAll(long medicalId)
        {
            ServiceResponse<List<GetPatientDto>> response = new ServiceResponse<List<GetPatientDto>>();

            List<Patient> listResult = await ((IPatientRepository)_entityRepository).FindAllByMedicalId(medicalId);
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
            if (listResult.Count == 0)
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);   
                return response;
            }
            response.Data = listResult.Select(c => _mapper.Map<GetPatientDto>(c))
                .OrderBy(e=> e.Name)
                .ToList();

            response.Success = true;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);
            return response;
        }
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<GetPatientDto>> FindByID(long id)
        {
            ServiceResponse<GetPatientDto> response = new ServiceResponse<GetPatientDto>();
            try
            {
                Patient entityResponse = await ((IPatientRepository)_entityRepository).FindByID(id);

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

