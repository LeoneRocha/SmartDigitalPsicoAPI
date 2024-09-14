using AutoMapper;
using FluentValidation;
using Serilog;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
{
    public interface IPatientRecordServiceConfig
    {
        IApplicationLanguageRepository ApplicationLanguageRepository { get; }
        ICacheService CacheService { get; }
        ICryptoService CryptoService { get; }
        IValidator<PatientRecord> EntityValidator { get; }
        ILogger Logger { get; }
        IMapper Mapper { get; }
        IResiliencePolicyConfig PolicyConfig { get; }
        IStorageTableContract<PatientRecordTableEntity> StorageTableService { get; }
    }
}