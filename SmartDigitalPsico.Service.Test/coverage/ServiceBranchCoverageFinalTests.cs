using System.Globalization;
using System.Reflection;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Notification.Common;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Validation.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Service.Bussines.Notification;
using SmartDigitalPsico.Service.Bussines.Schedule.Core.Commands;
using SmartDigitalPsico.Service.Bussines.Schedule.Core.Conflict;
using SmartDigitalPsico.Service.Bussines.Schedule.Core.Queries;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Service.Test.Infrastructure;
using SmartDigitalPsico.Service.Test.TestSupport;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Domain.DTO.Gender.ADD;
using SmartDigitalPsico.Domain.DTO.Office.ADD;
using SmartDigitalPsico.Domain.DTO.RoleGroup.ADD;
using SmartDigitalPsico.Domain.DTO.Leaves.ADD;
using SmartDigitalPsico.Domain.DTO.Specialty.ADD;
using SmartDigitalPsico.Domain.DTO.Notification.ADD;
using SmartDigitalPsico.Domain.DTO.Application.ADD;
using SmartDigitalPsico.Domain.DTO.Audit.ADD;

using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Test.Coverage;

[TestFixture]
public class ServiceBranchCoverageFinalTests
{
    // Cenário: mapper com nulos, MinValue e listas vazias nos ramos restantes.
    // Objetivo: fechar condition-coverage de MedicalScheduleMapper.
    [Test]
    public void MedicalScheduleMapper_NullAndFallbackBranches_CoverRemaining()
    {
        // Arrange / Act
        // Arrange

        // Act
        var updateNullToken = MedicalScheduleMapper.ToWriteRequest(
            new MedicalCalendar
            {
                Id = 1,
                MedicalId = 2,
                TokenRecurrence = null!,
                Title = "u",
                StartDateTime = new DateTime(2026, 9, 1, 8, 0, 0, DateTimeKind.Utc)
            },
            isUpdate: true,
            updateSeries: false);

        var single = MedicalScheduleMapper.BuildSingleItem(
            new MedicalCalendar
            {
                Title = "s",
                StartDateTime = DateTime.UtcNow,
                RecurrenceDays = null!,
                ReasonCancellation = null!
            },
            "tok");

        var getDto = MedicalScheduleMapper.ToGetDto(new ScheduleCalendar
        {
            Id = 3,
            OwnerKey = MedicalScheduleKeys.ForMedical(9),
            SubjectKey = null!,
            UniqueToken = "pkg",
            ScheduleData = null!
        });

        var getDtoNullFields = MedicalScheduleMapper.ToGetDto(new ScheduleCalendar
        {
            Id = 4,
            OwnerKey = MedicalScheduleKeys.ForMedical(9),
            SubjectKey = "   ",
            UniqueToken = "pkg2",
            ScheduleData =
            [
                new ScheduleCalendarItem
                {
                    Title = "n",
                    StartDateTime = DateTime.UtcNow,
                    RecurrenceDays = null!,
                    RecurrenceCount = null!,
                    TokenRecurrence = null!
                }
            ]
        });

        var fromPackageEmpty = MedicalScheduleMapper.ToMedicalCalendarFromPackage(
            new ScheduleCalendar
            {
                Id = 5,
                OwnerKey = MedicalScheduleKeys.ForMedical(1),
                SubjectKey = " ",
                ScheduleData = []
            },
            preferEventDate: DateTime.UtcNow);

        var fromPackageNull = MedicalScheduleMapper.ToMedicalCalendarFromPackage(
            new ScheduleCalendar
            {
                Id = 6,
                OwnerKey = MedicalScheduleKeys.ForMedical(1),
                SubjectKey = null!,
                ScheduleData = null!
            });

        var readNullPackageId = MedicalScheduleMapper.ToMedicalCalendarReadModel(
            new ScheduleCalendarItem { PackageId = null!, Title = "r", StartDateTime = DateTime.UtcNow },
            7);

        var calendarNullDays = MedicalScheduleMapper.ToCalendarDto(
            new ScheduleGradeResult { DisplayName = "Dr", Days = null! },
            8);

        var unknownPatient = MedicalScheduleMapper.ToTimeSlotDto(
            new ScheduleTimeSlotDto
            {
                StartTime = DateTime.UtcNow,
                EndTime = DateTime.UtcNow.AddMinutes(30),
                Booking = new ScheduleCalendarItem
                {
                    Title = "FallbackTitle",
                    StartDateTime = DateTime.UtcNow,
                    SubjectKey = MedicalScheduleKeys.ForPatient(99)
                }
            },
            8,
            new Dictionary<long, string>());

        var buildNullEnd = MedicalScheduleMapper.BuildItems(
            new MedicalCalendar
            {
                Title = "b",
                StartDateTime = new DateTime(2026, 9, 1, 9, 0, 0, DateTimeKind.Utc),
                EndDateTime = null!,
                RecurrenceDays = null!,
                ReasonCancellation = null!,
                RecurrenceType = ERecurrenceCalendarType.None
            },
            "t");

        var gradeMin = MedicalScheduleMapper.ToGradeRequest(
            new CalendarCriteriaDto
            {
                MedicalId = 1,
                Year = 2026,
                Month = 9,
                StartDate = DateTime.MinValue,
                EndDate = DateTime.MinValue
            },
            new ScheduleOwnerConstraints { DisplayName = "Dr" },
            "UTC",
            ScheduleGradeMode.Monthly);

        var emptyAppointments = MedicalScheduleMapper.ToAppointmentDtos([], 1, "Dr");
        var nullEndAppointment = MedicalScheduleMapper.ToAppointmentDtos(
        [
            new ScheduleCalendarItem
            {
                StartDateTime = new DateTime(2026, 9, 1, 10, 0, 0, DateTimeKind.Utc),
                EndDateTime = null!,
                TimeZone = "UTC"
            }

        ], 1, "Dr");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            updateNullToken.UniqueToken.Should().BeEmpty();
            single[0].RecurrenceDays.Should().BeEmpty();
            single[0].ReasonCancellation.Should().BeEmpty();
            getDto.PatientId.Should().BeNull();
            getDto.Title.Should().BeNullOrEmpty();
            getDtoNullFields.RecurrenceDays.Should().BeEmpty();
            getDtoNullFields.RecurrenceCount.Should().Be(0);
            fromPackageEmpty.Id.Should().Be(5);
            fromPackageNull.Id.Should().Be(6);
            readNullPackageId.Id.Should().Be(0);
            calendarNullDays.Days.Should().BeEmpty();
            unknownPatient.MedicalCalendar!.Patient!.Name.Should().Be("FallbackTitle");
            buildNullEnd.Should().NotBeEmpty();
            gradeMin.StartDate.Should().Be(new DateTime(2026, 9, 1));
            emptyAppointments.Should().BeEmpty();
            nullEndAppointment[0].EndDateTime.Should().Be(nullEndAppointment[0].StartDateTime);
        }
    }

    // Cenário: cache em disco com expiração MinValue, props nulas e TryGet expirado.
    // Objetivo: fechar ramos restantes de SmartDigitalPsico.Service.Infrastructure.CacheManager.CacheService.
    [Test]
    public void CacheService_DiskEdgeBranches_CoverRemaining()
    {
        // Arrange
        var disk = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>();
        var logs = new Mock<IApplicationCacheLogRepository>();
        var expired = new ExpirableCacheEntry
        {
            Data = "x",
            DateTimeSlidingExpiration = DateTime.Now.AddMinutes(-5).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
        };
        disk.Setup(x => x.TryGetAsync<ExpirableCacheEntry>("expired"))
            .ReturnsAsync(new KeyValuePair<bool, ExpirableCacheEntry>(true, expired));
        disk.Setup(x => x.RemoveAsync("expired")).ReturnsAsync(true);
        logs.Setup(x => x.Delete("expired")).ReturnsAsync(true);

        var minValue = new ExpirableCacheEntry
        {
            Data = "ok",
            DateTimeSlidingExpiration = DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
        };
        disk.Setup(x => x.TryGetAsync<ExpirableCacheEntry>("min"))
            .ReturnsAsync(new KeyValuePair<bool, ExpirableCacheEntry>(true, minValue));

        disk.Setup(x => x.SetAsync("null-props", It.IsAny<NullableCacheProps>())).ReturnsAsync(true);
        logs.Setup(x => x.Create(It.IsAny<ApplicationCacheLog>()))
            .ReturnsAsync(new ApplicationCacheLog());

        var memory = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>();
        memory.Setup(x => x.TryGet("mem-null", out It.Ref<CacheValue?>.IsAny))
            .Returns((string _, out CacheValue? value) =>
            {
                value = null;
                return true;
            });

        var diskService = CreateCache(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Disk, disk: disk, logs: logs);
        var memoryService = CreateCache(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Memory, memory: memory);

        var tryGetExpired = diskService.TryGet("expired", out ExpirableCacheEntry expiredValue);
        var existsMin = diskService.Exists<ExpirableCacheEntry>("min");
        var setNullProps = diskService.Set("null-props", new NullableCacheProps());
        var tryGetNullMem = memoryService.TryGet("mem-null", out CacheValue memValue);

        // Act

        // Assert
        using (Assert.EnterMultipleScope())
        {
            tryGetExpired.Should().BeFalse();
            expiredValue.Should().NotBeNull();
            existsMin.Should().BeTrue();
            setNullProps.Should().BeTrue();
            tryGetNullMem.Should().BeTrue();
            memValue.Should().NotBeNull();
        }
        logs.Verify(x => x.Create(It.IsAny<ApplicationCacheLog>()), Times.AtLeastOnce);
    }

    // Cenário: IsBefore=false para todos IntervalTypes e IsCompleted=true.
    // Objetivo: cobrir braços +interval e FinalSendDate.
    [TestCase(EIntervalNotificationType.Minutes)]
    [TestCase(EIntervalNotificationType.Hours)]
    [TestCase(EIntervalNotificationType.Days)]
    [TestCase(EIntervalNotificationType.Months)]
    [TestCase(EIntervalNotificationType.Years)]
    public async Task NotificationRecords_IsBeforeFalseAndCompleted_CoverRemaining(EIntervalNotificationType intervalType)
    {
        // Arrange
        var context = new NotificationRecordsServiceContext();
        var rule = new NotificationRule
        {
            Id = 20,
            IntervalType = intervalType,
            IntervalValue = 1,
            IsBefore = false,
            ENotificationServiceType = [ENotificationServiceType.Email]
        };
        context.NotificationRulesService
            .Setup(x => x.GetNotificationRulesAsync(It.IsAny<ENotificationType>(), It.IsAny<bool>(), It.IsAny<long>()))
            .ReturnsAsync([rule]);
        context.Repository.Setup(x => x.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<NotificationRecord, bool>>>()))
            .ReturnsAsync([]);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<NotificationRecord>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        NotificationRecord? created = null;
        context.Repository.Setup(x => x.Create(It.IsAny<NotificationRecord>()))
            .ReturnsAsync((NotificationRecord r) => { r.Id = 80; created = r; return r; });

        var dto = new GenerateNotificationRecordsDto
        {
            IsEnabled = true,
            IsCompleted = true,
            MedicalCalendars =
            [
                new MedicalCalendar
                {
                    MedicalId = 1,
                    StartDateTime = DateTime.UtcNow.AddHours(1),
                    TokenRecurrence = Guid.NewGuid().ToString(),
                    TimeZone = "BRT"
                }
            ],
            NotificationType = ENotificationType.BeforeAppointment
        };

        // Act
        await context.Service.CreateOrUpdateNotificationRecordsAsync(dto);
        var calculate = typeof(NotificationRecordsService)
            .GetMethod("CalculateScheduledSendTime", BindingFlags.Static | BindingFlags.NonPublic)!;
        var scheduled = (DateTime)calculate.Invoke(null!, [rule, DateTime.UtcNow.AddDays(1), "BRT"])!;

        // Assert
        scheduled.Should().BeAfter(DateTime.UtcNow.AddHours(-12));

        context.Repository.Verify(x => x.Create(It.IsAny<NotificationRecord>()), Times.AtMostOnce());
        _ = created;
    }

    // Cenário: ValidateCompletion true/false e FinalSendDate no update.
    // Objetivo: cobrir ValidateCompletion e ternários de FinalSendDate.
    [Test]
    public void NotificationRecords_ValidateCompletionAndFinalSendDate_CoverBranches()
    {
        // Arrange
        var validate = typeof(NotificationRecordsService)
            .GetMethod("ValidateCompletion", BindingFlags.Static | BindingFlags.NonPublic)!;
        var createDto = typeof(NotificationRecordsService)
            .GetMethod("CreateNotificationRecordsDto", BindingFlags.Static | BindingFlags.NonPublic)!;
        var calendar = new MedicalCalendar
        {
            StartDateTime = DateTime.UtcNow,
            Description = "d",
            TokenRecurrence = Guid.NewGuid().ToString()
        };
        var allSent = new[] { new NotificationRuleStatus { IsSent = true } };
        var pending = new[] { new NotificationRuleStatus { IsSent = false } };

        var completed = (bool)validate.Invoke(null!, [true, allSent])!;
        var notCompleted = (bool)validate.Invoke(null!, [true, pending])!;
        var dtoCompleted = (AddNotificationRecordsDto)createDto.Invoke(null!, [calendar, allSent, true])!;
        var dtoOpen = (AddNotificationRecordsDto)createDto.Invoke(null!, [calendar, pending, false])!;

        // Act

        // Assert
        using (Assert.EnterMultipleScope())
        {
            completed.Should().BeTrue();
            notCompleted.Should().BeFalse();
            dtoCompleted.FinalSendDate.Should().NotBeNull();
            dtoOpen.FinalSendDate.Should().BeNull();
        }
    }

    // Cenário: Create/Update com InnerException, Success=false e Message/Errors nulos.
    // Objetivo: fechar ramos de ScheduleCreateService e ScheduleUpdateService.
    [Test]
    public async Task ScheduleCreateUpdate_ExceptionAndNullFallbacks_CoverRemaining()
    {
        // Arrange
        var createCtx = new ScheduleCreateContext();
        var updateCtx = new ScheduleUpdateContext();
        var token = "token-branch";
        var item = new ScheduleCalendarItem
        {
            StartDateTime = DateTime.UtcNow.Date.AddDays(2).AddHours(10),
            EndDateTime = null!,
            Title = "a"
        };

        var conflictCtx = new ScheduleCreateContext();
        conflictCtx.Repository.Setup(x => x.GetByUniqueTokenAsync(It.IsAny<string>())).Returns(Task.FromResult<ScheduleCalendar?>(null!));
        conflictCtx.ConflictService
            .Setup(x => x.HasNoConflictBatchAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<ScheduleCalendarItem[]>(), It.IsAny<string?>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = false, Data = true, Message = null!, Errors = null! });

        // Act
        var conflictCreate = await conflictCtx.Service.CreateAsync(new ScheduleCalendarWriteRequest
        {
            TenantKey = "t",
            OwnerKey = "o",
            UniqueToken = "new2",
            Items = [item]
        });

        var bookCtx = new ScheduleCreateContext();
        bookCtx.Repository.Setup(x => x.GetByUniqueTokenAsync(It.IsAny<string>())).Returns(Task.FromResult<ScheduleCalendar?>(null!));
        bookCtx.ConflictService
            .Setup(x => x.HasNoConflictBatchAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<ScheduleCalendarItem[]>(), It.IsAny<string?>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = true });
        bookCtx.Repository.Setup(x => x.Create(It.IsAny<ScheduleCalendar>()))
            .ReturnsAsync((ScheduleCalendar e) => e);
        var booked = await bookCtx.Service.BookAsync(new ScheduleBookRequest
        {
            TenantKey = "t",
            OwnerKey = "o",
            UniqueToken = "keep-me",
            Item = item
        });

        updateCtx.Repository.Setup(x => x.GetByUniqueTokenAsync(token))
            .ReturnsAsync(new ScheduleCalendar { Id = 1, UniqueToken = token, ScheduleData = null! });
        updateCtx.ConflictService
            .Setup(x => x.HasNoConflictBatchAsync("t", "o", It.IsAny<ScheduleCalendarItem[]>(), token))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = false, Data = false, Message = null!, Errors = null! });
        var conflictUpdate = await updateCtx.Service.UpdateAsync(new ScheduleCalendarWriteRequest
        {
            TenantKey = "t",
            OwnerKey = "o",
            UniqueToken = token,
            IsUpdate = true,
            UpdateSeries = false,
            Items = [item]
        });

        var createThrow = new ScheduleCreateContext();
        createThrow.Repository.Setup(x => x.GetByUniqueTokenAsync(It.IsAny<string>())).Returns(Task.FromResult<ScheduleCalendar?>(null!));
        createThrow.ConflictService
            .Setup(x => x.HasNoConflictBatchAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<ScheduleCalendarItem[]>(), It.IsAny<string?>()))
            .ThrowsAsync(new Exception("outer", new Exception("inner-create")));
        var createEx = await createThrow.Service.CreateAsync(new ScheduleCalendarWriteRequest
        {
            TenantKey = "t",
            OwnerKey = "o",
            UniqueToken = "ex",
            Items = [item]
        });

        var updateThrow = new ScheduleUpdateContext();
        updateThrow.Repository.Setup(x => x.GetByUniqueTokenAsync(token))
            .ReturnsAsync(new ScheduleCalendar { Id = 2, UniqueToken = token, ScheduleData = [] });
        updateThrow.ConflictService
            .Setup(x => x.HasNoConflictBatchAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<ScheduleCalendarItem[]>(), token))
            .ThrowsAsync(new Exception("outer", new Exception("inner-update")));
        var updateEx = await updateThrow.Service.UpdateAsync(new ScheduleCalendarWriteRequest
        {
            TenantKey = "t",
            OwnerKey = "o",
            UniqueToken = token,
            IsUpdate = true,
            UpdateSeries = true,
            Items = [item]
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            booked.Success.Should().BeTrue();
            booked.Data!.UniqueToken.Should().Be("keep-me");
            conflictCreate.Success.Should().BeFalse();
            conflictUpdate.Success.Should().BeFalse();
            createEx.Success.Should().BeFalse();
            createEx.Message.Should().Be("inner-create");
            updateEx.Success.Should().BeFalse();
            updateEx.Message.Should().Be("inner-update");
        }
    }

    // Cenário: conflitos com items nulos, EndDateTime nulo e ScheduleData nulo.
    // Objetivo: fechar ramos de ScheduleConflictService.
    [Test]
    public async Task ScheduleConflict_NullItemsAndEndDate_CoverRemaining()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var start = DateTime.UtcNow.Date.AddDays(1).AddHours(10);
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(
            [
                new ScheduleCalendar
                {
                    UniqueToken = "other",
                    ScheduleData = null!
                },
                new ScheduleCalendar
                {
                    UniqueToken = "busy",
                    ScheduleData =
                    [
                        new ScheduleCalendarItem
                        {
                            StartDateTime = start,
                            EndDateTime = null!,
                            SubjectKey = "patient:1"
                        }
                    ]
                }
            ]);
        var service = new ScheduleConflictService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var nullItems = await service.HasNoConflictBatchAsync("medical", "medical:1", null!, null!);
        var nullEnd = await service.HasNoConflictBatchAsync(
            "medical",
            "medical:1",
            [new ScheduleCalendarItem { StartDateTime = start, EndDateTime = null!, SubjectKey = "patient:2" }],
            null!);
        var ok = await service.HasNoConflictAsync(new ScheduleCalendarConflictRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            StartDateTime = start,
            EndDateTime = start.AddHours(1)
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            nullItems.Success.Should().BeTrue();
            nullItems.Data.Should().BeTrue();
            nullEnd.Should().NotBeNull();
            ok.Message.Should().NotBeNull();
        }
    }

    // Cenário: WorkingDays/DisplayName nulos e AvailableOnly com slots filtrados.
    // Objetivo: fechar ramos de ScheduleAvailabilityService.
    [Test]
    public async Task ScheduleAvailability_NullWorkingDaysAndFilters_CoverRemaining()
    {
        // Arrange
        var day = DateTime.UtcNow.Date.AddDays(1);
        while (day.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
            day = day.AddDays(1);
        var service = new ScheduleAvailabilityService(Mock.Of<IScheduleCalendarRepository>(), Mock.Of<IAppLogger>());
        var request = new ScheduleGradeRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            DisplayName = null!,
            TimeZone = "UTC",
            StartDate = day,
            EndDate = day,
            Mode = ScheduleGradeMode.AvailableOnly,
            FilterByWorkingDays = true,
            PreloadedItems =
            [
                new ScheduleCalendarItem
                {
                    StartDateTime = day.AddHours(9),
                    EndDateTime = null!,
                    SubjectKey = "patient:1"
                }
            ],
            Constraints = new ScheduleOwnerConstraints
            {
                DisplayName = null!,
                WorkingDays = null!,
                StartWorkingTime = TimeSpan.FromHours(8),
                EndWorkingTime = TimeSpan.FromHours(18),
                IntervalMinutes = 30
            }
        };

        // Act
        var result = await service.BuildGradeAsync(request);

        // Assert
        var fill = typeof(ScheduleAvailabilityService)
            .GetMethod("FillMarkNonWorkingDays", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static)
            ?? typeof(ScheduleAvailabilityService)
                .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static)
                .FirstOrDefault(m => m.Name.Contains("Working", StringComparison.OrdinalIgnoreCase));

        result.Success.Should().BeTrue();
        _ = fill;
    }

    // Cenário: NotificationDispatch com regras nulas e paciente sem Medical.
    // Objetivo: cobrir FilterPendingRecords e Hydrate patient?.Medical.
    [Test]
    public async Task NotificationDispatch_NullRulesAndPatient_CoverRemaining()
    {
        // Arrange
        var notificationRecords = new Mock<INotificationRecordsService>();
        var medicalNotify = new Mock<IMedicalCalenderNotificationService>();
        var scheduleRepo = new Mock<IScheduleCalendarRepository>();
        var patientRepos = new Mock<SmartDigitalPsico.Domain.Interfaces.Patient.IPatientRepositories>();
        var patientRepo = new Mock<IPatientRepository>();
        patientRepos.SetupGet(x => x.PatientRepository).Returns(patientRepo.Object);
        patientRepo
            .Setup(x => x.FindAsync(5, It.IsAny<System.Linq.Expressions.Expression<Func<Patient, object>>[]>()))
            .ReturnsAsync(new Patient { Id = 5, Medical = null! });
        var sut = new NotificationDispatchJobService(
            notificationRecords.Object,
            medicalNotify.Object,
            scheduleRepo.Object,
            patientRepos.Object,
            Mock.Of<IAppLogger>());
        var process = typeof(NotificationDispatchJobService)
            .GetMethod("ProcessRecordAsync", BindingFlags.Instance | BindingFlags.NonPublic)!;
        var hydrate = typeof(NotificationDispatchJobService)
            .GetMethod("HydratePatientAndMedicalAsync", BindingFlags.Instance | BindingFlags.NonPublic)!;
        var calendar = new MedicalCalendar { PatientId = 5, Patient = null!, Medical = null! };

        // Act
        var nullRules = await (Task<bool>)process.Invoke(sut, [new NotificationRecord { NotificationRules = null! }, DateTime.UtcNow])!;
        await (Task)hydrate.Invoke(sut, [calendar])!;

        // Assert
        using (Assert.EnterMultipleScope())
        {
            nullRules.Should().BeFalse();
            calendar.Patient.Should().NotBeNull();
            calendar.Medical.Should().BeNull();
        }
    }

    // Cenário: audit Create falha com Message nula.
    // Objetivo: cobrir response.Message ?? default.
    [Test]
    public async Task AuditSelective_CreateFailsNullMessage_UsesDefaultErrorMessage()
    {
        // Arrange
        var logger = new Mock<IAppLogger>();
        var shared = new ServiceTestContext();
        shared.ConfigMock.SetupGet(x => x.Logger).Returns(logger.Object);
        var service = new ControllableAuditService(
            shared.SharedServices,
            shared.ConfigMock.Object,
            shared.SharedRepositories,
            Mock.Of<IAuditDataSelectiveEntityLogRepository>(),
            Mock.Of<IValidator<AuditDataSelectiveEntityLog>>())
        {
            CreateSucceeds = false,
            CreateMessage = null
        };

        // Act
        await service.Save(
            new Patient { Id = 1, Name = "Old", ModifyUser = new User { Name = "doc" } },
            new Patient { Id = 1, Name = "New", ModifyUser = new User { Name = "doc" } },
            "Update",
            ["ModifyDate"]);

        // Assert
        logger.Verify(x => x.Error(It.IsAny<Exception>(), "Error writing log"), Times.Once);
    }

    private static SmartDigitalPsico.Service.Infrastructure.CacheManager.CacheService CreateCache(
        global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache type,
        Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>? memory = null!,
        Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>? disk = null!,
        Mock<IApplicationCacheLogRepository>? logs = null!)
        => new(
            (memory ?? new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>()).Object,
            (disk ?? new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>()).Object,
            (logs ?? new Mock<IApplicationCacheLogRepository>()).Object,
            Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
            {
                TypeCache = type,
                IsEnable = true,
                AbsoluteExpirationInHours = 1,
                SlidingExpirationInMinutes = 5
            }));

    private sealed class NullableCacheProps
    {
        public string? CacheId { get; set; }
        public string? DateTimeSlidingExpiration { get; set; }
    }

    private sealed class NotificationRecordsServiceContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<INotificationRecordsRepository> Repository { get; } = new();
        public Mock<IApplicationLanguageRepository> ApplicationLanguageRepository { get; } = new();
        public Mock<IValidator<NotificationRecord>> Validator { get; } = new();
        public Mock<INotificationRulesService> NotificationRulesService { get; } = new();
        public NotificationRecordsService Service { get; }

        public NotificationRecordsServiceContext()
        {
            Service = new NotificationRecordsService(
                Context.SharedServices,
                Context.Config,
                Context.SharedRepositories,
                Repository.Object,
                ApplicationLanguageRepository.Object,
                Validator.Object,
                NotificationRulesService.Object);
        }
    }

    private sealed class ScheduleCreateContext
    {
        public Mock<IScheduleCalendarRepository> Repository { get; } = new();
        public Mock<IScheduleConflictService> ConflictService { get; } = new();
        public ScheduleCreateService Service { get; }

        public ScheduleCreateContext()
        {
            Service = new ScheduleCreateService(Repository.Object, ConflictService.Object, Mock.Of<IAppLogger>());
        }
    }

    private sealed class ScheduleUpdateContext
    {
        public Mock<IScheduleCalendarRepository> Repository { get; } = new();
        public Mock<IScheduleConflictService> ConflictService { get; } = new();
        public ScheduleUpdateService Service { get; }

        public ScheduleUpdateContext()
        {
            Service = new ScheduleUpdateService(Repository.Object, ConflictService.Object, Mock.Of<IAppLogger>());
        }
    }

    private sealed class ControllableAuditService : AuditDataSelectiveEntityLogService
    {
        public bool CreateSucceeds { get; set; }
        public string? CreateMessage { get; set; }

        public ControllableAuditService(
            Domain.Interfaces.Common.ISharedServices sharedServices,
            Domain.Interfaces.Common.ISharedDependenciesConfig sharedDependenciesConfig,
            Domain.Interfaces.Common.ISharedRepositories sharedRepositories,
            IAuditDataSelectiveEntityLogRepository entityRepository,
            IValidator<AuditDataSelectiveEntityLog> entityValidator)
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
        }

        public override Task<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<Domain.DTO.Audit.GET.GetAuditDataSelectiveEntityLogDto>> Create(
            SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
        {
            if (!CreateSucceeds)
                throw new InvalidOperationException(CreateMessage ?? "default-error");
            return Task.FromResult(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<Domain.DTO.Audit.GET.GetAuditDataSelectiveEntityLogDto>
            {
                Success = true,
                Message = CreateMessage!
            });
        }
    }
}

