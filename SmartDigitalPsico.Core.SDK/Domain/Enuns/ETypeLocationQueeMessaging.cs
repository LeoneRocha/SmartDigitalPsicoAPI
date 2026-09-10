using System.ComponentModel;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum tipográfico Quee — valores alinhados ao SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.ETypeLocationQueeMessaging",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho tipográfico Quee; também existe ETypeLocationQueueMessaging canônico no SCH.")]
public enum ETypeLocationQueeMessaging
{
    [Description("Local Salvamento em MongoDB")]
    MongoDB = (int)SchEnums.ETypeLocationQueeMessaging.MongoDB,

    [Description("Local Salvamento em Azure Storage Quee")]
    AzureStorageQuee = (int)SchEnums.ETypeLocationQueeMessaging.AzureStorageQuee,

    [Description("Local Salvamento em Azure Service Bus")]
    AzureServiceBus = (int)SchEnums.ETypeLocationQueeMessaging.AzureServiceBus,

    [Description("Local Salvamento em Azure Event Grid")]
    AzureEventGrid = (int)SchEnums.ETypeLocationQueeMessaging.AzureEventGrid,

    [Description("Local Salvamento em Azure Event Hubs")]
    AzureEventHubs = (int)SchEnums.ETypeLocationQueeMessaging.AzureEventHubs,

    [Description("Local Salvamento em Azure Event Hubs")]
    AzureRelay = (int)SchEnums.ETypeLocationQueeMessaging.AzureRelay,
}
