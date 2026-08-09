using System.ComponentModel;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns
{
    /// <summary>
    /// Status genéricos de calendário/agenda.
    /// </summary>
    public enum EStatusCalendar
    {
        [Description("Active")]
        Active = 0,

        [Description("Scheduled")]
        Scheduled = 1,

        [Description("Confirmed")]
        Confirmed = 2,

        [Description("Refused")]
        Refused = 3,

        [Description("Completed")]
        Completed = 4,

        [Description("No Show")]
        NoShow = 5,

        [Description("Pending Confirmation")]
        PendingConfirmation = 6,

        [Description("In Progress")]
        InProgress = 7,

        [Description("Rescheduled")]
        Rescheduled = 8,

        [Description("Canceled")]
        Canceled = 9,

        [Description("Pending Cancellation")]
        PendingCancellation = 10
    }
}
