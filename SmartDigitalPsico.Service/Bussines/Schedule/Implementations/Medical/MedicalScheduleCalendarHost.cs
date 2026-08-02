using AutoMapper;
using FluentValidation.Results;
using Serilog;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.Contracts;
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
                await _notifications.SendNotifyRegisterAsync(entity);

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
                var entity = _mapper.Map<MedicalCalendar>(item);
                entity.CreatedUserId = _userId;
                entity.ModifyUserId = _userId;
                entity.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                entity.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();
                if (string.IsNullOrWhiteSpace(entity.TokenRecurrence))
                    entity.TokenRecurrence = Guid.NewGuid().ToString();

                var validation = await ValidateEntityAsync(entity);
                if (!validation.Success) return validation;

                var write = MedicalScheduleMapper.ToWriteRequest(entity, isUpdate: true, updateSeries: item.UpdateSeries);
                var persist = await _scheduleService.CreateOrUpdateAsync(write);
                if (!persist.Success || persist.Data == null)
                    return FailDto(persist.Message);

                entity.Id = persist.Data.Id;
                await _notifications.CreateOrUpdateNotificationRecordsAsync([entity]);
                await _notifications.SendNotifyRegisterAsync(entity);

                return Ok(MedicalScheduleMapper.ToGetDto(persist.Data),
                    await Loc(MedicalCalendarKeyConstants.CalendarUpdated, MedicalCalendarMenssageConstants.CalendarUpdated));
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "MedicalScheduleCalendarHost.Update");
                return FailDto(await Loc(ValidatorConstants.GenericErroMessageKey, ValidatorConstants.Generic_Erro_Message));
            }
        }

        public async Task<ServiceResponse<bool>> DeleteOneOrRecurrence(DeleteMedicalCalendarDto request)
        {
            try
            {
                if (request.DeleteSeries)
                {
                    var packagesPreview = await _scheduleService.GetByTokenAsync(request.TokenRecurrence);
                    var readModels = packagesPreview.Data == null
                        ? []
                        : MedicalScheduleMapper.ToMedicalCalendarReadModels(
                            packagesPreview.Data.ScheduleData ?? [], request.MedicalId, request.PatientId);

                    if (!await EnsureListPermissionAsync(readModels))
                        return FailBool(await Loc(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission));

                    var deleted = await _bookingEngine.DeleteByTokenAsync(MedicalScheduleMapper.ToDeleteTokenRequest(request));
                    if (deleted.Success && packagesPreview.Data != null)
                        await _notifications.DeleteNotificationRecordsAsync(packagesPreview.Data.Id);

                    return deleted.Success
                        ? OkBool(true, await Loc(MedicalCalendarKeyConstants.SchedulesDeletedSuccessfully, MedicalCalendarMenssageConstants.SchedulesDeletedSuccessfully))
                        : FailBool(deleted.Message);
                }

                var package = await _scheduleService.GetByIdAsync(request.Id);
                if (!package.Success || package.Data == null)
                    return FailBool(await Loc(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound));

                ScheduleKeyHelper.TryParseMedicalId(package.Data.OwnerKey, out var medicalId);
                long? patientId = null;
                if (!string.IsNullOrWhiteSpace(package.Data.SubjectKey) && ScheduleKeyHelper.TryParsePatientId(package.Data.SubjectKey, out var pid))
                    patientId = pid;

                var one = MedicalScheduleMapper.ToMedicalCalendarReadModel(
                    package.Data.ScheduleData?.FirstOrDefault() ?? new Domain.ModelEntity.Schedule.ScheduleCalendarItem(),
                    medicalId, patientId);
                one.Id = package.Data.Id;

                if (!await EnsureListPermissionAsync([one]))
                    return FailBool(await Loc(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission));

                await _notifications.DeleteNotificationRecordsAsync(package.Data.Id);
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
                        await _notifications.DeleteNotificationRecordsAsync(canceled.Data.PackageId);

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
                    ScheduleKeyHelper.DefaultTenant,
                    ScheduleKeyHelper.ForMedical(criteria.MedicalId),
                    ScheduleKeyHelper.ForPatient(criteria.PatientId),
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

                var gradeRequest = MedicalScheduleMapper.ToGradeRequest(criteria, constraints, user.TimeZone ?? string.Empty, mode);
                var items = await _scheduleService.GetItemsForOwnerAsync(
                    gradeRequest.TenantKey, gradeRequest.OwnerKey, gradeRequest.StartDate, gradeRequest.EndDate);
                var preloaded = items.Data ?? [];

                if (mode == ScheduleGradeMode.Monthly)
                {
                    var readModels = MedicalScheduleMapper.ToMedicalCalendarReadModels(preloaded, criteria.MedicalId);
                    if (!await EnsureListPermissionAsync(readModels))
                    {
                        response.Success = false;
                        response.Data = new CalendarDto { MedicalId = medical.Id, MedicalName = medical.Name, Days = [] };
                        response.Message = await Loc(MedicalCalendarKeyConstants.Calendar_Error, MedicalCalendarMenssageConstants.Calendar_Error);
                        return response;
                    }
                }

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
                response.Data = MedicalScheduleMapper.ToCalendarDto(grade.Data, medical.Id);
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

        private async Task<bool> EnsureListPermissionAsync(IEnumerable<MedicalCalendar> calendars)
        {
            var list = new RecordsList<MedicalCalendar> { UserIdLogged = _userId, Records = calendars.ToList() };
            var result = await _validators.MedicalCalendarListValidator.ValidateAsync(list);
            return result.IsValid;
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
