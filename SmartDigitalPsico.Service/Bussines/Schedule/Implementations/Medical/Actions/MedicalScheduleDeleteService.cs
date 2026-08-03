using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions
{
    /// <summary>
    /// Classe responsável por MedicalScheduleDeleteService.
    /// Responsabilidade: módulo de agendamento (Schedule).
    /// Relação: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class MedicalScheduleDeleteService : IScheduleCalendarDeleteService
    {
        private readonly MedicalScheduleHostSupport _support;
        private readonly IScheduleQueryService _query;
        private readonly IScheduleDeleteService _delete;
        private readonly MedicalScheduleNotificationAdapter _notifications;

        /// <summary>
        /// Método MedicalScheduleDeleteService: executa a operação MedicalScheduleDeleteService.
        /// </summary>
        public MedicalScheduleDeleteService(
            MedicalScheduleHostSupport support,
            IScheduleQueryService query,
            IScheduleDeleteService delete,
            MedicalScheduleNotificationAdapter notifications)
        {
            _support = support;
            _query = query;
            _delete = delete;
            _notifications = notifications;
        }

        /// <summary>
        /// Método SetUserId: configura estado ou dependencias.
        /// </summary>
        public void SetUserId(long userId) => _support.SetUserId(userId);

        /// <summary>
        /// Método DeleteOneOrRecurrence: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task<ServiceResponse<bool>> DeleteOneOrRecurrence(DeleteMedicalCalendarDto request)
        {
            try
            {
                var user = await _support.UserRepository.FindByID(_support.UserId)
                    ?? throw new AppWarningException(
                        await _support.Loc(UserKeyConstants.User_Not_Found, UserMenssageConstants.User_Not_Found));

                if (request.DeleteSeries)
                {
                    var packagesPreview = await _query.GetByTokenAsync(request.TokenRecurrence);
                    if (packagesPreview.Data != null)
                    {
                        if (!MedicalScheduleKeys.TryParseMedicalId(packagesPreview.Data.OwnerKey, out var seriesMedicalId)
                            || user.MedicalId != seriesMedicalId
                            || user.MedicalId != request.MedicalId)
                            return MedicalScheduleHostSupport.FailBool(
                                await _support.Loc(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission));
                    }
                    else if (user.MedicalId != request.MedicalId)
                    {
                        return MedicalScheduleHostSupport.FailBool(
                            await _support.Loc(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission));
                    }

                    if (packagesPreview.Data != null)
                        await _notifications.DeleteNotificationRecordsAsync(packagesPreview.Data.UniqueToken);

                    var deleted = await _delete.DeleteByTokenFilteredAsync(MedicalScheduleMapper.ToDeleteTokenRequest(request));

                    return deleted.Success
                        ? MedicalScheduleHostSupport.OkBool(true,
                            await _support.Loc(MedicalCalendarKeyConstants.SchedulesDeletedSuccessfully, MedicalCalendarMenssageConstants.SchedulesDeletedSuccessfully))
                        : MedicalScheduleHostSupport.FailBool(deleted.Message);
                }

                var package = await _query.GetByIdAsync(request.Id);
                if (!package.Success || package.Data == null)
                    return MedicalScheduleHostSupport.FailBool(
                        await _support.Loc(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound));

                if (!MedicalScheduleKeys.TryParseMedicalId(package.Data.OwnerKey, out var medicalId)
                    || user.MedicalId != medicalId
                    || user.MedicalId != request.MedicalId)
                    return MedicalScheduleHostSupport.FailBool(
                        await _support.Loc(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission));

                await _notifications.DeleteNotificationRecordsAsync(package.Data.UniqueToken);
                var result = await _delete.DeleteByIdAsync(package.Data.Id);
                return result.Success
                    ? MedicalScheduleHostSupport.OkBool(true,
                        await _support.Loc(MedicalCalendarKeyConstants.SchedulesDeletedSuccessfully, MedicalCalendarMenssageConstants.SchedulesDeletedSuccessfully))
                    : MedicalScheduleHostSupport.FailBool(result.Message);
            }
            catch (Exception ex)
            {
                _support.Logger.Error(ex, "MedicalScheduleDeleteService.DeleteOneOrRecurrence");
                return MedicalScheduleHostSupport.FailBool(
                    await _support.Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message));
            }
        }
    }
}
