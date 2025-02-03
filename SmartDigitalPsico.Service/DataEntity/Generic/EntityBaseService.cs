using AutoMapper;
using DocumentFormat.OpenXml.Spreadsheet;
using FluentValidation;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Resiliency;
using SmartDigitalPsico.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using System.Linq.Expressions;

namespace SmartDigitalPsico.Service.DataEntity.Generic
{
    public class EntityBaseService<TEntity, TEntityAdd, TEntityUpdate, TEntityResult, Repo>
        : IEntityBaseService<TEntity, TEntityAdd, TEntityUpdate, TEntityResult>
        where TEntity : IEntityBase, IEntityBaseLog
        where TEntityAdd : IEntityDtoAdd
        where TEntityUpdate : IEntityDto
        where TEntityResult : class
        where Repo : IEntityBaseRepository<TEntity>
    {
        protected readonly IMapper _mapper;
        protected readonly Repo _entityRepository;
        protected readonly IValidator<TEntity> _entityValidator;
        protected long UserId { get; private set; }
        protected readonly IApplicationLanguageRepository _applicationLanguageRepository;
        protected readonly ICacheService _cacheService;
        protected readonly Serilog.ILogger _logger;
        protected readonly IResiliencePolicyConfig _policyConfig;
        private readonly IApplicationLanguageService _applicationLanguageService;

        public EntityBaseService(
              ISharedServices sharedServices,
              ISharedDependenciesConfig sharedDependenciesConfig,
              ISharedRepositories sharedRepositories,
              Repo entityRepository,
              IValidator<TEntity> entityValidator
            )
        {
            _mapper = sharedDependenciesConfig.Mapper;
            _logger = sharedDependenciesConfig.Logger;
            _applicationLanguageRepository = sharedRepositories.ApplicationLanguageRepository;
            _cacheService = sharedServices.CacheService;
            _policyConfig = sharedDependenciesConfig.PolicyConfig;
            _entityRepository = entityRepository;
            _entityValidator = entityValidator;

            _applicationLanguageService = sharedServices.ApplicationLanguageService;
        }
        public void SetUserId(long id)
        {
            UserId = id;
        }
        protected async Task<string> getMessageFromLocalization(string key, string defaultMenssage)
        {
            return await _applicationLanguageService.GetLocalization<ISharedResource>(key, defaultMenssage, _applicationLanguageRepository, _cacheService);
        }

        public virtual async Task<ServiceResponse<TEntityResult>> Create(TEntityAdd item)
        {
            ServiceResponse<TEntityResult> response = new ServiceResponse<TEntityResult>();
            try
            {
                await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
                {
                    TEntity entityAdd = _mapper.Map<TEntity>(item);
                    entityAdd.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
                    entityAdd.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                    entityAdd.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();
                    entityAdd.Enable = true;

                    response = await Validate(entityAdd);
                    if (response.Success)
                    {
                        TEntity entityResponse = await _entityRepository.Create(entityAdd);
                        response.Data = _mapper.Map<TEntityResult>(entityResponse);
                        response.Message = await getMessageFromLocalization(GeneralLanguageKeyConstants.RegisterCreated, GeneralLanguageMenssageConstants.RegisterCreated);

                    }
                });
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Errors.Add(new ErrorResponse() { Name = "Create", Message = $"{ex.Message}-{ex.InnerException?.Message}" });
                response.Message = await getMessageFromLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.GenericErroMessage);

                _logger.Error(ex, "Create: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
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
                        response.Message = await getMessageFromLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                    }
                    else
                    {
                        response.Success = await _entityRepository.Delete(id);
                        if (response.Success)
                        {
                            response.Message = await getMessageFromLocalization(GeneralLanguageKeyConstants.RegisterDeleted, GeneralLanguageMenssageConstants.RegisterDeleted);
                            response.Success = true;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Errors.Add(new ErrorResponse() { Name = "Delete", Message = $"{ex.Message}-{ex.InnerException?.Message}" });
                response.Message = await getMessageFromLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.GenericErroMessage);
                _logger.Error(ex, "Delete: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        public virtual async Task<ServiceResponse<TEntityResult>> Update(TEntityUpdate item)
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
                        response.Message = await getMessageFromLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);

                    }
                    var entityUpdate = _mapper.Map<TEntity>(item);
                    response = await Validate(entityUpdate);
                    entityUpdate.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                    if (response.Success)
                    {
                        TEntity entityResponse = await _entityRepository.Update(entityUpdate);
                        response.Data = _mapper.Map<TEntityResult>(entityResponse);
                        response.Message = await getMessageFromLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
                    }
                });
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = await getMessageFromLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.GenericErroMessage);
                _logger.Error(ex, "Update: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
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
                     response.Message = await getMessageFromLocalization(GeneralLanguageKeyConstants.RegisterExist, GeneralLanguageMenssageConstants.RegisterExist);
                 });
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = await getMessageFromLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.GenericErroMessage);
                _logger.Error(ex, "Exists: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
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
                    response.Message = await getMessageFromLocalization(GeneralLanguageKeyConstants.RegisterExist, GeneralLanguageMenssageConstants.RegisterExist);
                });
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = await getMessageFromLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.GenericErroMessage);
                _logger.Error(ex, "FindAll: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
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

                    response.Message = await getMessageFromLocalization(GeneralLanguageKeyConstants.RegisterFind, GeneralLanguageMenssageConstants.RegisterFind);
                });

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = await getMessageFromLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.GenericErroMessage);
                _logger.Error(ex, "FindByID: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
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
                    response.Message = await getMessageFromLocalization(GeneralLanguageKeyConstants.RegisterCounted, GeneralLanguageMenssageConstants.RegisterCounted);
                });
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = await getMessageFromLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.GenericErroMessage);
                _logger.Error(ex, "GetCount: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
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
                        response.Message = await getMessageFromLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                    }
                    else
                    {
                        response.Success = await _entityRepository.EnableOrDisable(id);
                        if (response.Success)
                        {
                            response.Message = await getMessageFromLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
                            response.Success = true;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = await getMessageFromLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.GenericErroMessage);
                _logger.Error(ex, "EnableOrDisable: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
        public virtual async Task<ServiceResponse<TEntityResult>> Validate(TEntity item)
        {
            ServiceResponse<TEntityResult> response = new ServiceResponse<TEntityResult>();
            try
            {
                await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
                {
                    var validationResult = await _entityValidator.ValidateAsync(item);

                    response.Success = validationResult.IsValid;
                    response.Errors = HelperValidation.GetErrosMap(validationResult);
                    response.Message = HelperValidation.GetMessage(validationResult.IsValid);
                    //Translate Message  
                    if (response.Errors != null)
                    {
                        List<ErrorResponse> errosTranslated = new List<ErrorResponse>();
                        foreach (var errosItem in response.Errors)
                        {
                            var errosAdd = new ErrorResponse()
                            {
                                Message = await _applicationLanguageService.GetLocalization<ISharedResource>(errosItem.ErrorCode, errosItem.Message, _applicationLanguageRepository, _cacheService),
                                Name = errosItem.Name
                            };
                            errosTranslated.Add(errosAdd);
                        }
                        response.Errors = errosTranslated;
                    }
                    response.Message = await _applicationLanguageService.GetLocalization<ISharedResource>(ValidatorConstants.GenericErroMessageKey, response.Message, _applicationLanguageRepository, _cacheService);
                });

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = await getMessageFromLocalization(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.GenericErroMessage);
                _logger.Error(ex, "Validate: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
            }
            return response;
        }
    }
}