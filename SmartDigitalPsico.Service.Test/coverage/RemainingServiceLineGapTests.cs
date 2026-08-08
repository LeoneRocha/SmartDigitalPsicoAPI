using System.Reflection;
using FluentValidation;
using FluentValidation.Results;
using Moq;
using Serilog;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Notification;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.Infrastructure.CacheManager;
using SmartDigitalPsico.Service.Bussines.Notification;
using SmartDigitalPsico.Service.Bussines.Schedule.Core.Conflict;
using SmartDigitalPsico.Service.Bussines.Schedule.Core.Queries;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Service.Test.Infrastructure;
using SmartDigitalPsico.Service.Test.TestSupport;
using ILogger = Serilog.ILogger;

namespace SmartDigitalPsico.Service.Test.Coverage;

[TestFixture]
public class RemainingServiceLineGapTests
{
    // Cenário: DeleteNotificationRecordsAsync com token Guid válido.
    // Objetivo: delegar exclusão ao repositório.
    [Test]
    public async Task MedicalScheduleNotificationAdapter_DeleteByValidToken_CallsRepository()
    {
        // Arrange
        var ctx = new MedicalScheduleTestContext();
        var token = Guid.NewGuid();
        ctx.NotificationRecordsRepository.Setup(x => x.DeleteAllByTokenAsync(token)).ReturnsAsync(true);

        // Act
        await ctx.NotificationAdapter.DeleteNotificationRecordsAsync(token.ToString());

        // Assert
        ctx.NotificationRecordsRepository.Verify(x => x.DeleteAllByTokenAsync(token), Times.Once);
    }

    // Cenário: ProcessRecordAsync com regras vazias / sem pendentes / PatientId inválido.
    // Objetivo: cobrir early-returns defensivos via reflexão.
    [Test]
    public async Task NotificationDispatchJob_ProcessRecordAsync_DefensiveBranches_ReturnFalse()
    {
        // Arrange
        var notificationRecords = new Mock<INotificationRecordsService>();
        var medicalNotify = new Mock<IMedicalCalenderNotificationService>();
        var scheduleRepo = new Mock<IScheduleCalendarRepository>();
        var patientRepos = new Mock<IPatientRepositories>();
        var patientRepo = new Mock<IPatientRepository>();
        patientRepos.SetupGet(x => x.PatientRepository).Returns(patientRepo.Object);
        var sut = new NotificationDispatchJobService(
            notificationRecords.Object,
            medicalNotify.Object,
            scheduleRepo.Object,
            patientRepos.Object,
            Mock.Of<ILogger>());
        var method = typeof(NotificationDispatchJobService)
            .GetMethod("ProcessRecordAsync", BindingFlags.Instance | BindingFlags.NonPublic)!;
        var now = DateTime.UtcNow;

        // Act
        var emptyRules = await (Task<bool>)method.Invoke(sut, [new NotificationRecord { NotificationRules = [] }, now])!;
        var noPending = await (Task<bool>)method.Invoke(sut, [new NotificationRecord
        {
            TokenId = Guid.NewGuid(),
            NotificationRules = [new NotificationRuleStatus { IsSent = true, ScheduledSendTime = now.AddMinutes(-1) }]
        }, now])!;
        var hydrate = typeof(NotificationDispatchJobService)
            .GetMethod("HydratePatientAndMedicalAsync", BindingFlags.Instance | BindingFlags.NonPublic)!;
        var calendar = new MedicalCalendar { PatientId = 0, Patient = null, Medical = null };
        await (Task)hydrate.Invoke(sut, [calendar])!;
        calendar.Patient = new Patient { Id = 1 };
        calendar.Medical = new Medical { Id = 2 };
        await (Task)hydrate.Invoke(sut, [calendar])!;

        // Assert
        using (Assert.EnterMultipleScope())
        {
            emptyRules.Should().BeFalse();
            noPending.Should().BeFalse();
            calendar.Patient!.Id.Should().Be(1);
        }
    }

    // Cenário: busy multi-dia com dias fora do range da grade.
    // Objetivo: cobrir continue quando d < rangeStart || d > rangeEnd.
    [Test]
    public async Task ScheduleAvailability_BusyOutsideRange_SkipsOutOfRangeDays()
    {
        // Arrange
        var service = new ScheduleAvailabilityService(Mock.Of<IScheduleCalendarRepository>(), Mock.Of<ILogger>());
        var day = new DateTime(2026, 3, 10);
        var request = new ScheduleGradeRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            DisplayName = "Dr",
            TimeZone = "UTC",
            StartDate = day,
            EndDate = day,
            PreloadedItems =
            [
                new ScheduleCalendarItem
                {
                    StartDateTime = day.AddDays(-2).AddHours(9),
                    EndDateTime = day.AddDays(2).AddHours(10),
                    SubjectKey = "patient:1"
                }
            ],
            Constraints = new ScheduleOwnerConstraints
            {
                WorkingDays = [day.DayOfWeek],
                StartWorkingTime = TimeSpan.FromHours(9),
                EndWorkingTime = TimeSpan.FromHours(17),
                IntervalMinutes = 30
            }
        };

        // Act
        var result = await service.BuildGradeAsync(request);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: FindConflictsAgainstExisting com MaxErrors atingido e item não sobreposto.
    // Objetivo: cobrir early-return bag.Count >= MaxErrors.
    [Test]
    public void ScheduleConflict_FindConflictsAgainstExisting_MaxErrorsAndNonOverlap_CoverBranches()
    {
        // Arrange

        // Act
        var method = typeof(ScheduleConflictService)
            .GetMethod("FindConflictsAgainstExisting", BindingFlags.Static | BindingFlags.NonPublic)!;
        var existingStart = new DateTime(2026, 9, 2, 10, 0, 0, DateTimeKind.Utc);
        var existingType = typeof(ScheduleConflictService).GetNestedType("ExistingOccurrence", BindingFlags.NonPublic)!;
        var existing = Array.CreateInstance(existingType, 1);
        var existingItem = Activator.CreateInstance(existingType,
            new ScheduleCalendarItem
            {
                StartDateTime = existingStart,
                EndDateTime = existingStart.AddHours(1),
                SubjectKey = "patient:0"
            },
            "pkg-token",
            "patient:0")!;
        existing.SetValue(existingItem, 0);
        var items = Enumerable.Range(0, 500)
            .Select(i => new ScheduleCalendarItem
            {
                StartDateTime = existingStart.AddMinutes(i),
                EndDateTime = existingStart.AddHours(1).AddMinutes(i),
                SubjectKey = $"patient:{i}"
            })
            .ToArray();

        var result = method.Invoke(null, [items, existing]) as System.Collections.IList;

        // Assert
        result.Should().NotBeNull();

        result!.Count.Should().BeLessThanOrEqualTo(20);
    }

    // Cenário: item do lote sem sobreposição com existentes.
    // Objetivo: cobrir continue do FindConflictsAgainstExisting.
    [Test]
    public async Task ScheduleConflict_NonOverlappingExisting_ContinuesWithoutError()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        var existingStart = new DateTime(2026, 9, 2, 10, 0, 0, DateTimeKind.Utc);
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync([new ScheduleCalendar
            {
                UniqueToken = "pkg",
                ScheduleData = [new ScheduleCalendarItem { StartDateTime = existingStart, EndDateTime = existingStart.AddHours(1) }]
            }]);
        var items = new[]
        {
            new ScheduleCalendarItem
            {
                StartDateTime = existingStart.AddHours(3),
                EndDateTime = existingStart.AddHours(4),
                SubjectKey = "patient:1"
            }
        };
        var service = new ScheduleConflictService(repository.Object, Mock.Of<ILogger>());

        // Act
        var result = await service.HasNoConflictBatchAsync("medical", "medical:1", items, null);

        // Assert
        result.Data.Should().BeTrue();
    }

    // Cenário: CreateAuditEntry bem-sucedido e Create falha.
    // Objetivo: logar Information quando auditEntry != null e Error no final.
    [Test]
    public async Task AuditDataSelectiveEntityLogService_Save_CreateThrows_LogsInformationAndError()
    {
        // Arrange
        var logger = new Mock<ILogger>();
        var sharedConfig = new Mock<ISharedDependenciesConfig>();
        sharedConfig.SetupGet(x => x.Logger).Returns(logger.Object);
        var shared = new ServiceTestContext();
        shared.ConfigMock.SetupGet(x => x.Logger).Returns(logger.Object);
        var service = new ControllableAuditDataSelectiveEntityLogService(
            shared.SharedServices,
            sharedConfig.Object,
            shared.SharedRepositories,
            Mock.Of<IAuditDataSelectiveEntityLogRepository>(),
            Mock.Of<IValidator<AuditDataSelectiveEntityLog>>());
        var oldEntry = new Patient { Id = 1, Name = "Old", ModifyUser = new User { Name = "doc" } };
        var newEntry = new Patient { Id = 1, Name = "New", ModifyUser = new User { Name = "doc" } };

        // Act
        service.CreateSucceeds = true;
        await service.Save(oldEntry, newEntry, "Update", ["ModifyDate"]);
        service.CreateSucceeds = false;
        await service.Save(oldEntry, newEntry, "Update", ["ModifyDate"]);

        // Assert
        logger.Verify(x => x.Error(It.IsAny<Exception>(), "Error writing log"), Times.Once);
    }

    private sealed class ControllableAuditDataSelectiveEntityLogService : AuditDataSelectiveEntityLogService
    {
        public bool CreateSucceeds { get; set; }

        public ControllableAuditDataSelectiveEntityLogService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IAuditDataSelectiveEntityLogRepository entityRepository,
            IValidator<AuditDataSelectiveEntityLog> entityValidator)
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
        }

        public override Task<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<SmartDigitalPsico.Domain.DTO.Domains.GetDTOs.GetAuditDataSelectiveEntityLogDto>> Create(
            SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
        {
            if (!CreateSucceeds)
                throw new InvalidOperationException("fail");
            return Task.FromResult(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<SmartDigitalPsico.Domain.DTO.Domains.GetDTOs.GetAuditDataSelectiveEntityLogDto>
            {
                Success = true,
                Message = "ok"
            });
        }
    }

    // Cenário: cálculo de agendamento com IntervalType inválido.
    // Objetivo: cobrir o default do switch CalculateScheduledSendTime.
    [Test]
    public void NotificationRecordsService_CalculateScheduledSendTime_InvalidInterval_ReturnsAdjustedStart()
    {
        // Arrange

        // Act
        var method = typeof(NotificationRecordsService)
            .GetMethod("CalculateScheduledSendTime", BindingFlags.Static | BindingFlags.NonPublic)!;
        var rule = new NotificationRule
        {
            IntervalType = (EIntervalNotificationType)999,
            IntervalValue = 2,
            IsBefore = false
        };
        var start = new DateTime(2026, 1, 1, 12, 0, 0, DateTimeKind.Utc);

        var result = (DateTime)method.Invoke(null, [rule, start, "UTC"])!;

        // Assert
        result.Should().Be(start);
    }

    // Cenário: Create com regras nulas / intervalo default / timezone BRT.
    // Objetivo: cobrir GetNextScheduledSendTime null e ramos CalculateScheduledSendTime.
    [Test]
    public async Task NotificationRecordsService_Create_NullRulesDefaultIntervalAndBrt_CoverHelpers()
    {
        // Arrange
        var context = new ServiceTestContext();
        var repository = new Mock<INotificationRecordsRepository>();
        var validator = new Mock<IValidator<NotificationRecord>>();
        validator.Setup(x => x.ValidateAsync(It.IsAny<NotificationRecord>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        repository.Setup(x => x.Create(It.IsAny<NotificationRecord>())).ReturnsAsync((NotificationRecord r) => { r.Id = 1; return r; });
        var rulesService = new Mock<INotificationRulesService>();
        var service = new NotificationRecordsService(
            context.SharedServices,
            context.Config,
            context.SharedRepositories,
            repository.Object,
            Mock.Of<IApplicationLanguageRepository>(),
            validator.Object,
            rulesService.Object);

        // Act
        var nullRules = await service.Create(new AddNotificationRecordsDto
        {
            TokenId = Guid.NewGuid(),
            EventDate = DateTime.UtcNow,
            NotificationRules = null!
        });

        rulesService.Setup(x => x.GetNotificationRulesAsync(It.IsAny<ENotificationType>(), It.IsAny<bool>(), It.IsAny<long>()))
            .ReturnsAsync(
            [
                new NotificationRule
                {
                    Id = 99,
                    IntervalType = (EIntervalNotificationType)999,
                    IntervalValue = 1,
                    IsBefore = false,
                    ENotificationServiceType = [ENotificationServiceType.Email]
                }
            ]);
        repository.Setup(x => x.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<NotificationRecord, bool>>>()))
            .ReturnsAsync([]);
        await service.CreateOrUpdateNotificationRecordsAsync(new GenerateNotificationRecordsDto
        {
            IsEnabled = true,
            MedicalCalendars =
            [
                new MedicalCalendar
                {
                    MedicalId = 1,
                    StartDateTime = DateTime.UtcNow.AddYears(2),
                    TokenRecurrence = Guid.NewGuid().ToString(),
                    TimeZone = "BRT"
                }
            ],
            NotificationType = ENotificationType.BeforeAppointment
        });

        // Assert
        nullRules.Success.Should().BeTrue();

        repository.Verify(x => x.Create(It.IsAny<NotificationRecord>()), Times.AtLeastOnce);
    }

    // Cenário: cache em disco com Data preenchido e expiração válida.
    // Objetivo: cobrir retorno true em checkCacheIsValid (fechamento do bloco externo).
    [Test]
    public void DiskCache_ValidDataProperty_ReturnsExistsTrue()
    {
        // Arrange
        var disk = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>();
        var entry = new ExpirableCacheEntry
        {
            Data = "payload",
            DateTimeSlidingExpiration = DateTime.Now.AddMinutes(30).ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
        };
        disk.Setup(x => x.TryGetAsync<ExpirableCacheEntry>("valid-data"))
            .ReturnsAsync(new KeyValuePair<bool, ExpirableCacheEntry>(true, entry));
        var service = new SmartDigitalPsico.Service.Infrastructure.CacheManager.CacheService(
            Mock.Of<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>(),
            disk.Object,
            Mock.Of<IApplicationCacheLogRepository>(),
            Microsoft.Extensions.Options.Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
            {
                TypeCache = global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Disk,
                IsEnable = true,
                AbsoluteExpirationInHours = 1,
                SlidingExpirationInMinutes = 5
            }));

        // Act
        var exists = service.Exists<ExpirableCacheEntry>("valid-data");
        var found = service.TryGet("valid-data", out ExpirableCacheEntry loaded);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            exists.Should().BeTrue();
            found.Should().BeTrue();
            loaded.Data.Should().Be("payload");
        }
    }
}

