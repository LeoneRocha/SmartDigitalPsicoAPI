using SmartDigitalPsico.Core.SDK.Domain.AppException;
using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Validation;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe responsável por MedicalScheduleGradeService.
    /// Responsabilidade: módulo de agendamento (Schedule).
    /// Relação: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class MedicalScheduleGradeService : IScheduleCalendarGradeService
    {
        private readonly MedicalScheduleHostSupport _support;
        private readonly IScheduleQueryService _query;
        private readonly IScheduleAvailabilityService _availability;
        private readonly MedicalScheduleConstraintsProvider _constraintsProvider;

        /// <summary>
        /// Método MedicalScheduleGradeService: executa a operação MedicalScheduleGradeService.
        /// </summary>
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

        /// <summary>
        /// Método SetUserId: configura estado ou dependencias.
        /// </summary>
        public void SetUserId(long userId) => _support.SetUserId(userId);

        /// <summary>
        /// Método GetMonthlyCalendar: consulta e retorna dados.
        /// </summary>
        public Task<ServiceResponse<CalendarDto>> GetMonthlyCalendar(CalendarCriteriaDto criteria)
            => BuildGradeAsync(criteria, ScheduleGradeMode.Monthly);

        /// <summary>
        /// Método GetAvailableMedicalCalendar: consulta e retorna dados.
        /// </summary>
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
                    response.Message = await _support.Loc(CalendarKeyConstants.Calendar_Error, CalendarMenssageConstants.Calendar_Error);
                    return response;
                }

                // DB: itens do owner (antes do CPU). CPU paralelo: GenerateDays. Nomes batch antes de ToCalendarDto.
                // Sem Parallel em FindByID de paciente — ResolvePatientNamesAsync usa uma query Contains.
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

                // DB batch de nomes ANTES do map paralelo ToCalendarDto
                response.Success = true;
                var patientNames = await ResolvePatientNamesAsync(grade.Data);
                response.Data = MedicalScheduleMapper.ToCalendarDto(grade.Data, medical.Id, patientNames);
                response.Message = await _support.Loc(CalendarKeyConstants.CalendarSuccess, CalendarMenssageConstants.CalendarSuccess);
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
            var result = await new MedicalCalendarCriteriaValidator(_support.UserRepository).ValidateAsync(criteria);
            if (result.IsValid) return true;
            response.Success = false;
            response.Data = new CalendarDto();
            response.Message = await _support.Loc(CalendarKeyConstants.Calendar_Error, CalendarMenssageConstants.Calendar_Error);
            response.Errors = await _support.TranslateErrors(
                HelperValidation.ConvertValidationFailureListToErroResponse(result.Errors));
            return false;
        }

        /// <summary>
        /// Resolve nomes de pacientes com UMA query batch (FindByCustomWhere + Contains).
        /// Sem Parallel.ForEach + FindByID: DbContext/EF não é thread-safe.
        /// Ganho esperado: evita N round-trips ao montar a grade mensal com bookings.
        /// </summary>
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

            if (patientIds.Length == 0)
                return new Dictionary<long, string>();

            try
            {
                // Uma única ida ao banco — sem paralelismo de I/O no mesmo contexto.
                var patients = await _support.PatientRepository.FindByCustomWhere(p => patientIds.Contains(p.Id));
                return patients
                    .Where(p => !string.IsNullOrWhiteSpace(p.Name))
                    .ToDictionary(p => p.Id, p => p.Name);
            }
            catch (Exception ex)
            {
                _support.Logger.Warning(ex, "Failed to batch-resolve patient names for {Count} ids", patientIds.Length);
                return new Dictionary<long, string>();
            }
        }
    }
}
