using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    public class PatientRecordServiceConfig : IPatientRecordServiceConfig
    {
        public IValidator<PatientRecord> EntityValidator { get; }
        public IStorageTableContract<PatientRecordTableEntity> StorageTableService { get; }
        public ISharedRepositories SharedRepositories { get; }
        public ISharedServices SharedServices { get; }
        public ISharedDependenciesConfig SharedDependenciesConfig { get; }

        public PatientRecordServiceConfig(
            ISharedRepositories sharedRepositories,
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            IValidator<PatientRecord> entityValidator,
            IStorageTableContract<PatientRecordTableEntity> storageTableService
            )
        {
            EntityValidator = entityValidator;
            StorageTableService = storageTableService;
            SharedRepositories = sharedRepositories;
            SharedServices = sharedServices;
            SharedDependenciesConfig = sharedDependenciesConfig;
        }
    }
}