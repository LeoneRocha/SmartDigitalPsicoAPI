using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;

/// <summary>
/// Casca IStorageTableRepositoryFactory — espelho SCH com tipos SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Infrastructure.IStorageTableRepositoryFactory",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca com tipos SDP; não herda SCH interface por generics/enums.")]
public interface IStorageTableRepositoryFactory
{
    IStorageTableContract<T> Create<T>(EStorageAdapterType eStorageAdapterType, string tableName)
        where T : BaseEntityTable, new();
}
