using Microsoft.Extensions.Localization;
using System.Globalization;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class CultureDateTimeHelper
    {
        public static List<SmartDigitalPsico.Core.SDK.Domain.DTO.TimeZoneDisplayDto> GetTimeZonesIds()
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetTimeZonesIds();

        public static List<SmartDigitalPsico.Core.SDK.Domain.DTO.CultureDisplayDto> GetCultures()
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetCultures();

        public static List<CultureInfo> TranslateCulture(List<SmartDigitalPsico.Core.SDK.Domain.DTO.CultureDisplayDto> cultureDisplays)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.TranslateCulture(cultureDisplays);

        public static string GetNameAndCulture(string localizedStringKeyName)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetNameAndCulture(localizedStringKeyName);

        public static string GetKeyLocalizationRecordFormat(string LanguageKey, string Language)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetKeyLocalizationRecordFormat(LanguageKey, Language);

        public static string GetLocalizer<T>(IStringLocalizer<T> localizer, string key)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetLocalizer(localizer, key);

        public static string GetTimeZoneBrazil()
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetTimeZoneBrazil();

        public static string GetCultureBrazil()
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetCultureBrazil();
    }
}
