using System.Globalization;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por DateHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public static class DateHelper
    {
        private static readonly string dateFormat = "dd/MM/yyyy HH:mm:ss";

        /// <summary>
        /// Método ConvertSecondsToTimeString: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static string ConvertSecondsToTimeString(double seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"hh\:mm\:ss");
        }

        /// <summary>
        /// Método GetDateTimeCustomFormat: consulta e retorna dados.
        /// </summary>
        public static string GetDateTimeCustomFormat(DateTime dateInput)
        {
            var cultureInfo = CultureInfo.InvariantCulture;
            return dateInput.ToString(dateFormat, cultureInfo);
        }

        /// <summary>
        /// Método SetCulture: configura estado ou dependencias.
        /// </summary>
        public static void SetCulture(string cultureName = "pt-BR")
        {
            var cultureInfo = new CultureInfo(cultureName);
            // Set the culture of the current thread
            Thread.CurrentThread.CurrentCulture = cultureInfo;

            // Set the UI culture of the current thread
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
        /// <summary>
        /// Método GetDateTimeNowBrazil: consulta e retorna dados.
        /// </summary>
        public static DateTime GetDateTimeNowBrazil()
        {
            return ApplyTimeZone(GetDateTimeNowFromUtc(), "E. South America Standard Time");
        }

        /// <summary>
        /// Método GetDateTimeNowToLog: consulta e retorna dados.
        /// </summary>
        public static DateTime GetDateTimeNowToLog()
        {
            return GetDateTimeNowBrazil();
        }

        /// <summary>
        /// Método GetDateTimeNowFromUtc: consulta e retorna dados.
        /// </summary>
        public static DateTime GetDateTimeNowFromUtc()
        {
            return DateTime.UtcNow;
        }
        /// <summary>
        /// Método GetDateTimeNowWithTimeZone: consulta e retorna dados.
        /// </summary>
        public static DateTime GetDateTimeNowWithTimeZone(string timeZoneId)
        {
            DateTime dateResult = GetDateTimeNowWithCurrentCulture();

            if (!string.IsNullOrEmpty(timeZoneId))
            {
                dateResult = ApplyTimeZone(GetDateTimeNowFromUtc(), timeZoneId);
            }
            return dateResult;
        }
        private static DateTime GetDateTimeNowWithCurrentCulture()
        {
            var cultureInfo = CultureInfo.CurrentCulture;
            var dateTimeFormatInfo = cultureInfo.DateTimeFormat;
            return GetDateTimeWithCulture(GetDateTimeNowFromUtc(), dateTimeFormatInfo);
        }

        private static DateTime GetDateTimeWithCulture(DateTime dateTime, DateTimeFormatInfo dateTimeFormatInfo)
        {
            // Lógica para formatar a data e hora de acordo com a cultura fornecida
            return DateTime.Parse(dateTime.ToString(dateTimeFormatInfo), dateTimeFormatInfo);
        }

        /// <summary>
        /// Método ApplyTimeZone: executa a operação ApplyTimeZone.
        /// </summary>
        public static DateTime ApplyTimeZone(DateTime dateTime, string timeZoneId)
        {
            // Obter o fuso horário a partir do ID
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

            // Converter a data e hora para o fuso horário especificado
            DateTime dateTimeWithTimeZone = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone);

            return dateTimeWithTimeZone;
        }

    }
}
