using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using FluentValidation.Results;
using Microsoft.Extensions.Localization;
using Microsoft.IdentityModel.Tokens;
using Moq;
using Newtonsoft.Json;
using SmartDigitalPsico.Core.SDK.Domain.AppException;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Core.SDK.Domain.Resiliency;
using SmartDigitalPsico.Core.SDK.Domain.Security;
using SmartDigitalPsico.Core.SDK.Domain.Validation;
using SmartDigitalPsico.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.Test.Report;
using SmartDigitalPsico.Domain.Validation;
using TextJson = System.Text.Json.JsonSerializer;
using ValidationFailure = FluentValidation.Results.ValidationFailure;

namespace SmartDigitalPsico.Domain.Test.Coverage;

[TestFixture]
public sealed class FinalBranchCoverageTests
{
    private string _tempPath = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp() => PdfSharpTestBootstrap.EnsureWindowsFonts();

    [SetUp]
    public void SetUp() => _tempPath = Path.Combine(Path.GetTempPath(), $"branch-final-{Guid.NewGuid():N}");

    [TearDown]
    public void TearDown()
    {
        if (Directory.Exists(_tempPath))
            Directory.Delete(_tempPath, recursive: true);
    }

    // Cenário: conversor de enum cobre descrição, nome, vazio e write sem attribute.
    // Objetivo: fechar ramos restantes do SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter.
    [Test]
    public void EnumDescriptionConverter_AllReadWritePaths_AreCovered()
    {
        // Arrange
        var options = new JsonSerializerOptions();
        options.Converters.Add(new SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<DescribedEnum>());
        var converter = new SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<DescribedEnum>();
        var fromDescription = typeof(SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<DescribedEnum>)
            .GetMethod("TryGetEnumValueFromDescription", BindingFlags.NonPublic | BindingFlags.Static)!;
        var fromName = typeof(SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<DescribedEnum>)
            .GetMethod("TryGetEnumValueFromName", BindingFlags.NonPublic | BindingFlags.Static)!;
        var valueField = typeof(DescribedEnum).GetField(nameof(DescribedEnum.Value))!;
        var plainField = typeof(DescribedEnum).GetField(nameof(DescribedEnum.Plain))!;
        using var writeStream = new MemoryStream();
        using var writer = new Utf8JsonWriter(writeStream);

        // Act
        var byDescription = TextJson.Deserialize<DescribedEnum>("\"Human value\"", options);
        var byName = TextJson.Deserialize<DescribedEnum>("\"Plain\"", options);
        var argsDescMiss = new object?[] { plainField, "Human value", null };
        var argsNameMiss = new object?[] { valueField, "Plain", null };
        var descMiss = (bool)fromDescription.Invoke(converter, argsDescMiss)!;
        var nameMiss = (bool)fromName.Invoke(converter, argsNameMiss)!;
        converter.Write(writer, DescribedEnum.Plain, options);
        writer.Flush();
        var emptyAct = () => TextJson.Deserialize<DescribedEnum>("\"\"", options);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            byDescription.Should().Be(DescribedEnum.Value);
            byName.Should().Be(DescribedEnum.Plain);
            descMiss.Should().BeFalse();
            nameMiss.Should().BeFalse();
            emptyAct.Should().Throw<ArgumentException>();
            var nullAct = () => TextJson.Deserialize<DescribedEnum>("null", options);
            nullAct.Should().Throw<ArgumentException>();
        }
    }

    // Cenário: materializador percorre limites, dias filtrados e parada semanal.
    // Objetivo: cobrir ShouldContinue, TryEnumerateDayStarts e ShouldStopAfterSingleWeek.
    [Test]
    public void RecurrenceMaterializer_LimitsFilteredDaysAndSingleWeek_ProduceExpectedIntervals()
    {
        // Arrange
        var monday = new DateTime(2025, 3, 3, 9, 0, 0);

        // Act
        var maxLimited = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Daily,
            RecurrenceCount = 5,
            MaxOccurrences = 1
        });
        var filteredDays = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Daily,
            RecurrenceDays = [DayOfWeek.Wednesday],
            RecurrenceCount = 3,
            MaxOccurrences = 10
        });
        var endDateOnly = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Daily,
            RecurrenceEndDate = monday.AddDays(3),
            RecurrenceDays = [],
            MaxOccurrences = 10
        });
        var singleWeek = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Weekly,
            RecurrenceDays = [DayOfWeek.Monday],
            MaxOccurrences = 10
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            maxLimited.Should().ContainSingle();
            filteredDays.Should().OnlyContain(i => i.StartDateTime.DayOfWeek == DayOfWeek.Wednesday);
            endDateOnly.Should().NotBeEmpty();
            singleWeek.Should().ContainSingle();
        }
    }

    // Cenário: relatórios Excel/PDF com e sem merge e valores nulos.
    // Objetivo: cobrir GetMergeCell null, células nulas e tipos de página.
    [Test]
    public async Task ReportAdapters_NullValuesAndNoMerge_CoverRemainingBranches()
    {
        // Arrange
        Directory.CreateDirectory(_tempPath);
        var excelOut = Path.Combine(_tempPath, "no-merge.xlsx");
        var pdfOut = Path.Combine(_tempPath, "null-cells.pdf");
        var excel = new SmartDigitalPsico.Core.SDK.Domain.Report.ExcelGeneratorOpenXmlAdapter();
        var pdf = new SmartDigitalPsico.Core.SDK.Domain.Report.PDFsharpMigraDocReportAdapter();
        var workbook = new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportWorkbookDataDto
        {
            Sheets = [new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportSheetDataDto { Name = "Plain", Rows = [new NullableRow { Text = null, Number = 0 }] }]
        };
        var content = new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto
        {
            Pages =
            [
                new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageDataDto
                {
                    Name = "Nulls",
                    PageType = SmartDigitalPsico.Core.SDK.Domain.Enuns.EReportPageType.Text,
                    Rows = [new NullableRow { Text = null, Number = 0 }],
                    PropertiesToIgnore = []
                }
            ]
        };

        // Act
        await excel.Generate(workbook, excelOut);
        var pdfBytes = pdf.Generate(content);
        await pdf.Generate(content, pdfOut);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            File.Exists(excelOut).Should().BeTrue();
            pdfBytes.Should().NotBeEmpty();
            File.Exists(pdfOut).Should().BeTrue();
        }
    }

    // Cenário: helpers de log, RSA e validação cobrem ramos restantes.
    // Objetivo: elevar branch de LogAppHelper, RsaCrypto, HelperValidation e AuditLogHelper.
    [Test]
    public void HelpersAndValidation_RemainingBranches_AreExercised()
    {
        // Arrange
        var previous = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Testing");
        try
        {
            var emptyModulus = new RSAParameters { Modulus = null, Exponent = null };
            var validation = new ValidationResult(
            [
                new ValidationFailure("Pipe", "OnlyPart_WithUnderscore") { ErrorCode = "legacy" },
                new ValidationFailure("Plain", "plain message") { ErrorCode = "legacy" },
                new ValidationFailure("Structured", "Token_Key|msg")
                {
                    ErrorCode = ValidationErrorCodes.For("V", "M", "F")
                }
            ]);
            var entityWithNullId = new EntityWithNullId { Id = null };

            // Act
            var info = LogAppHelper.GetInformationVersionProduct();
            var version = LogAppHelper.GetAssemblyVersion();
            var rsaBase64 = SmartDigitalPsico.Core.SDK.Domain.Helpers.RsaCryptoServiceHelper.ConvertToBase64(emptyModulus);
            var errors = HelperValidation.GetErrorsMap(validation);
            var translated = HelperValidation.TranslateErroCode(new ErrorResponse
            {
                FullMessage = "Key_WithUnderscore|Translated",
                ErrorCode = "legacy"
            });
            var entry = AuditLogHelper.CreateAuditEntry(
                new { ModifyUser = new { Name = "operator" } },
                entityWithNullId,
                "Update",
                []);

            // Assert
            using (Assert.EnterMultipleScope())
            {
                info.Name.Should().NotBeNullOrEmpty();
                version.Should().NotBeNullOrEmpty();
                rsaBase64.Should().NotBeNull();
                errors[0].DefaultMessage.Should().Be("OnlyPart_WithUnderscore");
                errors[1].ErrorCode.Should().Be("plain_message");
                translated.Message.Should().Be("Translated");
                entry.KeyValue.Should().BeEmpty();
                entry.UserAuditedLogin.Should().Be("operator");
            }
        }
        finally
        {
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", previous);
        }
    }

    // Cenário: validadores de calendário/agenda cobrem When-skip, overlap e permissões.
    // Objetivo: fechar ramos de MedicalCalendar, ScheduleItem e list validators.
    [Test]
    public async Task CalendarAndScheduleValidators_RemainingWhenAndPermissionBranches()
    {
        // Arrange
        var start = DateTime.UtcNow.Date.AddDays(7).AddHours(9);
        var users = new Mock<IUserRepository>();
        users.Setup(r => r.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 9, Admin = false, TimeZone = "UTC" });
        users.Setup(r => r.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Medical = new Medical { Id = 9 }, TimeZone = "UTC" });
        users.Setup(r => r.FindByID(5)).Returns(Task.FromResult<User>(null!));

        var medicalRepo = new Mock<IMedicalRepository>();
        medicalRepo.Setup(r => r.FindByID(5)).ReturnsAsync(new Medical
        {
            WorkingDays = [start.DayOfWeek],
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(18)
        });
        medicalRepo.Setup(r => r.Exists(It.IsAny<long>())).ReturnsAsync(true);
        var scheduleRepo = new Mock<IScheduleCalendarRepository>();

        var calendarValidator = new MedicalCalendarValidator(medicalRepo.Object, users.Object, scheduleRepo.Object);
        var calendarList = new MedicalCalendarListValidator(users.Object);
        var calendarCriteria = new MedicalCalendarCriteriaValidator(users.Object);
        var itemValidator = new ScheduleItemValidator(medicalRepo.Object);
        var calendarItemValidator = new ScheduleCalendarItemValidator();
        var overlapValidator = new ScheduleItemValidationContextValidator();

        var calendar = new MedicalCalendar
        {
            MedicalId = 5,
            PatientId = 1,
            CreatedUserId = 2,
            ModifyUserId = 2,
            Title = "Consulta",
            StartDateTime = start,
            EndDateTime = start.AddHours(1),
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!
        };

        // Act
        var calendarResult = await calendarValidator.ValidateAsync(calendar);
        var emptyListOk = await calendarList.ValidateAsync(new RecordsList<MedicalCalendar> { UserIdLogged = 1, Records = [] });
        var criteriaEndOnly = await calendarCriteria.ValidateAsync(new CalendarCriteriaDto
        {
            UserIdLogged = 1,
            MedicalId = 9,
            Month = 6,
            Year = 2099,
            StartDate = null,
            EndDate = start,
            IntervalInMinutes = 30
        });
        var criteriaStartOnly = await calendarCriteria.ValidateAsync(new CalendarCriteriaDto
        {
            UserIdLogged = 1,
            MedicalId = 9,
            Month = 6,
            Year = 2099,
            StartDate = start,
            EndDate = null,
            IntervalInMinutes = 30
        });
        var inHours = await InvokeBool(itemValidator, "BeInWorkingHours", new ScheduleItem
        {
            MedicalId = 5,
            PatientId = 1,
            StartDateTime = start,
            EndDateTime = start.AddHours(1)
        });
        var itemTimed = await itemValidator.ValidateAsync(new ScheduleItem
        {
            MedicalId = 5,
            PatientId = 1,
            Title = "T",
            StartDateTime = start,
            EndDateTime = start.AddHours(1),
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!
        });
        var calendarItemTimed = await calendarItemValidator.ValidateAsync(new ScheduleCalendarItem
        {
            Title = "T",
            StartDateTime = start,
            EndDateTime = start.AddHours(1),
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!
        });
        var overlapInvalid = await overlapValidator.ValidateAsync(new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start, EndDateTime = start.AddHours(2) },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = start.AddHours(1), EndDateTime = start.AddHours(3) }]
        });
        var createdOk = await InvokeBool(calendarValidator, "MedicalCreated", new MedicalCalendar { Id = 0, MedicalId = 9 }, (long?)2);
        var modifyOk = await InvokeBool(calendarValidator, "MedicalModify", new MedicalCalendar { Id = 1, MedicalId = 9 }, (long?)2);
        var medicalFileDenied = await new MedicalFileSelectListValidator(users.Object).ValidateAsync(new RecordsList<MedicalFile>
        {
            UserIdLogged = 1,
            Records = [new MedicalFile { MedicalId = 9, CreatedUser = null! }]
        });
        var basePatientDenied = await new PatientFileSelectListValidator(users.Object).ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 1,
            Records = [new PatientFile { Patient = new Patient { MedicalId = 99 }, CreatedUser = new User { Id = 1 } }]
        });
        var medicalBaseMismatch = await new MedicalBaseValidator<MedicalCalendar>(
            medicalRepo.Object,
            Mock.Of<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalCalendar>>(),
            users.Object).MedicalCreated(new MedicalCalendar { Id = 0, MedicalId = 99 }, 0, 2);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            calendarResult.Should().NotBeNull();
            emptyListOk.IsValid.Should().BeTrue();
            criteriaEndOnly.IsValid.Should().BeTrue();
            criteriaStartOnly.IsValid.Should().BeTrue();
            inHours.Should().BeTrue();
            itemTimed.Errors.Should().NotContain(e => e.PropertyName == "StartDateTime" && e.ErrorMessage.Contains("BeforeEnd"));
            calendarItemTimed.Errors.Should().NotContain(e => e.PropertyName == "StartDateTime" && e.ErrorMessage.Contains("BeforeEnd"));
            overlapInvalid.IsValid.Should().BeFalse();
            createdOk.Should().BeTrue();
            modifyOk.Should().BeTrue();
            medicalFileDenied.IsValid.Should().BeFalse();
            basePatientDenied.IsValid.Should().BeFalse();
            medicalBaseMismatch.Should().BeFalse();
        }
    }

    // Cenário: token inválido e política com delay default.
    // Objetivo: cobrir TokenService e SmartDigitalPsico.Core.SDK.Domain.Resiliency.ResiliencePolicies ramos restantes.
    [Test]
    public async Task TokenServiceAndResilience_RemainingBranches_AreCovered()
    {
        // Arrange
        const string secret = "0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef";
        var service = new TokenService(new SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto { Secret = secret, Issuer = "i", Audience = "a", Minutes = 1 });
        var attempts = 0;

        // Act
        var invalid = () => service.GetPrincipalFromExpiredToken("not-a-jwt");
        await SmartDigitalPsico.Core.SDK.Domain.Resiliency.ResiliencePolicies.CustomRetryPolicy(new ResiliencePolicyConfig
        {
            PolicyName = "CustomRetryPolicy",
            RetryCount = 1,
            RetryDelayInSeconds = -1
        }).ExecuteAsync(() =>
        {
            attempts++;
            if (attempts < 2) throw new InvalidOperationException();
            return Task.CompletedTask;
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            invalid.Should().Throw<Exception>();
            attempts.Should().Be(2);
        }
    }

    // Cenário: lista base nega usuário sem permissão e record validator nega criador divergente.
    // Objetivo: cobrir TrueForAll/Admin ramos de RecordsListValidator e RecordValidator.
    [Test]
    public async Task RecordsListAndRecordValidators_DeniedPaths_ReturnFalse()
    {
        // Arrange
        var users = new Mock<IUserRepository>();
        users.Setup(r => r.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 9, Admin = false });
        var listValidator = new RecordsListValidatorForFinalCoverage(users.Object);
        var recordValidator = new RecordValidatorForFinalCoverage(users.Object);

        // Act
        var listDenied = await listValidator.ValidateAsync(new RecordsList<Patient>
        {
            UserIdLogged = 1,
            Records = [new Patient { CreatedUser = new User { Id = 99 } }]
        });
        var recordDenied = await recordValidator.ValidateAsync(new Record<Patient>
        {
            UserIdLogged = 1,
            RecordEntity = new Patient { CreatedUser = new User { Id = 99 } }
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            listDenied.IsValid.Should().BeFalse();
            recordDenied.IsValid.Should().BeFalse();
        }
    }

    // Cenário: ramos restantes de helpers, relatórios, validadores e segurança.
    // Objetivo: fechar gaps de branch ainda ab abaixo de 100%.
    [Test]
    public async Task RemainingBranchGaps_AllPackages_AreExercised()
    {
        // Arrange
        Directory.CreateDirectory(_tempPath);
        var monday = DateTime.UtcNow.Date.AddDays(14).AddHours(9);
        while (monday.DayOfWeek != DayOfWeek.Monday)
            monday = monday.AddDays(1);

        var users = new Mock<IUserRepository>();
        users.Setup(r => r.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 9, Admin = true, TimeZone = "UTC" });
        users.Setup(r => r.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Medical = new Medical { Id = 9 }, TimeZone = "UTC" });
        users.Setup(r => r.FindByID(3)).ReturnsAsync(new User { Id = 3, MedicalId = 9, Admin = false, TimeZone = "UTC" });

        var medicalRepo = new Mock<IMedicalRepository>();
        medicalRepo.Setup(r => r.FindByID(5)).ReturnsAsync(new Medical
        {
            WorkingDays = [monday.DayOfWeek],
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(18)
        });
        medicalRepo.Setup(r => r.Exists(It.IsAny<long>())).ReturnsAsync(true);

        var scheduleRepo = new Mock<IScheduleCalendarRepository>();
        scheduleRepo.Setup(r => r.GetConflictingItemsAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync([]);

        var patientRepo = new Mock<IPatientRepository>();
        var scheduleKeys = new Mock<IScheduleKeyPolicy>();
        scheduleKeys.SetupGet(p => p.TenantKey).Returns("tenant");
        scheduleKeys.Setup(p => p.BuildOwnerKey(It.IsAny<long>())).Returns("owner");
        scheduleKeys.Setup(p => p.BuildSubjectKey(It.IsAny<long>())).Returns("subject");
        medicalRepo.Setup(r => r.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<Medical, bool>>>()))
            .ReturnsAsync([new Medical
            {
                WorkingDays = [monday.DayOfWeek],
                StartWorkingTime = TimeSpan.FromHours(8),
                EndWorkingTime = TimeSpan.FromHours(18)
            }]);

        const string secret = "0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef";
        var tokenService = new TokenService(new SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto { Secret = secret, Issuer = "i", Audience = "a", Minutes = 1 });
        var expiredToken = tokenService.GenerateAccessToken([new Claim("sub", "1")]);

        var prevEnv = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", null);

        // Act
        try
        {
            var localizer = new Mock<IStringLocalizer<FinalBranchCoverageTests>>();
            localizer.Setup(l => l[It.IsAny<string>()]).Returns(new LocalizedString("welcome", "ok"));

            var resolver = new SmartDigitalPsico.Core.SDK.Domain.Helpers.IgnorableSerializerContractResolver(["Secret"]);
            var ignoredJson = JsonConvert.SerializeObject(new { Visible = "yes", Secret = "no" }, new JsonSerializerSettings
            {
                ContractResolver = resolver
            });
            var keptJson = JsonConvert.SerializeObject(new { Visible = "yes", Public = "yes" }, new JsonSerializerSettings
            {
                ContractResolver = resolver
            });

            var dailyUnbounded = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
            {
                StartDateTime = monday,
                EndDateTime = monday.AddHours(1),
                RecurrenceType = ERecurrenceCalendarType.Daily,
                RecurrenceDays = [],
                MaxOccurrences = 10
            });
            var countLimited = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
            {
                StartDateTime = monday,
                EndDateTime = monday.AddHours(1),
                RecurrenceType = ERecurrenceCalendarType.Daily,
                RecurrenceCount = 2,
                RecurrenceEndDate = monday.AddDays(10),
                MaxOccurrences = 100
            });

            var excel = new SmartDigitalPsico.Core.SDK.Domain.Report.ExcelGeneratorOpenXmlAdapter();
            var excelOut = Path.Combine(_tempPath, "merge.xlsx");
            await excel.Generate(new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportWorkbookDataDto
            {
                Sheets =
                [
                    new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportSheetDataDto
                    {
                        Name = "Merged",
                        Rows = [new NullableRow { Text = "cell", Number = 1 }],
                        MergeCellReferences = ["A1:B1"]
                    }
                ]
            }, excelOut);

            var pdf = new SmartDigitalPsico.Core.SDK.Domain.Report.PDFsharpMigraDocReportAdapter();
            var pdfTableBytes = pdf.Generate(new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto
            {
                Pages =
                [
                    new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageDataDto
                    {
                        Name = "Table",
                        FooterTitle = null!,
                        PageType = SmartDigitalPsico.Core.SDK.Domain.Enuns.EReportPageType.Table,
                        Rows = [new NullableRow { Text = null, Number = 2 }],
                        PropertiesToIgnore = []
                    }
                ]
            });

            var hostInfo = LogAppHelper.GetInformationVersionProduct();
            var structuredErrors = HelperValidation.GetErrorsMap(new ValidationResult(
            [
                new ValidationFailure("Field", "SmartDigitalPsico.Test.Field|structured")
                {
                    ErrorCode = ValidationErrorCodes.For("Test", "Field", "Must")
                },
                new ValidationFailure("Plain", "plain message") { ErrorCode = "legacy" },
                new ValidationFailure("PipeOnly", "Key_Only|") { ErrorCode = "legacy" }
            ]));
            var translatedStructured = HelperValidation.TranslateErroCode(new ErrorResponse
            {
                FullMessage = "Key_WithUnderscore|done",
                ErrorCode = ValidationErrorCodes.For("Test", "Field", "Must")
            });

            var calendarValidator = new MedicalCalendarValidator(medicalRepo.Object, users.Object, scheduleRepo.Object);
            var calendarAtEndHours = await InvokeBool(calendarValidator, "BeInWorkingHours", 5L, monday.Date.AddHours(18));
            var calendarModifySkip = await InvokeBool(calendarValidator, "MedicalModify",
                new MedicalCalendar { Id = 0, MedicalId = 9 }, (long?)2);
            var calendarCreatedNoMedical = await InvokeBool(calendarValidator, "MedicalCreated",
                new MedicalCalendar { Id = 0, MedicalId = 9 }, (long?)3);

            users.Setup(r => r.FindByID(3)).ReturnsAsync(new User { Id = 3, MedicalId = 9, Medical = null, TimeZone = "UTC" });
            var calendarCreatedNullMedical = await InvokeBool(calendarValidator, "MedicalCreated",
                new MedicalCalendar { Id = 0, MedicalId = 9 }, (long?)3);

            var scheduleFields = new MedicalCalendarScheduleFieldsValidator();
            var allDayCalendar = await scheduleFields.ValidateAsync(new MedicalCalendar
            {
                Title = "All day",
                StartDateTime = monday,
                EndDateTime = monday.AddDays(1),
                IsAllDay = true,
                Status = EStatusCalendar.Confirmed,
                TimeZone = "UTC",
                RecurrenceDays = null!
            });

            var itemValidator = new ScheduleItemValidator(medicalRepo.Object);
            var allDayItem = await itemValidator.ValidateAsync(new ScheduleItem
            {
                MedicalId = 5,
                PatientId = 1,
                Title = "All day",
                StartDateTime = monday,
                EndDateTime = monday.AddDays(1),
                IsAllDay = true,
                Status = EStatusCalendar.Confirmed,
                TimeZone = "UTC",
                RecurrenceDays = null!
            });
            var endBoundary = await InvokeBool(itemValidator, "BeInWorkingHours", new ScheduleItem
            {
                MedicalId = 5,
                PatientId = 1,
                StartDateTime = monday,
                EndDateTime = monday.Date.AddHours(18)
            });

            var calendarItemValidator = new ScheduleCalendarItemValidator();
            var allDayCalendarItem = await calendarItemValidator.ValidateAsync(new ScheduleCalendarItem
            {
                Title = "All day",
                StartDateTime = monday,
                EndDateTime = monday.AddDays(1),
                IsAllDay = true,
                Status = EStatusCalendar.Confirmed,
                TimeZone = "UTC",
                RecurrenceDays = null!
            });

            var overlapValidator = new ScheduleItemValidationContextValidator();
            var overlapNullEnds = await overlapValidator.ValidateAsync(new ScheduleItemValidationContext
            {
                NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday, EndDateTime = null },
                ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday.AddHours(1), EndDateTime = null }]
            });

            var medicalBase = new MedicalBaseValidator<MedicalCalendar>(
                medicalRepo.Object,
                Mock.Of<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalCalendar>>(),
                users.Object);
            var baseCreatedSuccess = await medicalBase.MedicalCreated(
                new MedicalCalendar { Id = 0, MedicalId = 9 }, 0, 2);
            var baseModifySuccess = await medicalBase.MedicalModify(
                new MedicalCalendar { Id = 1, MedicalId = 9 }, 0, 2);
            var baseCreatedSkip = await medicalBase.MedicalCreated(
                new MedicalCalendar { Id = 5, MedicalId = 9 }, 0, 2);

            var listValidator = new RecordsListValidatorForFinalCoverage(users.Object);
            var listAdminOk = await listValidator.ValidateAsync(new RecordsList<Patient>
            {
                UserIdLogged = 1,
                Records = [new Patient { CreatedUser = new User { Id = 99 } }]
            });
            var listNullUserDenied = await listValidator.ValidateAsync(new RecordsList<Patient>
            {
                UserIdLogged = 5,
                Records = [new Patient { CreatedUser = new User { Id = 1 } }]
            });
            var recordValidator = new RecordValidatorForFinalCoverage(users.Object);
            var recordAdminOk = await recordValidator.ValidateAsync(new Record<Patient>
            {
                UserIdLogged = 1,
                RecordEntity = new Patient { CreatedUser = new User { Id = 99 } }
            });

            var calendarList = new MedicalCalendarListValidator(users.Object);
            var calendarListOk = await calendarList.ValidateAsync(new RecordsList<MedicalCalendar>
            {
                UserIdLogged = 2,
                Records = [new MedicalCalendar { CreatedUserId = 2, MedicalId = 9 }]
            });

            var patientFileList = new PatientFileSelectListValidator(users.Object);
            var patientFileOk = await patientFileList.ValidateAsync(new RecordsList<PatientFile>
            {
                UserIdLogged = 2,
                Records =
                [
                    new PatientFile
                    {
                        CreatedUser = new User { Id = 2 },
                        Patient = new Patient { MedicalId = 9 }
                    }
                ]
            });

            var patientRepository = new Mock<IPatientRepository>();
            patientRepository.Setup(r => r.Exists(It.IsAny<long>())).ReturnsAsync(false);
            var patientValidator = new PatientValidator(patientRepository.Object, medicalRepo.Object, users.Object);
            var futureBirth = typeof(PatientValidator).GetMethod("beValidAge", BindingFlags.Static | BindingFlags.NonPublic)!
                .Invoke(null, [DateTime.UtcNow.AddYears(1)]);

            var criteriaValidator = new ScheduleCriteriaDtoValidator(
                scheduleRepo.Object, patientRepo.Object, medicalRepo.Object, scheduleKeys.Object);
            var withinHours = await InvokeBool(criteriaValidator, "BeWithinWorkingHours", new ScheduleCriteriaDto
            {
                MedicalId = 5,
                PatientId = 1,
                AppointmentDateTime = monday.Date.AddHours(18),
                TimeZone = "UTC"
            }, CancellationToken.None);

            var validPrincipal = tokenService.GetPrincipalFromExpiredToken(expiredToken);
            await SmartDigitalPsico.Core.SDK.Domain.Resiliency.ResiliencePolicies.CustomRetryPolicy(new ResiliencePolicyConfig
            {
                PolicyName = "CustomRetryPolicy",
                RetryCount = 2,
                RetryDelayInSeconds = 1
            }).ExecuteAsync(() => Task.CompletedTask);

            SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetNameAndCulture(null!).Should().BeEmpty();
            SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetKeyLocalizationRecordFormat(null!, null!).Should().BeEmpty();

            // Assert
            using (Assert.EnterMultipleScope())
            {
                ignoredJson.Should().NotContain("Secret");
                keptJson.Should().Contain("Public");
                dailyUnbounded.Should().ContainSingle();
                countLimited.Should().HaveCount(2);
                File.Exists(excelOut).Should().BeTrue();
                pdfTableBytes.Should().NotBeEmpty();
                hostInfo.EnvironmentName.Should().NotBeNullOrEmpty();
                structuredErrors[0].ErrorCode.Should().StartWith("SmartDigitalPsico.");
                structuredErrors[2].DefaultMessage.Should().BeEmpty();
                translatedStructured.Message.Should().Be("done");
                calendarAtEndHours.Should().BeTrue();
                calendarModifySkip.Should().BeTrue();
                calendarCreatedNoMedical.Should().BeFalse();
                calendarCreatedNullMedical.Should().BeFalse();
                allDayCalendar.Errors.Should().NotContain(e => e.ErrorMessage.Contains("BeforeEnd"));
                allDayItem.Errors.Should().NotContain(e => e.ErrorMessage.Contains("BeforeEnd"));
                endBoundary.Should().BeTrue();
                allDayCalendarItem.Errors.Should().NotContain(e => e.ErrorMessage.Contains("BeforeEnd"));
                overlapNullEnds.IsValid.Should().BeTrue();
                baseCreatedSuccess.Should().BeTrue();
                baseModifySuccess.Should().BeTrue();
                baseCreatedSkip.Should().BeTrue();
                listAdminOk.IsValid.Should().BeTrue();
                listNullUserDenied.IsValid.Should().BeFalse();
                recordAdminOk.IsValid.Should().BeTrue();
                calendarListOk.IsValid.Should().BeTrue();
                patientFileOk.IsValid.Should().BeTrue();
                futureBirth.Should().Be(false);
                withinHours.Should().BeTrue();
                validPrincipal.Identity.Should().NotBeNull();
            }
        }
        finally
        {
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", prevEnv);
        }
    }

    // Cenário: segundo lote de ramos ainda parcialmente cobertos.
    // Objetivo: elevar branch Domain o mais próximo possível de 100%.
    [Test]
    public async Task RemainingBranchGaps_SecondWave_CoversValidatorAndHelperEdges()
    {
        // Arrange
        var monday = DateTime.UtcNow.Date.AddDays(21).AddHours(9);
        while (monday.DayOfWeek != DayOfWeek.Monday)
            monday = monday.AddDays(1);

        var users = new Mock<IUserRepository>();
        users.Setup(r => r.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Medical = new Medical { Id = 9 }, TimeZone = "UTC" });
        users.Setup(r => r.FindByID(4)).ReturnsAsync(new User { Id = 4, MedicalId = 9, Medical = null, TimeZone = "UTC" });

        var medicalRepo = new Mock<IMedicalRepository>();
        medicalRepo.Setup(r => r.FindByID(5)).ReturnsAsync(new Medical
        {
            WorkingDays = [monday.DayOfWeek],
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(18)
        });

        var scheduleRepo = new Mock<IScheduleCalendarRepository>();
        scheduleRepo.Setup(r => r.GetConflictingItemsAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync([]);

        const string secret = "0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef";
        var wrongAlgToken = new JwtSecurityTokenHandler().WriteToken(new JwtSecurityToken(
            issuer: "i",
            audience: "a",
            signingCredentials: new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret)),
                SecurityAlgorithms.HmacSha256)));

        var calendarValidator = new MedicalCalendarValidator(medicalRepo.Object, users.Object, scheduleRepo.Object);
        var itemValidator = new ScheduleItemValidator(medicalRepo.Object);
        var overlapValidator = new ScheduleItemValidationContextValidator();
        var calendarList = new MedicalCalendarListValidator(users.Object);
        var scheduleFields = new MedicalCalendarScheduleFieldsValidator();
        var logger = new Mock<IAppLogger>();

        // Act
        var outsideHours = await InvokeBool(calendarValidator, "BeInWorkingHours", 5L, monday.Date.AddHours(19));
        var modifyDenied = await InvokeBool(calendarValidator, "MedicalModify",
            new MedicalCalendar { Id = 1, MedicalId = 9 }, (long?)4);
        var listDenied = await calendarList.ValidateAsync(new RecordsList<MedicalCalendar>
        {
            UserIdLogged = 2,
            Records = [new MedicalCalendar { CreatedUserId = 99, MedicalId = 9 }]
        });
        var timedInvalid = await scheduleFields.ValidateAsync(new MedicalCalendar
        {
            Title = "Bad",
            StartDateTime = monday.AddHours(3),
            EndDateTime = monday.AddHours(1),
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!
        });
        var itemLessThan = await itemValidator.ValidateAsync(new ScheduleItem
        {
            MedicalId = 5,
            PatientId = 1,
            Title = "Bad",
            StartDateTime = monday.AddHours(3),
            EndDateTime = monday.AddHours(1),
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!
        });
        var itemOutsideHours = await InvokeBool(itemValidator, "BeInWorkingHours", new ScheduleItem
        {
            MedicalId = 5,
            PatientId = 1,
            StartDateTime = monday,
            EndDateTime = monday.Date.AddHours(19)
        });
        var calendarItemTimed = await new ScheduleCalendarItemValidator().ValidateAsync(new ScheduleCalendarItem
        {
            Title = "Bad",
            StartDateTime = monday.AddHours(3),
            EndDateTime = monday.AddHours(1),
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!
        });
        var overlapBothEnds = await overlapValidator.ValidateAsync(new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday, EndDateTime = monday.AddHours(2) },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday.AddHours(1), EndDateTime = monday.AddHours(3) }]
        });
        var overlapNewNullEnd = await overlapValidator.ValidateAsync(new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday, EndDateTime = null },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday.AddHours(-1), EndDateTime = monday.AddHours(1) }]
        });
        var maxZero = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Daily,
            MaxOccurrences = 0
        });
        var wrongAlg = () => new TokenService(new SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto { Secret = secret, Issuer = "i", Audience = "a", Minutes = 1 })
            .GetPrincipalFromExpiredToken(wrongAlgToken);
        LogAppHelper.LogException(logger.Object, new AppWarningException("warn"), "TEST");
        var pipeSingle = HelperValidation.GetErrorsMap(new ValidationResult(
            [new ValidationFailure("Pipe", "OnlyKey_|tail") { ErrorCode = "legacy" }]))[0];
        var noPipeTranslate = HelperValidation.TranslateErroCode(new ErrorResponse { FullMessage = "plain", ErrorCode = "legacy" });

        var usersBase = new Mock<IUserRepository>();
        usersBase.Setup(r => r.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Medical = null });
        var baseDenied = await new MedicalBaseValidator<MedicalCalendar>(
            medicalRepo.Object, Mock.Of<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalCalendar>>(), usersBase.Object)
            .MedicalCreated(new MedicalCalendar { Id = 0, MedicalId = 9 }, 0, 2);

        var patientListDenied = await new PatientFileSelectListValidator(users.Object).ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 2,
            Records = [new PatientFile { CreatedUser = new User { Id = 2 }, Patient = null! }]
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            outsideHours.Should().BeFalse();
            modifyDenied.Should().BeFalse();
            listDenied.IsValid.Should().BeFalse();
            timedInvalid.Errors.Should().Contain(e => e.ErrorMessage.Contains("BeforeEnd"));
            itemLessThan.Errors.Should().Contain(e => e.ErrorMessage.Contains("BeforeEnd"));
            itemOutsideHours.Should().BeFalse();
            calendarItemTimed.Errors.Should().Contain(e => e.ErrorMessage.Contains("BeforeEnd"));
            overlapBothEnds.IsValid.Should().BeFalse();
            overlapNewNullEnd.IsValid.Should().BeTrue();
            maxZero.Should().BeEmpty();
            wrongAlg.Should().Throw<SecurityTokenException>();
            logger.Verify(l => l.Warning(It.IsAny<string>()), Times.Once);
            pipeSingle.DefaultMessage.Should().Be("tail");
            noPipeTranslate.FullMessage.Should().Be("plain");
            baseDenied.Should().BeFalse();
            patientListDenied.IsValid.Should().BeFalse();
        }
    }

    private static async Task<bool> InvokeBool(object target, string methodName, params object?[] arguments)
    {
        var method = target.GetType()
            .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
            .First(m => m.Name == methodName && m.GetParameters().Length == arguments.Length);
        return await (Task<bool>)method.Invoke(target, arguments)!;
    }

    private enum DescribedEnum
    {
        [System.ComponentModel.Description("Human value")] Value,
        Plain
    }

    private sealed class NullableRow
    {
        public string? Text { get; init; }
        public int Number { get; init; }
    }

    private sealed class EntityWithNullId
    {
        public long? Id { get; init; }
    }

    private sealed class RecordsListValidatorForFinalCoverage : RecordsListValidator<Patient>
    {
        public RecordsListValidatorForFinalCoverage(IUserRepository userRepository) : base(userRepository) { }
    }

    private sealed class RecordValidatorForFinalCoverage : RecordValidator<Patient>
    {
        public RecordValidatorForFinalCoverage(IUserRepository userRepository) : base(userRepository) { }
    }
}
