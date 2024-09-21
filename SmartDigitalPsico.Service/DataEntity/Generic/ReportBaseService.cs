using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;

namespace SmartDigitalPsico.Service.DataEntity.Generic
{
    public class ReportBaseService<TEntity, Repo>
        where TEntity : IEntityBase, IEntityBaseLog
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
         
        public ReportBaseService(
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
        }
        public void SetUserId(long id)
        {
            UserId = id;
        }  
    }
}