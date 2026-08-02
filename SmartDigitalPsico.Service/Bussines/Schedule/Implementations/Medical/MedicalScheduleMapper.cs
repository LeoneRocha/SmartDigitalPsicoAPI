using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical
{
    /// <summary>
    /// Translates Medical FE DTOs/entities ↔ generic ScheduleCalendar keys/items.
    /// </summary>
    public static class MedicalScheduleMapper
    {
        public static ScheduleCalendarWriteRequest ToWriteRequest(MedicalCalendar entity, bool isUpdate = false, bool updateSeries = true)
        {
            var token = string.IsNullOrWhiteSpace(entity.TokenRecurrence)
                ? Guid.NewGuid().ToString()
                : entity.TokenRecurrence;
            entity.TokenRecurrence = token;

            return new ScheduleCalendarWriteRequest
            {
                TenantKey = MedicalScheduleKeys.TenantKey,
                OwnerKey = MedicalScheduleKeys.ForMedical(entity.MedicalId),
                SubjectKey = entity.PatientId.HasValue
                    ? MedicalScheduleKeys.ForPatient(entity.PatientId.Value)
                    : null,
                UniqueToken = token,
                IsUpdate = isUpdate,
                UpdateSeries = updateSeries,
                Enable = entity.Enable,
                Items = BuildItems(entity, token)
            };
        }

        public static GetMedicalCalendarDto ToGetDto(ScheduleCalendar package, ScheduleCalendarItem? preferredItem = null)
        {
            MedicalScheduleKeys.TryParseMedicalId(package.OwnerKey, out var medicalId);
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

        public static MedicalCalendar[] ToMedicalCalendarReadModels(ScheduleCalendarItem[] items, long medicalId, long? patientId = null)
            => items.Select(i => ToMedicalCalendarReadModel(i, medicalId, patientId)).ToArray();

        public static CalendarDto ToCalendarDto(
            ScheduleGradeResult grade,
            long medicalId,
            IReadOnlyDictionary<long, string>? patientNames = null)
        {
            return new CalendarDto
            {
                MedicalId = medicalId,
                MedicalName = grade.DisplayName,
                Days = grade.Days.Select(day => ToDayCalendarDto(day, medicalId, patientNames)).ToArray()
            };
        }

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
                    RecurrenceDays = mc.RecurrenceDays ?? [],
                    RecurrenceType = mc.RecurrenceType,
                    RecurrenceEndDate = mc.RecurrenceEndDate,
                    RecurrenceCount = mc.RecurrenceCount ?? 0,
                    TokenRecurrence = mc.TokenRecurrence,
                    PatientId = mc.PatientId,
                    Patient = new Domain.DTO.Patient.GetPatientDto
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

        public static ScheduleCalendarItem[] BuildItems(MedicalCalendar entity, string token)
        {
            var intervals = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
            {
                StartDateTime = entity.StartDateTime,
                EndDateTime = entity.EndDateTime ?? entity.StartDateTime,
                RecurrenceType = entity.RecurrenceType,
                RecurrenceDays = entity.RecurrenceDays ?? [],
                RecurrenceEndDate = entity.RecurrenceEndDate,
                RecurrenceCount = entity.RecurrenceCount
            });

            return intervals.Select(interval => new ScheduleCalendarItem
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
            }).ToArray();
        }

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
                    Status = Domain.Enuns.EStatusCalendar.PendingConfirmation,
                    TokenRecurrence = token
                }
            };
        }

        public static ScheduleCancelRequest ToCancelRequest(ScheduleCriteriaDto criteria)
            => new()
            {
                TenantKey = MedicalScheduleKeys.TenantKey,
                OwnerKey = MedicalScheduleKeys.ForMedical(criteria.MedicalId),
                SubjectKey = MedicalScheduleKeys.ForPatient(criteria.PatientId),
                AppointmentDateTime = criteria.AppointmentDateTime,
                Reason = criteria.Reason
            };

        public static ScheduleDeleteTokenRequest ToDeleteTokenRequest(DeleteMedicalCalendarDto request)
            => new()
            {
                UniqueToken = request.TokenRecurrence,
                OwnerKey = MedicalScheduleKeys.ForMedical(request.MedicalId),
                SubjectKey = MedicalScheduleKeys.ForPatient(request.PatientId)
            };

        public static AppointmentDto[] ToAppointmentDtos(ScheduleCalendarItem[] items, long medicalId, string medicalName)
        {
            var currentTime = items.Length == 0
                ? DateHelper.GetDateTimeNowFromUtc()
                : DateHelper.ApplyTimeZone(DateHelper.GetDateTimeNowFromUtc(), items[0].TimeZone);

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

        public static (DateTime startDate, DateTime endDate) GetMonthRange(int year, int month)
        {
            var startDate = new DateTime(year, month, 1, 0, 0, 0, DateTimeKind.Utc);
            return (startDate, startDate.AddMonths(1).AddDays(-1));
        }
    }
}
