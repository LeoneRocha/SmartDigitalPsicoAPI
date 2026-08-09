using System.ComponentModel;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns
{
    /// <summary>
    /// Tipo de item de calendário/agenda.
    /// </summary>
    public enum EScheduleCalendarType
    {
        [Description("Schedule")]
        Schedule = 0,

        [Description("Cancellation")]
        Cancellation = 1
    }
}
