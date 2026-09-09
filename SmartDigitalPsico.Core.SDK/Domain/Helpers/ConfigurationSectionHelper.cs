using Microsoft.Extensions.Configuration;
using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca: leitura genérica de <see cref="IConfiguration"/> — delega a SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.ConfigurationSectionHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando ConfigurationSectionHelper ao SCH.")]
public static class ConfigurationSectionHelper
{
    public static IConfiguration GetSectionApp(IConfiguration? configuration, string sectionName)
        => Sch.ConfigurationSectionHelper.GetSectionApp(configuration, sectionName);

    public static string GetConnectionStringApp(IConfiguration? configuration, string connectionName)
        => Sch.ConfigurationSectionHelper.GetConnectionStringApp(configuration, connectionName);

    public static string GetValueStringConfiguration(IConfiguration? configuration, string configurationName)
        => Sch.ConfigurationSectionHelper.GetValueStringConfiguration(configuration, configurationName);
}
