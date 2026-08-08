using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.DTO.Patient.ADD;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Domain.DTO.Patient.UPDATE;
using SmartDigitalPsico.Domain.DTO.Patient.Common;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.Interfaces.User;
namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    /// <summary>
    /// Classe responsável por PatientHospitalizationInformationService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class PatientHospitalizationInformationService : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<PatientHospitalizationInformation, GetPatientHospitalizationInformationDto>, IPatientHospitalizationInformationService

    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Método PatientHospitalizationInformationService: executa a operação PatientHospitalizationInformationService.
        /// </summary>
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

        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public override async Task<ServiceResponse<GetPatientHospitalizationInformationDto>> Create(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
        {
            var dto = (AddPatientHospitalizationInformationDto)item;

            PatientHospitalizationInformation entityAdd = _mapper.Map<PatientHospitalizationInformation>(dto);

            #region Relationship

            entityAdd.CreatedUserId = UserId;
            entityAdd.PatientId = dto.PatientId;

            #endregion

            entityAdd.CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

            ServiceResponse<GetPatientHospitalizationInformationDto> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                PatientHospitalizationInformation entityResponse = await ((IPatientHospitalizationInformationRepository)_entityRepository).Create(entityAdd);

                response.Data = _mapper.Map<GetPatientHospitalizationInformationDto>(entityResponse); 
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCreated, GeneralLanguageMenssageConstants.RegisterCreated);
            }

            return response;
        }

        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public override async Task<ServiceResponse<GetPatientHospitalizationInformationDto>> Update(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDto item)
        {
            var dto = (UpdatePatientHospitalizationInformationDto)item;

            PatientHospitalizationInformation entityUpdate = await ((IPatientHospitalizationInformationRepository)_entityRepository).FindByID(dto.Id);

            #region Relationship                 
            entityUpdate.ModifyUserId = UserId;
            #endregion

            entityUpdate.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityUpdate.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

            #region Columns
            entityUpdate.Enable = dto.Enable;
            entityUpdate.CID = dto.CID;
            entityUpdate.Description = dto.Description;
            entityUpdate.StartDate = dto.StartDate;
            entityUpdate.EndDate = dto.EndDate;
            entityUpdate.Observation = dto.Observation;
            #endregion Columns

            ServiceResponse<GetPatientHospitalizationInformationDto> response = await base.Validate(entityUpdate);

            if (response.Success)
            {
                PatientHospitalizationInformation entityResponse = await ((IPatientHospitalizationInformationRepository)_entityRepository).Update(entityUpdate);

                response.Data = _mapper.Map<GetPatientHospitalizationInformationDto>(entityResponse);                
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
            }

            return response;
        }
        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<List<GetPatientHospitalizationInformationDto>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientHospitalizationInformationDto>> response = new ServiceResponse<List<GetPatientHospitalizationInformationDto>>();

            var listResult = await ((IPatientHospitalizationInformationRepository)_entityRepository).FindAllByPatient(patientId);

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

            if (listResult.Count == 0)
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

        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        public async override Task<ServiceResponse<List<GetPatientHospitalizationInformationDto>>> FindAll()
        {
            var response = new ServiceResponse<List<GetPatientHospitalizationInformationDto>>();
            response.Success = false;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound); 
            return response;
        }
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<GetPatientHospitalizationInformationDto>> FindByID(long id)
        {
            ServiceResponse<GetPatientHospitalizationInformationDto> response = new ServiceResponse<GetPatientHospitalizationInformationDto>();
            try
            {
                PatientHospitalizationInformation entityResponse = await ((IPatientHospitalizationInformationRepository)_entityRepository).FindByID(id);

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

