using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
{
    public interface IPatientRecordServiceConfig
    {  
        IValidator<PatientRecord> EntityValidator { get; } 
        IStorageTableContract<PatientRecordTableEntity> StorageTableService { get; }

        ISharedRepositories SharedRepositories { get; }
         
        ISharedServices SharedServices { get; }

        ISharedDependenciesConfig SharedDependenciesConfig { get; } 
    }
}