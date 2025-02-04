using FluentValidation;
using Microsoft.Extensions.Localization;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Resiliency;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.Infrastructure.CacheManager;
using System.Globalization;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    public class ApplicationLanguageService : EntityBaseService<ApplicationLanguage, AddApplicationLanguageDto, UpdateApplicationLanguageDto, GetApplicationLanguageDto, IApplicationLanguageRepository>, IApplicationLanguageService
    {
        public ApplicationLanguageService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IApplicationLanguageRepository entityRepository,
            IValidator<ApplicationLanguage> entityValidator
            ) : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
        }
        public override async Task<ServiceResponse<List<GetApplicationLanguageDto>>> FindAll()
        {
            string keyCache = "FindAll_GetApplicationLanguageVO";

            ServiceResponse<List<GetApplicationLanguageDto>> result = await CacheService.GetDataFromCache<List<GetApplicationLanguageDto>>(_cacheService, keyCache);
            if (_cacheService.IsEnable())
            {
                if (result.Data == null)
                {
                    result = await base.FindAll();

                    await CacheService.SaveDataToCache(keyCache, result.Data, _cacheService);
                }
            }
            else
            {
                result = await base.FindAll();
            }
            return result;
        }

        #region GetLocalization
        public static async Task<string> GetLocalization<T>(string key, IStringLocalizer<T> localizer)
        {
            var findKey = CultureDateTimeHelper.GetNameAndCulture(key);
            string message = localizer.GetString(findKey);

            await Task.FromResult("NotFoundLocalization");

            return message;
        }

        public async Task<string> GetLocalization<T>(string key, string defaultMenssage, ICacheService cacheService)
        {
            string resultLocalization = string.Empty;

            var culturenameCurrent = CultureInfo.CurrentCulture;

            string keyCache = "FindAll_GetApplicationLanguageVO";
            ServiceResponse<List<GetApplicationLanguageDto>> resultFromCache = await CacheService.GetDataFromCache<List<GetApplicationLanguageDto>>(cacheService, keyCache);

            string resourceKey = typeof(T).Name.Replace("I", "");
            string language = culturenameCurrent.Name;
            try
            {
                if (resultFromCache != null && resultFromCache.Data != null && resultFromCache.Data.Count > 0)
                {
                    GetApplicationLanguageDto? languageFindFromCache = filterAndGetSingle(resultFromCache, resourceKey, key, language);
                    if (languageFindFromCache != null)
                    {
                        resultLocalization = languageFindFromCache.LanguageValue;
                    }
                }
                else
                {
                    var existLanguage = await _entityRepository.ExistLanguage(language, key, resourceKey); 
                    if (existLanguage)
                    {
                        var languageFindDB = await _entityRepository.Find(language, key, resourceKey);
                        if (languageFindDB != null)
                        {
                            resultLocalization = languageFindDB.LanguageValue;
                        }
                    }
                    else
                    {
                        try
                        {
                            var defaultLanguage = new AddApplicationLanguageDto();
                            defaultLanguage.Language = "en-US";
                            defaultLanguage.Description = defaultMenssage;
                            defaultLanguage.LanguageValue = defaultMenssage;
                            defaultLanguage.LanguageKey = key;
                            defaultLanguage.ResourceKey = resourceKey;


                            var existLanguageDafault = await _entityRepository.ExistLanguage(defaultLanguage.Language, key, resourceKey);
                            if (!existLanguageDafault)
                            {
                                await Save(defaultLanguage);
                                resultLocalization = string.IsNullOrEmpty(resultLocalization) ? $"NotFoundLocalizationButInsertedDefault|{key}|{defaultMenssage}" : resultLocalization;
                            }
                        }
                        catch (Exception ex)
                        {
                            _logger.Error(ex, "GetLocalization: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
                        }
                    }
                    if (_cacheService.IsEnable())
                    {
                        var result = await _entityRepository.FindAll();
                        var data = result.Select(c => _mapper.Map<GetApplicationLanguageDto>(c)).ToList();

                        await CacheService.SaveDataToCache(keyCache, data, _cacheService);
                    }
                }
            }
            catch (Exception)
            {
                resultLocalization = string.IsNullOrEmpty(resultLocalization) ? $"NotFoundLocalization|{key}|{defaultMenssage}" : resultLocalization;
                //Feature add default menssage. 
            }
            return resultLocalization;
        }

        #endregion GetLocalization


        public virtual async Task Save(AddApplicationLanguageDto item)
        {
            ServiceResponse<GetApplicationLanguageDto> response = new ServiceResponse<GetApplicationLanguageDto>();
            try
            {
                await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
                {
                    ApplicationLanguage entityAdd = _mapper.Map<ApplicationLanguage>(item);
                    entityAdd.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
                    entityAdd.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                    entityAdd.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();
                    entityAdd.Enable = true;

                    response = await Validate(entityAdd);
                    if (response.Success)
                    {
                        ApplicationLanguage entityResponse = await _entityRepository.Create(entityAdd);
                        response.Data = _mapper.Map<GetApplicationLanguageDto>(entityResponse);
                    }
                });
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Create: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
            }
        }

        private static GetApplicationLanguageDto? filterAndGetSingle(ServiceResponse<List<GetApplicationLanguageDto>> resultFromCache, string resourceKey, string key, string language)
        {
            if (resultFromCache.Data == null)
            {
                throw new AppWarningException("filterAndGetSingle: Data cannot be null.");
            }
            return resultFromCache.Data.FirstOrDefault(p =>
            p.ResourceKey.Trim().Equals(resourceKey.Trim(), StringComparison.OrdinalIgnoreCase)
            && p.LanguageKey.Trim().Equals(key.Trim(), StringComparison.OrdinalIgnoreCase)
            && p.Language.Trim().Equals(language.Trim(), StringComparison.OrdinalIgnoreCase)
            );
        }
    }
}