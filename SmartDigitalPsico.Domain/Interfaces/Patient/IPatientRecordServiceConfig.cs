using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Patient
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientRecordServiceConfig.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IPatientRecordServiceConfig
    {
        IValidator<PatientRecord> EntityValidator { get; }
        SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<PatientRecordTableEntity> StorageTableService { get; }

        ISharedRepositories SharedRepositories { get; }

        ISharedServices SharedServices { get; }

        ISharedDependenciesConfig SharedDependenciesConfig { get; }
    }
}
