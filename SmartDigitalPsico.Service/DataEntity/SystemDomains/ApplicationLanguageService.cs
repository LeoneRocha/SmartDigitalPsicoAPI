using FluentValidation;
using Microsoft.Extensions.Localization;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.Infrastructure.CacheManager;
using System.Globalization;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    /// <summary>
    /// Classe responsÃ¡vel por ApplicationLanguageService.
    /// Responsabilidade: serviÃ§o de entidade de negÃ³cio.
    /// RelaÃ§Ã£o: orquestra repositÃ³rios, validators e mapeamentos.
    /// </summary>
    public class ApplicationLanguageService : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<ApplicationLanguage, GetApplicationLanguageDto>, IApplicationLanguageService
    {
        /// <summary>
        /// MÃ©todo ApplicationLanguageService: executa a operaÃ§Ã£o ApplicationLanguageService.
        /// </summary>
        public ApplicationLanguageService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IApplicationLanguageRepository entityRepository,
            IValidator<ApplicationLanguage> entityValidator
            ) : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
        }
        /// <summary>
        /// MÃ©todo FindAll: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<List<GetApplicationLanguageDto>>> FindAll()
        {
            string keyCache = "FindAll_GetApplicationLanguageVO";

            ServiceResponse<List<GetApplicationLanguageDto>> result = await SmartDigitalPsico.Core.SDK.Service.Infrastructure.CacheManager.CacheService.GetDataFromCache<List<GetApplicationLanguageDto>>(_cacheService, keyCache);
            if (_cacheService.IsEnable())
            {
                if (result.Data == null)
                {
                    result = await base.FindAll();

                    await SmartDigitalPsico.Core.SDK.Service.Infrastructure.CacheManager.CacheService.SaveDataToCache(keyCache, result.Data, _cacheService);
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
            var findKey = SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetNameAndCulture(key);
            string message = localizer.GetString(findKey);

            await Task.FromResult("NotFoundLocalization");

            return message;
        }

        public async Task<string> GetLocalization<T>(string key, string defaultMenssage, SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService cacheService)
        {
            string resultLocalization = string.Empty;
            string keyCache = "FindAll_GetApplicationLanguageVO";
            string resourceKey = typeof(T).Name.Replace("I", "");
            var culturenameCurrent = CultureInfo.CurrentCulture;
            string language = culturenameCurrent.Name;
            await SaveCache(keyCache);
            try
            {
                ServiceResponse<List<GetApplicationLanguageDto>> resultFromCache = await SmartDigitalPsico.Core.SDK.Service.Infrastructure.CacheManager.CacheService.GetDataFromCache<List<GetApplicationLanguageDto>>(cacheService, keyCache);

                GetApplicationLanguageDto? languageFindFromCache = FindLanguageFromCache(resultFromCache, resourceKey, key, language);
                if (languageFindFromCache != null)
                {
                    resultLocalization = languageFindFromCache.LanguageValue;
                }
                else
                {
                    var existLanguage = await ((IApplicationLanguageRepository)_entityRepository).ExistLanguage(language, key, resourceKey);
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
                resultLocalization = $"NotFoundLocalization|{key}|{defaultMenssage}";
            }
            return resultLocalization;
        }

        private async Task<string> GetLanguageFromDataBase(string key, string resultLocalization, string resourceKey, string language)
        {
            var languageFindDB = await ((IApplicationLanguageRepository)_entityRepository).Find(language, key, resourceKey);
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


                var existLanguageDafault = await ((IApplicationLanguageRepository)_entityRepository).ExistLanguage(defaultLanguage.Language, key, resourceKey);
                if (!existLanguageDafault)
                {
                    await Save(defaultLanguage);
                    resultLocalization = CoalesceLocalization(resultLocalization, $"NotFoundLocalizationButInsertedDefault|{key}|{defaultMenssage}");

                    await RemoveCache(keyCache);
                    //Update
                    await SaveCache(keyCache, true);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "GetLocalization: {Message} at: {Time}", ex.Message, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }

            return resultLocalization;
        }

        private async Task SaveCache(string keyCache, bool overWrite = false)
        {
            if (_cacheService.IsEnable()
                && (!_cacheService.Exists<GetApplicationLanguageDto>(keyCache) || overWrite))
            {
                var result = await ((IApplicationLanguageRepository)_entityRepository).FindAll();
                var data = result.Select(c => _mapper.Map<GetApplicationLanguageDto>(c)).ToList();

                await SmartDigitalPsico.Core.SDK.Service.Infrastructure.CacheManager.CacheService.SaveDataToCache(keyCache, data, _cacheService);
            }
        }


        /// <summary>
        /// MÃ©todo RemoveCache: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task RemoveCache(string keyCache)
        {
            if (_cacheService.IsEnable())
            {
                await Task.FromResult(_cacheService.Remove<GetApplicationLanguageDto>(keyCache));
            }
        }
        #endregion GetLocalization


        /// <summary>
        /// MÃ©todo Save: cria ou persiste um novo registro/recurso.
        /// </summary>
        public virtual async Task Save(AddApplicationLanguageDto item)
        {
            ServiceResponse<GetApplicationLanguageDto> response = new ServiceResponse<GetApplicationLanguageDto>();
            try
            {
                ApplicationLanguage entityAdd = _mapper.Map<ApplicationLanguage>(item);
                entityAdd.CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entityAdd.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entityAdd.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entityAdd.Enable = true;

                if (response.Success)
                {
                    ApplicationLanguage entityResponse = await ((IApplicationLanguageRepository)_entityRepository).Create(entityAdd);
                    response.Data = _mapper.Map<GetApplicationLanguageDto>(entityResponse);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Create: {Message} at: {Time}", ex.Message, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog());
            }
        }


        internal static string CoalesceLocalization(string resultLocalization, string fallback)
            => string.IsNullOrEmpty(resultLocalization) ? fallback : resultLocalization;
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

