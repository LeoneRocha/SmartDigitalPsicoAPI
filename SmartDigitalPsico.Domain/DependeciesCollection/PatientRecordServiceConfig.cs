using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    /// <summary>
    /// Classe responsável por PatientRecordServiceConfig.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientRecordServiceConfig : IPatientRecordServiceConfig
    {
        public IValidator<PatientRecord> EntityValidator { get; }
        public SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<PatientRecordTableEntity> StorageTableService { get; }
        public ISharedRepositories SharedRepositories { get; }
        public ISharedServices SharedServices { get; }
        public ISharedDependenciesConfig SharedDependenciesConfig { get; }

        /// <summary>
        /// Método PatientRecordServiceConfig: executa a operação PatientRecordServiceConfig.
        /// </summary>
        public PatientRecordServiceConfig(
            ISharedRepositories sharedRepositories,
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            IValidator<PatientRecord> entityValidator,
            SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<PatientRecordTableEntity> storageTableService
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
