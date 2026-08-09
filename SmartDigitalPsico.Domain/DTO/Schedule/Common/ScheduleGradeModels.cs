using SmartDigitalPsico.Domain.EntityModels.Schedule;

namespace SmartDigitalPsico.Domain.DTO.Schedule.Common
{
    /// <summary>
    /// Enumeração responsável por ScheduleGradeMode.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public enum ScheduleGradeMode
    {
        Monthly = 0,
        AvailableOnly = 1
    }

    /// <summary>
    /// Generic grade/availability request (no Medical/Patient coupling).
    /// </summary>
    public sealed class ScheduleGradeRequest
    {
        public string TenantKey { get; init; } = string.Empty;
        public string OwnerKey { get; init; } = string.Empty;
        public string? DisplayName { get; init; }
        public string TimeZone { get; init; } = string.Empty;
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public ScheduleOwnerConstraints Constraints { get; init; } = new();
        public ScheduleGradeMode Mode { get; init; } = ScheduleGradeMode.Monthly;
        public bool FilterDaysWithBookingsOnly { get; init; }
        public DateTime? FilterByDate { get; init; }
        public bool FilterByWorkingDays { get; init; }
        /// <summary>Optional busy items already loaded by host (avoids double fetch).</summary>
        public ScheduleCalendarItem[]? PreloadedItems { get; init; }
    }

    /// <summary>
    /// Classe responsável por ScheduleGradeResult.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public sealed class ScheduleGradeResult
    {
        public string OwnerKey { get; init; } = string.Empty;
        public string DisplayName { get; init; } = string.Empty;
        public ScheduleDayDto[] Days { get; init; } = [];
    }

    /// <summary>
    /// Classe responsável por ScheduleDayDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public sealed class ScheduleDayDto
    {
        public DateTime Date { get; set; }
        public bool IsPast { get; set; }
        public ScheduleTimeSlotDto[] TimeSlots { get; set; } = [];
    }

    /// <summary>
    /// Classe responsável por ScheduleTimeSlotDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public sealed class ScheduleTimeSlotDto
    {
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsPast { get; set; }
        /// <summary>Busy booking overlapping this slot, if any.</summary>
        public ScheduleCalendarItem? Booking { get; set; }
    }
}
