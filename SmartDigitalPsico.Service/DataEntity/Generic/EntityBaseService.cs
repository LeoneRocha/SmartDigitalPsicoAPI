using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;

namespace SmartDigitalPsico.Service.DataEntity.Generic
{
    /// <summary>
    /// Bridge de produto sobre EntityBaseService do Core — injeta i18n via IApplicationLanguageService.
    /// Serviços de domínio devem herdar este tipo. Base canônica: SmartDigitalPsico.Core.SDK.Service.DataEntity.Generic.EntityBaseService.
    /// </summary>
    public class EntityBaseService<TEntity, TEntityResult> : SmartDigitalPsico.Core.SDK.Service.DataEntity.Generic.EntityBaseService<TEntity, TEntityResult>
        where TEntity : SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityBaseLog
        where TEntityResult : class
    {
        protected readonly Lazy<IApplicationLanguageService> _applicationLanguageService;

        public EntityBaseService(
              ISharedServices sharedServices,
              ISharedDependenciesConfig sharedDependenciesConfig,
              ISharedRepositories sharedRepositories,
              IEntityBaseRepository<TEntity> entityRepository,
              IValidator<TEntity> entityValidator
            ) : base(
                sharedDependenciesConfig.Mapper,
                sharedDependenciesConfig.Logger,
                sharedServices.CacheService,
                sharedDependenciesConfig.PolicyConfig,
                entityRepository,
                entityValidator
            )
        {
            _applicationLanguageService = new Lazy<IApplicationLanguageService>(() => sharedServices.ApplicationLanguageService);
        }

        protected override async Task<string> GetLocalization(string key, string defaultMenssage)
        {
            return await _applicationLanguageService.Value.GetLocalization<SmartDigitalPsico.Domain.Interfaces.ISharedResource>(key, defaultMenssage, _cacheService);
        }
    }
}

