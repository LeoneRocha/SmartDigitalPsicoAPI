using Microsoft.Extensions.Localization;
using SmartDigitalPsico.Domain.DTO;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO;
using System.Collections.ObjectModel;
using System.Globalization;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.CultureDateTimeHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
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
        public static List<SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.TimeZoneDisplayDto> GetTimeZonesIds()
        {
            List<SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.TimeZoneDisplayDto> result = new List<SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.TimeZoneDisplayDto>();

            ReadOnlyCollection<TimeZoneInfo> tz = TimeZoneInfo.GetSystemTimeZones();
            foreach (TimeZoneInfo tzInfo in tz)
            {
                result.Add(new SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.TimeZoneDisplayDto() { Id = tzInfo.Id, Name = tzInfo.DisplayName });
            }
            return result;
        }
        /// <summary>
        /// Método GetCultures: consulta e retorna dados.
        /// </summary>
        public static List<SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.CultureDisplayDto> GetCultures()
        {
            List<SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.CultureDisplayDto> result = new List<SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.CultureDisplayDto>();
            CultureInfo[] cinfo = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);

            foreach (CultureInfo cul in cinfo)
            {
                result.Add(new SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.CultureDisplayDto() { Id = cul.Name, Name = cul.DisplayName });
            }
            var culturesEnables = getCulturesEnable().Select(cie => cie.Name).ToList();
            result = result.Where(ci => culturesEnables.Contains(ci.Id)).ToList();

            return result;
        }

        /// <summary>
        /// Método TranslateCulture: executa a operação TranslateCulture.
        /// </summary>
        public static List<CultureInfo> TranslateCulture(List<SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.CultureDisplayDto> cultureDisplays)
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
                var findKey = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetNameAndCulture(key);
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
            var zt = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetTimeZonesIds().Find(c =>
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
            return SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetCultures().First(c => c.Id.Contains("pt-br", StringComparison.OrdinalIgnoreCase)).Id;
        }
    }
}
