using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Service.DataEntity.Generic
{
    /// <summary>
    /// Classe responsável por ReportBaseService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class ReportBaseService<TEntity, Repo>
        where TEntity : SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityBaseLog
        where Repo : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<TEntity>

    {
        protected readonly IMapper _mapper;
        protected readonly Repo _entityRepository;
        protected readonly IValidator<TEntity> _entityValidator;
        protected long UserId { get; private set; }
        protected readonly IApplicationLanguageRepository _applicationLanguageRepository;
        protected readonly SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService _cacheService;
        protected readonly IAppLogger _logger;
        protected readonly SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig _policyConfig;
         
        /// <summary>
        /// Método ReportBaseService: executa a operação ReportBaseService.
        /// </summary>
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
        /// <summary>
        /// Método SetUserId: configura estado ou dependencias.
        /// </summary>
        public void SetUserId(long id)
        {
            UserId = id;
        }  
    }
}
