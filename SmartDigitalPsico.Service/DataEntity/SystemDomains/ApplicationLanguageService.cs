using FluentValidation;
using Microsoft.Extensions.Localization;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
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
            string resourceKey = typeof(T).Name.Replace("I", "");
            string language = culturenameCurrent.Name;
            await SaveCache(keyCache);
            try
            {
                ServiceResponse<List<GetApplicationLanguageDto>> resultFromCache = await CacheService.GetDataFromCache<List<GetApplicationLanguageDto>>(cacheService, keyCache);

                GetApplicationLanguageDto? languageFindFromCache = FindLanguageFromCache(resultFromCache, resourceKey, key, language);
                if (languageFindFromCache != null)
                {
                    resultLocalization = languageFindFromCache.LanguageValue;
                }
                else
                {
                    var existLanguage = await _entityRepository.ExistLanguage(language, key, resourceKey);
                    if (existLanguage)
                    {
                        resultLocalization = await GetLanguageFromDataBase(key, resultLocalization, resourceKey, language);
                    }
                    else
                    {
                        resultLocalization = await InsertLanguageNotFound(key, defaultMenssage, resultLocalization, keyCache, resourceKey);
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

        private async Task<string> GetLanguageFromDataBase(string key, string resultLocalization, string resourceKey, string language)
        {
            var languageFindDB = await _entityRepository.Find(language, key, resourceKey);
            if (languageFindDB != null)
            {
                resultLocalization = languageFindDB.LanguageValue;
            }

            return resultLocalization;
        }

        private async Task<string> InsertLanguageNotFound(string key, string defaultMenssage, string resultLocalization, string keyCache, string resourceKey)
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

                    await RemoveCache(keyCache);
                    //Update
                    await SaveCache(keyCache, true);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "GetLocalization: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
            }

            return resultLocalization;
        }

        private async Task SaveCache(string keyCache, bool overWrite = false)
        {
            if (_cacheService.IsEnable())
            {
                if (!_cacheService.Exists<GetApplicationLanguageDto>(keyCache) || overWrite)
                {
                    var result = await _entityRepository.FindAll();
                    var data = result.Select(c => _mapper.Map<GetApplicationLanguageDto>(c)).ToList();

                    await CacheService.SaveDataToCache(keyCache, data, _cacheService);
                }
            }
        }

        public async Task RemoveCache(string keyCache)
        {
            if (_cacheService.IsEnable())
            {
                await Task.FromResult(_cacheService.Remove<GetApplicationLanguageDto>(keyCache));
            }
        }
        #endregion GetLocalization


        public virtual async Task Save(AddApplicationLanguageDto item)
        {
            ServiceResponse<GetApplicationLanguageDto> response = new ServiceResponse<GetApplicationLanguageDto>();
            try
            {
                ApplicationLanguage entityAdd = _mapper.Map<ApplicationLanguage>(item);
                entityAdd.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
                entityAdd.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                entityAdd.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();
                entityAdd.Enable = true;

                if (response.Success)
                {
                    ApplicationLanguage entityResponse = await _entityRepository.Create(entityAdd);
                    response.Data = _mapper.Map<GetApplicationLanguageDto>(entityResponse);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Create: {Message} at: {time}", ex.Message, DateHelper.GetDateTimeNowToLog());
            }
        }

        private static GetApplicationLanguageDto? FindLanguageFromCache(ServiceResponse<List<GetApplicationLanguageDto>> resultFromCache, string resourceKey, string key, string language)
        {
            if (resultFromCache != null && resultFromCache.Data != null && resultFromCache.Data.Count > 0)
            {
                var languageByCulture = resultFromCache.Data.FirstOrDefault(p =>
                p.ResourceKey.Trim().Equals(resourceKey.Trim(), StringComparison.OrdinalIgnoreCase)
                && p.LanguageKey.Trim().Equals(key.Trim(), StringComparison.OrdinalIgnoreCase)
                && p.Language.Trim().Equals(language.Trim(), StringComparison.OrdinalIgnoreCase)
                );

                if (languageByCulture != null)
                {
                    return languageByCulture;
                }
                var languageDefaultCulture = resultFromCache.Data.FirstOrDefault(p =>
                p.ResourceKey.Trim().Equals(resourceKey.Trim(), StringComparison.OrdinalIgnoreCase)
                && p.LanguageKey.Trim().Equals(key.Trim(), StringComparison.OrdinalIgnoreCase)
                && p.Language.Trim().Equals("en-us", StringComparison.OrdinalIgnoreCase)
                );

                return languageDefaultCulture;

            }
            return null;

        }
    }
}