using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.Json;
using Azure.Storage.Blobs.Models;
using SmartDigitalPsico.Domain.Contracts;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Newtonsoft.Json;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Domain.DTO.User.ADD;
using SmartDigitalPsico.Domain.DTO.User.GET;
using SmartDigitalPsico.Domain.DTO.User.UPDATE;
using SmartDigitalPsico.Domain.DTO.User.Common;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using TextJson = System.Text.Json.JsonSerializer;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Filters;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.Resiliency;
using SmartDigitalPsico.Domain.Validation.Base;
using SmartDigitalPsico.Domain.Validation.DTO;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.Principals.Calendar;
using SmartDigitalPsico.Domain.Validation.Principals.Schedule;
using SmartDigitalPsico.Domain.Validation.Schedule;

using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Test.Helpers;

[TestFixture]
public class DomainRemainingCoverageTests
{
    private static readonly JsonSerializerOptions DescribedEnumJsonOptions = CreateDescribedEnumJsonOptions();

    private static JsonSerializerOptions CreateDescribedEnumJsonOptions()
    {
        var options = new JsonSerializerOptions();
        options.Converters.Add(new SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<DescribedEnum>());
        return options;
    }
    // Cenário: recorrências paralelas e sequenciais atingem filtros, limites e datas expiradas.
    // Objetivo: cobrir retornos antecipados restantes do RecurrenceMaterializer.
    [Test]
    public void RecurrenceMaterializer_EdgeBranches_CoversRemainingLines()
    {
        // Arrange
        var wednesday = new DateTime(2025, 1, 8, 10, 0, 0); // Wednesday
        var monday = new DateTime(2025, 1, 6, 9, 0, 0);

        // Act
        var weeklyBeforeStart = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = wednesday,
            EndDateTime = wednesday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Weekly,
            RecurrenceDays = [DayOfWeek.Monday, DayOfWeek.Wednesday],
            RecurrenceCount = 2,
            MaxOccurrences = 10
        });
        var weeklyEndDateCutoff = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Weekly,
            RecurrenceDays = [DayOfWeek.Monday, DayOfWeek.Friday],
            RecurrenceEndDate = monday.AddDays(2),
            RecurrenceCount = 20,
            MaxOccurrences = 20
        });
        var weeklyCountLimitMidWeek = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Weekly,
            RecurrenceDays = [DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday],
            RecurrenceCount = 1,
            MaxOccurrences = 10
        });
        var weeklyExpiredEnd = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Weekly,
            RecurrenceDays = [DayOfWeek.Monday],
            RecurrenceEndDate = monday.AddDays(-7),
            RecurrenceCount = 5
        });
        var parallelPastEnd = InvokeDailyParallelPastEndDate();
        var sequentialDaily = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Daily,
            RecurrenceDays = [DayOfWeek.Tuesday],
            MaxOccurrences = 10
        });
        var sequentialWeeklyLimited = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Weekly,
            RecurrenceDays = [DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday],
            MaxOccurrences = 1
        });
        var beforeStartItems = InvokeTryAddWeeklyBeforeStart();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            weeklyBeforeStart.Should().OnlyContain(item => item.StartDateTime >= wednesday);
            weeklyEndDateCutoff.Should().OnlyContain(item => item.StartDateTime.Date <= monday.AddDays(2).Date);
            weeklyCountLimitMidWeek.Should().ContainSingle();
            weeklyExpiredEnd.Should().BeEmpty();
            parallelPastEnd.Should().NotContain(item => item.StartDateTime.Date > new DateTime(2025, 1, 1));
            sequentialDaily.Should().BeEmpty();
            sequentialWeeklyLimited.Should().ContainSingle();
            beforeStartItems.Should().BeEmpty();
            ScheduleParallel.MapParallelThreshold.Should().Be(ScheduleParallel.CpuCount);
        }
    }

    // Cenário: a janela diária possui intervalos ocupados que se sobrepõem ao dia.
    // Objetivo: ordenar busy intervals e gerar slots disponíveis.
    [Test]
    public void TimeSlotGenerator_OverlappingBusyIntervals_OrdersAndMarksUnavailable()
    {
        // Arrange
        var date = new DateTime(2025, 3, 1);
        var busy = new List<(DateTime Start, DateTime End)>
        {
            (date.AddHours(11), date.AddHours(12)),
            (date.AddHours(9), date.AddHours(10))
        };

        // Act
        var slots = TimeSlotGenerator.Generate(new TimeSlotWindow
        {
            Date = date,
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(13),
            Interval = TimeSpan.FromHours(1)
        }, busy, date.AddHours(-1), allowParallel: false);

        // Assert
        slots.Single(slot => slot.StartTime == date.AddHours(9)).IsAvailable.Should().BeFalse();
        slots.Single(slot => slot.StartTime == date.AddHours(11)).IsAvailable.Should().BeFalse();
        ScheduleKeyHelper.Build("MedicalId:", 9).Should().Be("MedicalId:9");
        ((Action)(() => ScheduleKeyHelper.Build(" ", 1))).Should().Throw<ArgumentException>();
    }

    // Cenário: serialização dispara erro tratado e login aninhado vazio.
    // Objetivo: executar o handler Error e o retorno string.Empty do helper de auditoria.
    [Test]
    public void AuditLogHelper_SerializationErrorAndEmptyNestedName_HandlesSafely()
    {
        // Arrange
        var settings = AuditLogHelper.GetJsonSettings();
        var previous = new { ModifyUser = new { Name = string.Empty } };
        var current = new { Id = 3L, UserId = (long?)4 };

        // Act
        var json = JsonConvert.SerializeObject(new ThrowingJsonModel(), settings);
        var entry = AuditLogHelper.CreateAuditEntry(previous, current, "Update", []);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            json.Should().NotBeNull();
            entry.UserAuditedLogin.Should().Be("admin");
        }
    }

    // Cenário: planilha com CustomSheetView e colunas explícitas.
    // Objetivo: cobrir inserção de merge após CustomSheetView e BestFit em colunas.
    [Test]
    public async Task ExcelGenerator_CustomSheetViewAndColumns_CoversMergeAndBestFit()
    {
        // Arrange
        var temp = Path.Combine(Path.GetTempPath(), $"sdp-excel-{Guid.NewGuid():N}");
        Directory.CreateDirectory(temp);
        var output = Path.Combine(temp, "custom.xlsx");
        try
        {
            InvokeAddSheetWithCustomSheetView(output);
            InvokeAddBestFitWithColumns(output);

            var adapter = new SmartDigitalPsico.Core.SDK.Domain.Report.ExcelGeneratorOpenXmlAdapter();

            // Act
            await adapter.Generate(new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportWorkbookDataDto
            {
                Sheets = [new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportSheetDataDto { Name = "A", Rows = [new { Value = 1 }] }]
            }, Path.Combine(temp, "plain.xlsx"));

            // Assert
            File.Exists(output).Should().BeTrue();
        }
        finally
        {
            Directory.Delete(temp, true);
        }
    }

    // Cenário: o filtro hypermedia encontra um enricher compatível.
    // Objetivo: executar Enrich quando CanEnrich retorna verdadeiro.
    [Test]
    public void HyperMediaFilterAttribute_MatchingEnricher_InvokesEnrich()
    {
        // Arrange
        var enricher = new TestEnricher();
        var filter = new HyperMediaFilterrAttribute(new HyperMediaFilterOptions
        {
            ContentResponseEnricherList = [enricher]
        });

        // Act
        filter.OnResultExecuting(CreateResultContext(new GetUserDto()));

        // Assert
        enricher.Enriched.Should().Be(1);
    }

    // Cenário: critérios de agenda no tipo Schedule com horário válido.
    // Objetivo: executar When(Schedule) e BeWithinWorkingHours até o retorno final.
    [Test]
    public async Task ScheduleCriteriaDtoValidator_ScheduleTypeAndWorkingHours_ValidatesRules()
    {
        // Arrange
        var appointment = DateTime.UtcNow.Date.AddDays(5).AddHours(10);
        var patientRepository = new Mock<IPatientRepository>();
        var medicalRepository = new Mock<IMedicalRepository>();
        var scheduleRepository = new Mock<IScheduleCalendarRepository>();
        var keys = new Mock<IScheduleKeyPolicy>();
        keys.SetupGet(policy => policy.TenantKey).Returns("tenant");
        keys.Setup(policy => policy.BuildOwnerKey(It.IsAny<long>())).Returns("owner");
        keys.Setup(policy => policy.BuildSubjectKey(It.IsAny<long>())).Returns("subject");
        patientRepository.Setup(repository => repository.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<Patient, bool>>>()))
            .ReturnsAsync([new Patient()]);
        medicalRepository.Setup(repository => repository.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<Medical, bool>>>()))
            .ReturnsAsync([new Medical
            {
                WorkingDays = [appointment.DayOfWeek],
                StartWorkingTime = TimeSpan.FromHours(8),
                EndWorkingTime = TimeSpan.FromHours(18)
            }]);
        scheduleRepository.Setup(repository => repository.HasConflictAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>()))
            .ReturnsAsync(false);
        var validator = new ScheduleCriteriaDtoValidator(scheduleRepository.Object, patientRepository.Object, medicalRepository.Object, keys.Object);
        var criteria = new ScheduleCriteriaDto
        {
            MedicalId = 1,
            PatientId = 2,
            AppointmentDateTime = appointment,
            TimeZone = "UTC",
            Reason = "Consulta",
            ScheduleType = EScheduleCalendarType.Schedule
        };

        // Act
        var withinHours = await InvokeBoolAsync(validator, "BeWithinWorkingHours", criteria, CancellationToken.None);
        var result = await validator.ValidateAsync(criteria);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            withinHours.Should().BeTrue();
            result.Errors.Should().NotContain(error => error.ErrorMessage.Contains("OutsideWorkingHours"));
        }
    }

    // Cenário: item de agenda com dias de recorrência e médico em expediente.
    // Objetivo: cobrir BeValidDays e ramos positivos de working day/hours.
    [Test]
    public async Task ScheduleItemValidator_ValidDaysAndWorkingWindow_IsAccepted()
    {
        // Arrange
        var start = DateTime.UtcNow.Date.AddDays(2).AddHours(9);
        var medicalRepository = new Mock<IMedicalRepository>();
        medicalRepository.Setup(repository => repository.FindByID(5)).ReturnsAsync(new Medical
        {
            WorkingDays = [start.DayOfWeek],
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(18)
        });
        var validator = new ScheduleItemValidator(medicalRepository.Object);
        var item = new ScheduleItem
        {
            MedicalId = 5,
            PatientId = 1,
            Title = "Consulta",
            StartDateTime = start,
            EndDateTime = start.AddHours(1),
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = [DayOfWeek.Monday, DayOfWeek.Friday],
            RecurrenceType = ERecurrenceCalendarType.Weekly
        };

        // Act
        var result = await validator.ValidateAsync(item);
        var validDays = InvokeBool(validator, "BeValidDays", item.RecurrenceDays);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            validDays.Should().BeTrue();
            result.Errors.Should().NotContain(error => error.PropertyName.Contains("RecurrenceDays"));
        }
    }

    // Cenário: contexto de validação possui itens existentes, sobrepostos, vazios ou nulos.
    // Objetivo: distinguir ausência de conflito de sobreposição real.
    [Test]
    public async Task ScheduleItemValidationContextValidator_ExistingItemsPresent_ReturnsValid()
    {
        // Arrange
        var validator = new ScheduleItemValidationContextValidator();
        var start = DateTime.UtcNow.Date.AddHours(9);
        var noOverlap = new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start, EndDateTime = start.AddHours(1) },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start.AddHours(2), EndDateTime = start.AddHours(3) }]
        };
        var overlapping = new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start, EndDateTime = start.AddHours(2) },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start.AddHours(1), EndDateTime = start.AddHours(3) }]
        };
        var withNull = new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start, EndDateTime = start.AddHours(1) },
            ExistingItems = null!
        };
        var empty = new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start, EndDateTime = start.AddHours(1) },
            ExistingItems = []
        };

        // Act
        var noOverlapResult = await validator.ValidateAsync(noOverlap);
        var overlappingResult = await validator.ValidateAsync(overlapping);
        var withNullResult = await validator.ValidateAsync(withNull);
        var emptyResult = await validator.ValidateAsync(empty);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            noOverlapResult.IsValid.Should().BeTrue();
            overlappingResult.IsValid.Should().BeFalse();
            withNullResult.IsValid.Should().BeTrue();
            emptyResult.IsValid.Should().BeTrue();
        }
    }

    // Cenário: horário fora do expediente e cancelamento fora da janela/status.
    // Objetivo: cobrir ramos negativos restantes do ScheduleCriteriaDtoValidator.
    [Test]
    public async Task ScheduleCriteriaDtoValidator_OutsideHoursAndInvalidCancel_ReturnFalse()
    {
        // Arrange
        var appointment = DateTime.UtcNow.Date.AddDays(5).AddHours(20);
        var patientRepository = new Mock<IPatientRepository>();
        var medicalRepository = new Mock<IMedicalRepository>();
        var scheduleRepository = new Mock<IScheduleCalendarRepository>();
        var keys = new Mock<IScheduleKeyPolicy>();
        keys.SetupGet(policy => policy.TenantKey).Returns("tenant");
        keys.Setup(policy => policy.BuildOwnerKey(It.IsAny<long>())).Returns("owner");
        keys.Setup(policy => policy.BuildSubjectKey(It.IsAny<long>())).Returns("subject");
        medicalRepository.Setup(repository => repository.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<Medical, bool>>>()))
            .ReturnsAsync([new Medical
            {
                WorkingDays = [appointment.DayOfWeek],
                StartWorkingTime = TimeSpan.FromHours(8),
                EndWorkingTime = TimeSpan.FromHours(12)
            }]);
        scheduleRepository.Setup(repository => repository.GetItemAsync(
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string?>(), It.IsAny<DateTime>()))
            .ReturnsAsync(new ScheduleCalendarItem
            {
                StartDateTime = DateTime.UtcNow.AddHours(1),
                TimeZone = "UTC",
                Status = EStatusCalendar.Completed
            });
        var validator = new ScheduleCriteriaDtoValidator(scheduleRepository.Object, patientRepository.Object, medicalRepository.Object, keys.Object);
        var criteria = new ScheduleCriteriaDto
        {
            MedicalId = 1,
            PatientId = 2,
            AppointmentDateTime = appointment,
            TimeZone = "UTC",
            ScheduleType = EScheduleCalendarType.Cancellation
        };

        // Act
        var outsideHours = await InvokeBoolAsync(validator, "BeWithinWorkingHours", criteria, CancellationToken.None);
        var invalidCancel = await InvokeBoolAsync(validator, "HaveValidStatusForCancellation", criteria, CancellationToken.None);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            outsideHours.Should().BeFalse();
            invalidCancel.Should().BeFalse();
        }
    }

    // Cenário: calendário de item possui dias de recorrência válidos.
    // Objetivo: cobrir BeValidDays do ScheduleCalendarItemValidator.
    [Test]
    public async Task ScheduleCalendarItemValidator_ValidRecurrenceDays_IsAccepted()
    {
        // Arrange
        var validator = new ScheduleCalendarItemValidator();
        var item = new ScheduleCalendarItem
        {
            Title = "Recorrente",
            StartDateTime = DateTime.UtcNow.AddDays(1),
            EndDateTime = DateTime.UtcNow.AddDays(1).AddHours(1),
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = [DayOfWeek.Monday],
            RecurrenceType = ERecurrenceCalendarType.Weekly
        };

        // Act
        var result = await validator.ValidateAsync(item);

        // Assert
        result.Errors.Should().NotContain(error => error.PropertyName.Contains("RecurrenceDays"));
    }

    // Cenário: medical id do critério diverge ou a consulta falha.
    // Objetivo: cobrir sucesso e catch de CalendarCriteriaValidator.
    [Test]
    public async Task CalendarCriteriaValidator_MedicalIdScenarios_ReturnsExpectedValidity()
    {
        // Arrange
        var okUsers = new Mock<IUserRepository>();
        okUsers.Setup(repository => repository.FindByID(1)).ReturnsAsync(new User { MedicalId = 9 });
        var okValidator = new CalendarCriteriaValidator(okUsers.Object);
        var faultedUsers = new Mock<IUserRepository>();
        faultedUsers.Setup(repository => repository.FindByID(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException());
        var faultedValidator = new CalendarCriteriaValidator(faultedUsers.Object);
        var matching = new CalendarCriteriaDto { UserIdLogged = 1, MedicalId = 9 };
        var mismatch = new CalendarCriteriaDto { UserIdLogged = 1, MedicalId = 2 };

        // Act
        var ok = await InvokeBoolAsync(okValidator, "IsValidMedicalId", matching, CancellationToken.None);
        var invalid = await InvokeBoolAsync(okValidator, "IsValidMedicalId", mismatch, CancellationToken.None);
        var faulted = await InvokeBoolAsync(faultedValidator, "IsValidMedicalId", matching, CancellationToken.None);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            ok.Should().BeTrue();
            invalid.Should().BeFalse();
            faulted.Should().BeFalse();
        }
    }

    // Cenário: PatientBase/MedicalBase com ids inalterados, medical nulo e modify sem id.
    // Objetivo: cobrir fechamentos de if e retornos true/false restantes.
    [Test]
    public async Task BaseValidators_UnchangedIdsAndNullMedical_ReturnExpectedBooleans()
    {
        // Arrange
        var medicalEntities = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalCalendar>>();
        medicalEntities.Setup(repository => repository.Exists(1)).ReturnsAsync(true);
        medicalEntities.Setup(repository => repository.FindByID(1)).ReturnsAsync(new MedicalCalendar { Id = 1, MedicalId = 10 });
        var medicalValidator = new MedicalBaseValidator<MedicalCalendar>(
            Mock.Of<IMedicalRepository>(), medicalEntities.Object, Mock.Of<IUserRepository>());

        var patientEntities = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<PatientRecord>>();
        patientEntities.Setup(repository => repository.Exists(1)).ReturnsAsync(true);
        patientEntities.Setup(repository => repository.FindByID(10)).ReturnsAsync(new PatientRecord { PatientId = 10 });
        var patients = new Mock<IPatientRepository>();
        patients.Setup(repository => repository.FindByID(10)).ReturnsAsync(new Patient { Medical = null });
        patients.Setup(repository => repository.FindByID(11))
            .ReturnsAsync(new Patient { Medical = new Medical { UserId = 99 } });
        var patientValidator = new PatientBaseValidator<PatientRecord>(patients.Object, patientEntities.Object);

        // Act
        var medicalUnchanged = await medicalValidator.MedicalIdChanged(new MedicalCalendar { Id = 1, MedicalId = 10 });
        var medicalModifyNew = await medicalValidator.MedicalModify(new MedicalCalendar { Id = 0, MedicalId = 10 }, 0, 1);
        var patientUnchanged = await patientValidator.PatientIdChanged(new PatientRecord { Id = 1, PatientId = 10 });
        var patientCreatedNullMedical = await patientValidator.MedicalCreated(new PatientRecord { PatientId = 10 }, 1);
        var patientCreatedMismatch = await patientValidator.MedicalCreated(new PatientRecord { PatientId = 11 }, 1);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            medicalUnchanged.Should().BeTrue();
            medicalModifyNew.Should().BeTrue();
            patientUnchanged.Should().BeTrue();
            patientCreatedNullMedical.Should().BeTrue();
            patientCreatedMismatch.Should().BeFalse();
        }
    }

    // Cenário: o validador base de lista encontra falha no repositório.
    // Objetivo: cobrir o catch de RecordsListValidator.HasPermissionAsync.
    [Test]
    public async Task RecordsListValidator_RepositoryThrows_ReturnsPermissionFailure()
    {
        // Arrange
        var repository = new Mock<IUserRepository>();
        repository.Setup(value => value.FindByID(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException("db"));
        var validator = new RecordsListValidatorForCoverage(repository.Object);

        // Act
        var result = await validator.ValidateAsync(new RecordsList<Patient>
        {
            UserIdLogged = 1,
            Records = [new Patient { CreatedUser = new User { Id = 1 } }]
        });

        // Assert
        result.IsValid.Should().BeFalse();
    }

    // Cenário: listas e records disparam catch e falham por registros vazios/sem permissão.
    // Objetivo: cobrir HasPermissionAsync restante dos validators de seleção.
    [Test]
    public async Task ListValidators_EmptyFaultedAndDenied_ReturnFalse()
    {
        // Arrange
        var faulted = new Mock<IUserRepository>();
        faulted.Setup(repository => repository.FindByID(It.IsAny<long>())).ThrowsAsync(new Exception("db"));
        var ok = new Mock<IUserRepository>();
        ok.Setup(repository => repository.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 9 });

        var patientList = new PatientSelectListValidator(faulted.Object);
        var patientFileList = new PatientFileSelectListValidator(faulted.Object);
        var medicalFileList = new SmartDigitalPsico.Domain.Validation.Contratcs.MedicalFileSelectListValidator(faulted.Object);
        var calendarList = new MedicalCalendarListValidator(faulted.Object);
        var deniedFileList = new PatientFileSelectListValidator(ok.Object);
        var emptyFileList = new PatientFileSelectListValidator(ok.Object);

        // Act
        var patientFaulted = await patientList.ValidateAsync(new RecordsList<Patient>
        {
            UserIdLogged = 1,
            Records = [new Patient { MedicalId = 9, CreatedUser = new User { Id = 1 } }]
        });
        var fileFaulted = await patientFileList.ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 1,
            Records = [new PatientFile { Patient = new Patient { MedicalId = 9 }, CreatedUser = new User { Id = 1 } }]
        });
        var medicalFileFaulted = await medicalFileList.ValidateAsync(new RecordsList<MedicalFile>
        {
            UserIdLogged = 1,
            Records = [new MedicalFile { MedicalId = 9, CreatedUser = new User { Id = 1 } }]
        });
        var calendarFaulted = await calendarList.ValidateAsync(new RecordsList<MedicalCalendar>
        {
            UserIdLogged = 1,
            Records = [new MedicalCalendar { MedicalId = 9, CreatedUser = new User { Id = 1 } }]
        });
        var denied = await deniedFileList.ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 1,
            Records = [new PatientFile { Patient = new Patient { MedicalId = 99 }, CreatedUser = new User { Id = 1 } }]
        });
        var empty = await emptyFileList.ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 1,
            Records = []
        });
        var permitted = await new PatientFileSelectListValidator(ok.Object).ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 1,
            Records =
            [
                new PatientFile
                {
                    Patient = new Patient { MedicalId = 9 },
                    CreatedUser = new User { Id = 1 }
                }
            ]
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            patientFaulted.IsValid.Should().BeFalse();
            fileFaulted.IsValid.Should().BeFalse();
            medicalFileFaulted.IsValid.Should().BeFalse();
            calendarFaulted.IsValid.Should().BeFalse();
            denied.IsValid.Should().BeFalse();
            empty.IsValid.Should().BeTrue();
            permitted.IsValid.Should().BeTrue();
        }
    }

    // Cenário: enum é lido por nome após falhar descrição e valores desconhecidos.
    // Objetivo: executar os retornos false do SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter.
    [Test]
    public void EnumDescriptionConverter_UnmatchedDescriptionAndName_ReturnsFalsePaths()
    {
        // Arrange
        var converter = new SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<DescribedEnum>();
        var fromDescription = typeof(SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<DescribedEnum>)
            .GetMethod("TryGetEnumValueFromDescription", BindingFlags.NonPublic | BindingFlags.Static)!;
        var fromName = typeof(SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<DescribedEnum>)
            .GetMethod("TryGetEnumValueFromName", BindingFlags.NonPublic | BindingFlags.Static)!;
        var field = typeof(DescribedEnum).GetField(nameof(DescribedEnum.Plain))!;

        // Act
        var byName = TextJson.Deserialize<DescribedEnum>("\"Plain\"", DescribedEnumJsonOptions);
        var argsDescription = new object?[] { field, "nope", null };
        var argsName = new object?[] { field, "Other", null };
        var descriptionMiss = (bool)fromDescription.Invoke(converter, argsDescription)!;
        var nameMiss = (bool)fromName.Invoke(converter, argsName)!;

        // Assert
        using (Assert.EnterMultipleScope())
        {
            byName.Should().Be(DescribedEnum.Plain);
            descriptionMiss.Should().BeFalse();
            nameMiss.Should().BeFalse();
        }
    }

    // Cenário: conversão RSA usa padding OAEP SHA3-256 e AES binário válido.
    // Objetivo: cobrir getSizeRSA(OaepSHA3_256) e construtor AES byte[] completo.
    [Test]
    public void CryptoHelpers_OaepSha3AndBinaryAes_InitializeSuccessfully()
    {
        // Arrange
        var keys = SmartDigitalPsico.Core.SDK.Domain.Helpers.RsaCryptoServiceHelper.GenerateKeys(RSAEncryptionPadding.OaepSHA3_256);
        var key = Convert.FromBase64String(SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateKey());
        var iv = Convert.FromBase64String(SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateIV());

        // Act
        var converted = SmartDigitalPsico.Core.SDK.Domain.Helpers.RsaCryptoServiceHelper.ConvertFromBase64(keys.PublicKeyBase64, RSAEncryptionPadding.OaepSHA3_256);
        var aes = new SmartDigitalPsico.Core.SDK.Domain.Security.AesCryptoAdpter(key, iv);
        var blob = new SmartDigitalPsico.Core.SDK.Domain.DTO.BlobFileDto { BlobHeaders = new BlobHttpHeaders { ContentType = "application/pdf" } };

        // Assert
        using (Assert.EnterMultipleScope())
        {
            converted.Modulus.Should().NotBeNull();
            aes.Decrypt(aes.Encrypt("ok")).Should().Be("ok");
            blob.BlobHeaders!.ContentType.Should().Be("application/pdf");
            SmartDigitalPsico.Core.SDK.Domain.Resiliency.ResiliencePolicies.GetPolicyFromConfig(new ResiliencePolicyConfig { PolicyName = "CustomRetryPolicy", RetryCount = 1, RetryDelayInSeconds = 0 })
                .Should().NotBeNull();
        }
    }

    // Cenário: overlap com EndDateTime nulo e enum lido/gravado sem DescriptionAttribute.
    // Objetivo: cobrir ramos restantes de ScheduleItemValidationContext e SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter.
    [Test]
    public async Task ScheduleItemValidationContextValidator_NullEndDateTime_OverlapBranches()
    {
        // Arrange
        var validator = new ScheduleItemValidationContextValidator();
        var start = DateTime.UtcNow.Date.AddHours(9);
        var overlapNullEnd = new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start, EndDateTime = null },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start.AddMinutes(30), EndDateTime = start.AddHours(1) }]
        };
        var noOverlapNullEnd = new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start, EndDateTime = null },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start.AddHours(2), EndDateTime = start.AddHours(3) }]
        };
        var options = new JsonSerializerOptions();
        options.Converters.Add(new SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<DescribedEnum>());
        using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes("\"Plain\""));
        var reader = new Utf8JsonReader(stream.ToArray());
        reader.Read();
        var converter = new SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<DescribedEnum>();
        var writeStream = new MemoryStream();
        using var writer = new Utf8JsonWriter(writeStream);

        // Act
        var overlapResult = await validator.ValidateAsync(overlapNullEnd);
        var noOverlapResult = await validator.ValidateAsync(noOverlapNullEnd);
        converter.Write(writer, DescribedEnum.Plain, options);
        writer.Flush();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            overlapResult.IsValid.Should().BeTrue();
            noOverlapResult.IsValid.Should().BeTrue();
            System.Text.Encoding.UTF8.GetString(writeStream.ToArray()).Should().Be("\"Plain\"");
        }
    }

    // Cenário: item all-day ignora LessThan e dto sem paciente retorna nome vazio.
    // Objetivo: cobrir When de ScheduleCalendarItemValidator e PatientName getter.
    [Test]
    public async Task ScheduleCalendarItemValidator_AllDayAndDtoWithoutPatient_CoversConditionalBranches()
    {
        // Arrange
        var start = DateTime.UtcNow.Date.AddDays(1);
        var validator = new ScheduleCalendarItemValidator();
        var item = new ScheduleCalendarItem
        {
            Title = "All day",
            StartDateTime = start,
            EndDateTime = start.AddHours(23),
            IsAllDay = true,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!
        };
        var dto = new GetMedicalCalendarTimeSlotDto { Patient = null };

        // Act
        var result = await validator.ValidateAsync(item);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Errors.Should().NotContain(error => error.PropertyName == "StartDateTime" && error.ErrorMessage.Contains("BeforeEnd"));
            dto.PatientName.Should().BeEmpty();
        }
    }

    // Cenário: template sem tokens, email sem chave e serialização ignora propriedades listadas.
    // Objetivo: cobrir ramos false de SmartDigitalPsico.Core.SDK.Domain.Helpers.EmailHelper e SmartDigitalPsico.Core.SDK.Domain.Helpers.IgnorableSerializerContractResolver.
    [Test]
    public void EmailHelperAndSerializerResolver_EdgeInputs_HandleGracefully()
    {
        // Arrange
        var resolver = new SmartDigitalPsico.Core.SDK.Domain.Helpers.IgnorableSerializerContractResolver(["Secret"]);
        var settings = new JsonSerializerSettings { ContractResolver = resolver };
        var model = new { Visible = "ok", Secret = "hidden" };

        // Act
        var unchanged = SmartDigitalPsico.Core.SDK.Domain.Helpers.EmailHelper.ReplaceTokens("Hello", null!);
        var noMatch = SmartDigitalPsico.Core.SDK.Domain.Helpers.EmailHelper.ReplaceTokens("Hello", new Dictionary<string, string> { ["Missing"] = "x" });
        var json = JsonConvert.SerializeObject(model, settings);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            unchanged.Should().Be("Hello");
            noMatch.Should().Be("Hello");
            json.Should().Contain("Visible");
            json.Should().NotContain("Secret");
        }
    }

    // Cenário: entidade sem Id numérico e recorrência diária sem limite explícito.
    // Objetivo: cobrir GetKeyValues null e ShouldContinue/continueSequential restantes.
    [Test]
    public void AuditLogHelperAndRecurrenceMaterializer_RemainingBranches_AreCovered()
    {
        // Arrange
        var entity = new { Label = "no-id" };
        var dailyUnbounded = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = new DateTime(2025, 2, 1, 9, 0, 0),
            EndDateTime = new DateTime(2025, 2, 1, 10, 0, 0),
            RecurrenceType = ERecurrenceCalendarType.Daily,
            RecurrenceDays = [],
            MaxOccurrences = 2
        });
        var weeklyEndOnly = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = new DateTime(2025, 2, 3, 9, 0, 0),
            EndDateTime = new DateTime(2025, 2, 3, 10, 0, 0),
            RecurrenceType = ERecurrenceCalendarType.Weekly,
            RecurrenceDays = [DayOfWeek.Monday],
            RecurrenceEndDate = new DateTime(2025, 2, 17),
            MaxOccurrences = 10
        });

        // Act
        var entry = AuditLogHelper.CreateAuditEntry(entity, entity, "Update", []);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            entry.KeyValue.Should().BeEmpty();
            dailyUnbounded.Should().ContainSingle();
            weeklyEndOnly.Should().NotBeEmpty();
        }
    }

    // Cenário: calendário all-day ignora LessThan condicional.
    // Objetivo: cobrir When de MedicalCalendarScheduleFieldsValidator.
    [Test]
    public async Task MedicalCalendarScheduleFieldsValidator_AllDay_SkipsLessThanRule()
    {
        // Arrange
        var scheduleFields = new MedicalCalendarScheduleFieldsValidator();
        var start = DateTime.UtcNow.Date.AddDays(3).AddHours(10);

        // Act
        var allDayOk = await scheduleFields.ValidateAsync(new MedicalCalendar
        {
            Title = "Event",
            StartDateTime = start,
            EndDateTime = start.AddHours(23),
            IsAllDay = true,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!,
            RecurrenceType = ERecurrenceCalendarType.None,
            RecurrenceCount = 1
        });

        // Assert
        allDayOk.Errors.Should().NotContain(e => e.PropertyName == "StartDateTime" && e.ErrorMessage.Contains("BeforeEnd"));
    }

    // Cenário: ramos restantes de validadores, helpers e critérios de calendário.
    // Objetivo: elevar cobertura de branch para 100% nos pontos pendentes.
    [Test]
    public async Task RemainingBranchGaps_ValidatorsHelpersAndSecurity_AreExercised()
    {
        // Arrange
        var users = new Mock<IUserRepository>();
        users.Setup(r => r.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 9, Admin = false });
        users.Setup(r => r.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Medical = new Medical { Id = 9 } });
        users.Setup(r => r.FindByID(3)).ReturnsAsync(new User { Id = 3, MedicalId = 9, Medical = new Medical { Id = 8 } });

        var medicalEntities = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalCalendar>>();
        medicalEntities.Setup(r => r.Exists(It.IsAny<long>())).ReturnsAsync(false);
        var medicalValidator = new MedicalBaseValidator<MedicalCalendar>(
            Mock.Of<IMedicalRepository>(), medicalEntities.Object, users.Object);

        var recordValidator = new RecordValidatorForBranchCoverage(users.Object);
        var calendarList = new MedicalCalendarListValidator(users.Object);
        var calendarCriteria = new CalendarCriteriaValidator(users.Object);

        var start = DateTime.UtcNow.Date.AddDays(5).AddHours(10);
        var medicalRepository = new Mock<IMedicalRepository>();
        medicalRepository.Setup(r => r.FindByID(5)).ReturnsAsync(new Medical
        {
            WorkingDays = [start.DayOfWeek],
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(18)
        });
        var itemValidator = new ScheduleItemValidator(medicalRepository.Object);
        itemValidator.GetType().GetField("_medicalRepository", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(itemValidator, null);

        var appointment = DateTime.UtcNow.Date.AddDays(5).AddHours(20);
        var scheduleKeys = new Mock<IScheduleKeyPolicy>();
        scheduleKeys.SetupGet(k => k.TenantKey).Returns("t");
        scheduleKeys.Setup(k => k.BuildOwnerKey(It.IsAny<long>())).Returns("o");
        var scheduleRepo = new Mock<IScheduleCalendarRepository>();
        var patientRepo = new Mock<IPatientRepository>();
        var criteriaMedicalRepo = new Mock<IMedicalRepository>();
        criteriaMedicalRepo.Setup(r => r.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<Medical, bool>>>()))
            .ReturnsAsync([new Medical
            {
                WorkingDays = [appointment.DayOfWeek],
                StartWorkingTime = TimeSpan.FromHours(8),
                EndWorkingTime = TimeSpan.FromHours(12)
            }]);
        var criteriaValidator = new ScheduleCriteriaDtoValidator(scheduleRepo.Object, patientRepo.Object, criteriaMedicalRepo.Object, scheduleKeys.Object);

        var overlapContext = new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start, EndDateTime = start.AddHours(2) },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start.AddHours(1), EndDateTime = start.AddHours(3) }]
        };

        // Act
        var createdMismatch = await medicalValidator.MedicalCreated(new MedicalCalendar { Id = 0, MedicalId = 9 }, 0, 3);
        var modifyMismatch = await medicalValidator.MedicalModify(new MedicalCalendar { Id = 1, MedicalId = 9 }, 0, 3);
        var recordDenied = await recordValidator.ValidateAsync(new Record<Patient> { UserIdLogged = 1, RecordEntity = new Patient { CreatedUser = new User { Id = 99 } } });
        var calendarAllowed = await calendarList.ValidateAsync(new RecordsList<MedicalCalendar> { UserIdLogged = 1, Records = [new MedicalCalendar { MedicalId = 9, CreatedUserId = 1 }] });
        var criteriaInvalid = await calendarCriteria.ValidateAsync(new CalendarCriteriaDto { UserIdLogged = 1, MedicalId = 9, Month = 1, Year = 2099, StartDate = DateTime.MinValue, EndDate = start, IntervalInMinutes = 30 });
        var outsideHours = await InvokeBoolAsync(criteriaValidator, "BeWithinWorkingHours", new ScheduleCriteriaDto { MedicalId = 1, AppointmentDateTime = appointment, TimeZone = "UTC" }, CancellationToken.None);
        var itemValid = await itemValidator.ValidateAsync(new ScheduleItem
        {
            MedicalId = 5, PatientId = 1, Title = "x", StartDateTime = start, EndDateTime = start.AddHours(1),
            Status = EStatusCalendar.Confirmed, TimeZone = "UTC", RecurrenceDays = []
        });
        var nullRepoDays = await InvokeBoolAsync(itemValidator, "BeInWorkingDays", new ScheduleItem { MedicalId = 5, PatientId = 1, StartDateTime = start, EndDateTime = start.AddHours(1) });
        var nullRepoHours = await InvokeBoolAsync(itemValidator, "BeInWorkingHours", new ScheduleItem { MedicalId = 5, PatientId = 1, StartDateTime = start, EndDateTime = start.AddHours(1) });
        var overlapInvalid = await new ScheduleItemValidationContextValidator().ValidateAsync(overlapContext);

        var aes = new SmartDigitalPsico.Core.SDK.Domain.Security.AesCryptoAdpter(SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateKey(), SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateIV());
        var rsaKeys = SmartDigitalPsico.Core.SDK.Domain.Helpers.RsaCryptoServiceHelper.GenerateKeys(RSAEncryptionPadding.OaepSHA256);
        var rsa = new SmartDigitalPsico.Core.SDK.Domain.Security.RsaCryptoAdpter(rsaKeys.PublicKeyBase64, rsaKeys.PrivateKeyBase64);
        var conflict = ScheduleConflictDetailHelper.Create(
            new ScheduleCalendarItem { StartDateTime = start, EndDateTime = start.AddHours(1) },
            null,
            new ScheduleCalendarItem { StartDateTime = start, EndDateTime = null, Title = "x" },
            "PatientId:1");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            createdMismatch.Should().BeFalse();
            modifyMismatch.Should().BeFalse();
            recordDenied.IsValid.Should().BeFalse();
            calendarAllowed.IsValid.Should().BeTrue();
            criteriaInvalid.IsValid.Should().BeFalse();
            outsideHours.Should().BeFalse();
            itemValid.IsValid.Should().BeTrue();
            nullRepoDays.Should().BeTrue();
            nullRepoHours.Should().BeTrue();
            overlapInvalid.IsValid.Should().BeFalse();
            ((Action)(() => aes.Decrypt(null!))).Should().Throw<ArgumentException>();
            ((Action)(() => rsa.Decrypt(null!))).Should().Throw<ArgumentException>();
            conflict.Message.Should().Contain("ExistingPatientId=1");
            SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetNameAndCulture("key").Should().Be("key");
            SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetKeyLocalizationRecordFormat("k", "pt").Should().Be("k");
        }
    }

    // Cenário: produto e logs são obtidos no host de teste.
    // Objetivo: exercitar informações de versão e ramos defensivos acessíveis.
    [Test]
    public void LogAppHelper_ProductInformationBranches_ReturnMessages()
    {
        // Arrange
        var previous = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", null);
        try
        {
            // Act
            var info = LogAppHelper.GetInformationVersionProduct();
            var text = LogAppHelper.ShowInformationVersionProductString();
            var logger = new Mock<IAppLogger>();
            LogAppHelper.PrintLogInformationVersionProduct(logger.Object);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                info.Should().NotBeNull();
                text.Should().Contain("PRODUCT INFORMATION");
                logger.Verify(x => x.Information("******* PRODUCT INFORMATION *******"), Times.Once);
            }
        }
        finally
        {
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", previous);
        }
    }

    private static List<RecurrenceInterval> InvokeDailyParallelPastEndDate()
    {
        var request = new RecurrenceMaterializeRequest
        {
            StartDateTime = new DateTime(2025, 1, 1, 9, 0, 0),
            EndDateTime = new DateTime(2025, 1, 1, 10, 0, 0),
            RecurrenceType = ERecurrenceCalendarType.Daily,
            RecurrenceEndDate = new DateTime(2025, 1, 1),
            RecurrenceDays = [],
            MaxOccurrences = 10
        };
        var items = new List<RecurrenceInterval>();
        var dayStarts = new[]
        {
            new DateTime(2025, 1, 1, 9, 0, 0),
            new DateTime(2025, 1, 3, 9, 0, 0)
        };
        var method = typeof(RecurrenceMaterializer).GetMethod("MaterializeDailyParallel", BindingFlags.NonPublic | BindingFlags.Static)!;
        method.Invoke(null, [request, TimeSpan.FromHours(1), items, dayStarts]);
        return items;
    }

    private static void InvokeAddSheetWithCustomSheetView(string filePath)
    {
        using var document = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook);
        var workbookPart = document.AddWorkbookPart();
        workbookPart.Workbook = new Workbook();
        workbookPart.Workbook.AppendChild(new Sheets());
        var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
        // CustomSheetView must be a direct child for Elements<CustomSheetView>() to find it.
        worksheetPart.Worksheet = new Worksheet(new SheetData(), new CustomSheetView());
        var mergeCells = new MergeCells(new MergeCell { Reference = new StringValue("A1:B1") });
        var method = typeof(SmartDigitalPsico.Core.SDK.Domain.Report.ExcelGeneratorOpenXmlAdapter).GetMethod("AddSheetToWorkbook", BindingFlags.NonPublic | BindingFlags.Static)!;
        method.Invoke(null, [workbookPart, worksheetPart, "Custom", 1u, mergeCells]);
        worksheetPart.Worksheet.Elements<MergeCells>().Should().ContainSingle();
        workbookPart.Workbook.Save();
    }

    private static List<RecurrenceInterval> InvokeTryAddWeeklyBeforeStart()
    {
        var start = new DateTime(2025, 1, 8, 10, 0, 0);
        var request = new RecurrenceMaterializeRequest
        {
            StartDateTime = start,
            EndDateTime = start.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Weekly,
            MaxOccurrences = 10
        };
        var items = new List<RecurrenceInterval>();
        var method = typeof(RecurrenceMaterializer).GetMethod("TryAddWeeklyInterval", BindingFlags.NonPublic | BindingFlags.Static)!;
        method.Invoke(null, [request, TimeSpan.FromHours(1), items, start.Date.AddDays(-7), start.DayOfWeek]);
        return items;
    }

    private static void InvokeAddBestFitWithColumns(string filePath)
    {
        using var document = SpreadsheetDocument.Open(filePath, true);
        var worksheetPart = document.WorkbookPart!.WorksheetParts.First();
        var worksheet = worksheetPart.Worksheet;
        worksheet.Should().NotBeNull();
        worksheet!.InsertAt(new Columns(new Column { Min = 1, Max = 1, Width = 10 }), 0);
        var method = typeof(SmartDigitalPsico.Core.SDK.Domain.Report.ExcelGeneratorOpenXmlAdapter).GetMethod("AddBestFit", BindingFlags.NonPublic | BindingFlags.Static)!;
        method.Invoke(null, [worksheetPart]);
        worksheet.Descendants<Column>().Should().OnlyContain(column => column.BestFit!.Value);
        worksheet.Save();
    }

    private static ResultExecutingContext CreateResultContext(object value)
    {
        var httpContext = new DefaultHttpContext
        {
            RequestServices = new ServiceCollection().AddRouting().BuildServiceProvider()
        };
        var router = new Mock<IRouter>();
        router.Setup(value => value.GetVirtualPath(It.IsAny<VirtualPathContext>()))
            .Returns(new VirtualPathData(router.Object, "api/test"));
        var routeData = new RouteData();
        routeData.Routers.Add(router.Object);
        var actionContext = new ActionContext(httpContext, routeData, new ActionDescriptor());
        return new ResultExecutingContext(actionContext, [], new OkObjectResult(value), new object());
    }

    private static async Task<bool> InvokeBoolAsync(object target, string methodName, params object?[] arguments)
    {
        var method = target.GetType()
            .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
            .First(candidate => candidate.Name == methodName && candidate.GetParameters().Length == arguments.Length);
        return await (Task<bool>)method.Invoke(target, arguments)!;
    }

    private static bool InvokeBool(object target, string methodName, params object?[] arguments)
    {
        var method = target.GetType()
            .GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic)
            .First(candidate => candidate.Name == methodName && candidate.GetParameters().Length == arguments.Length);
        return (bool)method.Invoke(target, arguments)!;
    }

    private enum DescribedEnum
    {
        [System.ComponentModel.Description("Human value")] Value,
        Plain
    }

    private sealed class ThrowingJsonModel
    {
        private readonly byte _instanceMarker = 1;
        public string Broken
        {
            get
            {
                _ = _instanceMarker;
                throw new InvalidOperationException("serialize-error");
            }
        }
    }

    private sealed class TestEnricher : SmartDigitalPsico.Core.SDK.Domain.Hypermedia.ContentResponseEnricher<GetUserDto>
    {
        public int Enriched { get; private set; }

        protected override Task EnrichModel(GetUserDto content, IUrlHelper urlHelper)
        {
            Enriched++;
            GetLink(1, urlHelper, "users");
            return Task.CompletedTask;
        }
    }

    private sealed class RecordsListValidatorForCoverage : SmartDigitalPsico.Domain.Validation.Contratcs.RecordsListValidator<Patient>
    {
        public RecordsListValidatorForCoverage(IUserRepository userRepository) : base(userRepository)
        {
        }
    }

    private sealed class RecordValidatorForBranchCoverage : SmartDigitalPsico.Domain.Validation.Contratcs.RecordValidator<Patient>
    {
        public RecordValidatorForBranchCoverage(IUserRepository userRepository) : base(userRepository)
        {
        }
    }
}
