using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.DTO.Notification;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    public class NotificationRecordsService : EntityBaseService<NotificationRecords, AddNotificationRecordsDto, UpdateNotificationRecordsDto, GetNotificationRecordsDto, INotificationRecordsRepository>, INotificationRecordsService
    {
        private readonly INotificationRulesService _notificationRulesService;

        public NotificationRecordsService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            INotificationRecordsRepository entityRepository,
            IApplicationLanguageRepository applicationLanguageRepository,
            IValidator<NotificationRecords> entityValidator,
            INotificationRulesService notificationRulesService)
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
            _notificationRulesService = notificationRulesService;
        }

        public override async Task<ServiceResponse<GetNotificationRecordsDto>> Create(AddNotificationRecordsDto item)
        {
            item.NextScheduledSendTime = AdjustNextScheduledSendTime(item);
            item.CreatedDate = DateTime.UtcNow;
            item.ModifyDate = DateTime.UtcNow;
            return await base.Create(item);
        }

        public override async Task<ServiceResponse<GetNotificationRecordsDto>> Update(UpdateNotificationRecordsDto item)
        {
            item.NextScheduledSendTime = AdjustNextScheduledSendTime(item);
            item.ModifyDate = DateTime.UtcNow;
            return await base.Update(item);
        }

        /// <summary>
        /// Cria ou atualiza registros de NotificationRecords para um MedicalCalendar, associando todas as regras existentes.
        /// </summary>
        /// <param name="dto">DTO contendo o MedicalCalendar e o tipo de notificação.</param>
        /// <returns>Task representando a operação assíncrona.</returns>
        public async Task CreateOrUpdateNotificationRecordsAsync(GenerateNotificationRecordsDto dto)
        {
            var medicalCalendar = dto.MedicalCalendar;

            var notificationRules = await GetNotificationRulesAsync(dto);

            if (notificationRules.Length > 0)
            {
                var notificationRulesDtos = GenerateNotificationRulesDtos(notificationRules, medicalCalendar);

                bool isCompleted = ValidateCompletion(dto.IsCompleted, notificationRulesDtos);

                var notificationRecordDto = CreateNotificationRecordsDto(medicalCalendar, notificationRulesDtos, isCompleted);

                await SaveNotificationRecordAsync(medicalCalendar, notificationRecordDto, isCompleted);
            }
        }

        private async Task<NotificationRules[]> GetNotificationRulesAsync(GenerateNotificationRecordsDto dto)
        {
            return await _notificationRulesService.GetNotificationRulesAsync(dto.NotificationType, dto.IsEnabled, dto.MedicalCalendar.MedicalId);
        }

        private static NotificationRuleStatus[] GenerateNotificationRulesDtos(NotificationRules[] notificationRules, MedicalCalendar medicalCalendar)
        {
            return notificationRules.Select(nr => new NotificationRuleStatus
            {
                NotificationRuleId = nr.Id,
                ScheduledSendTime = CalculateScheduledSendTime(nr, medicalCalendar.StartDateTime, medicalCalendar.TimeZone),
                IsSent = false,
                NotificationMethods = nr.ENotificationServiceType
            }).ToArray();
        }

        private static bool ValidateCompletion(bool isCompletedFromDto, NotificationRuleStatus[] notificationRulesDtos)
        {
            return isCompletedFromDto && notificationRulesDtos.All(nr => nr.IsSent);
        }

        private static AddNotificationRecordsDto CreateNotificationRecordsDto(MedicalCalendar medicalCalendar, NotificationRuleStatus[] notificationRulesDtos, bool isCompleted)
        {
            return new AddNotificationRecordsDto
            { 
                MedicalCalendarId = medicalCalendar.Id,
                NotificationRules = notificationRulesDtos,
                IsCompleted = isCompleted,
                FinalSendDate = isCompleted ? (DateTime?)DateHelper.GetDateTimeNowFromUtc() : null, 
            };
        }

        private async Task SaveNotificationRecordAsync(MedicalCalendar medicalCalendar, AddNotificationRecordsDto notificationRecordDto, bool isCompleted)
        {
            var existingRecord = (await _entityRepository.FindByCustomWhere(nr => nr.MedicalCalendarId == medicalCalendar.Id)).First();

            if (existingRecord != null)
            {
                var updateNotificationRecordDto = new UpdateNotificationRecordsDto
                {
                    Id = existingRecord.Id, 
                    MedicalCalendarId = existingRecord.MedicalCalendarId,
                    NotificationRules = notificationRecordDto.NotificationRules,
                    IsCompleted = isCompleted,
                    FinalSendDate = isCompleted ? (DateTime?)DateHelper.GetDateTimeNowFromUtc() : null  
                };

                await Update(updateNotificationRecordDto);
            }
            else
            {
                await Create(notificationRecordDto);
            }
        }

        private static DateTime CalculateScheduledSendTime(NotificationRules notificationRule, DateTime startDateTime, string timeZone)
        {
            var timeZoneOffset = GetTimeZoneOffset(timeZone);
            var adjustedStartDateTime = startDateTime.AddHours(-timeZoneOffset);

            return notificationRule.IntervalType switch
            {
                EIntervalNotificationType.Minutes => adjustedStartDateTime.AddMinutes(notificationRule.IsBefore ? -notificationRule.IntervalValue : notificationRule.IntervalValue),
                EIntervalNotificationType.Hours => adjustedStartDateTime.AddHours(notificationRule.IsBefore ? -notificationRule.IntervalValue : notificationRule.IntervalValue),
                EIntervalNotificationType.Days => adjustedStartDateTime.AddDays(notificationRule.IsBefore ? -notificationRule.IntervalValue : notificationRule.IntervalValue),
                EIntervalNotificationType.Months => adjustedStartDateTime.AddMonths(notificationRule.IsBefore ? -notificationRule.IntervalValue : notificationRule.IntervalValue),
                EIntervalNotificationType.Years => adjustedStartDateTime.AddYears(notificationRule.IsBefore ? -notificationRule.IntervalValue : notificationRule.IntervalValue),
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private static int GetTimeZoneOffset(string timeZone)
        {
            // Implementação simplificada, ajustar conforme necessidade
            // Exemplo: retorna -3 para horário de Brasília
            return timeZone == "BRT" ? -3 : 0;
        }

        #region private

        private DateTime? AdjustNextScheduledSendTime(NotificationRecordsBaseDto dto)
        {
            if (dto.NotificationRules == null || !dto.NotificationRules.Any(r => !r.IsSent))
            {
                return null;
            }

            var minScheduledLocal = dto.NotificationRules
                .Where(r => !r.IsSent)
                .Min(r => r.ScheduledSendTime);

            int timeZoneOffset = GetAppointmentTimeZoneOffset(dto.MedicalCalendarId);

            return minScheduledLocal.AddHours(-timeZoneOffset);
        }

        private int GetAppointmentTimeZoneOffset(long? medicalCalendarId)
        {
            return medicalCalendarId.HasValue ? -3 : 0;
        }

        #endregion private
    }
}
