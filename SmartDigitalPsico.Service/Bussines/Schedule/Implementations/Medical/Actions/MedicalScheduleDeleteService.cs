using SmartDigitalPsico.Core.SDK.Domain.AppException;
using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.VO;

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

                return request.DeleteSeries
                    ? await DeleteSeriesAsync(request, user)
                    : await DeleteSingleAsync(request, user);
            }
            catch (Exception ex)
            {
                _support.Logger.Error(ex, "MedicalScheduleDeleteService.DeleteOneOrRecurrence");
                return MedicalScheduleHostSupport.FailBool(
                    await _support.Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message));
            }
        }

        private async Task<ServiceResponse<bool>> DeleteSeriesAsync(DeleteMedicalCalendarDto request, User user)
        {
            var packagesPreview = await _query.GetByTokenAsync(request.TokenRecurrence);
            var permissionError = await ValidateSeriesPermissionAsync(request, user, packagesPreview.Data);
            if (permissionError != null)
                return permissionError;

            if (packagesPreview.Data != null)
                await _notifications.DeleteNotificationRecordsAsync(packagesPreview.Data.UniqueToken);

            var deleted = await _delete.DeleteByTokenFilteredAsync(MedicalScheduleMapper.ToDeleteTokenRequest(request));
            return deleted.Success
                ? MedicalScheduleHostSupport.OkBool(true,
                    await _support.Loc(CalendarKeyConstants.SchedulesDeletedSuccessfully, CalendarMenssageConstants.SchedulesDeletedSuccessfully))
                : MedicalScheduleHostSupport.FailBool(deleted.Message);
        }

        private async Task<ServiceResponse<bool>> DeleteSingleAsync(DeleteMedicalCalendarDto request, User user)
        {
            var package = await _query.GetByIdAsync(request.Id);
            if (!package.Success || package.Data == null)
                return MedicalScheduleHostSupport.FailBool(
                    await _support.Loc(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound));

            if (!IsOwnerMedical(user, request.MedicalId, package.Data.OwnerKey))
                return await FailPermissionAsync();

            await _notifications.DeleteNotificationRecordsAsync(package.Data.UniqueToken);
            var result = await _delete.DeleteByIdAsync(package.Data.Id);
            return result.Success
                ? MedicalScheduleHostSupport.OkBool(true,
                    await _support.Loc(CalendarKeyConstants.SchedulesDeletedSuccessfully, CalendarMenssageConstants.SchedulesDeletedSuccessfully))
                : MedicalScheduleHostSupport.FailBool(result.Message);
        }

        private async Task<ServiceResponse<bool>?> ValidateSeriesPermissionAsync(
            DeleteMedicalCalendarDto request, User user, ScheduleCalendar? package)
        {
            if (package != null)
            {
                if (!IsOwnerMedical(user, request.MedicalId, package.OwnerKey))
                    return await FailPermissionAsync();
                return null;
            }

            if (user.MedicalId != request.MedicalId)
                return await FailPermissionAsync();

            return null;
        }

        private static bool IsOwnerMedical(User user, long requestMedicalId, string ownerKey)
            => MedicalScheduleKeys.TryParseMedicalId(ownerKey, out var medicalId)
               && user.MedicalId == medicalId
               && user.MedicalId == requestMedicalId;

        private async Task<ServiceResponse<bool>> FailPermissionAsync()
            => MedicalScheduleHostSupport.FailBool(
                await _support.Loc(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission));
    }
}
