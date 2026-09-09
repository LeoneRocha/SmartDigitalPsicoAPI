using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca: helpers de data/hora — delega a <see cref="Sch.DateHelper"/>.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.DateHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando para DateHelper em SmartCoreHub.Core.SDK.")]
public static class DateHelper
{
    public static string ConvertSecondsToTimeString(double seconds)
        => Sch.DateHelper.ConvertSecondsToTimeString(seconds);

    public static string GetDateTimeCustomFormat(DateTime dateInput)
        => Sch.DateHelper.GetDateTimeCustomFormat(dateInput);

    public static void SetCulture(string cultureName = "pt-BR")
        => Sch.DateHelper.SetCulture(cultureName);

    public static DateTime GetDateTimeNowBrazil()
        => Sch.DateHelper.GetDateTimeNowBrazil();

    public static DateTime GetDateTimeNowToLog()
        => Sch.DateHelper.GetDateTimeNowToLog();

    public static DateTime GetDateTimeNowFromUtc()
        => Sch.DateHelper.GetDateTimeNowFromUtc();

    public static DateTime GetDateTimeNowWithTimeZone(string timeZoneId)
        => Sch.DateHelper.GetDateTimeNowWithTimeZone(timeZoneId);

    public static DateTime ApplyTimeZone(DateTime dateTime, string timeZoneId)
        => Sch.DateHelper.ApplyTimeZone(dateTime, timeZoneId);
}
