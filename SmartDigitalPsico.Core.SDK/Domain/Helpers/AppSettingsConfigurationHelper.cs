using Microsoft.Extensions.Configuration;
using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca: seções padrão de appsettings — delega a SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.AppSettingsConfigurationHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando AppSettingsConfigurationHelper ao SCH.")]
public static class AppSettingsConfigurationHelper
{
    public static IConfiguration GetCacheConfiguration(IConfiguration? configuration)
        => Sch.AppSettingsConfigurationHelper.GetCacheConfiguration(configuration);

    public static IConfiguration GetAuthConfiguration(IConfiguration? configuration)
        => Sch.AppSettingsConfigurationHelper.GetAuthConfiguration(configuration);

    public static IConfiguration GetTokenConfigurations(IConfiguration? configuration)
        => Sch.AppSettingsConfigurationHelper.GetTokenConfigurations(configuration);

    public static IConfiguration GetDataBaseConfigurations(IConfiguration? configuration)
        => Sch.AppSettingsConfigurationHelper.GetDataBaseConfigurations(configuration);

    public static IConfiguration GetResiliencePolicyConfig(IConfiguration configuration)
        => Sch.AppSettingsConfigurationHelper.GetResiliencePolicyConfig(configuration);

    public static IConfiguration GetLocationSaveFileConfiguration(IConfiguration configuration)
        => Sch.AppSettingsConfigurationHelper.GetLocationSaveFileConfiguration(configuration);

    public static IConfiguration GetSmtpSettings(IConfiguration configuration)
        => Sch.AppSettingsConfigurationHelper.GetSmtpSettings(configuration);
}
