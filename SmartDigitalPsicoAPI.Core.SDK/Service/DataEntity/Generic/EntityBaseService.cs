using AutoMapper;
using Azure;
using DocumentFormat.OpenXml.Spreadsheet;
using FluentValidation;
using FluentValidation.Results;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Constants;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces;

using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Service;
using Serilog;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Constants;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Resiliency;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SmartDigitalPsicoAPI.Core.SDK.Service.DataEntity.Generic
{
    /// <summary>
    /// Classe responsÃ¡vel por EntityBaseService (mÃ¡x. 2 genÃ©ricos â€” Sonar S2436).
    /// DTOs Add/Update via IEntityDtoAdd/IEntityDto; repositÃ³rio tipado como SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository&lt;TEntity&gt;.
    /// </summary>
    public class EntityBaseService<TEntity, TEntityResult>
        : IEntityBaseService<TEntity, TEntityResult>
        where TEntity : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityBase, SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityBaseLog
        where TEntityResult : class
    {
        protected readonly IMapper _mapper;
        protected readonly SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<TEntity> _entityRepository;
        protected readonly IValidator<TEntity> _entityValidator;
        protected long UserId { get; private set; }
        protected readonly ICacheService _cacheService;
        protected readonly Serilog.ILogger _logger;
        protected readonly IResiliencePolicyConfig _policyConfig;
        

        /// <summary>
        /// MÃ©todo EntityBaseService: executa a operaÃ§Ã£o EntityBaseService.
        /// </summary>
        public EntityBaseService(
    IMapper mapper,
    Serilog.ILogger logger,
    SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Service.ICacheService cacheService,
    SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig policyConfig,
    SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<TEntity> entityRepository,
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
        /// MÃ©todo SetUserId: configura estado ou dependencias.
        /// </summary>
        public void SetUserId(long id)
        {
            UserId = id;
        }
        /// <summary>
        /// MÃ©todo GetLocalization: consulta e retorna dados.
        /// </summary>
        protected virtual async Task<string> GetLocalization(string key, string defaultMenssage)
        {
            return await Task.FromResult(defaultMenssage);
        }

        /// <summary>
        /// MÃ©todo Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public virtual async Task<ServiceResponse<TEntityResult>> Create(IEntityDtoAdd item)
        {
            ServiceResponse<TEntityResult> response = new ServiceResponse<TEntityResult>();
            try
            {
                await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
                {
                    TEntity entityAdd = _mapper.Map<TEntity>(item);
                    entityAdd.CreatedDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                    entityAdd.ModifyDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                    entityAdd.LastAccessDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
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
                response.Success = false;
                response.Errors.Add(new ErrorResponse() { Name = "Create", Message = $"{ex.Message}-{ex.InnerException?.Message}" });
                response.Message = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);

                _logger.Error(ex, "Create: {Message} at: {Time}", ex.Message, SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// MÃ©todo Delete: remove ou cancela um registro/recurso.
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
                        response.Success = false;
                        response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                    }
                    else
                    {
                        response.Success = await _entityRepository.Delete(id);
                        if (response.Success)
                        {
                            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterDeleted, GeneralLanguageMenssageConstants.RegisterDeleted);
                            response.Success = true;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Errors.Add(new ErrorResponse() { Name = "Delete", Message = $"{ex.Message}-{ex.InnerException?.Message}" });
                response.Message = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                _logger.Error(ex, "Delete: {Message} at: {Time}", ex.Message, SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// MÃ©todo Update: atualiza um registro/recurso existente.
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
                        response.Success = false;
                        response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);

                    }
                    var entityUpdate = _mapper.Map<TEntity>(item);
                    response = await Validate(entityUpdate);
                    entityUpdate.ModifyDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
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
                response.Success = false;
                response.Message = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                _logger.Error(ex, "Update: {Message} at: {Time}", ex.Message, SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// MÃ©todo Exists: valida regras ou verifica existÃªncia.
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
                     response.Success = true;
                     response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterExist, GeneralLanguageMenssageConstants.RegisterExist);
                 });
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                _logger.Error(ex, "Exists: {Message} at: {Time}", ex.Message, SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// MÃ©todo FindAll: consulta e retorna dados.
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

                    response.Success = true;
                    response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterExist, GeneralLanguageMenssageConstants.RegisterExist);
                });
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                _logger.Error(ex, "FindAll: {Message} at: {Time}", ex.Message, SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// MÃ©todo FindByID: consulta e retorna dados.
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
                    response.Success = true;

                    response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterFind, GeneralLanguageMenssageConstants.RegisterFind);
                });

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                _logger.Error(ex, "FindByID: {Message} at: {Time}", ex.Message, SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// MÃ©todo GetCount: consulta e retorna dados.
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
                    response.Success = true;
                    response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCounted, GeneralLanguageMenssageConstants.RegisterCounted);
                });
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                _logger.Error(ex, "GetCount: {Message} at: {Time}", ex.Message, SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// MÃ©todo EnableOrDisable: altera o estado de habilitaÃ§Ã£o do recurso.
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
                        response.Success = false;
                        response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                    }
                    else
                    {
                        response.Success = await _entityRepository.EnableOrDisable(id);
                        if (response.Success)
                        {
                            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
                            response.Success = true;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                _logger.Error(ex, "EnableOrDisable: {Message} at: {Time}", ex.Message, SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        /// <summary>
        /// MÃ©todo Validate: valida regras ou verifica existÃªncia.
        /// </summary>
        public virtual async Task<ServiceResponse<TEntityResult>> Validate(TEntity item)
        {
            ServiceResponse<TEntityResult> response = new ServiceResponse<TEntityResult>();
            try
            {

                var validationResult = await _entityValidator.ValidateAsync(item);

                response.Success = validationResult.IsValid;
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
                response.Success = false;
                response.Message = await GetLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                _logger.Error(ex, "Validate: {Message} at: {Time}", ex.Message, SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        //HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors)

        /// <summary>
        /// MÃ©todo GetLocalizationErros: consulta e retorna dados.
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




