using FluentValidation;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Patient.PatientAdditionalInformation;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;

using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    /// <summary>
    /// Classe responsÃ¡vel por PatientAdditionalInformationService.
    /// Responsabilidade: serviÃ§o de entidade de negÃ³cio.
    /// RelaÃ§Ã£o: orquestra repositÃ³rios, validators e mapeamentos.
    /// </summary>
    public class PatientAdditionalInformationService : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<PatientAdditionalInformation, GetPatientAdditionalInformationDto>, IPatientAdditionalInformationService

    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// MÃ©todo PatientAdditionalInformationService: executa a operaÃ§Ã£o PatientAdditionalInformationService.
        /// </summary>
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
        /// <summary>
        /// MÃ©todo FindAll: consulta e retorna dados.
        /// </summary>
        public async override Task<ServiceResponse<List<GetPatientAdditionalInformationDto>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientAdditionalInformationDto>>();
            result.Success = false;
            result.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
            return result;
        }

        /// <summary>
        /// MÃ©todo Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public override async Task<ServiceResponse<GetPatientAdditionalInformationDto>> Create(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
        {
            var dto = (AddPatientAdditionalInformationDto)item;
            PatientAdditionalInformation entityAdd = _mapper.Map<PatientAdditionalInformation>(dto);

            #region Relationship

            entityAdd.CreatedUserId = UserId;
            entityAdd.PatientId = dto.PatientId;

            #endregion

            entityAdd.CreatedDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.ModifyDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.LastAccessDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

            ServiceResponse<GetPatientAdditionalInformationDto> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                PatientAdditionalInformation entityResponse = await ((IPatientAdditionalInformationRepository)_entityRepository).Create(entityAdd);

                response.Data = _mapper.Map<GetPatientAdditionalInformationDto>(entityResponse);
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCreated, GeneralLanguageMenssageConstants.RegisterCreated);
            }
            return response;
        }

        /// <summary>
        /// MÃ©todo Update: atualiza um registro/recurso existente.
        /// </summary>
        public override async Task<ServiceResponse<GetPatientAdditionalInformationDto>> Update(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityDto item)
        {
            var dto = (UpdatePatientAdditionalInformationDto)item;

            PatientAdditionalInformation entityUpdate = await ((IPatientAdditionalInformationRepository)_entityRepository).FindByID(dto.Id);

            #region Relationship 
            entityUpdate.ModifyUserId = UserId;

            #endregion Relationship

            entityUpdate.ModifyDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityUpdate.LastAccessDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

            #region Columns
            entityUpdate.Enable = dto.Enable;
            entityUpdate.FollowUp_Neurological = dto.FollowUp_Neurological;
            entityUpdate.FollowUp_Psychiatric = dto.FollowUp_Psychiatric;
            #endregion Columns

            ServiceResponse<GetPatientAdditionalInformationDto> response = await base.Validate(entityUpdate);

            if (response.Success)
            {
                PatientAdditionalInformation entityResponse = await ((IPatientAdditionalInformationRepository)_entityRepository).Update(entityUpdate);

                response.Data = _mapper.Map<GetPatientAdditionalInformationDto>(entityResponse);
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
            }
            return response;
        }

        /// <summary>
        /// MÃ©todo FindAllByPatient: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<List<GetPatientAdditionalInformationDto>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientAdditionalInformationDto>> response = new ServiceResponse<List<GetPatientAdditionalInformationDto>>();

            var listResult = await ((IPatientAdditionalInformationRepository)_entityRepository).FindAllByPatient(patientId);

            var recordsList = new RecordsList<PatientAdditionalInformation>
            {
                UserIdLogged = UserId,
                Records = listResult

            };
            var validator = new PatientAdditionalInformationSelectListValidator(_userRepository);
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
            response.Data = listResult.Select(c => _mapper.Map<GetPatientAdditionalInformationDto>(c)).ToList();
            response.Success = true;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);
            return response;
        }
        /// <summary>
        /// MODELO SELECT 1 VALIDACAO 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <summary>
        /// MÃ©todo FindByID: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<GetPatientAdditionalInformationDto>> FindByID(long id)
        {
            ServiceResponse<GetPatientAdditionalInformationDto> response = new ServiceResponse<GetPatientAdditionalInformationDto>();
            try
            {
                PatientAdditionalInformation entityResponse = await ((IPatientAdditionalInformationRepository)_entityRepository).FindByID(id);

                var recordData = new Record<PatientAdditionalInformation>
                {
                    UserIdLogged = UserId,
                    RecordEntity = entityResponse
                };

                var validator = new PatientAdditionalInformationSelectOneValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordData);
                if (!validationResult.IsValid)
                {
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Success = false;
                    response.Message = await GetLocalization(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);
                    return response;
                }
                response.Data = _mapper.Map<GetPatientAdditionalInformationDto>(entityResponse);
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

