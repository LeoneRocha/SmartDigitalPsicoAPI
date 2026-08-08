using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions
{
    /// <summary>
    /// Classe responsável por MedicalScheduleAppointmentService.
    /// Responsabilidade: módulo de agendamento (Schedule).
    /// Relação: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class MedicalScheduleAppointmentService : IScheduleCalendarAppointmentService
    {
        private readonly MedicalScheduleHostSupport _support;
        private readonly IScheduleCreateService _create;
        private readonly IScheduleUpdateService _update;
        private readonly IScheduleAppointmentQueryService _appointmentQuery;
        private readonly MedicalScheduleConstraintsProvider _constraintsProvider;
        private readonly MedicalScheduleNotificationAdapter _notifications;
        private readonly IMedicalCalendarValidators _validators;

        /// <summary>
        /// Método MedicalScheduleAppointmentService: executa a operação MedicalScheduleAppointmentService.
        /// </summary>
        public MedicalScheduleAppointmentService(
            MedicalScheduleHostSupport support,
            IScheduleCreateService create,
            IScheduleUpdateService update,
            IScheduleAppointmentQueryService appointmentQuery,
            MedicalScheduleConstraintsProvider constraintsProvider,
            MedicalScheduleNotificationAdapter notifications,
            IMedicalCalendarValidators validators)
        {
            _support = support;
            _create = create;
            _update = update;
            _appointmentQuery = appointmentQuery;
            _constraintsProvider = constraintsProvider;
            _notifications = notifications;
            _validators = validators;
        }

        /// <summary>
        /// Método SetUserId: configura estado ou dependencias.
        /// </summary>
        public void SetUserId(long userId) => _support.SetUserId(userId);

        /// <summary>
        /// Método RequestAppointment: operação de agendamento.
        /// </summary>
        public async Task<ServiceResponse<bool>> RequestAppointment(ScheduleCriteriaDto criteria)
        {
            try
            {
                var validation = await _validators.ScheduleCriteriaDtoValidator.ValidateAsync(criteria);
                if (!validation.IsValid)
                {
                    return new ServiceResponse<bool>
                    {
                        Success = false,
                        Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validation.Errors),
                        Message = validation.Errors[0].ErrorMessage
                    };
                }

                if (criteria.ScheduleType == EScheduleCalendarType.Schedule)
                {
                    criteria.UserIdLogged = _support.UserId;
                    var medical = await _constraintsProvider.GetMedicalAsync(criteria.MedicalId);
                    var booked = await _create.BookAsync(MedicalScheduleMapper.ToBookRequest(criteria, medical.PatientIntervalTimeMinutes));
                    return booked.Success
                        ? MedicalScheduleHostSupport.OkBool(true,
                            await _support.Loc(MedicalCalendarKeyConstants.Schedule_Appointment_Success, MedicalCalendarMenssageConstants.Schedule_Appointment_Success) + $". ({booked.Data?.Id})")
                        : MedicalScheduleHostSupport.FailBool(booked.Message);
                }

                if (criteria.ScheduleType == EScheduleCalendarType.Cancellation)
                {
                    var canceled = await _update.CancelOccurrenceAsync(MedicalScheduleMapper.ToCancelRequest(criteria));
                    if (canceled.Success && canceled.Data != null)
                        await _notifications.DeleteNotificationRecordsAsync(
                            canceled.Data.UniqueToken,
                            criteria.AppointmentDateTime);

                    return canceled.Success
                        ? MedicalScheduleHostSupport.OkBool(true,
                            await _support.Loc(MedicalCalendarKeyConstants.Cancel_Appointment_Success, MedicalCalendarMenssageConstants.Cancel_Appointment_Success) + $". ({canceled.Data?.PackageId})")
                        : MedicalScheduleHostSupport.FailBool(
                            canceled.Message ?? await _support.Loc(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound));
                }

                return MedicalScheduleHostSupport.FailBool(
                    await _support.Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message));
            }
            catch (Exception ex)
            {
                _support.Logger.Error(ex, "MedicalScheduleAppointmentService.RequestAppointment");
                return MedicalScheduleHostSupport.FailBool(
                    await _support.Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message));
            }
        }

        /// <summary>
        /// Método GetAppointments: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<AppointmentDto[]>> GetAppointments(AppointmentCriteriaDto criteria)
        {
            try
            {
                var validation = await _validators.AppointmentCriteriaDtoValidator.ValidateAsync(criteria);
                if (!validation.IsValid)
                {
                    return new ServiceResponse<AppointmentDto[]>
                    {
                        Success = false,
                        Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validation.Errors),
                        Message = validation.Errors[0].ErrorMessage
                    };
                }

                var (start, end) = MedicalScheduleMapper.GetMonthRange(criteria.Year, criteria.Month);
                var items = await _appointmentQuery.GetItemsForOwnerSubjectAsync(
                    MedicalScheduleKeys.TenantKey,
                    MedicalScheduleKeys.ForMedical(criteria.MedicalId),
                    MedicalScheduleKeys.ForPatient(criteria.PatientId),
                    start, end);

                if (items.Data == null || items.Data.Length == 0)
                {
                    return new ServiceResponse<AppointmentDto[]>
                    {
                        Success = false,
                        Message = await _support.Loc(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound)
                    };
                }

                var medical = await _constraintsProvider.GetMedicalAsync(criteria.MedicalId);
                return new ServiceResponse<AppointmentDto[]>
                {
                    Success = true,
                    Data = MedicalScheduleMapper.ToAppointmentDtos(items.Data, criteria.MedicalId, medical.Name),
                    Message = await _support.Loc(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound)
                };
            }
            catch (Exception ex)
            {
                _support.Logger.Error(ex, "MedicalScheduleAppointmentService.GetAppointments");
                return new ServiceResponse<AppointmentDto[]>
                {
                    Success = false,
                    Message = await _support.Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message)
                };
            }
        }
    }
}
