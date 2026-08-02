using AutoMapper;
using FluentValidation.Results;
using Serilog;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Validation.Principals.Calendar;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical
{
    /// <summary>
    /// Thin Medical host: validates FE DTOs, maps ↔ Core engines, maps results back. No schedule engine logic.
    /// </summary>
    public class MedicalScheduleCalendarHost :
        IScheduleCalendarFacade,
        IScheduleCalendarFindService,
        IScheduleCalendarCreateService,
        IScheduleCalendarUpdateService,
        IScheduleCalendarDeleteService,
        IScheduleCalendarGradeService,
        IScheduleCalendarAppointmentService
    {
        private readonly IScheduleCalendarService _scheduleService;
        private readonly IScheduleGradeEngine _gradeEngine;
        private readonly IScheduleBookingEngine _bookingEngine;
        private readonly MedicalScheduleConstraintsProvider _constraintsProvider;
        private readonly MedicalScheduleNotificationAdapter _notifications;
        private readonly IMedicalCalendarValidators _validators;
        private readonly IUserRepository _userRepository;
        private readonly IPatientRepository _patientRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        private readonly IApplicationLanguageService _languageService;
        private readonly ICacheService _cacheService;
        private long _userId;

        public MedicalScheduleCalendarHost(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            IMedicalCalendarValidators validators,
            IPatientRepositories patientRepositories,
            IScheduleCalendarService scheduleService,
            IScheduleGradeEngine gradeEngine,
            IScheduleBookingEngine bookingEngine,
            MedicalScheduleConstraintsProvider constraintsProvider,
            MedicalScheduleNotificationAdapter notifications)
        {
            _mapper = sharedDependenciesConfig.Mapper;
            _logger = sharedDependenciesConfig.Logger;
            _languageService = sharedServices.ApplicationLanguageService;
            _cacheService = sharedServices.CacheService;
            _validators = validators;
            _userRepository = patientRepositories.SharedRepositories.UserRepository;
            _patientRepository = patientRepositories.PatientRepository;
            _scheduleService = scheduleService;
            _gradeEngine = gradeEngine;
            _bookingEngine = bookingEngine;
            _constraintsProvider = constraintsProvider;
            _notifications = notifications;
        }

        public void SetUserId(long userId) => _userId = userId;

        public async Task<ServiceResponse<GetMedicalCalendarDto>> FindByID(long id)
        {
            var result = await _scheduleService.GetByIdAsync(id);
            if (!result.Success || result.Data == null)
                return FailDto(await Loc(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound));

            return Ok(MedicalScheduleMapper.ToGetDto(result.Data),
                await Loc(GeneralLanguageKeyConstants.RegisterFind, GeneralLanguageMenssageConstants.RegisterFind));
        }

        public async Task<ServiceResponse<GetMedicalCalendarDto>> Create(AddMedicalCalendarDto item)
        {
            try
            {
                var entity = MapNewEntity(item);
                var validation = await ValidateEntityAsync(entity);
                if (!validation.Success) return validation;

                var write = MedicalScheduleMapper.ToWriteRequest(entity);
                var persist = await _scheduleService.CreateOrUpdateAsync(write);
                if (!persist.Success || persist.Data == null)
                    return FailDto(persist.Message);

                entity.Id = persist.Data.Id;
                await _notifications.CreateOrUpdateNotificationRecordsAsync([entity]);
                await _notifications.SendNotifyRegisterAsync(entity, EMedicalCalendarActionType.Add);

                return Ok(MedicalScheduleMapper.ToGetDto(persist.Data),
                    await Loc(MedicalCalendarKeyConstants.CalendarRegistred, MedicalCalendarMenssageConstants.CalendarRegistred));
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "MedicalScheduleCalendarHost.Create");
                return FailDto(await Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message));
            }
        }

        public async Task<ServiceResponse<GetMedicalCalendarDto>> Update(UpdateMedicalCalendarDto item)
        {
            try
            {
                var existing = await _scheduleService.GetByIdAsync(item.Id);
                if (!existing.Success || existing.Data == null)
                    return FailDto(await Loc(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound));

                var package = existing.Data;
                var targetOccurrence = FindTargetOccurrence(package.ScheduleData, item.StartDateTime);

                // Block editing canceled/refused packages (payload status or target occurrence).
                if (item.Status is EStatusCalendar.Canceled or EStatusCalendar.Refused
                    || targetOccurrence?.Status is EStatusCalendar.Canceled or EStatusCalendar.Refused)
                {
                    return FailDto(await Loc(MedicalCalendarKeyConstants.Calendar_Error, MedicalCalendarMenssageConstants.Calendar_Error));
                }

                var entity = _mapper.Map<MedicalCalendar>(item);
                entity.Id = package.Id;
                entity.CreatedUserId = _userId;
                entity.ModifyUserId = _userId;
                entity.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                entity.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();
                // Never invent a new token on update — preserve package UniqueToken for self-exclude + SoT lookup.
                entity.TokenRecurrence = package.UniqueToken;

                var validation = await ValidateEntityAsync(entity);
                if (!validation.Success) return validation;

                var write = MedicalScheduleMapper.ToWriteRequest(entity, isUpdate: true, updateSeries: item.UpdateSeries);
                write.PackageId = package.Id;
                var persist = await _scheduleService.CreateOrUpdateAsync(write);
                if (!persist.Success || persist.Data == null)
                    return FailDto(persist.Message);

                entity.Id = persist.Data.Id;
                await _notifications.CreateOrUpdateNotificationRecordsAsync([entity]);
                await _notifications.SendNotifyRegisterAsync(entity, EMedicalCalendarActionType.Update);

                var preferred = FindTargetOccurrence(persist.Data.ScheduleData, item.StartDateTime);
                return Ok(MedicalScheduleMapper.ToGetDto(persist.Data, preferred),
                    await Loc(MedicalCalendarKeyConstants.CalendarUpdated, MedicalCalendarMenssageConstants.CalendarUpdated));
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "MedicalScheduleCalendarHost.Update");
                return FailDto(await Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message));
            }
        }

        private static ScheduleCalendarItem? FindTargetOccurrence(ScheduleCalendarItem[]? items, DateTime startDateTime)
        {
            if (items == null || items.Length == 0) return null;
            return items.FirstOrDefault(i => i.StartDateTime == startDateTime)
                ?? items.FirstOrDefault(i => i.StartDateTime.Date == startDateTime.Date);
        }

        public async Task<ServiceResponse<bool>> DeleteOneOrRecurrence(DeleteMedicalCalendarDto request)
        {
            try
            {
                var user = await _userRepository.FindByID(_userId)
                    ?? throw new AppWarningException(await Loc(UserKeyConstants.User_Not_Found, UserMenssageConstants.User_Not_Found));

                if (request.DeleteSeries)
                {
                    var packagesPreview = await _scheduleService.GetByTokenAsync(request.TokenRecurrence);
                    if (packagesPreview.Data != null)
                    {
                        MedicalScheduleKeys.TryParseMedicalId(packagesPreview.Data.OwnerKey, out var seriesMedicalId);
                        if (user.MedicalId != seriesMedicalId || user.MedicalId != request.MedicalId)
                            return FailBool(await Loc(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission));
                    }
                    else if (user.MedicalId != request.MedicalId)
                    {
                        return FailBool(await Loc(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission));
                    }

                    if (packagesPreview.Data != null)
                        await _notifications.DeleteNotificationRecordsAsync(packagesPreview.Data.UniqueToken);

                    var deleted = await _bookingEngine.DeleteByTokenAsync(MedicalScheduleMapper.ToDeleteTokenRequest(request));

                    return deleted.Success
                        ? OkBool(true, await Loc(MedicalCalendarKeyConstants.SchedulesDeletedSuccessfully, MedicalCalendarMenssageConstants.SchedulesDeletedSuccessfully))
                        : FailBool(deleted.Message);
                }

                var package = await _scheduleService.GetByIdAsync(request.Id);
                if (!package.Success || package.Data == null)
                    return FailBool(await Loc(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound));

                MedicalScheduleKeys.TryParseMedicalId(package.Data.OwnerKey, out var medicalId);
                if (user.MedicalId != medicalId || user.MedicalId != request.MedicalId)
                    return FailBool(await Loc(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission));

                await _notifications.DeleteNotificationRecordsAsync(package.Data.UniqueToken);
                var result = await _bookingEngine.DeleteByIdAsync(package.Data.Id);
                return result.Success
                    ? OkBool(true, await Loc(MedicalCalendarKeyConstants.SchedulesDeletedSuccessfully, MedicalCalendarMenssageConstants.SchedulesDeletedSuccessfully))
                    : FailBool(result.Message);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "MedicalScheduleCalendarHost.DeleteOneOrRecurrence");
                return FailBool(await Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message));
            }
        }

        public Task<ServiceResponse<CalendarDto>> GetMonthlyCalendar(CalendarCriteriaDto criteria)
            => BuildGradeAsync(criteria, ScheduleGradeMode.Monthly);

        public Task<ServiceResponse<CalendarDto>> GetAvailableMedicalCalendar(CalendarCriteriaDto criteria)
            => BuildGradeAsync(criteria, ScheduleGradeMode.AvailableOnly);

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
                    criteria.UserIdLogged = _userId;
                    var medical = await _constraintsProvider.GetMedicalAsync(criteria.MedicalId);
                    var booked = await _bookingEngine.BookAsync(MedicalScheduleMapper.ToBookRequest(criteria, medical.PatientIntervalTimeMinutes));
                    return booked.Success
                        ? OkBool(true, await Loc(MedicalCalendarKeyConstants.Schedule_Appointment_Success, MedicalCalendarMenssageConstants.Schedule_Appointment_Success) + $". ({booked.Data?.Id})")
                        : FailBool(booked.Message);
                }

                if (criteria.ScheduleType == EScheduleCalendarType.Cancellation)
                {
                    var canceled = await _bookingEngine.CancelAsync(MedicalScheduleMapper.ToCancelRequest(criteria));
                    if (canceled.Success && canceled.Data != null)
                        await _notifications.DeleteNotificationRecordsAsync(
                            canceled.Data.UniqueToken,
                            criteria.AppointmentDateTime);

                    return canceled.Success
                        ? OkBool(true, await Loc(MedicalCalendarKeyConstants.Cancel_Appointment_Success, MedicalCalendarMenssageConstants.Cancel_Appointment_Success) + $". ({canceled.Data?.PackageId})")
                        : FailBool(canceled.Message ?? await Loc(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound));
                }

                return FailBool(await Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message));
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "MedicalScheduleCalendarHost.RequestAppointment");
                return FailBool(await Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message));
            }
        }

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
                var items = await _scheduleService.GetItemsForOwnerSubjectAsync(
                    MedicalScheduleKeys.TenantKey,
                    MedicalScheduleKeys.ForMedical(criteria.MedicalId),
                    MedicalScheduleKeys.ForPatient(criteria.PatientId),
                    start, end);

                if (items.Data == null || items.Data.Length == 0)
                {
                    return new ServiceResponse<AppointmentDto[]>
                    {
                        Success = false,
                        Message = await Loc(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound)
                    };
                }

                var medical = await _constraintsProvider.GetMedicalAsync(criteria.MedicalId);
                return new ServiceResponse<AppointmentDto[]>
                {
                    Success = true,
                    Data = MedicalScheduleMapper.ToAppointmentDtos(items.Data, criteria.MedicalId, medical.Name),
                    Message = await Loc(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound)
                };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "MedicalScheduleCalendarHost.GetAppointments");
                return new ServiceResponse<AppointmentDto[]>
                {
                    Success = false,
                    Message = await Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message)
                };
            }
        }

        private async Task<ServiceResponse<CalendarDto>> BuildGradeAsync(CalendarCriteriaDto criteria, ScheduleGradeMode mode)
        {
            var response = new ServiceResponse<CalendarDto>();
            try
            {
                criteria.UserIdLogged = _userId;
                if (mode == ScheduleGradeMode.Monthly && !await ValidateCriteriaAsync(criteria, response))
                    return response;

                var medical = await _constraintsProvider.GetMedicalAsync(criteria.MedicalId);
                var user = await _userRepository.FindByID(_userId)
                    ?? throw new AppWarningException(await Loc(UserKeyConstants.User_Not_Found, UserMenssageConstants.User_Not_Found));

                var constraints = MedicalScheduleConstraintsProvider.ToConstraints(medical);
                criteria.IntervalInMinutes = constraints.IntervalMinutes;
                if (mode == ScheduleGradeMode.Monthly && !await ValidateCriteriaAsync(criteria, response))
                    return response;

                // Ownership already enforced by CalendarCriteriaValidator (user.MedicalId == criteria.MedicalId).
                // Do not run MedicalCalendarListValidator on SoT item projections (no CreatedUserId).
                if (user.MedicalId != criteria.MedicalId)
                {
                    response.Success = false;
                    response.Data = new CalendarDto { MedicalId = medical.Id, MedicalName = medical.Name, Days = [] };
                    response.Message = await Loc(MedicalCalendarKeyConstants.Calendar_Error, MedicalCalendarMenssageConstants.Calendar_Error);
                    return response;
                }

                var gradeRequest = MedicalScheduleMapper.ToGradeRequest(criteria, constraints, user.TimeZone ?? string.Empty, mode);
                var items = await _scheduleService.GetItemsForOwnerAsync(
                    gradeRequest.TenantKey, gradeRequest.OwnerKey, gradeRequest.StartDate, gradeRequest.EndDate);
                var preloaded = items.Data ?? [];

                gradeRequest = MedicalScheduleMapper.ToGradeRequest(criteria, constraints, user.TimeZone ?? string.Empty, mode, preloaded);
                var grade = await _gradeEngine.BuildGradeAsync(gradeRequest);
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
                response.Message = await Loc(MedicalCalendarKeyConstants.CalendarSuccess, MedicalCalendarMenssageConstants.CalendarSuccess);
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "MedicalScheduleCalendarHost.BuildGradeAsync");
                response.Success = false;
                response.Message = await Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message);
                return response;
            }
        }

        private MedicalCalendar MapNewEntity(AddMedicalCalendarDto item)
        {
            var entity = _mapper.Map<MedicalCalendar>(item);
            entity.Enable = true;
            entity.CreatedUserId = _userId;
            entity.PatientId = item.PatientId;
            entity.MedicalId = item.MedicalId;
            entity.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
            entity.ModifyDate = entity.CreatedDate;
            entity.LastAccessDate = entity.CreatedDate;
            if (string.IsNullOrWhiteSpace(entity.TokenRecurrence))
                entity.TokenRecurrence = Guid.NewGuid().ToString();
            return entity;
        }

        private async Task<ServiceResponse<GetMedicalCalendarDto>> ValidateEntityAsync(MedicalCalendar entity)
        {
            var response = new ServiceResponse<GetMedicalCalendarDto>();
            var validationResult = await _validators.EntityValidator.ValidateAsync(entity);
            response.Success = validationResult.IsValid;
            response.Errors = HelperValidation.GetErrorsMap(validationResult).ToList();
            if (response.Errors.Count > 0)
            {
                response.Errors = await TranslateErrors(response.Errors);
                response.Message = await Loc(ValidatorConstants.ValidateErroMessageKey, ValidatorConstants.ValidateErroMessage_Message);
            }
            return response;
        }

        private async Task<bool> ValidateCriteriaAsync(CalendarCriteriaDto criteria, ServiceResponse<CalendarDto> response)
        {
            var result = await new CalendarCriteriaValidator(_userRepository).ValidateAsync(criteria);
            if (result.IsValid) return true;
            response.Success = false;
            response.Data = new CalendarDto();
            response.Message = await Loc(MedicalCalendarKeyConstants.Calendar_Error, MedicalCalendarMenssageConstants.Calendar_Error);
            response.Errors = await TranslateErrors(HelperValidation.ConvertValidationFailureListToErroResponse(result.Errors));
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
                    var patient = await _patientRepository.FindByID(patientId);
                    if (patient != null && !string.IsNullOrWhiteSpace(patient.Name))
                        names[patientId] = patient.Name;
                }
                catch (Exception ex)
                {
                    _logger.Warning(ex, "Failed to resolve patient name for PatientId={PatientId}", patientId);
                }
            }
            return names;
        }

        private async Task<string> Loc(string key, string fallback)
            => await _languageService.GetLocalization<ISharedResource>(key, fallback, _cacheService);

        private async Task<List<Domain.VO.ErrorResponse>> TranslateErrors(List<Domain.VO.ErrorResponse> errors)
        {
            var translated = new List<Domain.VO.ErrorResponse>();
            foreach (var item in errors)
            {
                var add = new Domain.VO.ErrorResponse
                {
                    Name = item.Name,
                    ErrorCode = item.ErrorCode,
                    Message = await Loc(item.ErrorCode, item.DefaultMessage),
                    DefaultMessage = item.DefaultMessage,
                    FullMessage = item.FullMessage
                };
                translated.Add(HelperValidation.TranslateErroCode(add));
            }
            return translated;
        }

        private static ServiceResponse<GetMedicalCalendarDto> Ok(GetMedicalCalendarDto data, string message)
            => new() { Success = true, Data = data, Message = message };

        private static ServiceResponse<GetMedicalCalendarDto> FailDto(string? message)
            => new() { Success = false, Message = message };

        private static ServiceResponse<bool> OkBool(bool data, string message)
            => new() { Success = true, Data = data, Message = message };

        private static ServiceResponse<bool> FailBool(string? message)
            => new() { Success = false, Message = message };
    }
}
