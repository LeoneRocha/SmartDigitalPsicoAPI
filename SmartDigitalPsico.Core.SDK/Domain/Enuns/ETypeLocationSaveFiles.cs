using System.ComponentModel;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de local de salvamento de arquivos (nomes históricos SDP preservados).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.ETypeLocationSaveFiles",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho; ints idênticos (DataBase↔Database, CloudStorageAWS↔CloudStorageAws).")]
public enum ETypeLocationSaveFiles
{
    [Description("Local Salvamento em Banco de dados")]
    DataBase = (int)SchEnums.ETypeLocationSaveFiles.Database,

    [Description("Local Salvamento em Disco HD/SSD")]
    Disk = (int)SchEnums.ETypeLocationSaveFiles.Disk,

    [Description("Local Salvamento em Cloud Storage Azure")]
    CloudStorageAzure = (int)SchEnums.ETypeLocationSaveFiles.CloudStorageAzure,

    [Description("Local Salvamento em Cloud Storage AWS")]
    CloudStorageAWS = (int)SchEnums.ETypeLocationSaveFiles.CloudStorageAws,
}
