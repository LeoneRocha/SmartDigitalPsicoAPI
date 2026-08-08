using FluentValidation;
using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Leaves.Common;
using SmartDigitalPsico.Domain.DTO.Notification.Common;
using SmartDigitalPsico.Domain.DTO.Application.Common;
using SmartDigitalPsico.Domain.DTO.Audit.Common;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.DTO.Gender.UPDATE;
using SmartDigitalPsico.Domain.DTO.Office.UPDATE;
using SmartDigitalPsico.Domain.DTO.RoleGroup.UPDATE;
using SmartDigitalPsico.Domain.DTO.Leaves.UPDATE;
using SmartDigitalPsico.Domain.DTO.Specialty.UPDATE;
using SmartDigitalPsico.Domain.DTO.Notification.UPDATE;
using SmartDigitalPsico.Domain.DTO.Application.UPDATE;
using SmartDigitalPsico.Domain.DTO.Audit.UPDATE;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.DTO.Gender.ADD;
using SmartDigitalPsico.Domain.DTO.Office.ADD;
using SmartDigitalPsico.Domain.DTO.RoleGroup.ADD;
using SmartDigitalPsico.Domain.DTO.Leaves.ADD;
using SmartDigitalPsico.Domain.DTO.Specialty.ADD;
using SmartDigitalPsico.Domain.DTO.Notification.ADD;
using SmartDigitalPsico.Domain.DTO.Application.ADD;
using SmartDigitalPsico.Domain.DTO.Audit.ADD;

using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    /// <summary>
    /// Classe responsável por NotificationRecordsService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class NotificationRecordsService : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<NotificationRecord, GetNotificationRecordsDto>, INotificationRecordsService
    {
        private readonly INotificationRulesService _notificationRulesService;

        /// <summary>
        /// Método NotificationRecordsService: executa a operação NotificationRecordsService.
        /// </summary>
        public NotificationRecordsService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            INotificationRecordsRepository entityRepository,
            IApplicationLanguageRepository applicationLanguageRepository,
            IValidator<NotificationRecord> entityValidator,
            INotificationRulesService notificationRulesService)
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
            _notificationRulesService = notificationRulesService;
        }

        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public override async Task<ServiceResponse<GetNotificationRecordsDto>> Create(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
        {
            var dto = (AddNotificationRecordsDto)item;
            dto.NextScheduledSendTime = GetNextScheduledSendTime(dto);
            dto.CreatedDate = DateTime.UtcNow;
            dto.ModifyDate = DateTime.UtcNow;
            return await base.Create(dto);
        }

        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public override async Task<ServiceResponse<GetNotificationRecordsDto>> Update(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDto item)
        {
            var dto = (UpdateNotificationRecordsDto)item;
            ServiceResponse<GetNotificationRecordsDto> response = new ServiceResponse<GetNotificationRecordsDto>();

            NotificationRecord? entityUpdate = await ((INotificationRecordsRepository)_entityRepository).FindByID(dto.Id);
            if (entityUpdate != null)
            {   
                entityUpdate.NotificationRules = dto.NotificationRules;
                entityUpdate.NextScheduledSendTime = dto.NextScheduledSendTime;
                entityUpdate.FinalSendDate = dto.FinalSendDate;
                entityUpdate.EventDate = dto.EventDate;
                entityUpdate.TokenId = dto.TokenId;
                entityUpdate.Enable = dto.Enable;
                entityUpdate.IsCompleted = dto.IsCompleted;               
               
                // Atualiza as datas e o usuário modificador
                entityUpdate.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

                response = await base.Validate(entityUpdate);

                if (response.Success)
                {  
                    NotificationRecord entityResponse = await ((INotificationRecordsRepository)_entityRepository).Update(entityUpdate);

                    response.Data = _mapper.Map<GetNotificationRecordsDto>(entityResponse);
                    response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
                }
            }
            else
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
            }

            return response;
        }

        /// <summary>
        /// Cria ou atualiza registros de NotificationRecords para um ou mais MedicalCalendars, associando todas as regras existentes.
        /// </summary>
        /// <param name="dto">DTO contendo os MedicalCalendars e o tipo de notificação.</param>
        /// <returns>Task representando a operação assíncrona.</returns>
        /// <summary>
        /// Método CreateOrUpdateNotificationRecordsAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task CreateOrUpdateNotificationRecordsAsync(GenerateNotificationRecordsDto dto)
        {
            try
            {
                foreach (var medicalCalendar in dto.MedicalCalendars)
                {
                    await ProcessSingleMedicalCalendarAsync(medicalCalendar, dto);
                }
            } 
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at CreateOrUpdateNotificationRecordsAsync");
            }
        }

        private async Task ProcessSingleMedicalCalendarAsync(MedicalCalendar medicalCalendar, GenerateNotificationRecordsDto dto)
        {
            var notificationRules = await GetNotificationRulesAsync(dto, medicalCalendar.MedicalId);

            if (notificationRules.Length > 0)
            {
                var notificationRulesDtos = GenerateNotificationRulesDtos(notificationRules, medicalCalendar);
                bool isCompleted = ValidateCompletion(dto.IsCompleted, notificationRulesDtos);
                var notificationRecordDto = CreateNotificationRecordsDto(medicalCalendar, notificationRulesDtos, isCompleted);

                await SaveNotificationRecordAsync(medicalCalendar, notificationRecordDto, isCompleted);
            }
        }

        private async Task<NotificationRule[]> GetNotificationRulesAsync(GenerateNotificationRecordsDto dto, long medicalId)
        {
            return await _notificationRulesService.GetNotificationRulesAsync(dto.NotificationType, dto.IsEnabled, medicalId);
        }

        private static NotificationRuleStatus[] GenerateNotificationRulesDtos(NotificationRule[] notificationRules, MedicalCalendar medicalCalendar)
        {
            var currentTime  = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.ApplyTimeZone(DateTime.UtcNow, medicalCalendar.TimeZone);

            return notificationRules
                .Select(nr => new NotificationRuleStatus
                {
                    NotificationRuleId = nr.Id,
                    ScheduledSendTime = CalculateScheduledSendTime(nr, medicalCalendar.StartDateTime, medicalCalendar.TimeZone),
                    IsSent = false,
                    NotificationMethods = nr.ENotificationServiceType
                })
                .Where(nr => nr.ScheduledSendTime > currentTime)
                .ToArray();
        }

        private static bool ValidateCompletion(bool isCompletedFromDto, NotificationRuleStatus[] notificationRulesDtos)
        {
            return isCompletedFromDto && notificationRulesDtos.All(nr => nr.IsSent);
        }

        private static AddNotificationRecordsDto CreateNotificationRecordsDto(MedicalCalendar medicalCalendar, NotificationRuleStatus[] notificationRulesDtos, bool isCompleted)
        {
            return new AddNotificationRecordsDto
            {
                Enable = true,
                EventDate = medicalCalendar.StartDateTime,
                Language = "en",
                Description = medicalCalendar.Description,
                TokenId = ParseTokenId(medicalCalendar.TokenRecurrence),
                NotificationRules = notificationRulesDtos,
                IsCompleted = isCompleted,
                FinalSendDate = isCompleted ? (DateTime?)SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc() : null
            };
        }

        private async Task SaveNotificationRecordAsync(MedicalCalendar medicalCalendar, AddNotificationRecordsDto notificationRecordDto, bool isCompleted)
        {
            try
            {
                var tokenId = notificationRecordDto.TokenId;
                if (tokenId == Guid.Empty)
                {
                    _logger.Warning("SaveNotificationRecordAsync skipped: empty TokenId for EventDate {EventDate}", medicalCalendar.StartDateTime);
                    return;
                }

                var existingRecord = (await ((INotificationRecordsRepository)_entityRepository).FindByCustomWhere(nr =>
                    nr.TokenId == tokenId
                    && nr.EventDate == medicalCalendar.StartDateTime)).FirstOrDefault();

                if (existingRecord != null)
                {
                    var updateNotificationRecordDto = new UpdateNotificationRecordsDto
                    {
                        Id = existingRecord.Id,
                        EventDate = medicalCalendar.StartDateTime,
                        TokenId = tokenId,
                        NotificationRules = notificationRecordDto.NotificationRules,
                        IsCompleted = isCompleted,
                        FinalSendDate = isCompleted ? (DateTime?)SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc() : null
                    };

                    await Update(updateNotificationRecordDto);
                }
                else
                {
                    await Create(notificationRecordDto);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error at SaveNotificationRecordAsync");
            }

        }

        private static Guid ParseTokenId(string? token)
            => Guid.TryParse(token, out var id) ? id : Guid.Empty;

        private static DateTime CalculateScheduledSendTime(NotificationRule notificationRule, DateTime startDateTime, string timeZone)
        {
            var timeZoneOffset = GetTimeZoneOffset(timeZone);
            var adjustedStartDateTime = startDateTime.AddHours(-timeZoneOffset);

            switch (notificationRule.IntervalType)
            {
                case EIntervalNotificationType.Minutes:
                    return adjustedStartDateTime.AddMinutes(notificationRule.IsBefore ? -notificationRule.IntervalValue : notificationRule.IntervalValue);
                case EIntervalNotificationType.Hours:
                    return adjustedStartDateTime.AddHours(notificationRule.IsBefore ? -notificationRule.IntervalValue : notificationRule.IntervalValue);
                case EIntervalNotificationType.Days:
                    return adjustedStartDateTime.AddDays(notificationRule.IsBefore ? -notificationRule.IntervalValue : notificationRule.IntervalValue);
                case EIntervalNotificationType.Months:
                    return adjustedStartDateTime.AddMonths(notificationRule.IsBefore ? -notificationRule.IntervalValue : notificationRule.IntervalValue);
                case EIntervalNotificationType.Years:
                    return adjustedStartDateTime.AddYears(notificationRule.IsBefore ? -notificationRule.IntervalValue : notificationRule.IntervalValue);
                default: 
                    return adjustedStartDateTime;
            }
        }
         
        private static int GetTimeZoneOffset(string timeZone)
        {
            // Implementação simplificada, ajustar conforme necessidade
            // Exemplo: retorna -3 para horário de Brasília
            return timeZone == "BRT" ? -3 : 0;
        }

        #region private

        private static DateTime? GetNextScheduledSendTime(NotificationRecordsBaseDto dto)
        {
            if (dto.NotificationRules == null || !dto.NotificationRules.Any(r => !r.IsSent))
            {
                return null;
            }

            var minScheduledLocal = dto.NotificationRules
                .Where(r => !r.IsSent)
                .Min(r => r.ScheduledSendTime);            

            return minScheduledLocal;
        } 

        /// <summary>
        /// Método GetPendingNotificationsAsync: consulta e retorna dados.
        /// </summary>
        public async Task<NotificationRecord[]> GetPendingNotificationsAsync()
        {
            return await ((INotificationRecordsRepository)_entityRepository).GetPendingNotificationsAsync();
        }

        #endregion private
    }
}

