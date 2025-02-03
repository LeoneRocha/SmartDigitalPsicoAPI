using FluentValidation;
using Microsoft.Extensions.Localization;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.Infrastructure.CacheManager;
using System.Globalization;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    public class ApplicationLanguageService
      : EntityBaseService<ApplicationLanguage, AddApplicationLanguageDto, UpdateApplicationLanguageDto, GetApplicationLanguageDto, IApplicationLanguageRepository>, IApplicationLanguageService
    {

        public ApplicationLanguageService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IApplicationLanguageRepository entityRepository,
            IValidator<ApplicationLanguage> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
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
         

        public async Task<string> GetLocalization<T>(string key, string defaultMenssage, IApplicationLanguageRepository languageRepository, ICacheService cacheService)
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
                    var existLanguage = await languageRepository.ExistLanguage(language, key, resourceKey);

                    if (existLanguage)
                    {
                        var languageFindDB = await languageRepository.Find(language, key, resourceKey);
                        resultLocalization = languageFindDB.LanguageValue;
                    } else {

                        var defaultLanguage = new AddApplicationLanguageDto();
                        defaultLanguage.Language = "en-US";
                        defaultLanguage.Description = defaultMenssage;
                        defaultLanguage.LanguageValue = defaultMenssage;
                        defaultLanguage.LanguageKey = key;
                        defaultLanguage.ResourceKey = resourceKey;
                        await base.Create(defaultLanguage);
                        resultLocalization = string.IsNullOrEmpty(resultLocalization) ? $"NotFoundLocalizationButInsertedDefault|{key}|{defaultMenssage}" : resultLocalization;
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
         
        [Obsolete("USe o GetLocalization instance")]//SELECT * FROM `smartdigitalhom`.`ApplicationLanguage`  WHERE LanguageKey = 'RegisterIsNotFound'
        public static async Task<string> GetLocalization<T>(string key, IApplicationLanguageRepository languageRepository, ICacheService cacheService)
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
                    GetApplicationLanguageDto languageFindFromCache = filterAndGetSingle(resultFromCache, resourceKey, key, language);
                    resultLocalization = languageFindFromCache.LanguageValue;

                }
                else
                {
                    var languageFindDB = await languageRepository.Find(language, key, resourceKey);
                    resultLocalization = languageFindDB.LanguageValue;
                }
            }
            catch (Exception)
            {
                resultLocalization = string.IsNullOrEmpty(resultLocalization) ? $"NotFoundLocalization|{key}|" : resultLocalization;
            }
            return resultLocalization;
        }
         
        #endregion GetLocalization

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