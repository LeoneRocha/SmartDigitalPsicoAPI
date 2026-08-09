using Microsoft.Extensions.Localization;
using SmartDigitalPsico.Core.SDK.Domain.DTO;
using System.Collections.ObjectModel;
using System.Globalization;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por CultureDateTimeHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public static class CultureDateTimeHelper
    {
        private static List<CultureInfo> getCulturesEnable()
        {
            List<CultureInfo> list = new List<CultureInfo>();

            list.Add(new CultureInfo("en-US"));
            list.Add(new CultureInfo("pt-BR"));
            list.Add(new CultureInfo("es-ES"));

            return list;
        }

        /// <summary>
        /// Método GetTimeZonesIds: consulta e retorna dados.
        /// </summary>
        public static List<TimeZoneDisplayDto> GetTimeZonesIds()
        {
            List<TimeZoneDisplayDto> result = new List<TimeZoneDisplayDto>();

            ReadOnlyCollection<TimeZoneInfo> tz = TimeZoneInfo.GetSystemTimeZones();
            foreach (TimeZoneInfo tzInfo in tz)
            {
                result.Add(new TimeZoneDisplayDto() { Id = tzInfo.Id, Name = tzInfo.DisplayName });
            }
            return result;
        }
        /// <summary>
        /// Método GetCultures: consulta e retorna dados.
        /// </summary>
        public static List<CultureDisplayDto> GetCultures()
        {
            List<CultureDisplayDto> result = new List<CultureDisplayDto>();
            CultureInfo[] cinfo = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);

            foreach (CultureInfo cul in cinfo)
            {
                result.Add(new CultureDisplayDto() { Id = cul.Name, Name = cul.DisplayName });
            }
            var culturesEnables = getCulturesEnable().Select(cie => cie.Name).ToList();
            result = result.Where(ci => culturesEnables.Contains(ci.Id)).ToList();

            return result;
        }

        /// <summary>
        /// Método TranslateCulture: executa a operação TranslateCulture.
        /// </summary>
        public static List<CultureInfo> TranslateCulture(List<CultureDisplayDto> cultureDisplays)
        {
            return cultureDisplays.Select(cd => new CultureInfo(cd.Id)).ToList();
        }

        /// <summary>
        /// Método GetNameAndCulture: consulta e retorna dados.
        /// </summary>
        public static string GetNameAndCulture(string localizedStringKeyName)
        {
            return $"{localizedStringKeyName}";
        }
        /// <summary>
        /// Método GetKeyLocalizationRecordFormat: consulta e retorna dados.
        /// </summary>
        public static string GetKeyLocalizationRecordFormat(string LanguageKey, string Language)
        {
            return $"{LanguageKey}";
        }

        public static string GetLocalizer<T>(Microsoft.Extensions.Localization.IStringLocalizer<T> localizer, string key)
        {
            string result = "NotFoundLocalization";
            try
            {
                var findKey = CultureDateTimeHelper.GetNameAndCulture(key);
                string message = localizer.GetString(findKey);

                result = message;
            }
            catch (Exception)
            {
                return result;
            }
            return result;
        }

        /// <summary>
        /// Método GetTimeZoneBrazil: consulta e retorna dados.
        /// </summary>
        public static string GetTimeZoneBrazil()
        {
            var zt = CultureDateTimeHelper.GetTimeZonesIds().Find(c =>
             c.Name.Contains("o Paulo", StringComparison.OrdinalIgnoreCase)
             || c.Id.Contains("o Paulo", StringComparison.OrdinalIgnoreCase)
             || c.Name.Contains("Brasília", StringComparison.OrdinalIgnoreCase)
             || c.Id.Contains("Brasília", StringComparison.OrdinalIgnoreCase)
             || c.Id.Contains("South America", StringComparison.OrdinalIgnoreCase)
             );
            string idZT = "E. South America Standard Time";
            if (zt != null)
            {
                idZT = zt.Id;
            }
            return idZT;
        }

        /// <summary>
        /// Método GetCultureBrazil: consulta e retorna dados.
        /// </summary>
        public static string GetCultureBrazil()
        {
            return CultureDateTimeHelper.GetCultures().First(c => c.Id.Contains("pt-br", StringComparison.OrdinalIgnoreCase)).Id;
        }
    }
}
