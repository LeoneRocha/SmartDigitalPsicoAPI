using SmartDigitalPsico.Service.Audit;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.UPDATE;
using SmartDigitalPsico.Domain.DTO.Notification.ADD;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Patient.UPDATE;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.Interfaces.RoleGroup;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
using SmartDigitalPsico.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Domain.Validation;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.Notification;
using SmartDigitalPsico.Service.Schedule.Core.Commands;
using SmartDigitalPsico.Service.Schedule.Core.Conflict;
using SmartDigitalPsico.Service.Schedule.Core.Queries;
using SmartDigitalPsico.Service.Schedule.Medical;
using SmartDigitalPsico.Service.Schedule.Medical.Actions;
using SmartDigitalPsico.Service.Medical;
using SmartDigitalPsico.Service.Patient;
using SmartDigitalPsico.Service.Medical;
using SmartDigitalPsico.Service.Application;
using SmartDigitalPsico.Service.Gender;
using SmartDigitalPsico.Service.Leaves;
using SmartDigitalPsico.Service.Notification;
using SmartDigitalPsico.Service.Office;
using SmartDigitalPsico.Service.RoleGroup;
using SmartDigitalPsico.Service.Specialty;
using SmartDigitalPsico.Service.User;
using SmartDigitalPsico.Service.Patient;
using SmartDigitalPsico.Service.Test.Infrastructure;
using SmartDigitalPsico.Service.Test.TestSupport;
using System.Globalization;
using System.Reflection;
using System.Security.Claims;
using MedicalEntity = SmartDigitalPsico.Domain.EntityModels.Medical;

namespace SmartDigitalPsico.Service.Test.Coverage;
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;

[TestFixture]
public class ServiceBranchCoverageRemainingTests
{
    // Cenário: UserService com Medical nulo, roles fallback/Admin e token nulo.
    // Objetivo: fechar ramos de MedicalId, getRolesGroups e validateCredentials.
    [Test]
    public async Task UserService_AuthAndRoles_CoverRemainingBranches()
    {
        // Arrange
        var ctx = new UserServiceContext();
        SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreatePasswordHash("secret", out var hash, out var salt);
        var userNoMedical = new User
        {
            Id = 20,
            Login = "nomed",
            Name = "NoMed",
            PasswordHash = hash,
            PasswordSalt = salt,
            Medical = null!,
            UserRoleGroups = null!,
            Role = "Manager",
            Language = "pt-BR",
            Admin = true
        };
        ctx.Context.UserRepository.Setup(x => x.FindByLogin("nomed")).ReturnsAsync(userNoMedical);
        ctx.TokenService.Setup(x => x.GenerateAccessToken(It.IsAny<IEnumerable<Claim>>())).Returns("access");
        ctx.TokenService.Setup(x => x.GenerateRefreshToken()).Returns("refresh");
        ctx.Context.UserRepository.Setup(x => x.RefreshUserInfo(userNoMedical)).ReturnsAsync(userNoMedical);
        ctx.TokenSessionService.Setup(x => x.GetSessionAsync(20)).Returns(Task.FromResult<UserTokenSession?>(null!));
        ctx.TokenSessionService.Setup(x => x.SaveSessionAsync(It.IsAny<UserTokenSession>())).Returns(Task.CompletedTask);
        ctx.TokenConfiguration.SetupGet(x => x.Minutes).Returns(30);
        ctx.TokenConfiguration.SetupGet(x => x.DaysToExpiry).Returns(7);

        var userWithNullRoleGroup = new User
        {
            Id = 21,
            Name = "RG",
            UserRoleGroups =
            [
                new RoleGroupUser { RoleGroup = null! },
                new RoleGroupUser { RoleGroup = new RoleGroup { Id = 2, RolePolicyClaimCode = "Staff", Description = "Staff", Enable = true, Language = "en" } }
            ],
            Admin = false,
            Role = null!
        };
        ctx.Context.UserRepository.Setup(x => x.FindByID(21)).ReturnsAsync(userWithNullRoleGroup);

        var userRoleFallback = new User { Id = 22, Name = "FB", Role = "FallbackRole", Language = null!, Admin = false, UserRoleGroups = [] };
        ctx.Context.UserRepository.Setup(x => x.FindByID(22)).ReturnsAsync(userRoleFallback);

        var identity = new ClaimsIdentity([new Claim(ClaimTypes.Name, "23")], "TestAuth");
        var principal = new ClaimsPrincipal(identity);
        var userMismatch = new User
        {
            Id = 23,
            RefreshToken = "other-refresh",
            RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(1)
        };
        ctx.TokenService.Setup(x => x.GetPrincipalFromExpiredToken(string.Empty)).Returns(principal);
        ctx.Context.UserRepository.Setup(x => x.FindByID(23)).ReturnsAsync(userMismatch);
        ctx.TokenConfiguration.SetupGet(x => x.Minutes).Returns(10);

        var validateUser = typeof(UserService).GetMethod("validateCredentials", BindingFlags.Instance | BindingFlags.NonPublic, [typeof(User)])!;

        // Act
        var login = await ctx.Service.Login("nomed", "secret");
        var findRoles = await ctx.Service.FindByID(21);
        var findFallback = await ctx.Service.FindByID(22);
        var nullUserToken = await (Task<TokenVO>)validateUser.Invoke(ctx.Service, [null!])!;
        var nullAccessRefresh = await ctx.Service.validateCredentials(new TokenVO(true, "c", "e", null!, null!));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            login.Success.Should().BeTrue();
            login.Data!.MedicalId.Should().BeNull();
            login.Data.RoleGroups.Should().Contain(r => r.RolePolicyClaimCode == "Manager");
            login.Data.RoleGroups.Should().Contain(r => r.RolePolicyClaimCode == "Admin");
            findRoles.Data!.RoleGroups.Should().ContainSingle(r => r.RolePolicyClaimCode == "Staff");
            findFallback.Data!.RoleGroups.Should().ContainSingle(r => r.RolePolicyClaimCode == "FallbackRole");
            nullUserToken.Authenticated.Should().BeFalse();
            nullAccessRefresh.Should().NotBeNull();
        }
    }

    // Cenário: Create/Delete com InnerException e GetLocalizationErros(null!).
    // Objetivo: fechar InnerException?.Message e errorResponses null.
    [Test]
    public async Task EntityBaseService_NullErrorsLocalization_CoverBranch()
    {
        // Arrange
        var localizationCtx = new EntityProbeContext();

        // Act
        var nullErrors = await localizationCtx.Service.ExposeGetLocalizationErros(null!);
        var emptyErrors = await localizationCtx.Service.ExposeGetLocalizationErros([]);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            nullErrors.Should().BeNull();
            emptyErrors.Should().BeEmpty();
        }
    }

    // Cenário: ApplicationLanguage catch com valor prévio e cache case-insensitive.
    // Objetivo: fechar ?: de resultLocalization e Equals ignore-case.
    [Test]
    public async Task ApplicationLanguage_CatchAndCacheCase_CoverBranches()
    {
        // Arrange
        var previous = CultureInfo.CurrentCulture;
        CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
        try
        {
            var ctx = new ApplicationLanguageServiceContext();
            ctx.Cache.Setup(x => x.IsEnable()).Returns(false);
            ctx.Repository.Setup(x => x.ExistLanguage("pt-BR", "Prefilled", "SharedResource"))
                .ThrowsAsync(new InvalidOperationException("db"));
            var prefilled = typeof(ApplicationLanguageService)
                .GetMethod("GetLocalization", BindingFlags.Instance | BindingFlags.Public, null!,
                    [typeof(string), typeof(string), typeof(SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService)], null!)!;

            // Force catch with non-empty resultLocalization via reflection on private flow:
            // ExistLanguage throws after we can't pre-set; instead test InsertLanguageNotFound with non-empty.
            ctx.Repository.Setup(x => x.ExistLanguage("pt-BR", "KeepValue", "SharedResource")).ReturnsAsync(false);
            ctx.Repository.Setup(x => x.ExistLanguage("en-US", "KeepValue", "SharedResource")).ReturnsAsync(false);
            ctx.Repository.Setup(x => x.Create(It.IsAny<ApplicationLanguage>())).ReturnsAsync((ApplicationLanguage a) => { a.Id = 1; return a; });

            var cached = new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>>(
                new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<List<GetApplicationLanguageDto>>
                {
                    Data =
                    [
                        new GetApplicationLanguageDto
                        {
                            Language = "PT-br",
                            LanguageKey = "Welcome",
                            LanguageValue = "Olá Case",
                            ResourceKey = " sharedresource "
                        },
                        new GetApplicationLanguageDto
                        {
                            Language = "en-US",
                            LanguageKey = "OnlyDefault",
                            LanguageValue = "Hello Default",
                            ResourceKey = "SharedResource"
                        }
                    ],
                    Success = true
                },
                "FindAll_GetApplicationLanguageVO",
                DateTime.UtcNow.AddMinutes(30));
            var cacheCtx = new ApplicationLanguageServiceContext();
            cacheCtx.Cache.Setup(x => x.IsEnable()).Returns(true);
            cacheCtx.Cache.Setup(x => x.Exists<GetApplicationLanguageDto>("FindAll_GetApplicationLanguageVO")).Returns(true);
            cacheCtx.Cache.Setup(x => x.TryGet("FindAll_GetApplicationLanguageVO", out It.Ref<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>>>.IsAny))
                .Returns((string _, out global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetApplicationLanguageDto>> value) =>
                {
                    value = cached;
                    return true;
                });

            // Act
            var thrown = await ctx.Service.GetLocalization<ISharedResource>("Prefilled", "DefaultMsg", ctx.Cache.Object);
            var keep = await ctx.Service.GetLocalization<ISharedResource>("KeepValue", "DefaultKeep", ctx.Cache.Object);
            var caseHit = await cacheCtx.Service.GetLocalization<ISharedResource>("Welcome", "fb", cacheCtx.Cache.Object);
            var defaultHit = await cacheCtx.Service.GetLocalization<ISharedResource>("OnlyDefault", "fb", cacheCtx.Cache.Object);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                thrown.Should().Contain("NotFoundLocalization");
                keep.Should().Contain("NotFoundLocalizationButInsertedDefault");
                caseHit.Should().Be("Olá Case");
                defaultHit.Should().Be("Hello Default");
                _ = prefilled;
            }
        }
        finally
        {
            CultureInfo.CurrentCulture = previous;
        }
    }

    // Cenário: NotificationRecords IsBefore=true, timezone UTC e isCompleted false.
    // Objetivo: cobrir lados opostos dos ternários remanescentes.
    [Test]
    public void NotificationRecords_IsBeforeTrueAndUtc_CoverOppositeBranches()
    {
        // Arrange
        var calculate = typeof(NotificationRecordsService)
            .GetMethod("CalculateScheduledSendTime", BindingFlags.Static | BindingFlags.NonPublic)!;
        var validate = typeof(NotificationRecordsService)
            .GetMethod("ValidateCompletion", BindingFlags.Static | BindingFlags.NonPublic)!;
        var createDto = typeof(NotificationRecordsService)
            .GetMethod("CreateNotificationRecordsDto", BindingFlags.Static | BindingFlags.NonPublic)!;
        var getOffset = typeof(NotificationRecordsService)
            .GetMethod("GetTimeZoneOffset", BindingFlags.Static | BindingFlags.NonPublic)
            ?? typeof(NotificationRecordsService).GetMethods(BindingFlags.Static | BindingFlags.NonPublic)
                .FirstOrDefault(m => m.ReturnType == typeof(int) && m.GetParameters().Length == 1);
        var start = new DateTime(2026, 6, 1, 12, 0, 0, DateTimeKind.Utc);
        var calendar = new MedicalCalendar { StartDateTime = start, Description = "d", TokenRecurrence = Guid.NewGuid().ToString() };

        foreach (EIntervalNotificationType interval in Enum.GetValues<EIntervalNotificationType>())
        {
            var rule = new NotificationRule { IntervalType = interval, IntervalValue = 1, IsBefore = true };
            var scheduled = (DateTime)calculate.Invoke(null!, [rule, start, "UTC"])!;
            scheduled.Should().BeOnOrBefore(start.AddHours(1));
        }
        var incomplete = (bool)validate.Invoke(null!, [false, new[] { new NotificationRuleStatus { IsSent = true } }])!;
        var dtoOpen = (AddNotificationRecordsDto)createDto.Invoke(null!, [calendar, new[] { new NotificationRuleStatus { IsSent = false } }, false])!;
        var dtoDone = (AddNotificationRecordsDto)createDto.Invoke(null!, [calendar, new[] { new NotificationRuleStatus { IsSent = true } }, true])!;

        // Act

        // Assert
        using (Assert.EnterMultipleScope())
        {
            incomplete.Should().BeFalse();
            dtoOpen.FinalSendDate.Should().BeNull();
            dtoDone.FinalSendDate.Should().NotBeNull();
            _ = getOffset;
        }
    }

    // Cenário: Schedule Create/Update com UniqueToken vazio, conflito Success/Data e sem InnerException.
    // Objetivo: fechar ternários e ?? restantes dos serviços core.
    [Test]
    public async Task ScheduleCreateUpdate_RemainingConflictAndToken_CoverBranches()
    {
        // Arrange
        var item = new ScheduleCalendarItem
        {
            StartDateTime = DateTime.UtcNow.Date.AddDays(3).AddHours(10),
            EndDateTime = DateTime.UtcNow.Date.AddDays(3).AddHours(11),
            Title = "t"
        };
        var bookEmptyToken = new ScheduleCreateContext();
        bookEmptyToken.Repository.Setup(x => x.GetByUniqueTokenAsync(It.IsAny<string>())).Returns(Task.FromResult<ScheduleCalendar?>(null!));
        bookEmptyToken.ConflictService
            .Setup(x => x.HasNoConflictBatchAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<ScheduleCalendarItem[]>(), It.IsAny<string?>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = true });
        bookEmptyToken.Repository.Setup(x => x.Create(It.IsAny<ScheduleCalendar>()))
            .ReturnsAsync((ScheduleCalendar e) => e);

        var createConflictDataFalse = new ScheduleCreateContext();
        createConflictDataFalse.Repository.Setup(x => x.GetByUniqueTokenAsync(It.IsAny<string>())).Returns(Task.FromResult<ScheduleCalendar?>(null!));
        createConflictDataFalse.ConflictService
            .Setup(x => x.HasNoConflictBatchAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<ScheduleCalendarItem[]>(), It.IsAny<string?>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = false, Message = null!, Errors = null! });

        var createNoInner = new ScheduleCreateContext();
        createNoInner.Repository.Setup(x => x.GetByUniqueTokenAsync(It.IsAny<string>())).Returns(Task.FromResult<ScheduleCalendar?>(null!));
        createNoInner.ConflictService
            .Setup(x => x.HasNoConflictBatchAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<ScheduleCalendarItem[]>(), It.IsAny<string?>()))
            .ThrowsAsync(new Exception("only-outer"));

        var updateConflictSuccessFalse = new ScheduleUpdateContext();
        var token = "upd-token";
        updateConflictSuccessFalse.Repository.Setup(x => x.GetByUniqueTokenAsync(token))
            .ReturnsAsync(new ScheduleCalendar { Id = 1, UniqueToken = token, ScheduleData = [item] });
        updateConflictSuccessFalse.ConflictService
            .Setup(x => x.HasNoConflictBatchAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<ScheduleCalendarItem[]>(), It.IsAny<string?>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = false, Data = true, Message = "msg", Errors = [new global::SmartDigitalPsico.Core.SDK.Domain.VO.ErrorResponse { Name = "c" }] });

        var updateNoInner = new ScheduleUpdateContext();
        updateNoInner.Repository.Setup(x => x.GetByUniqueTokenAsync(token))
            .ReturnsAsync(new ScheduleCalendar { Id = 2, UniqueToken = token, ScheduleData = null! });
        updateNoInner.ConflictService
            .Setup(x => x.HasNoConflictBatchAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<ScheduleCalendarItem[]>(), It.IsAny<string?>()))
            .ThrowsAsync(new Exception("update-outer-only"));

        var cancelCtx = new ScheduleUpdateContext();
        var appt = DateTime.UtcNow.Date.AddDays(4).AddHours(9);
        cancelCtx.Repository.Setup(x => x.GetItemAsync("medical", "medical:1", null!, appt))
            .ReturnsAsync(new ScheduleCalendarItem { StartDateTime = appt, Status = EStatusCalendar.Confirmed });
        cancelCtx.Repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", appt, It.IsAny<DateTime>()))
            .ReturnsAsync(
            [
                new ScheduleCalendar
                {
                    Id = 9,
                    UniqueToken = "c1",
                    SubjectKey = null!,
                    ScheduleData = [new ScheduleCalendarItem { StartDateTime = appt, Status = EStatusCalendar.Confirmed }]
                }
            ]);
        cancelCtx.Repository.Setup(x => x.Update(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => e);

        // Act
        var booked = await bookEmptyToken.Service.BookAsync(new ScheduleBookRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            UniqueToken = "   ",
            Item = item
        });
        var conflictData = await createConflictDataFalse.Service.CreateAsync(new ScheduleCalendarWriteRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            UniqueToken = "new-c",
            Items = [item]
        });
        var createEx = await createNoInner.Service.CreateAsync(new ScheduleCalendarWriteRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            UniqueToken = "ex",
            Items = [item]
        });
        var updateConflict = await updateConflictSuccessFalse.Service.UpdateAsync(new ScheduleCalendarWriteRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            UniqueToken = token,
            IsUpdate = true,
            UpdateSeries = true,
            Items = [item]
        });
        var updateEx = await updateNoInner.Service.UpdateAsync(new ScheduleCalendarWriteRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            UniqueToken = token,
            IsUpdate = true,
            UpdateSeries = false,
            Items = [item]
        });
        var canceled = await cancelCtx.Service.CancelOccurrenceAsync(new ScheduleCancelRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            SubjectKey = null!,
            AppointmentDateTime = appt,
            Reason = "r"
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            booked.Success.Should().BeTrue();
            booked.Data!.UniqueToken.Should().NotBeNullOrWhiteSpace();
            conflictData.Success.Should().BeFalse();
            createEx.Message.Should().Be("only-outer");
            updateConflict.Success.Should().BeFalse();
            updateEx.Message.Should().Be("update-outer-only");
            canceled.Success.Should().BeTrue();
        }
    }

    // Cenário: Conflict com array vazio, conflito real e EndDateTime preenchido.
    // Objetivo: fechar ramos restantes de ScheduleConflictService.
    [Test]
    public async Task ScheduleConflict_EmptyArrayConflictAndNonNullEnd_CoverBranches()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var start = DateTime.UtcNow.Date.AddDays(2).AddHours(10);
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(
            [
                new ScheduleCalendar
                {
                    UniqueToken = "busy",
                    ScheduleData =
                    [
                        new ScheduleCalendarItem
                        {
                            StartDateTime = start,
                            EndDateTime = start.AddHours(1),
                            SubjectKey = "patient:1",
                            Status = EStatusCalendar.Confirmed
                        }
                    ]
                }
            ]);
        var service = new ScheduleConflictService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var empty = await service.HasNoConflictBatchAsync("medical", "medical:1", [], null!);
        var conflict = await service.HasNoConflictBatchAsync(
            "medical",
            "medical:1",
            [new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddMinutes(30), SubjectKey = "patient:2" }],
            null!);
        var okConflict = await service.HasNoConflictAsync(new ScheduleCalendarConflictRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            StartDateTime = start,
            EndDateTime = start.AddHours(1)
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            empty.Data.Should().BeTrue();
            conflict.Data.Should().BeFalse();
            okConflict.Should().NotBeNull();
        }
    }

    // Cenário: Availability com DisplayName, WorkingDays IEnumerable e filtros AvailableOnly.
    // Objetivo: fechar coalescência e predicados de slot.
    [Test]
    public async Task ScheduleAvailability_DisplayNameAndFilterPredicates_CoverBranches()
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
            DisplayName = "Dr Explicit",
            TimeZone = "UTC",
            StartDate = day,
            EndDate = day.AddDays(1),
            Mode = ScheduleGradeMode.AvailableOnly,
            FilterByWorkingDays = true,
            FilterByDate = day,
            PreloadedItems = [],
            Constraints = new ScheduleOwnerConstraints
            {
                DisplayName = null!,
                WorkingDays = [day.DayOfWeek],
                StartWorkingTime = TimeSpan.FromHours(8),
                EndWorkingTime = TimeSpan.FromHours(18),
                IntervalMinutes = 30
            }
        };
        var fill = typeof(ScheduleAvailabilityService)
            .GetMethod("FillMarkNonWorkingDays", BindingFlags.Static | BindingFlags.NonPublic)!;
        var days = new[]
        {
            new ScheduleDayDto
            {
                Date = day,
                TimeSlots = [new ScheduleTimeSlotDto { StartTime = day.AddHours(9), IsAvailable = true }]
            }
        };
        IEnumerable<DayOfWeek> workingList = new List<DayOfWeek> { day.DayOfWeek };

        // Act
        var result = await service.BuildGradeAsync(request);

        // Assert
        fill.Invoke(null!, [days, workingList]);
        fill.Invoke(null!, [days, new[] { day.DayOfWeek }]);

        result.Success.Should().BeTrue();
        result.Data!.DisplayName.Should().Be("Dr Explicit");
    }

    // Cenário: NotificationDispatch FilterPending e Hydrate com PatientId nulo / patient nulo.
    // Objetivo: fechar && de FilterPending e patient?.Medical.
    [Test]
    public async Task NotificationDispatch_FilterAndHydrate_CoverRemainingBranches()
    {
        // Arrange
        var notificationRecords = new Mock<INotificationRecordsService>();
        var medicalNotify = new Mock<IMedicalCalenderNotificationService>();
        var scheduleRepo = new Mock<IScheduleCalendarRepository>();
        var patientRepos = new Mock<IPatientRepositories>();
        var patientRepo = new Mock<IPatientRepository>();
        patientRepos.SetupGet(x => x.PatientRepository).Returns(patientRepo.Object);
        patientRepo.Setup(x => x.FindAsync(7, It.IsAny<System.Linq.Expressions.Expression<Func<Patient, object>>[]>()))
            .Returns(Task.FromResult<Patient?>(null!));
        var sut = new NotificationDispatchJobService(
            notificationRecords.Object,
            medicalNotify.Object,
            scheduleRepo.Object,
            patientRepos.Object,
            Mock.Of<IAppLogger>());
        var filter = typeof(NotificationDispatchJobService)
            .GetMethod("FilterPendingRecords", BindingFlags.Static | BindingFlags.NonPublic)!;
        var hydrate = typeof(NotificationDispatchJobService)
            .GetMethod("HydratePatientAndMedicalAsync", BindingFlags.Instance | BindingFlags.NonPublic)!;
        var process = typeof(NotificationDispatchJobService)
            .GetMethod("ProcessRecordAsync", BindingFlags.Instance | BindingFlags.NonPublic)!;
        var now = DateTime.UtcNow;
        var records = new[]
        {
            new NotificationRecord
            {
                NotificationRules =
                [
                    new NotificationRuleStatus { IsSent = true, ScheduledSendTime = now.AddMinutes(-10) },
                    new NotificationRuleStatus { IsSent = false, ScheduledSendTime = now.AddHours(2) }
                ]
            },
            new NotificationRecord
            {
                NotificationRules =
                [
                    new NotificationRuleStatus { IsSent = false, ScheduledSendTime = now.AddMinutes(-1) }
                ]
            }
        };

        var filtered = (NotificationRecord[])filter.Invoke(null!, [records, now])!;
        var calendarNullId = new MedicalCalendar { PatientId = null!, Patient = null!, Medical = null! };

        // Act
        await (Task)hydrate.Invoke(sut, [calendarNullId])!;
        var calendarMissingPatient = new MedicalCalendar { PatientId = 7, Patient = null!, Medical = null! };
        await (Task)hydrate.Invoke(sut, [calendarMissingPatient])!;
        var processed = await (Task<bool>)process.Invoke(sut,
        [
            new NotificationRecord
            {
                TokenId = Guid.NewGuid(),
                NotificationRules =
                [
                    new NotificationRuleStatus { IsSent = false, ScheduledSendTime = now.AddMinutes(-1) }
                ]
            },
            now
        ])!;

        // Assert
        using (Assert.EnterMultipleScope())
        {
            filtered.Should().ContainSingle();
            calendarNullId.Patient.Should().BeNull();
            calendarMissingPatient.Medical.Should().BeNull();
            processed.Should().BeFalse();
        }
    }

    // Cenário: MedicalScheduleMapper com SubjectKey válido, preferEventDate e recorrência paralela.
    // Objetivo: fechar ramos restantes do mapper.
    [Test]
    public void MedicalScheduleMapper_SubjectKeyPreferDateAndParallel_CoverBranches()
    {
        // Arrange
        var start = new DateTime(2026, 9, 1, 9, 0, 0, DateTimeKind.Utc);
        var package = new ScheduleCalendar
        {
            Id = 11,
            OwnerKey = MedicalScheduleKeys.ForMedical(3),
            SubjectKey = MedicalScheduleKeys.ForPatient(8),
            UniqueToken = "tok",
            ScheduleData =
            [
                new ScheduleCalendarItem { Title = "A", StartDateTime = start, RecurrenceDays = [], TokenRecurrence = "t1" },
                new ScheduleCalendarItem { Title = "B", StartDateTime = start.AddDays(1), EndDateTime = start.AddDays(1).AddHours(1) }
            ]
        };

        // Act
        var getDto = MedicalScheduleMapper.ToGetDto(package);
        var preferred = MedicalScheduleMapper.ToGetDto(package, package.ScheduleData[1]);
        var fromPrefer = MedicalScheduleMapper.ToMedicalCalendarFromPackage(package, start.AddDays(1));
        var fromNoPrefer = MedicalScheduleMapper.ToMedicalCalendarFromPackage(package);
        var write = MedicalScheduleMapper.ToWriteRequest(new MedicalCalendar
        {
            Id = 0,
            MedicalId = 3,
            PatientId = 8,
            Title = "w",
            TokenRecurrence = "  keep  ",
            StartDateTime = start,
            EndDateTime = start.AddMinutes(30),
            RecurrenceType = ERecurrenceCalendarType.None,
            RecurrenceCount = 1,
            RecurrenceDays = []
        }, isUpdate: false, updateSeries: true);
        var gradeWithDates = MedicalScheduleMapper.ToGradeRequest(
            new CalendarCriteriaDto
            {
                MedicalId = 3,
                Year = 2026,
                Month = 9,
                StartDate = new DateTime(2026, 9, 5),
                EndDate = new DateTime(2026, 9, 20)
            },
            new ScheduleOwnerConstraints { DisplayName = "Dr" },
            "UTC",
            ScheduleGradeMode.Monthly);
        var gradeNullOptional = MedicalScheduleMapper.ToGradeRequest(
            new CalendarCriteriaDto { MedicalId = 3, Year = 2026, Month = 9, StartDate = null!, EndDate = null },
            new ScheduleOwnerConstraints { DisplayName = "Dr" },
            "UTC",
            ScheduleGradeMode.Monthly);
        var calendarDays = MedicalScheduleMapper.ToCalendarDto(
            new ScheduleGradeResult { DisplayName = "Dr", Days = [new ScheduleDayDto { Date = start.Date, TimeSlots = [] }] },
            3);
        var slotResolved = MedicalScheduleMapper.ToTimeSlotDto(
            new ScheduleTimeSlotDto
            {
                StartTime = start,
                EndTime = start.AddMinutes(30),
                Booking = new ScheduleCalendarItem
                {
                    Title = "T",
                    StartDateTime = start,
                    SubjectKey = MedicalScheduleKeys.ForPatient(8)
                }
            },
            3,
            new Dictionary<long, string> { [8] = "Patient Eight" });
        var appointments = MedicalScheduleMapper.ToAppointmentDtos(
            [new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddHours(1), TimeZone = "UTC" }],
            3,
            "Dr");
        var readWithKeys = MedicalScheduleMapper.ToMedicalCalendarReadModel(
            new ScheduleCalendarItem
            {
                PackageId = 5,
                Title = "r",
                StartDateTime = start,
                SubjectKey = MedicalScheduleKeys.ForPatient(9),
                OwnerKey = MedicalScheduleKeys.ForMedical(4),
                ReasonCancellation = null!,
                RecurrenceDays = null!
            },
            0);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            getDto.PatientId.Should().Be(8);
            preferred.Title.Should().Be("B");
            fromPrefer.Title.Should().Be("B");
            fromNoPrefer.Title.Should().Be("A");
            write.UniqueToken.Should().Be("keep");
            write.Items.Should().ContainSingle();
            gradeWithDates.StartDate.Should().Be(new DateTime(2026, 9, 5));
            gradeNullOptional.Should().NotBeNull();
            calendarDays.Days.Should().ContainSingle();
            slotResolved.MedicalCalendar!.Patient!.Name.Should().Be("Patient Eight");
            appointments.Should().ContainSingle();
            readWithKeys.PatientId.Should().Be(9);
            readWithKeys.MedicalId.Should().Be(4);
        }
    }

    // Cenário: Appointment book/cancel falha e GetAppointments Data null.
    // Objetivo: fechar ternários Success/Data de MedicalScheduleAppointmentService.
    [Test]
    public async Task MedicalScheduleAppointment_FailAndNullData_CoverBranches()
    {
        // Arrange
        var context = new AppointmentServiceContext();
        context.ScheduleCriteriaDtoValidator.Setup(x => x.ValidateAsync(It.IsAny<ScheduleCriteriaDto>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.MedicalRepository.Setup(x => x.FindByID(3)).ReturnsAsync(new MedicalEntity { Id = 3, PatientIntervalTimeMinutes = 30 });
        context.CreateService.Setup(x => x.BookAsync(It.IsAny<ScheduleBookRequest>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar> { Success = false, Message = "book-fail" });
        context.UpdateService.Setup(x => x.CancelOccurrenceAsync(It.IsAny<ScheduleCancelRequest>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCancelResult> { Success = false, Message = null!, Data = null! });
        context.AppointmentCriteriaDtoValidator.Setup(x => x.ValidateAsync(It.IsAny<AppointmentCriteriaDto>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.AppointmentQuery.Setup(x => x.GetItemsForOwnerSubjectAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendarItem[]> { Success = true, Data = null! });

        var cancelSuccessNullData = new AppointmentServiceContext();
        cancelSuccessNullData.ScheduleCriteriaDtoValidator.Setup(x => x.ValidateAsync(It.IsAny<ScheduleCriteriaDto>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        cancelSuccessNullData.UpdateService.Setup(x => x.CancelOccurrenceAsync(It.IsAny<ScheduleCancelRequest>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCancelResult> { Success = true, Data = null! });

        // Act
        var bookFail = await context.Service.RequestAppointment(new ScheduleCriteriaDto
        {
            ScheduleType = EScheduleCalendarType.Schedule,
            MedicalId = 3,
            PatientId = 10,
            AppointmentDateTime = DateTime.UtcNow
        });
        var cancelFail = await context.Service.RequestAppointment(new ScheduleCriteriaDto
        {
            ScheduleType = EScheduleCalendarType.Cancellation,
            MedicalId = 3,
            PatientId = 10,
            AppointmentDateTime = DateTime.UtcNow
        });
        var cancelOkNull = await cancelSuccessNullData.Service.RequestAppointment(new ScheduleCriteriaDto
        {
            ScheduleType = EScheduleCalendarType.Cancellation,
            MedicalId = 3,
            PatientId = 10,
            AppointmentDateTime = DateTime.UtcNow
        });
        var appointmentsNull = await context.Service.GetAppointments(new AppointmentCriteriaDto
        {
            MedicalId = 3,
            PatientId = 10,
            Year = 2026,
            Month = 1
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            bookFail.Success.Should().BeFalse();
            cancelFail.Success.Should().BeFalse();
            cancelOkNull.Success.Should().BeTrue();
            appointmentsNull.Success.Should().BeFalse();
        }
    }

    // Cenário: Grade com TimeZone nulo, items.Data nulo e SubjectKey inválido.
    // Objetivo: fechar ?? e ResolvePatientNamesAsync.
    [Test]
    public async Task MedicalScheduleGrade_NullTimeZoneAndData_CoverBranches()
    {
        // Arrange
        var ctx = new MedicalScheduleTestContext();
        ctx.HostSupport.SetUserId(1);
        var day = new DateTime(2026, 6, 2);
        ctx.MedicalRepository.Setup(x => x.FindByID(3)).ReturnsAsync(new MedicalEntity
        {
            Id = 3,
            Name = "Dr",
            WorkingDays = [day.DayOfWeek],
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(18),
            PatientIntervalTimeMinutes = 30
        });
        ctx.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 3, TimeZone = null! });
        var query = new Mock<IScheduleQueryService>();
        query.Setup(x => x.GetItemsForOwnerAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendarItem[]> { Success = true, Data = null! });
        var availability = new Mock<IScheduleAvailabilityService>();
        availability.Setup(x => x.BuildGradeAsync(It.IsAny<ScheduleGradeRequest>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleGradeResult>
            {
                Success = true,
                Data = new ScheduleGradeResult
                {
                    OwnerKey = MedicalScheduleKeys.ForMedical(3),
                    Days =
                    [
                        new ScheduleDayDto
                        {
                            Date = day,
                            TimeSlots =
                            [
                                new ScheduleTimeSlotDto
                                {
                                    StartTime = day.AddHours(9),
                                    EndTime = day.AddHours(9).AddMinutes(30),
                                    Booking = new ScheduleCalendarItem { SubjectKey = "   " }
                                },
                                new ScheduleTimeSlotDto
                                {
                                    StartTime = day.AddHours(10),
                                    EndTime = day.AddHours(10).AddMinutes(30),
                                    Booking = new ScheduleCalendarItem { SubjectKey = "invalid-key" }
                                }
                            ]
                        }
                    ]
                }
            });
        var sut = new MedicalScheduleGradeService(ctx.HostSupport, query.Object, availability.Object, ctx.ConstraintsProvider);

        // Act
        var result = await sut.GetMonthlyCalendar(new CalendarCriteriaDto

        // Assert
        {
            MedicalId = 3,
            Month = 6,
            Year = 2026,
            IntervalInMinutes = 30,
            UserIdLogged = 1
        });

        result.Success.Should().BeTrue();
    }

    // Cenário: Update com Status Refused, ScheduleData nulo/vazio e validação falha.
    // Objetivo: fechar FindTargetOccurrence e status Canceled/Refused.
    [Test]
    public async Task MedicalScheduleUpdate_RefusedNullItemsAndValidation_CoverBranches()
    {
        // Arrange
        var shared = new MedicalScheduleTestContext();
        var query = new Mock<IScheduleQueryService>();
        var update = new Mock<IScheduleUpdateService>();
        var sut = new MedicalScheduleUpdateService(shared.HostSupport, query.Object, update.Object, shared.NotificationAdapter);
        var start = DateTime.UtcNow.AddDays(2);

        query.Setup(x => x.GetByIdAsync(1)).ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar?>
        {
            Success = true,
            Data = new ScheduleCalendar { Id = 1, UniqueToken = "t", ScheduleData = null! }
        });

        // Act
        var refusedDto = await sut.Update(new UpdateMedicalCalendarDto
        {
            Id = 1,
            StartDateTime = start,
            Status = EStatusCalendar.Refused
        });

        query.Setup(x => x.GetByIdAsync(2)).ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar?>
        {
            Success = true,
            Data = new ScheduleCalendar
            {
                Id = 2,
                UniqueToken = "t2",
                ScheduleData = [new ScheduleCalendarItem { StartDateTime = start.AddDays(1), Status = EStatusCalendar.Refused }]
            }
        });
        var refusedOccurrence = await sut.Update(new UpdateMedicalCalendarDto
        {
            Id = 2,
            StartDateTime = start,
            Status = EStatusCalendar.Active
        });

        query.Setup(x => x.GetByIdAsync(3)).ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar?>
        {
            Success = true,
            Data = new ScheduleCalendar
            {
                Id = 3,
                UniqueToken = "t3",
                ScheduleData = []
            }
        });
        shared.EntityValidator.Setup(x => x.ValidateAsync(It.IsAny<MedicalCalendar>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult([new ValidationFailure("Title", "Required")]));
        var validationFail = await sut.Update(new UpdateMedicalCalendarDto
        {
            Id = 3,
            StartDateTime = start,
            Status = EStatusCalendar.Confirmed,
            Title = ""
        });

        var find = typeof(MedicalScheduleUpdateService)
            .GetMethod("FindTargetOccurrence", BindingFlags.Static | BindingFlags.NonPublic)!;
        var byDay = find.Invoke(null!, [new[] { new ScheduleCalendarItem { StartDateTime = start.Date.AddHours(8) } }, start.Date.AddHours(15)]);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            refusedDto.Success.Should().BeFalse();
            refusedOccurrence.Success.Should().BeFalse();
            validationFail.Success.Should().BeFalse();
            byDay.Should().NotBeNull();
        }
    }

    // Cenário: NotificationAdapter com Patient/Medical já preenchidos e patient null no hydrate.
    // Objetivo: fechar if Patient/Medical e patient?.Medical.
    [Test]
    public async Task MedicalScheduleNotificationAdapter_HydrateBranches_CoverRemaining()
    {
        // Arrange
        var ctx = new MedicalScheduleTestContext();
        ctx.MedicalCalenderNotification.Setup(x => x.NotifyAsync(It.IsAny<MedicalCalendar>(), It.IsAny<EMedicalCalendarActionType>()))
            .Returns(Task.CompletedTask);
        ctx.PatientRepository.Setup(x => x.FindAsync(9, It.IsAny<System.Linq.Expressions.Expression<Func<Patient, object>>[]>()))
            .Returns(Task.FromResult<Patient?>(null!));
        var alreadyFilled = new MedicalCalendar
        {
            PatientId = 1,
            Patient = new Patient { Id = 1 },
            Medical = new MedicalEntity { Id = 2 }
        };
        var needsHydrate = new MedicalCalendar { PatientId = 9, Patient = null!, Medical = null! };

        // Act
        await ctx.NotificationAdapter.SendNotifyRegisterAsync(alreadyFilled, EMedicalCalendarActionType.Add);
        await ctx.NotificationAdapter.SendNotifyRegisterAsync(needsHydrate, EMedicalCalendarActionType.Add);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            alreadyFilled.Patient.Should().NotBeNull();
            needsHydrate.Medical.Should().BeNull();
        }
        ctx.PatientRepository.Verify(x => x.FindAsync(9, It.IsAny<System.Linq.Expressions.Expression<Func<Patient, object>>[]>()), Times.Once);
    }

    // Cenário: Constraints com WorkingDays não nulo.
    // Objetivo: cobrir lado contrário do ??.
    [Test]
    public void MedicalScheduleConstraints_NonNullWorkingDays_CoverBranch()
    {
        // Arrange / Act
        // Arrange

        // Act
        var result = MedicalScheduleConstraintsProvider.ToConstraints(new MedicalEntity
        {
            Name = "Dr",
            WorkingDays = [DayOfWeek.Friday],
            PatientIntervalTimeMinutes = 20
        });

        // Assert
        result.WorkingDays.Should().Equal(DayOfWeek.Friday);
    }

    // Cenário: template com chave desconhecida usa Body.
    // Objetivo: cobrir Resolve(...) ?? template.Body.
    [Test]
    public async Task MedicalCalenderNotification_UnknownTemplateKey_UsesBodyFallback()
    {
        // Arrange
        var services = new Mock<ISharedServices>();
        var templates = new Mock<INotificationTemplateService>();
        var send = new Mock<ISendNotificationService>();
        services.SetupGet(x => x.NotificationTemplateService).Returns(templates.Object);
        services.SetupGet(x => x.SendNotificationService).Returns(send.Object);
        templates.Setup(x => x.GetNotificationTemplatesAsync(It.IsAny<string>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<GetNotificationTemplateDto>
            {
                Success = true,
                Data = new GetNotificationTemplateDto
                {
                    Subject = "S",
                    Body = "<p>FallbackBody</p>",
                    TemplateKey = "unknown-key-xyz"
                }
            });
        global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO? captured = null;
        send.Setup(x => x.SendNotificationAsync(It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO>(), ENotificationServiceType.Email, It.IsAny<Dictionary<string, string>>()))
            .Callback<global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO, ENotificationServiceType, Dictionary<string, string>>((vo, _, _) => captured = vo)
            .Returns(Task.CompletedTask);
        var sut = new MedicalCalenderNotificationService(services.Object);

        // Act
        await sut.NotifyAsync(new MedicalCalendar

        // Assert
        {
            Title = "T",
            StartDateTime = DateTime.UtcNow,
            Description = "D",
            Location = "L",
            Medical = new MedicalEntity { Name = "M" },
            Patient = new Patient { Name = "P" }
        }, EMedicalCalendarActionType.Add);

        captured!.Body.Should().Be("<p>FallbackBody</p>");
    }

    // Cenário: PatientNotificationMessage Update com IsReaded/Notified false.
    // Objetivo: cobrir ramos que zeram ReadingDate/NotifiedDate.
    [Test]
    public async Task PatientNotificationMessage_UpdateUnreadNotNotified_SetsNullDates()
    {
        // Arrange
        var shared = new ServiceTestContext();
        var repository = new Mock<IPatientNotificationMessageRepository>();
        var validator = new Mock<IValidator<PatientNotificationMessage>>();
        var entity = new PatientNotificationMessage
        {
            Id = 3,
            ReadingDate = DateTime.UtcNow,
            NotifiedDate = DateTime.UtcNow
        };
        repository.Setup(x => x.FindByID(3)).ReturnsAsync(entity);
        validator.Setup(x => x.ValidateAsync(It.IsAny<PatientNotificationMessage>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);
        var service = new PatientNotificationMessageService(
            shared.SharedServices,
            shared.Config,
            shared.SharedRepositories,
            repository.Object,
            Mock.Of<IPatientRepository>(),
            validator.Object);

        // Act
        var result = await service.Update(new UpdatePatientNotificationMessageDto
        {
            Id = 3,
            Message = "m",
            IsReaded = false,
            Notified = false
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            entity.ReadingDate.Should().BeNull();
            entity.NotifiedDate.Should().BeNull();
        }
    }

    // Cenário: PatientRecord Update com TableStorageRowKey existente e Patient nulo; FindByID Medical nulo.
    // Objetivo: fechar ?? de RowKey, MedicalId e SecurityKey.
    [Test]
    public async Task PatientRecord_UpdateAndFind_CoverNullPatientMedicalBranches()
    {
        // Arrange
        var context = new PatientRecordContext();
        var entity = new PatientRecord
        {
            Id = 30,
            PatientId = 5,
            Patient = null!,
            TableStorageRowKey = "existing-row"
        };
        context.Repository.Setup(x => x.FindByID(30)).ReturnsAsync(entity);
        context.Context.UserRepository.Setup(x => x.FindByID(It.IsAny<long>())).ReturnsAsync(new User { Id = 1 });
        context.MedicalRepository.Setup(x => x.FindByID(0)).ReturnsAsync(new MedicalEntity { Id = 0, SecurityKey = "k" });
        context.Context.Crypto.Setup(x => x.Encrypt("k", It.IsAny<string>())).Returns("enc");
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<PatientRecord>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.StorageTableService.Setup(x => x.UpdateAsync(It.IsAny<PatientRecordTableEntity>())).Returns(Task.CompletedTask);
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);
        context.AuditService.Setup(x => x.Save(It.IsAny<object>(), It.IsAny<object>(), "Update", It.IsAny<string[]>()))
            .Returns(Task.CompletedTask);

        // Act
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindByID(40)).ReturnsAsync(new PatientRecord { Id = 40, PatientId = 5, Annotation = "c" });
        context.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });
        context.PatientRepository.Setup(x => x.FindByID(5, It.IsAny<System.Linq.Expressions.Expression<Func<Patient, object>>[]>()))
            .ReturnsAsync(new Patient { Id = 5, Medical = null! });
        context.Context.Crypto.Setup(x => x.Decrypt(string.Empty, "c")).Returns("plain");

        var update = await context.Service.Update(new UpdatePatientRecordDto
        {
            Id = 30,
            PatientId = 5,
            Description = "d",
            Annotation = "a",
            AnnotationDate = DateTime.UtcNow
        });
        var find = await context.Service.FindByID(40);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            update.Success.Should().BeTrue();
            entity.TableStorageRowKey.Should().Be("existing-row");
            find.Success.Should().BeTrue();
        }
    }

    // Cenário: MedicalFile FindByID quando Data é nulo.
    // Objetivo: cobrir short-circuit de response.Data != null.
    [Test]
    public async Task MedicalFile_FindByID_NullData_SkipsTempFileBranch()
    {
        // Arrange — invalid policy forces FindByID catch without Polly retry storm / host crash.
        var shared = new ServiceTestContext();
        shared.ConfigMock.SetupGet(x => x.PolicyConfig)
            .Returns(new SmartDigitalPsico.Core.SDK.Domain.Resiliency.ResiliencePolicyConfig { PolicyName = "invalid" });
        var repository = new Mock<IMedicalFileRepository>();
        var service = new MedicalFileService(
            shared.SharedServices,
            shared.Config,
            shared.SharedRepositories,
            repository.Object,
            Mock.Of<IValidator<MedicalFile>>(),
            Mock.Of<IFileManagerService>());

        // Act
        var result = await service.FindByID(8);

        // Assert
        result.Success.Should().BeFalse();
        result.Data.Should().BeNull();
    }

    // Cenário: PatientReport com Medical nulo na descriptografia.
    // Objetivo: cobrir Medical?.SecurityKey ?? string.Empty.
    [Test]
    public async Task PatientReport_MedicalNull_DecryptsWithEmptyKey()
    {
        // Arrange
        var shared = new ServiceTestContext();
        var patientRepo = new Mock<IPatientRepository>();
        var patientRepos = new Mock<IPatientRepositories>();
        patientRepos.SetupGet(x => x.PatientRepository).Returns(patientRepo.Object);
        patientRepos.SetupGet(x => x.PatientRecordRepository).Returns(Mock.Of<IPatientRecordRepository>());
        patientRepos.SetupGet(x => x.MedicalRepository).Returns(Mock.Of<IMedicalRepository>());
        patientRepos.SetupGet(x => x.SharedRepositories).Returns(shared.SharedRepositories);
        var config = new Mock<IPatientRecordServiceConfig>();
        config.SetupGet(x => x.SharedServices).Returns(shared.SharedServices);
        config.SetupGet(x => x.SharedDependenciesConfig).Returns(shared.Config);
        config.SetupGet(x => x.SharedRepositories).Returns(shared.SharedRepositories);
        config.SetupGet(x => x.EntityValidator).Returns(Mock.Of<IValidator<PatientRecord>>());
        config.SetupGet(x => x.StorageTableService).Returns(Mock.Of<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<PatientRecordTableEntity>>());
        var reportConfig = new Mock<IReportServiceConfig>();
        reportConfig.SetupGet(x => x.ExcelGeneratorService).Returns(Mock.Of<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorService>());
        reportConfig.SetupGet(x => x.PdfReportService).Returns(Mock.Of<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportService>());
        patientRepo.Setup(x => x.GetPatientDetailsByIdAsync(10)).ReturnsAsync(new Patient
        {
            Id = 10,
            CreatedUser = new User { Id = 2 },
            Medical = null!,
            PatientRecords = [new PatientRecord { Annotation = "cipher", Description = "n" }],
            PatientAdditionalInformations = [],
            PatientHospitalizationInformations = [],
            PatientMedicationInformations = []
        });
        shared.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });
        shared.Crypto.Setup(x => x.Decrypt(string.Empty, "cipher")).Returns("plain");
        var service = new PatientReportService(patientRepos.Object, config.Object, reportConfig.Object);

        // Act
        service.SetUserId(1);

        var result = await service.GetPatientDetailsByIdAsync(10);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.PatientRecords.Should().ContainSingle(r => r.Annotation == "plain");
        }
    }

    // Cenário: Cache TryGet exception, value null e checkCacheIsValid temData false.
    // Objetivo: fechar ramos restantes de SmartDigitalPsico.Service.Infrastructure.Cache.CacheService.
    [Test]
    public void CacheService_ExceptionNullValueAndInvalidDate_CoverBranches()
    {
        // Arrange
        var disk = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>();
        var logs = new Mock<IApplicationCacheLogRepository>();
        disk.Setup(x => x.TryGetAsync<ExpirableCacheEntry>("throw"))
            .ThrowsAsync(new InvalidOperationException("disk-fail"));
        var noDataProp = new Dictionary<string, string> { ["Other"] = "x" };
        disk.Setup(x => x.TryGetAsync<object>("no-data"))
            .ReturnsAsync(new KeyValuePair<bool, object>(true, noDataProp));
        var badDate = new ExpirableCacheEntry
        {
            Data = "x",
            DateTimeSlidingExpiration = "not-a-date"
        };
        disk.Setup(x => x.TryGetAsync<ExpirableCacheEntry>("bad-date"))
            .ReturnsAsync(new KeyValuePair<bool, ExpirableCacheEntry>(true, badDate));
        disk.Setup(x => x.SetAsync("props", It.IsAny<CachePropsWithValues>())).ReturnsAsync(true);
        logs.Setup(x => x.Create(It.IsAny<ApplicationCacheLog>())).ReturnsAsync(new ApplicationCacheLog());
        var memory = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>();
        memory.Setup(x => x.TryGet("mem", out It.Ref<CacheValue?>.IsAny))
            .Returns((string _, out CacheValue? value) =>
            {
                value = null;
                return false;
            });
        var diskService = CreateCache(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Disk, disk: disk, logs: logs);
        var memoryService = CreateCache(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Memory, memory: memory);

        var tryThrow = diskService.TryGet("throw", out ExpirableCacheEntry thrownValue);
        var badDateExists = diskService.Exists<ExpirableCacheEntry>("bad-date");
        var setProps = diskService.Set("props", new CachePropsWithValues
        {
            CacheId = "id-1",
            DateTimeSlidingExpiration = DateTime.Now.AddHours(1).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
        });
        var memMiss = memoryService.TryGet("mem", out CacheValue memValue);

        // Act

        // Assert
        using (Assert.EnterMultipleScope())
        {
            tryThrow.Should().BeFalse();
            thrownValue.Should().NotBeNull();
            badDateExists.Should().BeTrue();
            setProps.Should().BeTrue();
            memMiss.Should().BeFalse();
            memValue.Should().NotBeNull();
        }
    }

    // Cenário: Azure Table/Blob sem connection string.
    // Objetivo: cobrir early-return seguro (_tableClient/_blobServiceClient null!).
    [Test]
    public async Task AzureAdapters_WithoutConnection_SafeNoClientBranches()
    {
        // Arrange
        var emptyConfig = new ConfigurationBuilder().AddInMemoryCollection().Build();
        var table = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageTableAdapter<PatientRecordTableEntity>(emptyConfig, "branch-table");
        var blob = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter(emptyConfig);

        // Act
        var tableResult = await table.GetByIdAsync("pk", "rk");
        var upload = await blob.UploadFileReturnUrl(new SmartDigitalPsico.Core.SDK.Domain.DTO.BlobFileDto
        {
            ContainerName = "files",
            BlobName = string.Empty,
            FilePath = Path.Combine(Path.GetTempPath(), "branch-file.txt")
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            tableResult.Should().NotBeNull();
            upload.Should().BeEmpty();
        }
    }

    // Cenário: login com Medical preenchido e Admin já presente nos RoleGroups.
    // Objetivo: cobrir Medical?.Id e pular inserção duplicada de Admin.
    [Test]
    public async Task UserService_MedicalAndExistingAdminRole_CoverRemainingBranches()
    {
        // Arrange
        var ctx = new UserServiceContext();
        SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreatePasswordHash("secret", out var hash, out var salt);
        // Medical sem navegações para evitar ciclo no AutoMapper durante Login.
        var user = new User
        {
            Id = 30,
            Login = "withmed",
            Name = "WithMed",
            PasswordHash = hash,
            PasswordSalt = salt,
            Medical = new MedicalEntity
            {
                Id = 77,
                Name = "Dr",
                Email = "dr@test.com"
            },
            Admin = true,
            Language = null!,
            Role = null!,
            UserRoleGroups = []
        };
        ctx.Context.UserRepository.Setup(x => x.FindByLogin("withmed")).ReturnsAsync(user);
        ctx.TokenService.Setup(x => x.GenerateAccessToken(It.IsAny<IEnumerable<Claim>>())).Returns("a");
        ctx.TokenService.Setup(x => x.GenerateRefreshToken()).Returns("r");
        ctx.Context.UserRepository.Setup(x => x.RefreshUserInfo(It.IsAny<User>())).ReturnsAsync(user);
        ctx.TokenSessionService.Setup(x => x.GetSessionAsync(30)).Returns(Task.FromResult<UserTokenSession?>(null!));
        ctx.TokenSessionService.Setup(x => x.SaveSessionAsync(It.IsAny<UserTokenSession>())).Returns(Task.CompletedTask);
        ctx.TokenConfiguration.SetupGet(x => x.Minutes).Returns(30);
        ctx.TokenConfiguration.SetupGet(x => x.DaysToExpiry).Returns(7);

        var identity = new ClaimsIdentity([new Claim(ClaimTypes.Name, "31")], "TestAuth");
        var principal = new ClaimsPrincipal(identity);
        var mismatchUser = new User
        {
            Id = 31,
            RefreshToken = "stored-refresh",
            RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(2)
        };
        ctx.TokenService.Setup(x => x.GetPrincipalFromExpiredToken("access-m")).Returns(principal);
        ctx.Context.UserRepository.Setup(x => x.FindByID(31)).ReturnsAsync(mismatchUser);

        // Act
        var login = await ctx.Service.Login("withmed", "secret");
        var mismatch = await ctx.Service.validateCredentials(new TokenVO(true, "c", "e", "access-m", "wrong-refresh"));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            login.Success.Should().BeTrue();
            login.Data!.MedicalId.Should().Be(77);
            login.Data.RoleGroups.Should().Contain(r => r.RolePolicyClaimCode == "Admin");
            mismatch.Authenticated.Should().BeFalse();
        }
    }

    // Cenário: Admin já possui RoleGroup Admin (Language preenchida).
    // Objetivo: não duplicar Admin e cobrir Language não-nulo no fallback.
    [Test]
    public async Task UserService_AdminAlreadyInRoleGroups_DoesNotDuplicateAdmin()
    {
        // Arrange
        var ctx = new UserServiceContext();
        ctx.Context.UserRepository.Setup(x => x.FindByID(40)).ReturnsAsync(new User
        {
            Id = 40,
            Name = "AdminUser",
            Admin = true,
            Language = "en-US",
            UserRoleGroups =
            [
                new RoleGroupUser
                {
                    RoleGroup = new RoleGroup
                    {
                        Id = 1,
                        RolePolicyClaimCode = "Admin",
                        Description = "Administrador",
                        Enable = true,
                        Language = "en-US"
                    }
                }
            ]
        });

        // Act
        var result = await ctx.Service.FindByID(40);

        // Assert
        result.Data!.RoleGroups.Should().ContainSingle(r => r.RolePolicyClaimCode == "Admin");
    }

    // Cenário: Conflict single-item com sobreposição e Update merge com ScheduleData nulo.
    // Objetivo: cobrir Message de conflito e existing ?? [].
    [Test]
    public async Task ScheduleConflictAndUpdate_MergeNullAndConflictMessage_CoverBranches()
    {
        // Arrange
        var start = DateTime.UtcNow.Date.AddDays(5).AddHours(10);
        var conflictRepo = new Mock<IScheduleCalendarRepository>();
        conflictRepo.Setup(x => x.GetConflictingItemsAsync("medical", "medical:1", start, It.IsAny<DateTime>()))
            .ReturnsAsync(
            [
                new ScheduleCalendarItem
                {
                    StartDateTime = start,
                    EndDateTime = start.AddHours(1),
                    Status = EStatusCalendar.Confirmed,
                    TokenRecurrence = "other"
                }
            ]);
        var conflictService = new ScheduleConflictService(conflictRepo.Object, Mock.Of<IAppLogger>());

        var updateCtx = new ScheduleUpdateContext();
        var token = "merge-null";
        updateCtx.Repository.Setup(x => x.GetByUniqueTokenAsync(token))
            .ReturnsAsync(new ScheduleCalendar { Id = 4, UniqueToken = token, ScheduleData = null! });
        updateCtx.ConflictService
            .Setup(x => x.HasNoConflictBatchAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<ScheduleCalendarItem[]>(), It.IsAny<string?>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = true });
        updateCtx.Repository.Setup(x => x.Update(It.IsAny<ScheduleCalendar>()))
            .ReturnsAsync((ScheduleCalendar e) => e);
        var item = new ScheduleCalendarItem
        {
            StartDateTime = start,
            EndDateTime = start.AddMinutes(45),
            Title = "partial"
        };

        var cancelRepo = new Mock<IScheduleCalendarRepository>();
        cancelRepo.Setup(x => x.GetItemAsync("medical", "medical:1", "patient:2", start))
            .ReturnsAsync(new ScheduleCalendarItem { StartDateTime = start, Status = EStatusCalendar.PendingConfirmation });
        cancelRepo.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", start, It.IsAny<DateTime>()))
            .ReturnsAsync(
            [
                new ScheduleCalendar
                {
                    Id = 11,
                    UniqueToken = "pkg",
                    SubjectKey = "patient:2",
                    ScheduleData = [new ScheduleCalendarItem { StartDateTime = start, Status = EStatusCalendar.PendingConfirmation }]
                }
            ]);
        cancelRepo.Setup(x => x.Update(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => e);
        var cancelService = new ScheduleUpdateService(cancelRepo.Object, Mock.Of<IScheduleConflictService>(), Mock.Of<IAppLogger>());

        // Act
        var conflict = await conflictService.HasNoConflictAsync(new ScheduleCalendarConflictRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            StartDateTime = start,
            EndDateTime = start.AddHours(1)
        });
        var merged = await updateCtx.Service.UpdateAsync(new ScheduleCalendarWriteRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            UniqueToken = token,
            IsUpdate = true,
            UpdateSeries = false,
            Items = [item]
        });
        var canceled = await cancelService.CancelOccurrenceAsync(new ScheduleCancelRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            SubjectKey = "patient:2",
            AppointmentDateTime = start,
            Reason = "x"
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            conflict.Data.Should().BeFalse();
            conflict.Message.Should().NotBeNullOrEmpty();
            merged.Success.Should().BeTrue();
            canceled.Success.Should().BeTrue();
        }
    }

    // Cenário: NotificationRecords update existente com IsCompleted true/false.
    // Objetivo: cobrir FinalSendDate no UpdateNotificationRecordsDto.
    [Test]
    public async Task NotificationRecords_UpdateExisting_CompletedAndOpen_CoverFinalSendDate()
    {
        // Arrange
        var shared = new ServiceTestContext();
        var repository = new Mock<INotificationRecordsRepository>();
        var validator = new Mock<IValidator<NotificationRecord>>();
        validator.Setup(x => x.ValidateAsync(It.IsAny<NotificationRecord>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        var rules = new Mock<INotificationRulesService>();
        var token = Guid.NewGuid();
        var existing = new NotificationRecord { Id = 5, TokenId = token, EventDate = DateTime.UtcNow.Date.AddDays(2) };
        repository.Setup(x => x.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<NotificationRecord, bool>>>()))
            .ReturnsAsync([existing]);
        repository.Setup(x => x.FindByID(5)).ReturnsAsync(existing);
        repository.Setup(x => x.Update(It.IsAny<NotificationRecord>())).ReturnsAsync((NotificationRecord r) => r);
        rules.Setup(x => x.GetNotificationRulesAsync(It.IsAny<ENotificationType>(), It.IsAny<bool>(), It.IsAny<long>()))
            .ReturnsAsync(
            [
                new NotificationRule
                {
                    Id = 1,
                    IntervalType = EIntervalNotificationType.Hours,
                    IntervalValue = 1,
                    IsBefore = true,
                    ENotificationServiceType = [ENotificationServiceType.Email]
                }
            ]);
        var service = new NotificationRecordsService(
            shared.SharedServices,
            shared.Config,
            shared.SharedRepositories,
            repository.Object,
            Mock.Of<IApplicationLanguageRepository>(),
            validator.Object,
            rules.Object);

        var save = typeof(NotificationRecordsService)
            .GetMethod("SaveNotificationRecordAsync", BindingFlags.Instance | BindingFlags.NonPublic)!;
        var calendar = new MedicalCalendar
        {
            MedicalId = 1,
            StartDateTime = existing.EventDate,
            TokenRecurrence = token.ToString(),
            TimeZone = "UTC"
        };

        // Act
        await (Task)save.Invoke(service,
        [
            calendar,
            new AddNotificationRecordsDto
            {
                TokenId = token,
                EventDate = existing.EventDate,
                NotificationRules = [new NotificationRuleStatus { IsSent = true }],
                IsCompleted = true,
                FinalSendDate = DateTime.UtcNow
            },
            true
        ])!;
        await (Task)save.Invoke(service,
        [
            calendar,
            new AddNotificationRecordsDto
            {
                TokenId = token,
                EventDate = existing.EventDate,
                NotificationRules = [new NotificationRuleStatus { IsSent = false }],
                IsCompleted = false,
                FinalSendDate = null
            },
            false
        ])!;

        // Assert
        repository.Verify(x => x.Update(It.IsAny<NotificationRecord>()), Times.AtLeastOnce);
    }

    // Cenário: NotificationAdapter hidrata paciente com Medical; Appointment Success com Data nulo.
    // Objetivo: cobrir patient?.Medical e booked.Data?.Id.
    [Test]
    public async Task NotificationAdapterAndAppointment_HydrateMedicalAndNullBookData_CoverBranches()
    {
        // Arrange
        var ctx = new MedicalScheduleTestContext();
        ctx.MedicalCalenderNotification.Setup(x => x.NotifyAsync(It.IsAny<MedicalCalendar>(), It.IsAny<EMedicalCalendarActionType>()))
            .Returns(Task.CompletedTask);
        ctx.PatientRepository.Setup(x => x.FindAsync(4, It.IsAny<System.Linq.Expressions.Expression<Func<Patient, object>>[]>()))
            .ReturnsAsync(new Patient { Id = 4, Medical = new MedicalEntity { Id = 8, Name = "Dr" } });
        var calendar = new MedicalCalendar { PatientId = 4, Patient = null!, Medical = null! };

        var appt = new AppointmentServiceContext();
        appt.ScheduleCriteriaDtoValidator.Setup(x => x.ValidateAsync(It.IsAny<ScheduleCriteriaDto>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        appt.MedicalRepository.Setup(x => x.FindByID(3)).ReturnsAsync(new MedicalEntity { Id = 3, PatientIntervalTimeMinutes = 30 });
        appt.CreateService.Setup(x => x.BookAsync(It.IsAny<ScheduleBookRequest>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<ScheduleCalendar> { Success = true, Data = null!, Message = "ok" });

        // Act
        await ctx.NotificationAdapter.SendNotifyRegisterAsync(calendar, EMedicalCalendarActionType.Add);
        var booked = await appt.Service.RequestAppointment(new ScheduleCriteriaDto
        {
            ScheduleType = EScheduleCalendarType.Schedule,
            MedicalId = 3,
            PatientId = 10,
            AppointmentDateTime = DateTime.UtcNow.AddDays(1)
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            calendar.Medical!.Id.Should().Be(8);
            booked.Success.Should().BeTrue();
        }
    }

    // Cenário: Mapper preferEventDate com ScheduleData nulo e slot sem Booking.
    // Objetivo: fechar pattern Length e bookingDto null.
    [Test]
    public void MedicalScheduleMapper_PreferDateNullDataAndNoBooking_CoverBranches()
    {
        // Arrange / Act
        // Arrange

        // Act
        var withEmptyData = MedicalScheduleMapper.ToMedicalCalendarFromPackage(
            new ScheduleCalendar
            {
                Id = 1,
                OwnerKey = MedicalScheduleKeys.ForMedical(1),
                ScheduleData = []
            },
            preferEventDate: DateTime.UtcNow);
        var withNullData = MedicalScheduleMapper.ToMedicalCalendarFromPackage(
            new ScheduleCalendar
            {
                Id = 2,
                OwnerKey = MedicalScheduleKeys.ForMedical(1),
                ScheduleData = null!
            },
            preferEventDate: DateTime.UtcNow);
        var noBooking = MedicalScheduleMapper.ToTimeSlotDto(
            new ScheduleTimeSlotDto
            {
                StartTime = DateTime.UtcNow,
                EndTime = DateTime.UtcNow.AddMinutes(30),
                Booking = null!,
                IsAvailable = true
            },

            1);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            withEmptyData.Should().NotBeNull();
            withNullData.Should().NotBeNull();
            noBooking.MedicalCalendar.Should().BeNull();
        }
    }

    // Cenário: Cache com props sem DateTime/CacheId e Data sem expiração; AvailableOnly.
    // Objetivo: fechar ternários de props nulas e valorExpiracao?.
    [Test]
    public async Task CacheAndAvailability_MissingPropsAndNullExpiration_CoverBranches()
    {
        // Arrange
        var disk = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>();
        var logs = new Mock<IApplicationCacheLogRepository>();
        disk.Setup(x => x.SetAsync("no-props", It.IsAny<CachePropsWithValues>())).ReturnsAsync(true);
        logs.Setup(x => x.Create(It.IsAny<ApplicationCacheLog>())).ReturnsAsync(new ApplicationCacheLog());
        var noExp = new ExpirableCacheEntry { Data = "x", DateTimeSlidingExpiration = null! };
        disk.Setup(x => x.TryGetAsync<ExpirableCacheEntry>("no-exp"))
            .ReturnsAsync(new KeyValuePair<bool, ExpirableCacheEntry>(true, noExp));
        var service = CreateCache(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Disk, disk: disk, logs: logs);

        var day = DateTime.UtcNow.Date.AddDays(2);
        while (day.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
            day = day.AddDays(1);
        var availability = new ScheduleAvailabilityService(Mock.Of<IScheduleCalendarRepository>(), Mock.Of<IAppLogger>());
        var request = new ScheduleGradeRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            DisplayName = "Dr",
            TimeZone = "UTC",
            StartDate = day,
            EndDate = day.AddDays(1),
            Mode = ScheduleGradeMode.AvailableOnly,
            PreloadedItems = [],
            Constraints = new ScheduleOwnerConstraints
            {
                WorkingDays = [day.DayOfWeek],
                StartWorkingTime = TimeSpan.FromHours(8),
                EndWorkingTime = TimeSpan.FromHours(18),
                IntervalMinutes = 30,
                DisplayName = "Dr"
            }
        };

        // Act
        var set = service.Set("no-props", new CachePropsWithValues());
        var exists = service.Exists<ExpirableCacheEntry>("no-exp");
        var grade = await availability.BuildGradeAsync(request);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            set.Should().BeTrue();
            exists.Should().BeTrue();
            grade.Success.Should().BeTrue();
        }
    }

    private static SmartDigitalPsico.Service.Infrastructure.Cache.CacheService CreateCache(
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

    private sealed class CachePropsWithValues
    {
        public string? CacheId { get; set; }
        public string? DateTimeSlidingExpiration { get; set; }
    }

    private sealed class UserServiceContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<IRoleGroupRepository> RoleGroupRepository { get; } = new();
        public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ITokenConfigurationDto> TokenConfiguration { get; } = new();
        public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.ITokenService> TokenService { get; } = new();
        public Mock<ITokenSessionPersistenceService> TokenSessionService { get; } = new();
        public Mock<IValidator<User>> Validator { get; } = new();
        public UserService Service { get; }

        public UserServiceContext()
        {
            var authConfig = Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.AuthConfigurationDto { IsEnable = true, TypeApiCredential = global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeApiCredential.Jwt });
            Service = new UserService(
                Context.SharedServices,
                Context.Config,
                Context.SharedRepositories,
                RoleGroupRepository.Object,
                TokenConfiguration.Object,
                TokenService.Object,
                authConfig,
                Validator.Object,
                TokenSessionService.Object);
        }
    }

    private sealed class EntityProbeContext
    {
        public Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<Gender>> Repository { get; } = new();
        public Mock<IValidator<Gender>> Validator { get; } = new();
        public Mock<IAppMapper> Mapper { get; } = new();
        public ProbeEntityBaseService Service { get; }

        public EntityProbeContext(string policyName = "")
        {
            var shared = new ServiceTestContext();
            shared.ConfigMock.SetupGet(x => x.PolicyConfig).Returns(new SmartDigitalPsico.Core.SDK.Domain.Resiliency.ResiliencePolicyConfig { PolicyName = policyName });
            shared.ConfigMock.SetupGet(x => x.Mapper).Returns(Mapper.Object);
            Service = new ProbeEntityBaseService(
                shared.SharedServices,
                shared.Config,
                shared.SharedRepositories,
                Repository.Object,
                Validator.Object);
        }
    }

    private sealed class ProbeEntityBaseService : SmartDigitalPsico.Service.Common.EntityBaseService<Gender, GetGenderDto>
    {
        public ProbeEntityBaseService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig dependencies,
            ISharedRepositories repositories,
            global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<Gender> repository,
            IValidator<Gender> validator)
            : base(sharedServices, dependencies, repositories, repository, validator)
        {
        }

        public Task<List<global::SmartDigitalPsico.Core.SDK.Domain.VO.ErrorResponse>> ExposeGetLocalizationErros(List<global::SmartDigitalPsico.Core.SDK.Domain.VO.ErrorResponse> errors)
            => GetLocalizationErros(errors);
    }

    private sealed class ApplicationLanguageServiceContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<IApplicationLanguageRepository> Repository => Context.ApplicationLanguageRepository;
        public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService> Cache => Context.Cache;
        public ApplicationLanguageService Service { get; }

        public ApplicationLanguageServiceContext()
        {
            var validator = new Mock<IValidator<ApplicationLanguage>>();
            validator.Setup(x => x.ValidateAsync(It.IsAny<ApplicationLanguage>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult());
            Service = new ApplicationLanguageService(
                Context.SharedServices,
                Context.Config,
                Context.SharedRepositories,
                Repository.Object,
                validator.Object);
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

    private sealed class AppointmentServiceContext
    {
        public MedicalScheduleTestContext Shared { get; } = new();
        public Mock<IScheduleCreateService> CreateService { get; } = new();
        public Mock<IScheduleUpdateService> UpdateService { get; } = new();
        public Mock<IScheduleAppointmentQueryService> AppointmentQuery { get; } = new();
        public Mock<IMedicalRepository> MedicalRepository => Shared.MedicalRepository;
        public Mock<IValidator<ScheduleCriteriaDto>> ScheduleCriteriaDtoValidator => Shared.ScheduleCriteriaDtoValidator;
        public Mock<IValidator<AppointmentCriteriaDto>> AppointmentCriteriaDtoValidator => Shared.AppointmentCriteriaDtoValidator;
        public MedicalScheduleAppointmentService Service { get; }

        public AppointmentServiceContext()
        {
            Service = new MedicalScheduleAppointmentService(
                Shared.HostSupport,
                CreateService.Object,
                UpdateService.Object,
                AppointmentQuery.Object,
                Shared.ConstraintsProvider,
                Shared.NotificationAdapter,
                Shared.Validators.Object);
        }
    }

    private sealed class PatientRecordContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<IPatientRecordRepository> Repository { get; } = new();
        public Mock<IMedicalRepository> MedicalRepository { get; } = new();
        public Mock<IPatientRepository> PatientRepository { get; } = new();
        public Mock<IValidator<PatientRecord>> Validator { get; } = new();
        public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<PatientRecordTableEntity>> StorageTableService { get; } = new();
        public Mock<IAuditDataSelectiveEntityLogService> AuditService { get; } = new();
        public PatientRecordService Service { get; }

        public PatientRecordContext()
        {
            var repositories = new Mock<IPatientRepositories>();
            repositories.SetupGet(x => x.PatientRecordRepository).Returns(Repository.Object);
            repositories.SetupGet(x => x.MedicalRepository).Returns(MedicalRepository.Object);
            repositories.SetupGet(x => x.PatientRepository).Returns(PatientRepository.Object);
            repositories.SetupGet(x => x.SharedRepositories).Returns(Context.SharedRepositories);
            var config = new Mock<IPatientRecordServiceConfig>();
            config.SetupGet(x => x.SharedServices).Returns(Context.SharedServices);
            config.SetupGet(x => x.SharedDependenciesConfig).Returns(Context.Config);
            config.SetupGet(x => x.SharedRepositories).Returns(Context.SharedRepositories);
            config.SetupGet(x => x.EntityValidator).Returns(Validator.Object);
            config.SetupGet(x => x.StorageTableService).Returns(StorageTableService.Object);
            Service = new PatientRecordService(repositories.Object, config.Object, AuditService.Object);
        }
    }
}
