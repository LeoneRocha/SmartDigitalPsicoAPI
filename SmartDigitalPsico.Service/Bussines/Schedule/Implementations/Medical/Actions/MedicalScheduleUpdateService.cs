using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions
{
    /// <summary>
    /// Classe responsável por MedicalScheduleUpdateService.
    /// Responsabilidade: módulo de agendamento (Schedule).
    /// Relação: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class MedicalScheduleUpdateService : IScheduleCalendarUpdateService
    {
        private readonly MedicalScheduleHostSupport _support;
        private readonly IScheduleQueryService _query;
        private readonly IScheduleUpdateService _update;
        private readonly MedicalScheduleNotificationAdapter _notifications;

        /// <summary>
        /// Método MedicalScheduleUpdateService: executa a operação MedicalScheduleUpdateService.
        /// </summary>
        public MedicalScheduleUpdateService(
            MedicalScheduleHostSupport support,
            IScheduleQueryService query,
            IScheduleUpdateService update,
            MedicalScheduleNotificationAdapter notifications)
        {
            _support = support;
            _query = query;
            _update = update;
            _notifications = notifications;
        }

        /// <summary>
        /// Método SetUserId: configura estado ou dependencias.
        /// </summary>
        public void SetUserId(long userId) => _support.SetUserId(userId);

        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public async Task<ServiceResponse<GetMedicalCalendarDto>> Update(UpdateMedicalCalendarDto item)
        {
            try
            {
                var existing = await _query.GetByIdAsync(item.Id);
                if (!existing.Success || existing.Data == null)
                    return MedicalScheduleHostSupport.FailDto(
                        await _support.Loc(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound));

                var package = existing.Data;
                var targetOccurrence = FindTargetOccurrence(package.ScheduleData, item.StartDateTime);

                if (item.Status is EStatusCalendar.Canceled or EStatusCalendar.Refused
                    || targetOccurrence?.Status is EStatusCalendar.Canceled or EStatusCalendar.Refused)
                {
                    return MedicalScheduleHostSupport.FailDto(
                        await _support.Loc(CalendarKeyConstants.Calendar_Error, CalendarMenssageConstants.Calendar_Error));
                }

                var entity = _support.Mapper.Map<MedicalCalendar>(item);
                entity.Id = package.Id;
                entity.CreatedUserId = _support.UserId;
                entity.ModifyUserId = _support.UserId;
                entity.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entity.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entity.TokenRecurrence = package.UniqueToken;

                var validation = await _support.ValidateEntityAsync(entity);
                if (!validation.Success) return validation;

                var write = MedicalScheduleMapper.ToWriteRequest(entity, isUpdate: true, updateSeries: item.UpdateSeries);
                write.PackageId = package.Id;
                var persist = await _update.UpdateAsync(write);
                if (!persist.Success || persist.Data == null)
                    return MedicalScheduleHostSupport.FailDto(persist.Message, persist.Errors);

                entity.Id = persist.Data.Id;
                await _notifications.CreateOrUpdateNotificationRecordsAsync([entity]);
                await _notifications.SendNotifyRegisterAsync(entity, EMedicalCalendarActionType.Update);

                var preferred = FindTargetOccurrence(persist.Data.ScheduleData, item.StartDateTime);
                return MedicalScheduleHostSupport.OkDto(
                    MedicalScheduleMapper.ToGetDto(persist.Data, preferred),
                    await _support.Loc(CalendarKeyConstants.CalendarUpdated, CalendarMenssageConstants.CalendarUpdated));
            }
            catch (Exception ex)
            {
                _support.Logger.Error(ex, "MedicalScheduleUpdateService.Update");
                return MedicalScheduleHostSupport.FailDto(
                    await _support.Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message));
            }
        }

        private static ScheduleCalendarItem? FindTargetOccurrence(ScheduleCalendarItem[]? items, DateTime startDateTime)
        {
            if (items == null || items.Length == 0) return null;
            return items.FirstOrDefault(i => i.StartDateTime == startDateTime)
                ?? items.FirstOrDefault(i => i.StartDateTime.Date == startDateTime.Date);
        }
    }
}
