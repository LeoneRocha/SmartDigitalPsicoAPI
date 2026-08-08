namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class DateHelper
    {
        public static string ConvertSecondsToTimeString(double seconds)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.ConvertSecondsToTimeString(seconds);

        public static string GetDateTimeCustomFormat(DateTime dateInput)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeCustomFormat(dateInput);

        public static void SetCulture(string cultureName = "pt-BR")
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.SetCulture(cultureName);

        public static DateTime GetDateTimeNowBrazil()
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowBrazil();

        public static DateTime GetDateTimeNowToLog()
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog();

        public static DateTime GetDateTimeNowFromUtc()
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

        public static DateTime GetDateTimeNowWithTimeZone(string timeZoneId)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowWithTimeZone(timeZoneId);

        public static DateTime ApplyTimeZone(DateTime dateTime, string timeZoneId)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.ApplyTimeZone(dateTime, timeZoneId);
    }
}
