using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service.Schedule.Medical.Actions
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
    /// Classe responsável por MedicalScheduleCreateService.
    /// Responsabilidade: módulo de agendamento (Schedule).
    /// Relação: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class MedicalScheduleCreateService : IScheduleCalendarCreateService
    {
        private readonly MedicalScheduleHostSupport _support;
        private readonly IScheduleCreateService _create;
        private readonly MedicalScheduleNotificationAdapter _notifications;

        /// <summary>
        /// Método MedicalScheduleCreateService: executa a operação MedicalScheduleCreateService.
        /// </summary>
        public MedicalScheduleCreateService(
            MedicalScheduleHostSupport support,
            IScheduleCreateService create,
            MedicalScheduleNotificationAdapter notifications)
        {
            _support = support;
            _create = create;
            _notifications = notifications;
        }

        /// <summary>
        /// Método SetUserId: configura estado ou dependencias.
        /// </summary>
        public void SetUserId(long userId) => _support.SetUserId(userId);

        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task<ServiceResponse<GetMedicalCalendarDto>> Create(AddMedicalCalendarDto item)
        {
            try
            {
                var entity = _support.MapNewEntity(item);
                var validation = await _support.ValidateEntityAsync(entity);
                if (!validation.Success) return validation;

                var write = MedicalScheduleMapper.ToWriteRequest(entity);
                var persist = await _create.CreateAsync(write);
                if (!persist.Success || persist.Data == null)
                    return MedicalScheduleHostSupport.FailDto(persist.Message, persist.Errors);

                entity.Id = persist.Data.Id;
                await _notifications.CreateOrUpdateNotificationRecordsAsync([entity]);
                await _notifications.SendNotifyRegisterAsync(entity, EMedicalCalendarActionType.Add);

                return MedicalScheduleHostSupport.OkDto(
                    MedicalScheduleMapper.ToGetDto(persist.Data),
                    await _support.Loc(CalendarKeyConstants.CalendarRegistred, CalendarMenssageConstants.CalendarRegistred));
            }
            catch (Exception ex)
            {
                _support.Logger.Error(ex, "MedicalScheduleCreateService.Create");
                return MedicalScheduleHostSupport.FailDto(
                    await _support.Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message));
            }
        }
    }
}
