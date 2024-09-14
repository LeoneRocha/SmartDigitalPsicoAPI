using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    public class PatientRecordServiceConfig : IPatientRecordServiceConfig
    {
        public IMapper Mapper { get; }
        public Serilog.ILogger Logger { get; }
        public IResiliencePolicyConfig PolicyConfig { get; }
        public IValidator<PatientRecord> EntityValidator { get; }
        public IApplicationLanguageRepository ApplicationLanguageRepository { get; }
        public ICacheService CacheService { get; }
        public ICryptoService CryptoService { get; }
        public IStorageTableContract<PatientRecordTableEntity> StorageTableService { get; }

        public PatientRecordServiceConfig(IMapper mapper,
            Serilog.ILogger logger,
            IResiliencePolicyConfig policyConfig,
            IValidator<PatientRecord> entityValidator,
            IApplicationLanguageRepository applicationLanguageRepository,
            ICacheService cacheService,
            ICryptoService cryptoService,
            IStorageTableContract<PatientRecordTableEntity> storageTableService)
        {
            Mapper = mapper;
            Logger = logger;
            PolicyConfig = policyConfig;
            EntityValidator = entityValidator;
            ApplicationLanguageRepository = applicationLanguageRepository;
            CacheService = cacheService;
            CryptoService = cryptoService;
            StorageTableService = storageTableService;
        }
    }
}
