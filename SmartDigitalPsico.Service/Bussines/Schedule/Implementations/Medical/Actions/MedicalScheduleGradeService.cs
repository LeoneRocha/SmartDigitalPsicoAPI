using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Validation.Principals.Calendar;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions
{
    public class MedicalScheduleGradeService : IScheduleCalendarGradeService
    {
        private readonly MedicalScheduleHostSupport _support;
        private readonly IScheduleQueryService _query;
        private readonly IScheduleAvailabilityService _availability;
        private readonly MedicalScheduleConstraintsProvider _constraintsProvider;

        public MedicalScheduleGradeService(
            MedicalScheduleHostSupport support,
            IScheduleQueryService query,
            IScheduleAvailabilityService availability,
            MedicalScheduleConstraintsProvider constraintsProvider)
        {
            _support = support;
            _query = query;
            _availability = availability;
            _constraintsProvider = constraintsProvider;
        }

        public void SetUserId(long userId) => _support.SetUserId(userId);

        public Task<ServiceResponse<CalendarDto>> GetMonthlyCalendar(CalendarCriteriaDto criteria)
            => BuildGradeAsync(criteria, ScheduleGradeMode.Monthly);

        public Task<ServiceResponse<CalendarDto>> GetAvailableMedicalCalendar(CalendarCriteriaDto criteria)
            => BuildGradeAsync(criteria, ScheduleGradeMode.AvailableOnly);

        private async Task<ServiceResponse<CalendarDto>> BuildGradeAsync(CalendarCriteriaDto criteria, ScheduleGradeMode mode)
        {
            var response = new ServiceResponse<CalendarDto>();
            try
            {
                criteria.UserIdLogged = _support.UserId;
                if (mode == ScheduleGradeMode.Monthly && !await ValidateCriteriaAsync(criteria, response))
                    return response;

                var medical = await _constraintsProvider.GetMedicalAsync(criteria.MedicalId);
                var user = await _support.UserRepository.FindByID(_support.UserId)
                    ?? throw new AppWarningException(
                        await _support.Loc(UserKeyConstants.User_Not_Found, UserMenssageConstants.User_Not_Found));

                var constraints = MedicalScheduleConstraintsProvider.ToConstraints(medical);
                criteria.IntervalInMinutes = constraints.IntervalMinutes;
                if (mode == ScheduleGradeMode.Monthly && !await ValidateCriteriaAsync(criteria, response))
                    return response;

                if (user.MedicalId != criteria.MedicalId)
                {
                    response.Success = false;
                    response.Data = new CalendarDto { MedicalId = medical.Id, MedicalName = medical.Name, Days = [] };
                    response.Message = await _support.Loc(MedicalCalendarKeyConstants.Calendar_Error, MedicalCalendarMenssageConstants.Calendar_Error);
                    return response;
                }

                var gradeRequest = MedicalScheduleMapper.ToGradeRequest(criteria, constraints, user.TimeZone ?? string.Empty, mode);
                var items = await _query.GetItemsForOwnerAsync(
                    gradeRequest.TenantKey, gradeRequest.OwnerKey, gradeRequest.StartDate, gradeRequest.EndDate);
                var preloaded = items.Data ?? [];

                gradeRequest = MedicalScheduleMapper.ToGradeRequest(criteria, constraints, user.TimeZone ?? string.Empty, mode, preloaded);
                var grade = await _availability.BuildGradeAsync(gradeRequest);
                if (!grade.Success || grade.Data == null)
                {
                    response.Success = false;
                    response.Message = grade.Message;
                    response.Data = new CalendarDto { MedicalId = medical.Id, MedicalName = medical.Name, Days = [] };
                    return response;
                }

                response.Success = true;
                var patientNames = await ResolvePatientNamesAsync(grade.Data);
                response.Data = MedicalScheduleMapper.ToCalendarDto(grade.Data, medical.Id, patientNames);
                response.Message = await _support.Loc(MedicalCalendarKeyConstants.CalendarSuccess, MedicalCalendarMenssageConstants.CalendarSuccess);
                return response;
            }
            catch (Exception ex)
            {
                _support.Logger.Error(ex, "MedicalScheduleGradeService.BuildGradeAsync");
                response.Success = false;
                response.Message = await _support.Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                return response;
            }
        }

        private async Task<bool> ValidateCriteriaAsync(CalendarCriteriaDto criteria, ServiceResponse<CalendarDto> response)
        {
            var result = await new CalendarCriteriaValidator(_support.UserRepository).ValidateAsync(criteria);
            if (result.IsValid) return true;
            response.Success = false;
            response.Data = new CalendarDto();
            response.Message = await _support.Loc(MedicalCalendarKeyConstants.Calendar_Error, MedicalCalendarMenssageConstants.Calendar_Error);
            response.Errors = await _support.TranslateErrors(
                HelperValidation.ConvertValidationFailureListToErroResponse(result.Errors));
            return false;
        }

        private async Task<IReadOnlyDictionary<long, string>> ResolvePatientNamesAsync(ScheduleGradeResult grade)
        {
            var patientIds = grade.Days
                .SelectMany(d => d.TimeSlots)
                .Where(s => s.Booking != null)
                .Select(s =>
                {
                    if (!string.IsNullOrWhiteSpace(s.Booking!.SubjectKey)
                        && MedicalScheduleKeys.TryParsePatientId(s.Booking.SubjectKey, out var pid))
                        return pid;
                    return 0L;
                })
                .Where(id => id > 0)
                .Distinct()
                .ToArray();

            var names = new Dictionary<long, string>();
            foreach (var patientId in patientIds)
            {
                try
                {
                    var patient = await _support.PatientRepository.FindByID(patientId);
                    if (patient != null && !string.IsNullOrWhiteSpace(patient.Name))
                        names[patientId] = patient.Name;
                }
                catch (Exception ex)
                {
                    _support.Logger.Warning(ex, "Failed to resolve patient name for PatientId={PatientId}", patientId);
                }
            }
            return names;
        }
    }
}
