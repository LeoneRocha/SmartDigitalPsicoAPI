namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsicoAPI.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsicoAPI.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class DateHelper
    {
        public static string ConvertSecondsToTimeString(double seconds)
            => SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.ConvertSecondsToTimeString(seconds);

        public static string GetDateTimeCustomFormat(DateTime dateInput)
            => SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeCustomFormat(dateInput);

        public static void SetCulture(string cultureName = "pt-BR")
            => SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.SetCulture(cultureName);

        public static DateTime GetDateTimeNowBrazil()
            => SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowBrazil();

        public static DateTime GetDateTimeNowToLog()
            => SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog();

        public static DateTime GetDateTimeNowFromUtc()
            => SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

        public static DateTime GetDateTimeNowWithTimeZone(string timeZoneId)
            => SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowWithTimeZone(timeZoneId);

        public static DateTime ApplyTimeZone(DateTime dateTime, string timeZoneId)
            => SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.ApplyTimeZone(dateTime, timeZoneId);
    }
}
