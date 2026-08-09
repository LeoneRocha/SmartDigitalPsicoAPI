using FluentValidation;
using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Patient.ADD;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Domain.DTO.Patient.UPDATE;
using SmartDigitalPsico.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Validation;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe responsável por PatientNotificationMessageService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class PatientNotificationMessageService
        : SmartDigitalPsico.Service.EntityBaseService<PatientNotificationMessage, GetPatientNotificationMessageVO>, IPatientNotificationMessageService

    {
        private readonly IPatientRepository _patientRepository;
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Método PatientNotificationMessageService: executa a operação PatientNotificationMessageService.
        /// </summary>
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
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public override async Task<ServiceResponse<GetPatientNotificationMessageVO>> Create(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
        {
            var dto = (AddPatientNotificationMessageDto)item;
            PatientNotificationMessage entityAdd = _mapper.Map<PatientNotificationMessage>(dto);

            #region Relationship

            entityAdd.CreatedUserId = UserId;

            Patient patientAdd = await _patientRepository.FindByPatient(new Patient() { Cpf = dto.CPF, Rg = dto.RG, Email = dto.Email }) ?? new Patient();
            entityAdd.PatientId = patientAdd.Id;

            #endregion

            entityAdd.CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

            ServiceResponse<GetPatientNotificationMessageVO> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                PatientNotificationMessage entityResponse = await ((IPatientNotificationMessageRepository)_entityRepository).Create(entityAdd);

                response.Data = _mapper.Map<GetPatientNotificationMessageVO>(entityResponse);
                response.Success = true;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCreated, GeneralLanguageMenssageConstants.RegisterCreated);

            }
            return response;
        }

        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public override async Task<ServiceResponse<GetPatientNotificationMessageVO>> Update(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDto item)
        {
            var dto = (UpdatePatientNotificationMessageDto)item;
            PatientNotificationMessage entityUpdate = await ((IPatientNotificationMessageRepository)_entityRepository).FindByID(dto.Id);

            entityUpdate.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityUpdate.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

            entityUpdate.ModifyUserId = UserId;

            #region Columns
            entityUpdate.Enable = dto.Enable;
            entityUpdate.MessagePatient = dto.Message;

            entityUpdate.IsReaded = dto.IsReaded;
            entityUpdate.ReadingDate = dto.IsReaded ? SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc() : null;

            entityUpdate.Notified = dto.Notified;
            entityUpdate.NotifiedDate = dto.Notified ? SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc() : null;

            #endregion Columns

            ServiceResponse<GetPatientNotificationMessageVO> response = await base.Validate(entityUpdate);

            if (response.Success)
            {
                PatientNotificationMessage entityResponse = await ((IPatientNotificationMessageRepository)_entityRepository).Update(entityUpdate);

                response.Data = _mapper.Map<GetPatientNotificationMessageVO>(entityResponse);
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
            }

            return response;
        }
        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<List<GetPatientNotificationMessageVO>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientNotificationMessageVO>> response = new ServiceResponse<List<GetPatientNotificationMessageVO>>();

            var listResult = await ((IPatientNotificationMessageRepository)_entityRepository).FindAllByPatient(patientId);

            if (listResult.Count == 0)
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                return response;
            }
            response.Data = listResult.Select(c => _mapper.Map<GetPatientNotificationMessageVO>(c)).ToList();
            response.Success = true;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);
            return response;
        }

        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        public async override Task<ServiceResponse<List<GetPatientNotificationMessageVO>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientNotificationMessageVO>>();
            result.Success = false;
            result.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);

            return result;
        }

        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<GetPatientNotificationMessageVO>> FindByID(long id)
        {
            ServiceResponse<GetPatientNotificationMessageVO> response = new ServiceResponse<GetPatientNotificationMessageVO>();
            try
            {
                PatientNotificationMessage entityResponse = await ((IPatientNotificationMessageRepository)_entityRepository).FindByID(id);

                var recordData = new Record<PatientNotificationMessage>
                {
                    UserIdLogged = UserId,
                    RecordEntity = entityResponse
                };

                var validator = new PatientNotificationMessageSelectOneValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordData);
                if (!validationResult.IsValid)
                {
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Success = false;
                    response.Message = await GetLocalization(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);

                    return response;
                }
                response.Data = _mapper.Map<GetPatientNotificationMessageVO>(entityResponse);
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

