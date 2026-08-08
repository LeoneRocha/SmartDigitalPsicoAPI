using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Schedule.Medical
{
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;
    /// <summary>
    /// Translates Medical FE DTOs/entities ↔ generic ScheduleCalendar keys/items.
    /// </summary>
    public static class MedicalScheduleMapper
    {
        /// <summary>
        /// Método ToWriteRequest: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static ScheduleCalendarWriteRequest ToWriteRequest(MedicalCalendar entity, bool isUpdate = false, bool updateSeries = true)
        {
            // Create may mint a token; update must keep the package UniqueToken (Host sets it).
            if (!isUpdate && string.IsNullOrWhiteSpace(entity.TokenRecurrence))
                entity.TokenRecurrence = Guid.NewGuid().ToString();
            var token = entity.TokenRecurrence?.Trim() ?? string.Empty;

            // Partial update: only the seed occurrence — Core merges into existing ScheduleData.
            // Series update / create: rematerialize full recurrence.
            var items = isUpdate && !updateSeries
                ? BuildSingleItem(entity, token)
                : BuildItems(entity, token);

            return new ScheduleCalendarWriteRequest
            {
                PackageId = entity.Id > 0 ? entity.Id : null,
                TenantKey = MedicalScheduleKeys.TenantKey,
                OwnerKey = MedicalScheduleKeys.ForMedical(entity.MedicalId),
                SubjectKey = entity.PatientId.HasValue
                    ? MedicalScheduleKeys.ForPatient(entity.PatientId.Value)
                    : null,
                UniqueToken = token,
                IsUpdate = isUpdate,
                UpdateSeries = updateSeries,
                Enable = entity.Enable,
                Items = items
            };
        }

        /// <summary>
        /// Método BuildSingleItem: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static ScheduleCalendarItem[] BuildSingleItem(MedicalCalendar entity, string token)
            =>
            [
                new ScheduleCalendarItem
                {
                    Title = entity.Title,
                    Description = entity.Description,
                    Location = entity.Location,
                    StartDateTime = entity.StartDateTime,
                    EndDateTime = entity.EndDateTime,
                    IsAllDay = entity.IsAllDay,
                    Status = entity.Status,
                    ColorCategoryHexa = entity.ColorCategoryHexa,
                    TimeZone = entity.TimeZone,
                    IsPushedCalendar = entity.IsPushedCalendar,
                    RecurrenceDays = entity.RecurrenceDays ?? [],
                    RecurrenceType = entity.RecurrenceType,
                    RecurrenceEndDate = entity.RecurrenceEndDate,
                    RecurrenceCount = entity.RecurrenceCount,
                    ReasonCancellation = entity.ReasonCancellation ?? string.Empty,
                    TokenRecurrence = token
                }
            ];

        /// <summary>
        /// Método ToGetDto: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static GetMedicalCalendarDto ToGetDto(ScheduleCalendar package, ScheduleCalendarItem? preferredItem = null)
        {
            if (!MedicalScheduleKeys.TryParseMedicalId(package.OwnerKey, out var medicalId))
                medicalId = 0;
            long? patientId = null;
            if (!string.IsNullOrWhiteSpace(package.SubjectKey)
                && MedicalScheduleKeys.TryParsePatientId(package.SubjectKey, out var parsedPatient))
            {
                patientId = parsedPatient;
            }

            var item = preferredItem
                ?? package.ScheduleData?.OrderBy(i => i.StartDateTime).FirstOrDefault()
                ?? new ScheduleCalendarItem();

            return new GetMedicalCalendarDto
            {
                Id = package.Id,
                Enable = package.Enable,
                Title = item.Title,
                Description = item.Description,
                Location = item.Location,
                StartDateTime = item.StartDateTime,
                EndDateTime = item.EndDateTime,
                IsAllDay = item.IsAllDay,
                Status = item.Status,
                ColorCategoryHexa = item.ColorCategoryHexa,
                TimeZone = item.TimeZone,
                IsPushedCalendar = item.IsPushedCalendar,
                RecurrenceDays = item.RecurrenceDays ?? [],
                RecurrenceType = item.RecurrenceType,
                RecurrenceEndDate = item.RecurrenceEndDate,
                RecurrenceCount = item.RecurrenceCount ?? 0,
                TokenRecurrence = string.IsNullOrWhiteSpace(item.TokenRecurrence) ? package.UniqueToken : item.TokenRecurrence,
                MedicalId = medicalId,
                PatientId = patientId
            };
        }

        /// <summary>
        /// Hydrate MedicalCalendar POCO from ScheduleCalendar package (notification dispatch / read paths).
        /// </summary>
        public static MedicalCalendar ToMedicalCalendarFromPackage(ScheduleCalendar package, DateTime? preferEventDate = null)
        {
            if (!MedicalScheduleKeys.TryParseMedicalId(package.OwnerKey, out var medicalId))
                medicalId = 0;
            long? patientId = null;
            if (!string.IsNullOrWhiteSpace(package.SubjectKey)
                && MedicalScheduleKeys.TryParsePatientId(package.SubjectKey, out var parsedPatient))
            {
                patientId = parsedPatient;
            }

            ScheduleCalendarItem? item = null;
            if (preferEventDate.HasValue && package.ScheduleData is { Length: > 0 })
            {
                item = package.ScheduleData
                    .OrderBy(i => Math.Abs((i.StartDateTime - preferEventDate.Value).TotalMinutes))
                    .FirstOrDefault();
            }

            item ??= package.ScheduleData?.OrderBy(i => i.StartDateTime).FirstOrDefault()
                ?? new ScheduleCalendarItem();

            var calendar = ToMedicalCalendarReadModel(item, medicalId, patientId);
            calendar.Id = package.Id;
            calendar.Enable = package.Enable;
            return calendar;
        }

        /// <summary>
        /// Método ToMedicalCalendarReadModel: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static MedicalCalendar ToMedicalCalendarReadModel(ScheduleCalendarItem item, long medicalId, long? patientId = null)
        {
            if (!patientId.HasValue
                && !string.IsNullOrWhiteSpace(item.SubjectKey)
                && MedicalScheduleKeys.TryParsePatientId(item.SubjectKey, out var parsedPatient))
            {
                patientId = parsedPatient;
            }

            if (medicalId <= 0
                && !string.IsNullOrWhiteSpace(item.OwnerKey)
                && MedicalScheduleKeys.TryParseMedicalId(item.OwnerKey, out var parsedMedical))
            {
                medicalId = parsedMedical;
            }

            return new MedicalCalendar
            {
                Id = item.PackageId ?? 0,
                Title = item.Title,
                Description = item.Description,
                Location = item.Location,
                StartDateTime = item.StartDateTime,
                EndDateTime = item.EndDateTime,
                IsAllDay = item.IsAllDay,
                Status = item.Status,
                ColorCategoryHexa = item.ColorCategoryHexa,
                TimeZone = item.TimeZone,
                IsPushedCalendar = item.IsPushedCalendar,
                RecurrenceDays = item.RecurrenceDays ?? [],
                RecurrenceType = item.RecurrenceType,
                RecurrenceEndDate = item.RecurrenceEndDate,
                RecurrenceCount = item.RecurrenceCount,
                ReasonCancellation = item.ReasonCancellation,
                TokenRecurrence = item.TokenRecurrence,
                MedicalId = medicalId,
                PatientId = patientId,
                Enable = true
            };
        }

        /// <summary>
        /// Método ToMedicalCalendarReadModels: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static MedicalCalendar[] ToMedicalCalendarReadModels(ScheduleCalendarItem[] items, long medicalId, long? patientId = null)
            => items.Select(i => ToMedicalCalendarReadModel(i, medicalId, patientId)).ToArray();

        /// <summary>
        /// Onde Parallel: Parallel.For por dia no mapeamento grade → CalendarDto (CPU, sem DB).
        /// Ganho esperado: meses com muitos slots/bookings.
        /// Por que não Parallel nos slots internos: dia já roda em paralelo; slots via Select sequencial.
        /// DB e ResolvePatientNamesAsync ocorrem ANTES desta chamada (GradeService).
        /// Array indexado days[i] — não ConcurrentBag (ordem dos dias preservada).
        /// </summary>
        public static CalendarDto ToCalendarDto(
            ScheduleGradeResult grade,
            long medicalId,
            IReadOnlyDictionary<long, string>? patientNames = null)
        {
            var source = grade.Days ?? [];
            var days = new DayCalendarDto[source.Length];
            Parallel.For(0, source.Length, ScheduleParallel.MaxAvailableThreads, i =>
            {
                days[i] = ToDayCalendarDto(source[i], medicalId, patientNames);
            });

            return new CalendarDto
            {
                MedicalId = medicalId,
                MedicalName = grade.DisplayName,
                Days = days
            };
        }

        /// <summary>
        /// Método ToDayCalendarDto: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static DayCalendarDto ToDayCalendarDto(
            ScheduleDayDto day,
            long medicalId,
            IReadOnlyDictionary<long, string>? patientNames = null)
        {
            return new DayCalendarDto
            {
                Date = day.Date,
                IsPast = day.IsPast,
                TimeSlots = day.TimeSlots.Select(slot => ToTimeSlotDto(slot, medicalId, patientNames)).ToArray()
            };
        }

        /// <summary>
        /// Método ToTimeSlotDto: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static TimeSlotDto ToTimeSlotDto(
            ScheduleTimeSlotDto slot,
            long medicalId,
            IReadOnlyDictionary<long, string>? patientNames = null)
        {
            GetMedicalCalendarTimeSlotDto? bookingDto = null;
            if (slot.Booking != null)
            {
                var mc = ToMedicalCalendarReadModel(slot.Booking, medicalId);
                var patientName = string.Empty;
                if (mc.PatientId.HasValue && patientNames != null && patientNames.TryGetValue(mc.PatientId.Value, out var resolvedName))
                    patientName = resolvedName;
                if (string.IsNullOrWhiteSpace(patientName))
                    patientName = mc.Title;

                bookingDto = new GetMedicalCalendarTimeSlotDto
                {
                    Id = mc.Id,
                    Title = mc.Title,
                    Description = mc.Description,
                    Location = mc.Location,
                    StartDateTime = mc.StartDateTime,
                    EndDateTime = mc.EndDateTime,
                    IsAllDay = mc.IsAllDay,
                    Status = mc.Status,
                    ColorCategoryHexa = mc.ColorCategoryHexa,
                    TimeZone = mc.TimeZone,
                    IsPushedCalendar = mc.IsPushedCalendar,
                    RecurrenceDays = mc.RecurrenceDays,
                    RecurrenceType = mc.RecurrenceType,
                    RecurrenceEndDate = mc.RecurrenceEndDate,
                    RecurrenceCount = mc.RecurrenceCount ?? 0,
                    TokenRecurrence = mc.TokenRecurrence,
                    PatientId = mc.PatientId,
                    Patient = new Domain.DTO.Patient.GET.GetPatientDto
                    {
                        Id = mc.PatientId ?? 0,
                        Name = patientName
                    },
                    Enable = true
                };
            }

            return new TimeSlotDto
            {
                StartTime = slot.StartTime,
                EndTime = slot.EndTime,
                IsAvailable = slot.IsAvailable,
                IsPast = slot.IsPast,
                MedicalCalendar = bookingDto
            };
        }

        /// <summary>
        /// Materializa recorrência (Daily/Weekly paralelizam internamente com bound) e mapeia intervals → items.
        /// Onde Parallel: Parallel.For no map quando N &gt;= MapParallelThreshold (CpuCount).
        /// Ganho esperado: séries longas; limiar dinâmico evita overhead em eventos únicos.
        /// Sem DB: Materialize + map CPU. Persistência ocorre depois em ScheduleCreate/Update.
        /// Array indexado result[i] — não ConcurrentBag (ordem = ordem dos intervals).
        /// </summary>
        public static ScheduleCalendarItem[] BuildItems(MedicalCalendar entity, string token)
        {
            // Materialize: Parallel interno (Daily/Weekly bound); Monthly/Yearly / unbounded sequenciais.
            var intervals = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
            {
                StartDateTime = entity.StartDateTime,
                EndDateTime = entity.EndDateTime ?? entity.StartDateTime,
                RecurrenceType = entity.RecurrenceType,
                RecurrenceDays = entity.RecurrenceDays ?? [],
                RecurrenceEndDate = entity.RecurrenceEndDate,
                RecurrenceCount = entity.RecurrenceCount
            });

            ScheduleCalendarItem MapInterval(RecurrenceInterval interval) => new()
            {
                Title = entity.Title,
                Description = entity.Description,
                Location = entity.Location,
                StartDateTime = interval.StartDateTime,
                EndDateTime = interval.EndDateTime,
                IsAllDay = entity.IsAllDay,
                Status = entity.Status,
                ColorCategoryHexa = entity.ColorCategoryHexa,
                TimeZone = entity.TimeZone,
                IsPushedCalendar = entity.IsPushedCalendar,
                RecurrenceDays = entity.RecurrenceDays ?? [],
                RecurrenceType = entity.RecurrenceType,
                RecurrenceEndDate = entity.RecurrenceEndDate,
                RecurrenceCount = entity.RecurrenceCount,
                ReasonCancellation = entity.ReasonCancellation ?? string.Empty,
                TokenRecurrence = token
            };

            if (intervals.Count < ScheduleParallel.MapParallelThreshold)
                return intervals.Select(MapInterval).ToArray();

            var result = new ScheduleCalendarItem[intervals.Count];
            Parallel.For(0, intervals.Count, ScheduleParallel.MaxAvailableThreads, i =>
            {
                result[i] = MapInterval(intervals[i]);
            });
            return result;
        }

        /// <summary>
        /// Método ToGradeRequest: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static ScheduleGradeRequest ToGradeRequest(
            CalendarCriteriaDto criteria,
            ScheduleOwnerConstraints constraints,
            string timeZone,
            ScheduleGradeMode mode,
            ScheduleCalendarItem[]? preloadedItems = null)
        {
            var (startDate, endDate) = GetMonthRange(criteria.Year, criteria.Month);
            if (criteria.StartDate.HasValue && criteria.StartDate.GetValueOrDefault() > DateTime.MinValue)
                startDate = criteria.StartDate.Value.Date;
            if (criteria.EndDate.HasValue && criteria.EndDate.GetValueOrDefault() > DateTime.MinValue)
                endDate = criteria.EndDate.Value.Date;

            return new ScheduleGradeRequest
            {
                TenantKey = MedicalScheduleKeys.TenantKey,
                OwnerKey = MedicalScheduleKeys.ForMedical(criteria.MedicalId),
                DisplayName = constraints.DisplayName,
                TimeZone = timeZone,
                StartDate = startDate,
                EndDate = endDate,
                Constraints = constraints,
                Mode = mode,
                FilterDaysWithBookingsOnly = criteria.FilterDaysAndTimesWithAppointments && mode == ScheduleGradeMode.Monthly,
                FilterByDate = criteria.FilterByDate,
                FilterByWorkingDays = criteria.FilterDaysAndTimesWithAppointments,
                PreloadedItems = preloadedItems
            };
        }

        /// <summary>
        /// Método ToBookRequest: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static ScheduleBookRequest ToBookRequest(ScheduleCriteriaDto criteria, int intervalMinutes)
        {
            var token = Guid.NewGuid().ToString();
            return new ScheduleBookRequest
            {
                TenantKey = MedicalScheduleKeys.TenantKey,
                OwnerKey = MedicalScheduleKeys.ForMedical(criteria.MedicalId),
                SubjectKey = MedicalScheduleKeys.ForPatient(criteria.PatientId),
                UniqueToken = token,
                Item = new ScheduleCalendarItem
                {
                    Title = criteria.Reason,
                    Description = criteria.Reason,
                    TimeZone = criteria.TimeZone,
                    StartDateTime = criteria.AppointmentDateTime,
                    EndDateTime = criteria.AppointmentDateTime.AddMinutes(intervalMinutes),
                    Status = EStatusCalendar.PendingConfirmation,
                    TokenRecurrence = token
                }
            };
        }

        /// <summary>
        /// Método ToCancelRequest: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static ScheduleCancelRequest ToCancelRequest(ScheduleCriteriaDto criteria)
            => new()
            {
                TenantKey = MedicalScheduleKeys.TenantKey,
                OwnerKey = MedicalScheduleKeys.ForMedical(criteria.MedicalId),
                SubjectKey = MedicalScheduleKeys.ForPatient(criteria.PatientId),
                AppointmentDateTime = criteria.AppointmentDateTime,
                Reason = criteria.Reason
            };

        /// <summary>
        /// Método ToDeleteTokenRequest: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static ScheduleDeleteTokenRequest ToDeleteTokenRequest(DeleteMedicalCalendarDto request)
            => new()
            {
                UniqueToken = request.TokenRecurrence,
                OwnerKey = MedicalScheduleKeys.ForMedical(request.MedicalId),
                SubjectKey = MedicalScheduleKeys.ForPatient(request.PatientId)
            };

        /// <summary>
        /// Método ToAppointmentDtos: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static AppointmentDto[] ToAppointmentDtos(ScheduleCalendarItem[] items, long medicalId, string medicalName)
        {
            var currentTime = items.Length == 0
                ? SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc()
                : SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.ApplyTimeZone(SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc(), items[0].TimeZone);

            return items
                .Select(i => new AppointmentDto
                {
                    MedicalId = medicalId,
                    MedicalName = medicalName,
                    StartDateTime = i.StartDateTime,
                    EndDateTime = i.EndDateTime ?? i.StartDateTime,
                    Status = i.Status,
                    TimeZone = i.TimeZone,
                    Location = i.Location,
                    Description = i.Description,
                    IsPast = i.StartDateTime <= currentTime
                })
                .OrderBy(x => x.StartDateTime)
                .ToArray();
        }

        /// <summary>
        /// Método static: executa a operação static.
        /// </summary>
        public static (DateTime startDate, DateTime endDate) GetMonthRange(int year, int month)
        {
            var startDate = new DateTime(year, month, 1, 0, 0, 0, DateTimeKind.Utc);
            return (startDate, startDate.AddMonths(1).AddDays(-1));
        }
    }
}
