using System.Linq.Expressions;
using FluentValidation;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Core.SDK.Domain.Extensions;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service;
using SmartDigitalPsico.Core.SDK.Domain.Resiliency;
using SmartDigitalPsico.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Core.SDK.Service.DataEntity.Generic
{
    /// <summary>
    /// Classe responsável por EntityBaseService (máx. 2 genéricos — Sonar S2436).
    /// DTOs Add/Update via IEntityDtoAdd/IEntityDto; repositório tipado como SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository&lt;TEntity&gt;.
    /// </summary>
    /// <remarks>
    /// <b>EVO.4 / especialização:</b> <b>não</b> herda SCH <c>EntityBaseService</c> —
    /// divergência de logger (<c>IAppLogger</c> vs <c>ISdpAppLogger</c>) e cache.
    /// Envelope <c>Success</c> já alinhado à matriz SCH (AJ.3 onda 1).
    /// </remarks>
    [SdkWrappedSource(
        targetType: "SmartCoreHub.Core.SDK.Service.Services.Generic.EntityBaseService`2",
        targetPackage: "SmartCoreHub.Core.SDK",
        description: "EVO.4: especialização SDP (KeepBoth) — não herda SCH; logger/IEntity* divergem.")]
    public class EntityBaseService<TEntity, TEntityResult>
        : IEntityBaseService<TEntity, TEntityResult>
        where TEntity : SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityBaseLog
        where TEntityResult : class
    {
        protected readonly IAppMapper _mapper;
        protected readonly SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<TEntity> _entityRepository;
        protected readonly IValidator<TEntity> _entityValidator;
        protected long UserId { get; private set; }
        protected readonly ICacheService _cacheService;
        protected readonly IAppLogger _logger;
        protected readonly IResiliencePolicyConfig _policyConfig;


        /// <summary>
        /// Operação EntityBaseService: executa a operação EntityBaseService.
        /// </summary>
        public EntityBaseService(
    IAppMapper mapper,
    IAppLogger logger,
    SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService cacheService,
    SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig policyConfig,
    SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<TEntity> entityRepository,
    IValidator<TEntity> entityValidator
)
        {
            _mapper = mapper;
            _logger = logger;
            _cacheService = cacheService;
            _policyConfig = policyConfig;
            _entityRepository = entityRepository;
            _entityValidator = entityValidator;
        }
        /// <summary>
        /// Operação SetUserId: configura estado ou dependencias.
        /// </summary>
        public void SetUserId(long id)
        {
            UserId = id;
        }
        /// <summary>
        /// Operação GetLocalization: consulta e retorna dados.
        /// </summary>
        protected virtual async Task<string> GetLocalization(string key, string defaultMenssage)
        {
            return await Task.FromResult(defaultMenssage);
        }

        /// <summary>
        /// Operação Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public virtual async Task<ServiceResponse<TEntityResult>> Create(IEntityDtoAdd item)
        {
            ServiceResponse<TEntityResult> response = new ServiceResponse<TEntityResult>();
            try
            {
                await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
                {
                    TEntity entityAdd = _mapper.Map<TEntity>(item);
                    entityAdd.CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                    entityAdd.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                    entityAdd.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                    entityAdd.Enable = true;

                    response = await Validate(entityAdd);
                    if (response.Success)
                    {
                        TEntity entityResponse = await _entityRepository.Create(entityAdd);
                        response.Data = _mapper.Map<TEntityResult>(entityResponse);
                        response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCreated, GeneralLanguageMenssageConstants.RegisterCreated);
                    }
                });
            }
            catch (Exception ex)
            {
                response.FailWith($"{ex.Message}-{ex.InnerException?.Message}", "Create");
                response.Message = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);

                _logger.Error(ex, "Create: {Message} at: {Time}", ex.Message, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// Operação Delete: remove ou cancela um registro/recurso.
        /// </summary>
        public virtual async Task<ServiceResponse<bool>> Delete(long id)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
                {
                    bool exists = await _entityRepository.Exists(id);
                    if (!exists)
                    {
                        var notFound = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                        response.FailWith(notFound, "Delete");
                    }
                    else
                    {
                        var deleted = await _entityRepository.Delete(id);
                        response.Data = deleted;
                        if (deleted)
                        {
                            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterDeleted, GeneralLanguageMenssageConstants.RegisterDeleted);
                        }
                        else
                        {
                            var failMsg = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                            response.FailWith(failMsg, "Delete");
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                response.FailWith($"{ex.Message}-{ex.InnerException?.Message}", "Delete");
                response.Message = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                _logger.Error(ex, "Delete: {Message} at: {Time}", ex.Message, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// Operação Update: atualiza um registro/recurso existente.
        /// </summary>
        public virtual async Task<ServiceResponse<TEntityResult>> Update(IEntityDto item)
        {
            ServiceResponse<TEntityResult> response = new ServiceResponse<TEntityResult>();
            try
            {
                await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
                {

                    bool entityExists = await _entityRepository.Exists(item.Id);
                    if (!entityExists)
                    {
                        var notFound = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                        response.FailWith(notFound, "Update");
                        return;
                    }
                    var entityUpdate = _mapper.Map<TEntity>(item);
                    response = await Validate(entityUpdate);
                    entityUpdate.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                    if (response.Success)
                    {
                        TEntity entityResponse = await _entityRepository.Update(entityUpdate);
                        response.Data = _mapper.Map<TEntityResult>(entityResponse);
                        response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
                    }
                });
            }
            catch (Exception ex)
            {
                var msg = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                response.FailWith(msg, "Update");
                _logger.Error(ex, "Update: {Message} at: {Time}", ex.Message, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// Operação Exists: valida regras ou verifica existência.
        /// </summary>
        public async Task<ServiceResponse<bool>> Exists(long id)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
                 {
                     bool entityResponse = await _entityRepository.Exists(id);

                     response.Data = entityResponse;
                     response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterExist, GeneralLanguageMenssageConstants.RegisterExist);
                 });
            }
            catch (Exception ex)
            {
                var msg = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                response.FailWith(msg, "Exists");
                _logger.Error(ex, "Exists: {Message} at: {Time}", ex.Message, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// Operação FindAll: consulta e retorna dados.
        /// </summary>
        public virtual async Task<ServiceResponse<List<TEntityResult>>> FindAll()
        {
            ServiceResponse<List<TEntityResult>> response = new ServiceResponse<List<TEntityResult>>();
            try
            {
                await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
                {
                    List<TEntity> entityResponse = await _entityRepository.FindAll();

                    response.Data = entityResponse.Select(c => _mapper.Map<TEntityResult>(c)).ToList();

                    response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterExist, GeneralLanguageMenssageConstants.RegisterExist);
                });
            }
            catch (Exception ex)
            {
                var msg = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                response.FailWith(msg, "FindAll");
                _logger.Error(ex, "FindAll: {Message} at: {Time}", ex.Message, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// Operação FindByID: consulta e retorna dados.
        /// </summary>
        public virtual async Task<ServiceResponse<TEntityResult>> FindByID(long id)
        {
            ServiceResponse<TEntityResult> response = new ServiceResponse<TEntityResult>();
            try
            {
                await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
                {
                    TEntity? entityResponse = await _entityRepository.FindByID(id);
                    if (!EqualityComparer<TEntity>.Default.Equals(entityResponse, default))
                    {
                        response.Data = _mapper.Map<TEntityResult>(entityResponse);
                    }

                    response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterFind, GeneralLanguageMenssageConstants.RegisterFind);
                });

            }
            catch (Exception ex)
            {
                var msg = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                response.FailWith(msg, "FindByID");
                _logger.Error(ex, "FindByID: {Message} at: {Time}", ex.Message, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// Operação GetCount: consulta e retorna dados.
        /// </summary>
        public virtual async Task<ServiceResponse<int>> GetCount()
        {
            ServiceResponse<int> response = new ServiceResponse<int>();
            try
            {
                await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
                {
                    Expression<Func<TEntity, bool>> predicate = g => g.Id > 0;
                    int entityResponse = await _entityRepository.GetCount(predicate);

                    response.Data = entityResponse;
                    response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCounted, GeneralLanguageMenssageConstants.RegisterCounted);
                });
            }
            catch (Exception ex)
            {
                var msg = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                response.FailWith(msg, "GetCount");
                _logger.Error(ex, "GetCount: {Message} at: {Time}", ex.Message, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// Operação EnableOrDisable: altera o estado de habilitação do recurso.
        /// </summary>
        public virtual async Task<ServiceResponse<bool>> EnableOrDisable(long id)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
                {
                    bool exists = await _entityRepository.Exists(id);
                    if (!exists)
                    {
                        var notFound = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                        response.FailWith(notFound, "EnableOrDisable");
                    }
                    else
                    {
                        var toggled = await _entityRepository.EnableOrDisable(id);
                        response.Data = toggled;
                        if (toggled)
                        {
                            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
                        }
                        else
                        {
                            var failMsg = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                            response.FailWith(failMsg, "EnableOrDisable");
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                var msg = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                response.FailWith(msg, "EnableOrDisable");
                _logger.Error(ex, "EnableOrDisable: {Message} at: {Time}", ex.Message, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// Operação Validate: valida regras ou verifica existência.
        /// </summary>
        public virtual async Task<ServiceResponse<TEntityResult>> Validate(TEntity item)
        {
            ServiceResponse<TEntityResult> response = new ServiceResponse<TEntityResult>();
            try
            {

                var validationResult = await _entityValidator.ValidateAsync(item);

                response.Errors = HelperValidation.GetErrorsMap(validationResult).ToList();
                //Translate Message  
                if (response.Errors.Count > 0)
                {
                    List<ErrorResponse> errosTranslated = new List<ErrorResponse>();
                    foreach (var errosItem in response.Errors)
                    {
                        var errosAdd = new ErrorResponse()
                        {
                            Name = errosItem.Name,
                            Message = await GetLocalization(errosItem.ErrorCode, errosItem.DefaultMessage),
                            DefaultMessage = errosItem.DefaultMessage,
                            ErrorCode = errosItem.ErrorCode,
                            FullMessage = errosItem.FullMessage
                        };
                        errosAdd = HelperValidation.TranslateErroCode(errosAdd);

                        errosTranslated.Add(errosAdd);
                    }
                    response.Errors = errosTranslated;
                    response.Message = await GetLocalization(ValidatorConstants.ValidateErroMessageKey, ValidatorConstants.ValidateErroMessage_Message);
                }
                else
                {
                    response.Message = await GetLocalization(ValidatorConstants.ValidateSuccessMessageKey, ValidatorConstants.ValidateSuccessMessage_Message);
                }
            }
            catch (Exception ex)
            {
                var msg = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                response.FailWith(msg, "Validate");
                _logger.Error(ex, "Validate: {Message} at: {Time}", ex.Message, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }

        /// <summary>
        /// Operação GetLocalizationErros: consulta e retorna dados.
        /// </summary>
        protected async Task<List<ErrorResponse>> GetLocalizationErros(List<ErrorResponse> errorResponses)
        {
            if (errorResponses != null && errorResponses.Count > 0)
            {
                List<ErrorResponse> errosTranslated = new List<ErrorResponse>();
                foreach (var errosItem in errorResponses)
                {
                    var errosAdd = new ErrorResponse()
                    {
                        //GetMennsage 
                        Name = errosItem.Name,
                        ErrorCode = errosItem.ErrorCode,
                        Message = await GetLocalization(errosItem.ErrorCode, errosItem.DefaultMessage),
                        DefaultMessage = errosItem.DefaultMessage,
                        FullMessage = errosItem.FullMessage,
                    };
                    errosAdd.Message = HelperValidation.TranslateErroCode(errosAdd.Message, errosAdd.ErrorCode);
                    errosAdd = HelperValidation.TranslateErroCode(errosAdd);

                    errosTranslated.Add(errosAdd);
                }
                errorResponses = errosTranslated;
            }
            return errorResponses!;
        }
    }
}
