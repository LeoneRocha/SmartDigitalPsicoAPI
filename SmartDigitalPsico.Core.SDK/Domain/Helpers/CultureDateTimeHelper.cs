using System.Globalization;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers;
using SchCulture = SmartCoreHub.Core.SDK.Domain.DTOs.Entities;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca CultureDateTimeHelper — delega ao SCH (GetCultures = culturas habilitadas do produto).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.CultureDateTimeHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "GetCultures → GetSupportedApplicationCultures; demais métodos delegam SCH com mapeamento de DTOs.")]
public static class CultureDateTimeHelper
{
    public static List<TimeZoneDisplayDto> GetTimeZonesIds()
        => Sch.CultureDateTimeHelper.GetTimeZonesIds()
            .Select(tz => new TimeZoneDisplayDto { Id = tz.Id, Name = tz.Name })
            .ToList();

    /// <summary>
    /// Retorna culturas habilitadas (en-US, pt-BR, es-ES) — comportamento histórico SDP.
    /// </summary>
    public static List<CultureDisplayDto> GetCultures()
        => Sch.CultureDateTimeHelper.GetSupportedApplicationCultures()
            .Select(c => new CultureDisplayDto { Id = c.Id, Name = c.Name })
            .ToList();

    public static List<CultureInfo> TranslateCulture(List<CultureDisplayDto> cultureDisplays)
        => Sch.CultureDateTimeHelper.TranslateCulture(
            cultureDisplays.Select(c => new SchCulture.CultureDisplayDto { Id = c.Id, Name = c.Name }).ToList());

    public static string GetNameAndCulture(string localizedStringKeyName)
        => Sch.CultureDateTimeHelper.GetNameAndCulture(localizedStringKeyName);

    public static string GetKeyLocalizationRecordFormat(string LanguageKey, string Language)
        => Sch.CultureDateTimeHelper.GetKeyLocalizationRecordFormat(LanguageKey, Language);

    public static string GetLocalizer<T>(Microsoft.Extensions.Localization.IStringLocalizer<T> localizer, string key)
        => Sch.CultureDateTimeHelper.GetLocalizer(localizer, key);

    public static string GetTimeZoneBrazil()
        => Sch.CultureDateTimeHelper.GetTimeZoneBrazil();

    public static string GetCultureBrazil()
        => Sch.CultureDateTimeHelper.GetCultureBrazil();
}
