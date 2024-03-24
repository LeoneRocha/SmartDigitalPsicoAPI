using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Localization;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
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
      : EntityBaseSimpleService<ApplicationLanguage, AddApplicationLanguageVO, UpdateApplicationLanguageVO, GetApplicationLanguageVO, IApplicationLanguageRepository>, IApplicationLanguageService
    {  

        public ApplicationLanguageService(IMapper mapper, IApplicationLanguageRepository entityRepository
             , IValidator<ApplicationLanguage> entityValidator, IApplicationLanguageRepository applicationLanguageRepository,
               ICacheService cacheService)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {  

        }
        public static async Task<string> GetLocalization<T>(string key, Microsoft.Extensions.Localization.IStringLocalizer<T> localizer)
        {
            string result = "NotFoundLocalization";
            try
            {
                var culturenameCurrent = CultureInfo.CurrentCulture;

                var findKey = CultureDateTimeHelper.GetNameAndCulture(key);
                string message = localizer.GetString(findKey);

                result = message;
            }
            catch (Exception)
            {

            }
            await Task.FromResult(string.Empty);

            return result;
        }
        public override async Task<ServiceResponse<List<GetApplicationLanguageVO>>> FindAll()
        {
            long idu = this.UserId;

            string keyCache = "FindAll_GetApplicationLanguageVO";

            ServiceResponse<List<GetApplicationLanguageVO>> result = new ServiceResponse<List<GetApplicationLanguageVO>>();
            List<GetApplicationLanguageVO> listEntity = new List<GetApplicationLanguageVO>();

            result = await CacheService.GetDataFromCache<List<GetApplicationLanguageVO>>(base._cacheService, keyCache);
            if (base._cacheService.IsEnable())
            {
                if (result.Data == null)
                {
                    result = await base.FindAll();

                    await CacheService.SaveDataToCache(keyCache, result.Data, base._cacheService);
                }
                else
                {
                    result.Data = result.Data;
                }
            }
            else
            {
                result = await base.FindAll();
            } 
            return result;
        }

        public static async Task<string> GetLocalization<T>(string key,
            IApplicationLanguageRepository languageRepository, ICacheService cacheService)
        {
            string resultLocalization = $"NotFoundLocalization|{key}|";
            try
            {
                var culturenameCurrent = CultureInfo.CurrentCulture;
                var findKey = CultureDateTimeHelper.GetNameAndCulture(key);

                string keyCache = "FindAll_GetApplicationLanguageVO";
                ServiceResponse<List<GetApplicationLanguageVO>> resultFromCache = new ServiceResponse<List<GetApplicationLanguageVO>>();

                resultFromCache = await CacheService.GetDataFromCache<List<GetApplicationLanguageVO>>(cacheService, keyCache);

                string resourceKey = "SharedResource";
                string language = culturenameCurrent.Name;
                if (resultFromCache != null && resultFromCache.Data != null && resultFromCache.Data.Count > 0)
                {
                    try
                    {
                        GetApplicationLanguageVO languageFindFromCache = filterAndGetSingle(resultFromCache, resourceKey, key, language);
                        resultLocalization = languageFindFromCache.LanguageValue;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    var languageFindDB = await languageRepository.Find(language, key, resourceKey);
                    resultLocalization = languageFindDB.LanguageValue;
                }
            }
            catch (Exception)
            {

            }
            return resultLocalization;
        }

        private static GetApplicationLanguageVO filterAndGetSingle(ServiceResponse<List<GetApplicationLanguageVO>> resultFromCache, string resourceKey, string key, string language)
        {
            return resultFromCache.Data.Single(p => p.ResourceKey.ToUpper().Trim().Equals(resourceKey.ToUpper().Trim())
            && p.LanguageKey.ToUpper().Trim().Equals(key.ToUpper().Trim())
            && p.Language.ToUpper().Trim().Equals(language.ToUpper().Trim()));
        }
    }
}