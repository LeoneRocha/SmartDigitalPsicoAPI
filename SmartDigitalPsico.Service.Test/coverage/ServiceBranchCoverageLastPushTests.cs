using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;
using System.Globalization;
using System.Reflection;
using System.Security.Claims;
using AutoMapper;
using Azure;
using Azure.Data.Tables;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.Common;
using SmartDigitalPsico.Domain.DTO.Common;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.Bussines.Schedule.Core.Commands;
using SmartDigitalPsico.Service.Bussines.Schedule.Core.Conflict;
using SmartDigitalPsico.Service.Bussines.Schedule.Core.Queries;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical;
using SmartDigitalPsico.Service.DataEntity.Principals;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Service.Test.TestSupport;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using MedicalEntity = SmartDigitalPsico.Domain.ModelEntity.Medical;
using SmartDigitalPsico.Domain.DTO.Gender.ADD;
using SmartDigitalPsico.Domain.DTO.Office.ADD;
using SmartDigitalPsico.Domain.DTO.RoleGroup.ADD;
using SmartDigitalPsico.Domain.DTO.Leaves.ADD;
using SmartDigitalPsico.Domain.DTO.Specialty.ADD;
using SmartDigitalPsico.Domain.DTO.Notification.ADD;
using SmartDigitalPsico.Domain.DTO.Application.ADD;
using SmartDigitalPsico.Domain.DTO.Audit.ADD;

using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.RoleGroup;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Test.Coverage;

[TestFixture]
public class ServiceBranchCoverageLastPushTests
{
    // Cenário: Cache TryGet lança com out null e com valor; Set com CacheId.ToString nulo; Exists sem expiração.
    // Objetivo: fechar ??/ternários restantes de SmartDigitalPsico.Service.Infrastructure.CacheManager.CacheService.
    [Test]
    public void CacheService_CatchNullOutAndPropValues_CoverRemaining()
    {
        // Arrange
        TryGetCacheValue throwNull = (string _, out CacheValue? value) =>
        {
            value = null;
            throw new InvalidOperationException("boom-null");
        };
        TryGetCacheValue throwKeep = (string _, out CacheValue? value) =>
        {
            value = new CacheValue();
            throw new InvalidOperationException("boom-keep");
        };

        var memoryNull = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>();
        memoryNull.Setup(x => x.TryGet(It.IsAny<string>(), out It.Ref<CacheValue?>.IsAny))
            .Returns(throwNull);

        var memoryKeep = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>();
        memoryKeep.Setup(x => x.TryGet(It.IsAny<string>(), out It.Ref<CacheValue?>.IsAny))
            .Returns(throwKeep);

        var disk = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>();
        var logs = new Mock<IApplicationCacheLogRepository>();
        disk.Setup(x => x.SetAsync("with-null-tostring", It.IsAny<CachePropsNullToString>())).ReturnsAsync(true);
        logs.Setup(x => x.Create(It.IsAny<ApplicationCacheLog>())).ReturnsAsync(new ApplicationCacheLog());
        disk.Setup(x => x.TryGetAsync<ExpirableCacheEntry>("no-exp"))
            .ReturnsAsync(new KeyValuePair<bool, ExpirableCacheEntry>(true, new ExpirableCacheEntry
            {
                Data = "x",
                DateTimeSlidingExpiration = null!
            }));

        var memoryNullService = CreateCache(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Memory, memory: memoryNull);
        var memoryKeepService = CreateCache(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Memory, memory: memoryKeep);
        var diskService = CreateCache(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Disk, disk: disk, logs: logs);

        var tryGetNull = memoryNullService.TryGet("k", out CacheValue valueNull);
        var tryGetKeep = memoryKeepService.TryGet("k2", out CacheValue valueKeep);
        var set = diskService.Set("with-null-tostring", new CachePropsNullToString
        {
            CacheId = new NullToString(),
            DateTimeSlidingExpiration = DateTime.Now.AddMinutes(5).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
        });
        var existsNoExp = diskService.Exists<ExpirableCacheEntry>("no-exp");

        // Act

        // Assert
        using (Assert.EnterMultipleScope())
        {
            tryGetNull.Should().BeFalse();
            valueNull.Should().NotBeNull();
            tryGetKeep.Should().BeFalse();
            valueKeep.Should().NotBeNull();
            set.Should().BeTrue();
            existsNoExp.Should().BeTrue();
        }
        logs.Verify(x => x.Create(It.Is<ApplicationCacheLog>(l => l.CacheId == string.Empty)), Times.Once);
    }

    // Cenário: CancelOccurrence com SubjectKey do request e package.SubjectKey nulo; update com ScheduleData nulo e EndDateTime nulo.
    // Objetivo: fechar combinações do predicado L130 e Merge/ComputePeriod.
    [Test]
    public async Task ScheduleUpdate_CancelSubjectKeyAndNullEnd_CoverRemaining()
    {
        // Arrange
        var start = DateTime.UtcNow.Date.AddDays(4).AddHours(9);
        var item = new ScheduleCalendarItem
        {
            StartDateTime = start,
            EndDateTime = null!,
            Status = EStatusCalendar.PendingConfirmation,
            Title = "c"
        };
        var package = new ScheduleCalendar
        {
            Id = 9,
            UniqueToken = "pkg-9",
            SubjectKey = null!,
            ScheduleData = [item]
        };
        var repository = new Mock<IScheduleCalendarRepository>();
        var conflict = new Mock<IScheduleConflictService>();
        repository.Setup(x => x.GetItemAsync("medical", "medical:1", "patient:1", start))
            .ReturnsAsync(item);
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", start, It.IsAny<DateTime>()))
            .ReturnsAsync([package]);
        repository.Setup(x => x.Update(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => e);
        repository.Setup(x => x.GetByUniqueTokenAsync("upd-null-end"))
            .ReturnsAsync(new ScheduleCalendar { Id = 10, UniqueToken = "upd-null-end", ScheduleData = null! });
        conflict.Setup(x => x.HasNoConflictBatchAsync("medical", "medical:1", It.IsAny<ScheduleCalendarItem[]>(), "upd-null-end"))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<bool> { Success = true, Data = true });
        var service = new ScheduleUpdateService(repository.Object, conflict.Object, Mock.Of<IAppLogger>());

        // Act
        var canceledMatchingNullSubject = await service.CancelOccurrenceAsync(new ScheduleCancelRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            SubjectKey = "patient:1",
            AppointmentDateTime = start,
            Reason = "r"
        });
        var updated = await service.UpdateAsync(new ScheduleCalendarWriteRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            UniqueToken = "upd-null-end",
            IsUpdate = true,
            UpdateSeries = false,
            Items = [item]
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            canceledMatchingNullSubject.Success.Should().BeTrue();
            updated.Success.Should().BeTrue();
        }
    }

    // Cenário: HasNoConflictAsync retorna ok=true (mensagem vazia).
    // Objetivo: cobrir o braço true do ternário de Message.
    [Test]
    public async Task ScheduleConflict_NoConflict_MessageEmpty()
    {
        // Arrange
        var repository = new Mock<IScheduleCalendarRepository>();
        repository.Setup(x => x.GetOverlappingByOwnerAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync([]);
        var service = new ScheduleConflictService(repository.Object, Mock.Of<IAppLogger>());

        // Act
        var result = await service.HasNoConflictAsync(new Domain.Validation.Schedule.ScheduleCalendarConflictRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            StartDateTime = DateTime.UtcNow.AddDays(5),
            EndDateTime = DateTime.UtcNow.AddDays(5).AddHours(1)
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Data.Should().BeTrue();
            result.Message.Should().BeEmpty();
        }
    }

    // Cenário: mapper com preferEventDate + ScheduleData null/empty e booking com RecurrenceDays nulo.
    // Objetivo: fechar L132/L259 restantes.
    [Test]
    public void MedicalScheduleMapper_PreferDateNullScheduleAndNullNames_CoverRemaining()
    {
        // Arrange / Act
        // Arrange

        // Act
        var calendarNull = MedicalScheduleMapper.ToMedicalCalendarFromPackage(
            new ScheduleCalendar
            {
                Id = 1,
                OwnerKey = MedicalScheduleKeys.ForMedical(1),
                ScheduleData = null!
            },
            preferEventDate: DateTime.UtcNow);
        var calendarEmpty = MedicalScheduleMapper.ToMedicalCalendarFromPackage(
            new ScheduleCalendar
            {
                Id = 2,
                OwnerKey = MedicalScheduleKeys.ForMedical(1),
                ScheduleData = []
            },
            preferEventDate: DateTime.UtcNow);
        var calendarNoPrefer = MedicalScheduleMapper.ToMedicalCalendarFromPackage(
            new ScheduleCalendar
            {
                Id = 3,
                OwnerKey = MedicalScheduleKeys.ForMedical(1),
                ScheduleData =
                [
                    new ScheduleCalendarItem
                    {
                        StartDateTime = DateTime.UtcNow,
                        Title = "x",
                        RecurrenceDays = null!
                    }
                ]
            });

        var slot = MedicalScheduleMapper.ToTimeSlotDto(
            new ScheduleTimeSlotDto
            {
                StartTime = DateTime.UtcNow,
                Booking = new ScheduleCalendarItem
                {
                    Title = "T",
                    StartDateTime = DateTime.UtcNow,
                    SubjectKey = MedicalScheduleKeys.ForPatient(3),
                    RecurrenceDays = null!
                }
            },
            1,

            patientNames: null!);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            calendarNull.Id.Should().Be(1);
            calendarEmpty.Id.Should().Be(2);
            calendarNoPrefer.Id.Should().Be(3);
            slot.MedicalCalendar!.Patient!.Name.Should().Be("T");
            slot.MedicalCalendar.RecurrenceDays.Should().BeEmpty();
        }
    }

    // Cenário: MedicalFile FindByID com FilePath vazio, FileData nulo e FileName nulo via mapper.
    // Objetivo: cobrir FileName ?? string.Empty sem Path.Combine.
    [Test]
    public async Task MedicalFile_FindByID_EmptyPathNullFileNameAndData_UsesEmptyName()
    {
        // Arrange
        var shared = new ServiceTestContext();
        var mapper = new Mock<IAppMapper>();
        mapper.Setup(x => x.Map<GetMedicalFileDto>(It.IsAny<MedicalFile>()))
            .Returns(() =>
            {
                var dto = new GetMedicalFileDto
                {
                    Id = 8,
                    FilePath = string.Empty
                };
                dto.FileName = null!;
                dto.FileData = null!;
                return dto;
            });
        shared.ConfigMock.SetupGet(x => x.Mapper).Returns(mapper.Object);
        var repository = new Mock<IMedicalFileRepository>();
        repository.Setup(x => x.FindByID(8)).ReturnsAsync(new MedicalFile
        {
            Id = 8,
            MedicalId = 9,
            FileName = null!,
            FileData = null!,
            FilePath = string.Empty
        });
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
        result.Data.Should().NotBeNull();
        result.Data!.FileUrl.Should().NotBeNull();
    }

    // Cenário: refresh token igual mas expirado; Admin Language nulo; WorkingDays nulo.
    // Objetivo: fechar UserService L364/L499 e Constraints L64.
    [Test]
    public async Task UserService_ExpiredRefreshAndNullLanguage_CoverRemaining()
    {
        // Arrange
        var ctx = new UserServiceContext();
        SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreatePasswordHash("secret", out var hash, out var salt);
        var adminNoLang = new User
        {
            Id = 40,
            Login = "adminlang2",
            Name = "AdminLang2",
            PasswordHash = hash,
            PasswordSalt = salt,
            Medical = new MedicalEntity { Id = 88, Name = "Dr", Email = "d@t.com" },
            Admin = true,
            Language = null!,
            Role = null!,
            UserRoleGroups = []
        };
        ctx.Context.UserRepository.Setup(x => x.FindByLogin("adminlang2")).ReturnsAsync(adminNoLang);
        ctx.Context.UserRepository.Setup(x => x.RefreshUserInfo(It.IsAny<User>())).ReturnsAsync(adminNoLang);
        ctx.TokenService.Setup(x => x.GenerateAccessToken(It.IsAny<IEnumerable<Claim>>())).Returns("access");
        ctx.TokenService.Setup(x => x.GenerateRefreshToken()).Returns("refresh");
        ctx.TokenSessionService.Setup(x => x.GetSessionAsync(40)).Returns(Task.FromResult<UserTokenSession?>(null!));
        ctx.TokenSessionService.Setup(x => x.SaveSessionAsync(It.IsAny<UserTokenSession>())).Returns(Task.CompletedTask);
        ctx.TokenConfiguration.SetupGet(x => x.Minutes).Returns(30);
        ctx.TokenConfiguration.SetupGet(x => x.DaysToExpiry).Returns(7);

        var identity = new ClaimsIdentity([new Claim(ClaimTypes.Name, "41")], "TestAuth");
        var principal = new ClaimsPrincipal(identity);
        var expiredUser = new User
        {
            Id = 41,
            RefreshToken = "same-refresh",
            RefreshTokenExpiryTime = DateTime.UtcNow.AddMinutes(-5)
        };
        ctx.TokenService.Setup(x => x.GetPrincipalFromExpiredToken("acc")).Returns(principal);
        ctx.Context.UserRepository.Setup(x => x.FindByID(41)).ReturnsAsync(expiredUser);

        // Act
        var login = await ctx.Service.Login("adminlang2", "secret");
        var expired = await ctx.Service.validateCredentials(new TokenVO(true, "c", "e", "acc", "same-refresh"));
        var constraints = MedicalScheduleConstraintsProvider.ToConstraints(new MedicalEntity
        {
            Id = 1,
            Name = "Dr",
            WorkingDays = null!
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            login.Success.Should().BeTrue();
            login.Data!.MedicalId.Should().Be(88);
            login.Data.RoleGroups.Should().Contain(r => r.RolePolicyClaimCode == "Admin" && r.Language == string.Empty);
            expired.Authenticated.Should().BeFalse();
            constraints.WorkingDays.Should().BeEmpty();
        }
    }

    // Cenário: CancelOccurrence com SubjectKeys iguais; package ScheduleData nulo; mapper RecurrenceDays não nulo.
    // Objetivo: fechar L130 restantes e RecurrenceDays ??.
    [Test]
    public async Task ScheduleUpdateAndMapper_MatchingSubjectAndRecurrence_CoverRemaining()
    {
        // Arrange
        var start = DateTime.UtcNow.Date.AddDays(5).AddHours(11);
        var item = new ScheduleCalendarItem
        {
            StartDateTime = start,
            EndDateTime = start.AddMinutes(30),
            Status = EStatusCalendar.Confirmed,
            Title = "m",
            RecurrenceDays = [DayOfWeek.Monday]
        };
        var repository = new Mock<IScheduleCalendarRepository>();
        repository.Setup(x => x.GetItemAsync("medical", "medical:1", "patient:9", start)).ReturnsAsync(item);
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", start, It.IsAny<DateTime>()))
            .ReturnsAsync(
            [
                new ScheduleCalendar
                {
                    Id = 1,
                    UniqueToken = "match",
                    SubjectKey = "patient:9",
                    ScheduleData = [item]
                },
                new ScheduleCalendar
                {
                    Id = 2,
                    UniqueToken = "null-data",
                    SubjectKey = "patient:9",
                    ScheduleData = null!
                }
            ]);
        repository.Setup(x => x.Update(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => e);
        var service = new ScheduleUpdateService(repository.Object, Mock.Of<IScheduleConflictService>(), Mock.Of<IAppLogger>());

        // Act
        var canceled = await service.CancelOccurrenceAsync(new ScheduleCancelRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            SubjectKey = "patient:9",
            AppointmentDateTime = start,
            Reason = "r"
        });
        var slot = MedicalScheduleMapper.ToTimeSlotDto(
            new ScheduleTimeSlotDto
            {
                StartTime = start,
                Booking = item
            },
            1,
            patientNames: new Dictionary<long, string> { [9] = "Pat" });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            canceled.Success.Should().BeTrue();
            slot.MedicalCalendar!.RecurrenceDays.Should().Equal(DayOfWeek.Monday);
        }
    }

    // Cenário: Create/Delete sem InnerException; InsertLanguageNotFound com localization prévia; Table GetById lança.
    // Objetivo: fechar InnerException?. nulo, L137 e catch do TableAdapter.
    [Test]
    public async Task EntityLanguageAndTable_FinalBranches_Covered()
    {
        // Arrange
        var createCtx = new EntityBaseProbeContext();
        createCtx.Mapper.Setup(x => x.Map<Gender>(It.IsAny<AddGenderDto>())).Returns(new Gender());
        createCtx.Validator.Setup(x => x.ValidateAsync(It.IsAny<Gender>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        createCtx.Repository.Setup(x => x.Create(It.IsAny<Gender>()))
            .ThrowsAsync(new Exception("create-outer-only"));

        var deleteCtx = new EntityBaseProbeContext();
        deleteCtx.Repository.Setup(x => x.Exists(2)).ReturnsAsync(true);
        deleteCtx.Repository.Setup(x => x.Delete(2)).ThrowsAsync(new Exception("delete-outer-only"));

        var langCtx = new ApplicationLanguageProbeContext();
        langCtx.Cache.Setup(x => x.IsEnable()).Returns(false);
        langCtx.Repository.Setup(x => x.ExistLanguage("en-US", "KeepKey", "SharedResource")).ReturnsAsync(false);
        langCtx.Repository.Setup(x => x.Create(It.IsAny<ApplicationLanguage>()))
            .ReturnsAsync((ApplicationLanguage a) => { a.Id = 1; return a; });
        var insert = typeof(ApplicationLanguageService)
            .GetMethod("InsertLanguageNotFound", BindingFlags.Instance | BindingFlags.NonPublic)!;

        var tableClient = new Mock<Azure.Data.Tables.TableClient>();
        var boom = new Mock<NullableResponse<UserTokenSessionTableEntity>>();
        boom.SetupGet(x => x.HasValue).Returns(true);
        boom.SetupGet(x => x.Value).Throws(new InvalidOperationException("table-boom"));
        tableClient.Setup(x => x.GetEntityIfExistsAsync<UserTokenSessionTableEntity>(
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<IEnumerable<string>>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(boom.Object);
        var table = CreateTableAdapterWithClient(tableClient.Object);

        // Act
        var created = await createCtx.Service.Create(new AddGenderDto { Description = "g" });
        var deleted = await deleteCtx.Service.Delete(2);
        var kept = await (Task<string>)insert.Invoke(langCtx.Service, ["KeepKey", "def", "PREVIOUS", "cacheKey", "SharedResource"])!;
        var tableEntity = await table.GetByIdAsync("p", "r");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            created.Success.Should().BeFalse();
            created.Errors.Should().Contain(e => e.Message!.Contains("create-outer-only"));
            deleted.Success.Should().BeFalse();
            deleted.Errors.Should().Contain(e => e.Message!.Contains("delete-outer-only"));
            kept.Should().Be("PREVIOUS");
            tableEntity.Should().NotBeNull();
        }
    }

    // Cenário: ApplyFilters AvailableOnly com EndTime nulo.
    // Objetivo: cobrir slot.EndTime ?? slot.StartTime.
    [Test]
    public void ScheduleAvailability_NullEndTime_CoverBranch()
    {
        // Arrange

        // Act
        var apply = typeof(ScheduleAvailabilityService)
            .GetMethod("ApplyFilters", BindingFlags.Static | BindingFlags.NonPublic)!;
        var day = DateTime.UtcNow.Date.AddDays(2);
        while (day.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
            day = day.AddDays(1);
        var start = day.AddHours(10);
        var request = new ScheduleGradeRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            DisplayName = "Dr",
            TimeZone = "UTC",
            StartDate = day,
            EndDate = day.AddDays(1),
            Mode = ScheduleGradeMode.AvailableOnly,
            Constraints = new ScheduleOwnerConstraints
            {
                WorkingDays = [day.DayOfWeek],
                StartWorkingTime = TimeSpan.FromHours(8),
                EndWorkingTime = TimeSpan.FromHours(18),
                IntervalMinutes = 30,
                DisplayName = "Dr"
            }
        };
        var days = new[]
        {
            new ScheduleDayDto
            {
                Date = day,
                TimeSlots =
                [
                    new ScheduleTimeSlotDto
                    {
                        StartTime = start,
                        EndTime = null!,
                        IsAvailable = true,
                        IsPast = false,
                        Booking = null
                    }
                ]
            }
        };

        var filtered = (ScheduleDayDto[])apply.Invoke(null!, [request, days])!;

        // Assert
        filtered.Should().ContainSingle();

        filtered[0].TimeSlots.Should().ContainSingle();
    }

    // Cenário: ApplyFilters AvailableOnly com EndTime preenchido e nulo.
    // Objetivo: cobrir ambos os lados de slot.EndTime ?? slot.StartTime.
    [Test]
    public void ScheduleAvailability_EndTimeBothSides_CoverRemainingBranch()
    {
        // Arrange

        // Act
        var apply = typeof(ScheduleAvailabilityService)
            .GetMethod("ApplyFilters", BindingFlags.Static | BindingFlags.NonPublic)!;
        var day = DateTime.UtcNow.Date.AddDays(3);
        while (day.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
            day = day.AddDays(1);
        var start = day.AddHours(11);
        var request = new ScheduleGradeRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            DisplayName = "Dr",
            TimeZone = "UTC",
            StartDate = day,
            EndDate = day.AddDays(1),
            Mode = ScheduleGradeMode.AvailableOnly,
            Constraints = new ScheduleOwnerConstraints
            {
                WorkingDays = [day.DayOfWeek],
                StartWorkingTime = TimeSpan.FromHours(8),
                EndWorkingTime = TimeSpan.FromHours(18),
                IntervalMinutes = 30,
                DisplayName = "Dr"
            }
        };
        var days = new[]
        {
            new ScheduleDayDto
            {
                Date = day,
                TimeSlots =
                [
                    new ScheduleTimeSlotDto
                    {
                        StartTime = start,
                        EndTime = start.AddMinutes(30),
                        IsAvailable = true,
                        IsPast = false,
                        Booking = null
                    },
                    new ScheduleTimeSlotDto
                    {
                        StartTime = start.AddHours(1),
                        EndTime = null!,
                        IsAvailable = true,
                        IsPast = false,
                        Booking = null
                    }
                ]
            }
        };

        var filtered = (ScheduleDayDto[])apply.Invoke(null!, [request, days])!;

        // Assert
        filtered.Should().ContainSingle();

        filtered[0].TimeSlots.Length.Should().Be(2);
    }

    // Cenário: CancelOccurrence avalia SubjectKey igual/diferente e ScheduleData nulo/sem match.
    // Objetivo: fechar os jumps restantes do predicado L130 (sem short-circuit).
    [Test]
    public async Task ScheduleUpdate_CancelPredicate_AllSubjectAndDataCombos_CoverBranches()
    {
        // Arrange
        var start = DateTime.UtcNow.Date.AddDays(5).AddHours(10);
        var item = new ScheduleCalendarItem
        {
            StartDateTime = start,
            EndDateTime = start.AddMinutes(30),
            Status = EStatusCalendar.Confirmed,
            Title = "x"
        };
        var repository = new Mock<IScheduleCalendarRepository>();
        repository.Setup(x => x.GetItemAsync("medical", "medical:1", "patient:1", start)).ReturnsAsync(item);
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", start, It.IsAny<DateTime>()))
            .ReturnsAsync(
            [
                new ScheduleCalendar
                {
                    Id = 1,
                    UniqueToken = "mismatch",
                    SubjectKey = "patient:999",
                    ScheduleData = [item]
                },
                new ScheduleCalendar
                {
                    Id = 2,
                    UniqueToken = "null-data",
                    SubjectKey = "patient:1",
                    ScheduleData = null!
                },
                new ScheduleCalendar
                {
                    Id = 3,
                    UniqueToken = "wrong-start",
                    SubjectKey = "patient:1",
                    ScheduleData = [new ScheduleCalendarItem { StartDateTime = start.AddHours(2), Status = EStatusCalendar.Confirmed }]
                },
                new ScheduleCalendar
                {
                    Id = 4,
                    UniqueToken = "match",
                    SubjectKey = "patient:1",
                    ScheduleData = [item]
                }
            ]);
        repository.Setup(x => x.Update(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => e);
        var service = new ScheduleUpdateService(repository.Object, Mock.Of<IScheduleConflictService>(), Mock.Of<IAppLogger>());

        // Act
        var result = await service.CancelOccurrenceAsync(new ScheduleCancelRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            SubjectKey = "patient:1",
            AppointmentDateTime = start,
            Reason = "combo"
        });

        // Assert
        result.Success.Should().BeTrue();

        repository.Verify(x => x.Update(It.Is<ScheduleCalendar>(p => p.UniqueToken == "match")), Times.Once);
    }

    // Cenário: ToTimeSlotDto com RecurrenceDays/Count preenchidos e PatientId ausente.
    // Objetivo: cobrir ?? de RecurrenceDays/RecurrenceCount/PatientId no bookingDto.
    [Test]
    public void MedicalScheduleMapper_BookingRecurrenceAndPatient_CoverRemainingBranches()
    {
        // Arrange / Act
        // Arrange
        var start = DateTime.UtcNow;

        // Act
        var withRecurrence = MedicalScheduleMapper.ToTimeSlotDto(
            new ScheduleTimeSlotDto
            {
                StartTime = start,
                EndTime = start.AddMinutes(30),
                Booking = new ScheduleCalendarItem
                {
                    Title = "R",
                    StartDateTime = start,
                    SubjectKey = MedicalScheduleKeys.ForPatient(5),
                    RecurrenceDays = [DayOfWeek.Monday, DayOfWeek.Wednesday],
                    RecurrenceCount = 4,
                    TokenRecurrence = "tok"
                }
            },
            2,
            new Dictionary<long, string> { [5] = "Paciente 5" });
        var noPatient = MedicalScheduleMapper.ToTimeSlotDto(
            new ScheduleTimeSlotDto
            {
                StartTime = start,
                Booking = new ScheduleCalendarItem
                {
                    Title = "NoPatient",
                    StartDateTime = start,
                    SubjectKey = "   ",
                    RecurrenceDays = null!,
                    RecurrenceCount = null
                }
            },
            2,

            new Dictionary<long, string>());

        // Assert
        using (Assert.EnterMultipleScope())
        {
            withRecurrence.MedicalCalendar!.RecurrenceDays.Should().Contain(DayOfWeek.Monday);
            withRecurrence.MedicalCalendar.RecurrenceCount.Should().Be(4);
            withRecurrence.MedicalCalendar.Patient!.Name.Should().Be("Paciente 5");
            noPatient.MedicalCalendar!.PatientId.Should().BeNull();
            noPatient.MedicalCalendar.Patient!.Name.Should().Be("NoPatient");
            noPatient.MedicalCalendar.RecurrenceDays.Should().BeEmpty();
        }
    }

    // Cenário: EntityBase Create/Delete com InnerException e sem InnerException.
    // Objetivo: fechar InnerException?.Message nos catches de Create/Delete.
    [Test]
    public async Task EntityBaseService_CreateDelete_InnerExceptionBothSides_CoverBranches()
    {
        // Arrange
        var withInner = new EntityBaseProbeContext();
        withInner.Repository.Setup(x => x.Create(It.IsAny<Gender>()))
            .ThrowsAsync(new InvalidOperationException("outer-create", new Exception("inner-create")));
        withInner.Mapper.Setup(x => x.Map<Gender>(It.IsAny<AddGenderDto>())).Returns(new Gender());
        withInner.Validator.Setup(x => x.ValidateAsync(It.IsAny<Gender>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());

        var noInnerCreate = new EntityBaseProbeContext();
        noInnerCreate.Repository.Setup(x => x.Create(It.IsAny<Gender>()))
            .ThrowsAsync(new InvalidOperationException("outer-only-create"));
        noInnerCreate.Mapper.Setup(x => x.Map<Gender>(It.IsAny<AddGenderDto>())).Returns(new Gender());
        noInnerCreate.Validator.Setup(x => x.ValidateAsync(It.IsAny<Gender>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());

        var withInnerDelete = new EntityBaseProbeContext();
        withInnerDelete.Repository.Setup(x => x.Exists(9)).ReturnsAsync(true);
        withInnerDelete.Repository.Setup(x => x.Delete(9))
            .ThrowsAsync(new InvalidOperationException("outer-delete", new Exception("inner-delete")));

        var noInnerDelete = new EntityBaseProbeContext();
        noInnerDelete.Repository.Setup(x => x.Exists(10)).ReturnsAsync(true);
        noInnerDelete.Repository.Setup(x => x.Delete(10))
            .ThrowsAsync(new InvalidOperationException("outer-only-delete"));

        // Act
        var createInner = await withInner.Service.Create(new AddGenderDto { Description = "A" });
        var createPlain = await noInnerCreate.Service.Create(new AddGenderDto { Description = "B" });
        var deleteInner = await withInnerDelete.Service.Delete(9);
        var deletePlain = await noInnerDelete.Service.Delete(10);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            createInner.Errors.Should().ContainSingle(e => e.Message!.Contains("inner-create"));
            createPlain.Errors.Should().ContainSingle(e => e.Message!.Contains("outer-only-create"));
            deleteInner.Errors.Should().ContainSingle(e => e.Message!.Contains("inner-delete"));
            deletePlain.Errors.Should().ContainSingle(e => e.Message!.Contains("outer-only-delete"));
        }
    }

    // Cenário: MedicalFile FindByID com FileName nulo e não-nulo.
    // Objetivo: cobrir FileName ?? string.Empty.
    [Test]
    public async Task MedicalFile_FindByID_FileNameNullAndNonNull_CoverBranches()
    {
        // Arrange
        async Task<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<GetMedicalFileDto>> RunAsync(string? fileName)
        {
            var shared = new ServiceTestContext();
            var mapper = new Mock<IAppMapper>();
            mapper.Setup(x => x.Map<GetMedicalFileDto>(It.IsAny<MedicalFile>()))
                .Returns(() => new GetMedicalFileDto
                {
                    Id = 1,
                    FilePath = string.Empty,
                    FileName = fileName!,
                    FileData = null!
                });
            shared.ConfigMock.SetupGet(x => x.Mapper).Returns(mapper.Object);
            var repository = new Mock<IMedicalFileRepository>();
            repository.Setup(x => x.FindByID(1)).ReturnsAsync(new MedicalFile { Id = 1, MedicalId = 2, FilePath = string.Empty });
            var service = new MedicalFileService(
                shared.SharedServices,
                shared.Config,
                shared.SharedRepositories,
                repository.Object,
                Mock.Of<IValidator<MedicalFile>>(),
                Mock.Of<IFileManagerService>());
            return await service.FindByID(1);
        }

        // Act
        var nullName = await RunAsync(null!);
        var withName = await RunAsync("doc.pdf");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            nullName.Data.Should().NotBeNull();
            withName.Data.Should().NotBeNull();
        }
    }

    // Cenário: InsertLanguageNotFound com resultLocalization pré-preenchido; catch com valor mantido.
    // Objetivo: fechar lados não-vazios dos ternários L104/L137.
    [Test]
    public async Task ApplicationLanguage_PrefilledLocalization_CoverNonEmptyBranches()
    {
        // Arrange
        var previous = CultureInfo.CurrentCulture;
        CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
        try
        {
            var shared = new ServiceTestContext();
            var validator = new Mock<IValidator<ApplicationLanguage>>();
            validator.Setup(x => x.ValidateAsync(It.IsAny<ApplicationLanguage>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult());
            var service = new ApplicationLanguageService(
                shared.SharedServices,
                shared.Config,
                shared.SharedRepositories,
                shared.ApplicationLanguageRepository.Object,
                validator.Object);
            shared.ApplicationLanguageRepository.Setup(x => x.ExistLanguage("en-US", "KeepKey", "SharedResource"))
                .ReturnsAsync(false);
            shared.ApplicationLanguageRepository.Setup(x => x.Create(It.IsAny<ApplicationLanguage>()))
                .ReturnsAsync((ApplicationLanguage a) => { a.Id = 1; return a; });
            shared.Cache.Setup(x => x.IsEnable()).Returns(false);

            var insert = typeof(ApplicationLanguageService)
                .GetMethod("InsertLanguageNotFound", BindingFlags.Instance | BindingFlags.NonPublic)!;

            // Act
            var keepFromInsert = await (Task<string>)insert.Invoke(service,
                ["KeepKey", "def", "PREFILLED-VALUE", "FindAll_GetApplicationLanguageVO", "SharedResource"])!;

            // Assert
            keepFromInsert.Should().Be("PREFILLED-VALUE");
        }
        finally
        {
            CultureInfo.CurrentCulture = previous;
        }
    }

    // Cenário: Cache TryGet com fake que atribui out null/não-nulo e lança; Set com CacheId string e ToString nulo.
    // Objetivo: fechar ?? em L163/L230 com fake real (Moq pode não atribuir out ao lançar).
    [Test]
    public void CacheService_FakeNullOutAndCacheId_CoverRemainingBranches()
    {
        // Arrange
        var memoryNull = new ThrowingNullOutMemoryCache();
        var memoryKeep = new ThrowingKeepOutMemoryCache();
        var disk = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>();
        var logs = new Mock<IApplicationCacheLogRepository>();
        disk.Setup(x => x.SetAsync(It.IsAny<string>(), It.IsAny<CachePropsNullToString>())).ReturnsAsync(true);
        logs.Setup(x => x.Create(It.IsAny<ApplicationCacheLog>())).ReturnsAsync(new ApplicationCacheLog());
        var memoryNullService = new SmartDigitalPsico.Service.Infrastructure.CacheManager.CacheService(
            memoryNull,
            disk.Object,
            logs.Object,
            Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
            {
                TypeCache = global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Memory,
                IsEnable = true,
                AbsoluteExpirationInHours = 1,
                SlidingExpirationInMinutes = 5
            }));
        var memoryKeepService = new SmartDigitalPsico.Service.Infrastructure.CacheManager.CacheService(
            memoryKeep,
            disk.Object,
            logs.Object,
            Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
            {
                TypeCache = global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Memory,
                IsEnable = true,
                AbsoluteExpirationInHours = 1,
                SlidingExpirationInMinutes = 5
            }));
        var diskService = CreateCache(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Disk, disk: disk, logs: logs);

        var tryGetNull = memoryNullService.TryGet("k", out CacheValue valueNull);
        var tryGetKeep = memoryKeepService.TryGet("k2", out CacheValue valueKeep);
        var setOk = diskService.Set("id-ok", new CachePropsNullToString
        {
            CacheId = "real-cache-id",
            DateTimeSlidingExpiration = DateTime.Now.AddMinutes(5).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
        });
        var setNull = diskService.Set("id-null", new CachePropsNullToString
        {
            CacheId = new NullToString(),
            DateTimeSlidingExpiration = DateTime.Now.AddMinutes(5).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
        });

        // Act

        // Assert
        using (Assert.EnterMultipleScope())
        {
            tryGetNull.Should().BeFalse();
            valueNull.Should().NotBeNull();
            tryGetKeep.Should().BeFalse();
            valueKeep.Should().NotBeNull();
            setOk.Should().BeTrue();
            setNull.Should().BeTrue();
        }
        logs.Verify(x => x.Create(It.Is<ApplicationCacheLog>(l => l.CacheId == "real-cache-id")), Times.Once);
        logs.Verify(x => x.Create(It.Is<ApplicationCacheLog>(l => l.CacheId == string.Empty)), Times.AtLeastOnce);
    }

    // Cenário: InsertLanguageNotFound com localization vazia/prévia; refresh válido e expiry nulo; Cancel SubjectKey nulo.
    // Objetivo: fechar L137, UserService L364 (incl. DateTime? null!) e predicado SubjectKey nulo.
    [Test]
    public async Task LocalizationUserAndCancel_FinalBranchSides_Covered()
    {
        // Arrange — InsertLanguageNotFound both sides of IsNullOrEmpty ternary
        var langCtx = new ApplicationLanguageProbeContext();
        langCtx.Cache.Setup(x => x.IsEnable()).Returns(false);
        langCtx.Repository.Setup(x => x.ExistLanguage("en-US", It.IsAny<string>(), "SharedResource")).ReturnsAsync(false);
        langCtx.Repository.Setup(x => x.Create(It.IsAny<ApplicationLanguage>()))
            .ReturnsAsync((ApplicationLanguage a) => { a.Id = 1; return a; });
        var insert = typeof(ApplicationLanguageService)
            .GetMethod("InsertLanguageNotFound", BindingFlags.Instance | BindingFlags.NonPublic)!;

        // Valid refresh (token match + future expiry)
        var userCtx = new UserServiceContext();
        var identity = new ClaimsIdentity([new Claim(ClaimTypes.Name, "77")], "TestAuth");
        var principal = new ClaimsPrincipal(identity);
        var user = new User
        {
            Id = 77,
            RefreshToken = "good-refresh",
            RefreshTokenExpiryTime = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc().AddDays(3)
        };
        userCtx.TokenService.Setup(x => x.GetPrincipalFromExpiredToken("acc77")).Returns(principal);
        userCtx.Context.UserRepository.Setup(x => x.FindByID(77)).ReturnsAsync(user);
        userCtx.TokenService.Setup(x => x.GenerateAccessToken(principal.Claims)).Returns("new-a");
        userCtx.TokenService.Setup(x => x.GenerateRefreshToken()).Returns("new-r");
        userCtx.Context.UserRepository.Setup(x => x.RefreshUserInfo(user)).ReturnsAsync(user);
        userCtx.TokenConfiguration.SetupGet(x => x.Minutes).Returns(20);

        // RefreshTokenExpiryTime null — HasValue false rejects refresh
        var nullExpiryCtx = new UserServiceContext();
        var identityNull = new ClaimsIdentity([new Claim(ClaimTypes.Name, "78")], "TestAuth");
        var principalNull = new ClaimsPrincipal(identityNull);
        var userNullExpiry = new User
        {
            Id = 78,
            RefreshToken = "null-exp-refresh",
            RefreshTokenExpiryTime = null
        };
        nullExpiryCtx.TokenService.Setup(x => x.GetPrincipalFromExpiredToken("acc78")).Returns(principalNull);
        nullExpiryCtx.Context.UserRepository.Setup(x => x.FindByID(78)).ReturnsAsync(userNullExpiry);
        nullExpiryCtx.TokenService.Setup(x => x.GenerateAccessToken(principalNull.Claims)).Returns("new-a78");
        nullExpiryCtx.TokenService.Setup(x => x.GenerateRefreshToken()).Returns("new-r78");
        nullExpiryCtx.Context.UserRepository.Setup(x => x.RefreshUserInfo(userNullExpiry)).ReturnsAsync(userNullExpiry);
        nullExpiryCtx.TokenConfiguration.SetupGet(x => x.Minutes).Returns(20);

        // Cancel with request.SubjectKey null
        var start = DateTime.UtcNow.Date.AddDays(6).AddHours(9);
        var item = new ScheduleCalendarItem
        {
            StartDateTime = start,
            EndDateTime = start.AddMinutes(30),
            Status = EStatusCalendar.PendingConfirmation,
            Title = "n"
        };
        var repository = new Mock<IScheduleCalendarRepository>();
        repository.Setup(x => x.GetItemAsync("medical", "medical:1", It.Is<string?>(s => s == null!), start))
            .ReturnsAsync(item);
        repository.Setup(x => x.GetOverlappingByOwnerAsync("medical", "medical:1", start, It.IsAny<DateTime>()))
            .ReturnsAsync(
            [
                new ScheduleCalendar
                {
                    Id = 1,
                    UniqueToken = "null-subject-req",
                    SubjectKey = "patient:1",
                    ScheduleData = [item]
                }
            ]);
        repository.Setup(x => x.Update(It.IsAny<ScheduleCalendar>())).ReturnsAsync((ScheduleCalendar e) => e);
        var schedule = new ScheduleUpdateService(repository.Object, Mock.Of<IScheduleConflictService>(), Mock.Of<IAppLogger>());

        // Act
        var emptySide = await (Task<string>)insert.Invoke(langCtx.Service,
            ["EmptyKey", "def", "", "FindAll_GetApplicationLanguageVO", "SharedResource"])!;
        var keepSide = await (Task<string>)insert.Invoke(langCtx.Service,
            ["KeepKey", "def", "PREVIOUS", "FindAll_GetApplicationLanguageVO", "SharedResource"])!;
        var renewed = await userCtx.Service.validateCredentials(new TokenVO(true, "c", "e", "acc77", "good-refresh"));
        var renewedNullExpiry = await nullExpiryCtx.Service.validateCredentials(
            new TokenVO(true, "c", "e", "acc78", "null-exp-refresh"));
        var canceled = await schedule.CancelOccurrenceAsync(new ScheduleCancelRequest
        {
            TenantKey = "medical",
            OwnerKey = "medical:1",
            SubjectKey = null!,
            AppointmentDateTime = start,
            Reason = "n"
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            emptySide.Should().Contain("NotFoundLocalizationButInsertedDefault");
            keepSide.Should().Be("PREVIOUS");
                        renewed.Authenticated.Should().BeTrue();
            renewed.AccessToken.Should().Be("new-a");
            // null RefreshTokenExpiryTime: !HasValue rejects refresh
            renewedNullExpiry.Authenticated.Should().BeFalse();
            canceled.Success.Should().BeTrue();
        }
    }

    // Cenário: ResolveBlobName com BlobName vazio e preenchido.
    // Objetivo: cobrir ambos os lados do ternário IsNullOrEmpty.
    [Test]
    public void AzureBlobAdapter_ResolveBlobName_BothSides()
    {
        // Arrange
        var fromPath = SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter.ResolveBlobName(null!, @"C:\temp\file.pdf");
        var fromPathEmpty = SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter.ResolveBlobName("", @"C:\temp\file.pdf");
        var fromName = SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter.ResolveBlobName("explicit.bin", @"C:\temp\file.pdf");

        // Act

        // Assert
        using (Assert.EnterMultipleScope())
        {
            fromPath.Should().Be("file.pdf");
            fromPathEmpty.Should().Be("file.pdf");
            fromName.Should().Be("explicit.bin");
        }
    }

    // Cenário: Azure Table GetByIdAsync com Value nulo via mock (HasValue false).
    // Objetivo: cobrir response.Value ?? new T() / catch sem Azurite.
    [Test]
    public async Task AzureTableAdapter_GetById_NullValue_CoverCoalesceBranch()
    {
        // Arrange
        var tableClient = new Mock<TableClient>();
        var nullable = new Mock<NullableResponse<UserTokenSessionTableEntity>>();
        nullable.SetupGet(x => x.HasValue).Returns(false);
        nullable.SetupGet(x => x.Value).Returns((UserTokenSessionTableEntity)null!);
        tableClient
            .Setup(x => x.GetEntityIfExistsAsync<UserTokenSessionTableEntity>(
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<IEnumerable<string>>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(nullable.Object);
        var table = CreateTableAdapterWithClient(tableClient.Object);

        // Act
        var missing = await table.GetByIdAsync("pk", "rk");

        // Assert
        missing.Should().NotBeNull();
    }

    private static SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageTableAdapter<UserTokenSessionTableEntity> CreateTableAdapterWithClient(TableClient client)
        => new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageTableAdapter<UserTokenSessionTableEntity>(client);

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

    private sealed class CachePropsNullToString
    {
        public object? CacheId { get; set; }
        public string? DateTimeSlidingExpiration { get; set; }
    }

    private sealed class NullToString
    {
        public override string? ToString() => null;
    }

    private delegate bool TryGetCacheValue(string key, out CacheValue? value);

    private sealed class CacheValue
    {
    }

    private sealed class ExpirableCacheEntry
    {
        public string? Data { get; set; }
        public string? DateTimeSlidingExpiration { get; set; }
    }

    private sealed class ThrowingNullOutMemoryCache : global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository
    {
        public bool TryGet<T>(string cacheKey, out T? value)
        {
            value = default;
            throw new InvalidOperationException("null-out-then-throw");
        }

        public bool Set<T>(string cacheKey, T value) => false;

        public bool Set<T>(string cacheKey, T value, MemoryCacheEntryOptions memoryCacheEntryOptions) => false;

        public bool Remove(string cacheKey) => false;
    }

    private sealed class ThrowingKeepOutMemoryCache : global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository
    {
        public bool TryGet<T>(string cacheKey, out T? value)
        {
            value = (T)(object)new CacheValue();
            throw new InvalidOperationException("keep-out-then-throw");
        }

        public bool Set<T>(string cacheKey, T value) => false;

        public bool Set<T>(string cacheKey, T value, MemoryCacheEntryOptions memoryCacheEntryOptions) => false;

        public bool Remove(string cacheKey) => false;
    }

    private sealed class EntityBaseProbeContext
    {
        public ServiceTestContext Shared { get; } = new();
        public Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<Gender>> Repository { get; } = new();
        public Mock<IValidator<Gender>> Validator { get; } = new();
        public Mock<IAppMapper> Mapper { get; } = new();
        public SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<Gender, GetGenderDto> Service { get; }

        public EntityBaseProbeContext()
        {
            Shared.ConfigMock.SetupGet(x => x.Mapper).Returns(Mapper.Object);
            // Retry imediato (delay 0) para não estourar o host em suítes longas.
            Shared.ConfigMock.SetupGet(x => x.PolicyConfig)
                .Returns(new SmartDigitalPsico.Core.SDK.Domain.Resiliency.ResiliencePolicyConfig
                {
                    PolicyName = "CustomRetryPolicy",
                    RetryCount = 1,
                    RetryDelayInSeconds = 0
                });
            Service = new SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<Gender, GetGenderDto>(
                Shared.SharedServices,
                Shared.Config,
                Shared.SharedRepositories,
                Repository.Object,
                Validator.Object);
        }
    }

    private sealed class ApplicationLanguageProbeContext
    {
        public ServiceTestContext Shared { get; } = new();
        public Mock<IApplicationLanguageRepository> Repository => Shared.ApplicationLanguageRepository;
        public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService> Cache => Shared.Cache;
        public ApplicationLanguageService Service { get; }

        public ApplicationLanguageProbeContext()
        {
            var validator = new Mock<IValidator<ApplicationLanguage>>();
            validator.Setup(x => x.ValidateAsync(It.IsAny<ApplicationLanguage>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult());
            Service = new ApplicationLanguageService(
                Shared.SharedServices,
                Shared.Config,
                Shared.SharedRepositories,
                Repository.Object,
                validator.Object);
        }
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

        public EntityProbeContext()
        {
            var shared = new ServiceTestContext();
            shared.ConfigMock.SetupGet(x => x.Mapper).Returns(Mapper.Object);
            Service = new ProbeEntityBaseService(
                shared.SharedServices,
                shared.Config,
                shared.SharedRepositories,
                Repository.Object,
                Validator.Object);
        }
    }

    private sealed class ProbeEntityBaseService : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<Gender, GetGenderDto>
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
}
