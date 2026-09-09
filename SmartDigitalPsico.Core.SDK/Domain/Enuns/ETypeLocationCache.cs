using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de localização de cache (namespace SDP <c>Enuns</c> + nomes históricos MongoDB/Cosmo).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.ETypeLocationCache",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho; valores int idênticos (MongoDB↔MongoDb, AzureCosmoDB↔AzureCosmosDb).")]
public enum ETypeLocationCache
{
    Disk = (int)SchEnums.ETypeLocationCache.Disk,
    Memory = (int)SchEnums.ETypeLocationCache.Memory,
    MongoDB = (int)SchEnums.ETypeLocationCache.MongoDb,
    AzureStorage = (int)SchEnums.ETypeLocationCache.AzureStorage,
    AzureCosmoDB = (int)SchEnums.ETypeLocationCache.AzureCosmosDb,
    AzureRedis = (int)SchEnums.ETypeLocationCache.AzureRedis,
}
