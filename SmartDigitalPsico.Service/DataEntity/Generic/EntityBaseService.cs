using System;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Service.DataEntity.Generic;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;

namespace SmartDigitalPsico.Service.DataEntity.Generic
{
    [Obsolete("Use SmartDigitalPsicoAPI.Core.SDK.Service.DataEntity.Generic.EntityBaseService instead.")]
    public class EntityBaseService<TEntity, TEntityResult> : SmartDigitalPsicoAPI.Core.SDK.Service.DataEntity.Generic.EntityBaseService<TEntity, TEntityResult>
        where TEntity : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityBase, SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityBaseLog
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

