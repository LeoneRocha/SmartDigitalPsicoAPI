using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical
{
    /// <summary>
    /// Shared Medical host context (user, i18n, validation helpers). Scoped per request.
    /// </summary>
    public class MedicalScheduleHostSupport
    {
        private readonly IApplicationLanguageService _languageService;
        private readonly SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService _cacheService;
        private readonly IMedicalCalendarValidators _validators;

        /// <summary>
        /// Método MedicalScheduleHostSupport: executa a operação MedicalScheduleHostSupport.
        /// </summary>
        public MedicalScheduleHostSupport(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            IMedicalCalendarValidators validators,
            IPatientRepositories patientRepositories)
        {
            Mapper = sharedDependenciesConfig.Mapper;
            Logger = sharedDependenciesConfig.Logger;
            _languageService = sharedServices.ApplicationLanguageService;
            _cacheService = sharedServices.CacheService;
            _validators = validators;
            UserRepository = patientRepositories.SharedRepositories.UserRepository;
            PatientRepository = patientRepositories.PatientRepository;
        }

        public long UserId { get; private set; }
        public IAppMapper Mapper { get; }
        public IAppLogger Logger { get; }
        public IUserRepository UserRepository { get; }
        public IPatientRepository PatientRepository { get; }

        /// <summary>
        /// Método SetUserId: configura estado ou dependencias.
        /// </summary>
        public void SetUserId(long userId) => UserId = userId;

        /// <summary>
        /// Método Loc: executa a operação Loc.
        /// </summary>
        public Task<string> Loc(string key, string fallback)
            => _languageService.GetLocalization<ISharedResource>(key, fallback, _cacheService);

        /// <summary>
        /// Método TranslateErrors: executa a operação TranslateErrors.
        /// </summary>
        public async Task<List<ErrorResponse>> TranslateErrors(List<ErrorResponse> errors)
        {
            var translated = new List<ErrorResponse>();
            foreach (var item in errors)
            {
                var add = new ErrorResponse
                {
                    Name = item.Name,
                    ErrorCode = item.ErrorCode,
                    Message = await Loc(item.ErrorCode, item.DefaultMessage),
                    DefaultMessage = item.DefaultMessage,
                    FullMessage = item.FullMessage
                };
                translated.Add(HelperValidation.TranslateErroCode(add));
            }
            return translated;
        }

        /// <summary>
        /// Método ValidateEntityAsync: valida regras ou verifica existência.
        /// </summary>
        public async Task<ServiceResponse<GetMedicalCalendarDto>> ValidateEntityAsync(MedicalCalendar entity)
        {
            var response = new ServiceResponse<GetMedicalCalendarDto>();
            var validationResult = await _validators.EntityValidator.ValidateAsync(entity);
            response.Success = validationResult.IsValid;
            response.Errors = HelperValidation.GetErrorsMap(validationResult).ToList();
            if (response.Errors.Count > 0)
            {
                response.Errors = await TranslateErrors(response.Errors);
                response.Message = await Loc(ValidatorConstants.ValidateErroMessageKey, ValidatorConstants.ValidateErroMessage_Message);
            }
            return response;
        }

        /// <summary>
        /// Método MapNewEntity: mapeia ou transforma dados entre modelos.
        /// </summary>
        public MedicalCalendar MapNewEntity(AddMedicalCalendarDto item)
        {
            var entity = Mapper.Map<MedicalCalendar>(item);
            entity.Enable = true;
            entity.CreatedUserId = UserId;
            entity.PatientId = item.PatientId;
            entity.MedicalId = item.MedicalId;
            entity.CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entity.ModifyDate = entity.CreatedDate;
            entity.LastAccessDate = entity.CreatedDate;
            if (string.IsNullOrWhiteSpace(entity.TokenRecurrence))
                entity.TokenRecurrence = Guid.NewGuid().ToString();
            return entity;
        }

        /// <summary>
        /// Método OkDto: executa a operação OkDto.
        /// </summary>
        public static ServiceResponse<GetMedicalCalendarDto> OkDto(GetMedicalCalendarDto data, string message)
            => new() { Success = true, Data = data, Message = message };

        /// <summary>
        /// Método FailDto: executa a operação FailDto.
        /// </summary>
        public static ServiceResponse<GetMedicalCalendarDto> FailDto(string? message, List<ErrorResponse>? errors = null)
            => new()
            {
                Success = false,
                Message = message ?? string.Empty,
                Errors = errors ?? []
            };

        /// <summary>
        /// Método OkBool: executa a operação OkBool.
        /// </summary>
        public static ServiceResponse<bool> OkBool(bool data, string message)
            => new() { Success = true, Data = data, Message = message };

        /// <summary>
        /// Método FailBool: executa a operação FailBool.
        /// </summary>
        public static ServiceResponse<bool> FailBool(string? message)
            => new() { Success = false, Message = message ?? string.Empty };
    }
}
