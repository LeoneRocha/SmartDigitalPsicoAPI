using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Localization;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Domains.AddVOs;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.Domains.UpdateVOs;
using SmartDigitalPsico.Service.CacheManager;
using SmartDigitalPsico.Service.Generic;
using System.Globalization;

namespace SmartDigitalPsico.Service.SystemDomains
{
    public class ApplicationLanguageService
      : EntityBaseService<ApplicationLanguage, AddApplicationLanguageVO, UpdateApplicationLanguageVO, GetApplicationLanguageVO, IApplicationLanguageRepository>, IApplicationLanguageService
    {

        public ApplicationLanguageService(IMapper mapper
            , Serilog.ILogger logger
            , IResiliencePolicyConfig policyConfig
            , IApplicationLanguageRepository entityRepository
            , IValidator<ApplicationLanguage> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(mapper, logger, policyConfig, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {

        }
        public override async Task<ServiceResponse<List<GetApplicationLanguageVO>>> FindAll()
        {
            string keyCache = "FindAll_GetApplicationLanguageVO";

            ServiceResponse<List<GetApplicationLanguageVO>> result = await CacheService.GetDataFromCache<List<GetApplicationLanguageVO>>(base._cacheService, keyCache);
            if (base._cacheService.IsEnable())
            {
                if (result.Data == null)
                {
                    result = await base.FindAll();

                    await CacheService.SaveDataToCache(keyCache, result.Data, base._cacheService);
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

        public static async Task<string> GetLocalization<T>(string key, IApplicationLanguageRepository languageRepository, ICacheService cacheService)
        {
            string resultLocalization = string.Empty;

            var culturenameCurrent = CultureInfo.CurrentCulture;

            string keyCache = "FindAll_GetApplicationLanguageVO";
            ServiceResponse<List<GetApplicationLanguageVO>> resultFromCache = await CacheService.GetDataFromCache<List<GetApplicationLanguageVO>>(cacheService, keyCache);

            string resourceKey = typeof(T).Name.Replace("I", "");
            string language = culturenameCurrent.Name;
            try
            {
                if (resultFromCache != null && resultFromCache.Data != null && resultFromCache.Data.Count > 0)
                {
                    GetApplicationLanguageVO languageFindFromCache = filterAndGetSingle(resultFromCache, resourceKey, key, language);
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

        private static GetApplicationLanguageVO filterAndGetSingle(ServiceResponse<List<GetApplicationLanguageVO>> resultFromCache, string resourceKey, string key, string language)
        {
            if (resultFromCache.Data == null)
            {
                throw new AppWarningException("filterAndGetSingle: Data cannot be null.");
            }
            return resultFromCache.Data.Single(p =>
            p.ResourceKey.Trim().Equals(resourceKey.Trim(), StringComparison.OrdinalIgnoreCase)
            && p.LanguageKey.Trim().Equals(key.Trim(), StringComparison.OrdinalIgnoreCase)
            && p.Language.Trim().Equals(language.Trim(), StringComparison.OrdinalIgnoreCase)
            );
        }
    }
}