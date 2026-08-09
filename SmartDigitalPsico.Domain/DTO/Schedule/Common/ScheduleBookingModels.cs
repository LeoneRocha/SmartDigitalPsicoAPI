using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels.Schedule;

namespace SmartDigitalPsico.Domain.DTO.Schedule.Common
{
    /// <summary>
    /// Classe responsável por ScheduleBookRequest.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public sealed class ScheduleBookRequest
    {
        public string TenantKey { get; init; } = string.Empty;
        public string OwnerKey { get; init; } = string.Empty;
        public string? SubjectKey { get; init; }
        public string UniqueToken { get; init; } = string.Empty;
        public ScheduleCalendarItem Item { get; init; } = new();
    }

    /// <summary>
    /// Classe responsável por ScheduleCancelRequest.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public sealed class ScheduleCancelRequest
    {
        public string TenantKey { get; init; } = string.Empty;
        public string OwnerKey { get; init; } = string.Empty;
        public string? SubjectKey { get; init; }
        public DateTime AppointmentDateTime { get; init; }
        public string? Reason { get; init; }
    }

    /// <summary>
    /// Classe responsável por ScheduleDeleteTokenRequest.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public sealed class ScheduleDeleteTokenRequest
    {
        public string UniqueToken { get; init; } = string.Empty;
        public string OwnerKey { get; init; } = string.Empty;
        public string? SubjectKey { get; init; }
    }

    /// <summary>
    /// Classe responsável por ScheduleCancelResult.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public sealed class ScheduleCancelResult
    {
        public long PackageId { get; init; }
        public string UniqueToken { get; init; } = string.Empty;
        public EStatusCalendar NewStatus { get; init; }
    }
}
