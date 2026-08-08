using SmartDigitalPsico.Core.SDK.Domain.Security;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using FluentValidation.Results;
using Microsoft.IdentityModel.Tokens;
using Moq;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.Test.Report;
using SmartDigitalPsico.Domain.Validation.Base;
using SmartDigitalPsico.Domain.Validation.Contratcs;
using SmartDigitalPsico.Domain.Validation.DTO;
using SmartDigitalPsico.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.Principals.Calendar;
using SmartDigitalPsico.Domain.Validation.Principals.Schedule;
using SmartDigitalPsico.Domain.Validation.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using ValidationFailure = FluentValidation.Results.ValidationFailure;
using TextJson = System.Text.Json.JsonSerializer;

namespace SmartDigitalPsico.Domain.Test.Coverage;

[TestFixture]
public sealed class BranchCoverageHundredPercentTests
{
    private string _tempPath = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp() => PdfSharpTestBootstrap.EnsureWindowsFonts();

    [SetUp]
    public void SetUp() => _tempPath = Path.Combine(Path.GetTempPath(), $"branch-100-{Guid.NewGuid():N}");

    [TearDown]
    public void TearDown()
    {
        if (Directory.Exists(_tempPath))
            Directory.Delete(_tempPath, recursive: true);
    }

    // Cenário: LogAppHelper sem ASPNETCORE_ENVIRONMENT usa host builder fallback.
    // Objetivo: cobrir GetHostEnvironmentName e ramos de versão/nome do assembly.
    [Test]
    public void LogAppHelper_NoEnvAndHostFallback_CoversAssemblyBranches()
    {
        // Arrange
        var previous = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", null);
        try
        {
            var hostEnv = typeof(LogAppHelper).GetMethod("GetHostEnvironmentName", BindingFlags.NonPublic | BindingFlags.Static)!
                .Invoke(null, null) as string;
            var info = LogAppHelper.GetInformationVersionProduct();
            var version = LogAppHelper.GetAssemblyVersion();

        // Act
            // Assert
            using (Assert.EnterMultipleScope())
            {
                hostEnv.Should().NotBeNullOrEmpty();
                info.Name.Should().NotBeNullOrEmpty();
                info.EnvironmentName.Should().NotBeNullOrEmpty();
                version.Should().NotBeNullOrEmpty();
            }
        }
        finally
        {
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", previous);
        }
    }

    // Cenário: conversor enum percorre falhas parciais de descrição/nome e write sem attribute.
    // Objetivo: fechar ramos restantes do SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter.
    [Test]
    public void EnumDescriptionConverter_PartialMatchesAndWritePlain_CoverAllBranches()
    {
        // Arrange
        var options = new JsonSerializerOptions();
        options.Converters.Add(new SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<HundredDescribedEnum>());
        var converter = new SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<HundredDescribedEnum>();
        var fromDescription = typeof(SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<HundredDescribedEnum>)
            .GetMethod("TryGetEnumValueFromDescription", BindingFlags.NonPublic | BindingFlags.Static)!;
        var fromName = typeof(SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<HundredDescribedEnum>)
            .GetMethod("TryGetEnumValueFromName", BindingFlags.NonPublic | BindingFlags.Static)!;
        var valueField = typeof(HundredDescribedEnum).GetField(nameof(HundredDescribedEnum.Value))!;
        var plainField = typeof(HundredDescribedEnum).GetField(nameof(HundredDescribedEnum.Plain))!;
        using var stream = new MemoryStream();
        using var writer = new Utf8JsonWriter(stream);

        var wrongDescArgs = new object?[] { valueField, "Wrong description", null };
        var wrongNameArgs = new object?[] { plainField, "NotPlain", null };
        var rightDescArgs = new object?[] { valueField, "Human value", null };
        // Act
        // Assert
        fromDescription.Invoke(converter, wrongDescArgs).Should().Be(false);
        fromName.Invoke(converter, wrongNameArgs).Should().Be(false);
        fromDescription.Invoke(converter, rightDescArgs).Should().Be(true);
        converter.Write(writer, HundredDescribedEnum.Plain, options);
        writer.Flush();

        using (Assert.EnterMultipleScope())
        {
            TextJson.Deserialize<HundredDescribedEnum>("\"Human value\"", options).Should().Be(HundredDescribedEnum.Value);
            TextJson.Deserialize<HundredDescribedEnum>("\"Plain\"", options).Should().Be(HundredDescribedEnum.Plain);
            Encoding.UTF8.GetString(stream.ToArray()).Should().Contain("Plain");
        }
    }

    // Cenário: materialização diária/ semanal cobre continueSequential e ShouldStopAfterSingleWeek.
    // Objetivo: cobrir RecurrenceMaterializer linhas 117 e 294.
    [Test]
    public void RecurrenceMaterializer_SequentialDailyAndSingleWeek_StopAtExpectedPoints()
    {
        // Arrange
        var monday = new DateTime(2026, 4, 6, 9, 0, 0);
        var dailySequential = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Daily,
            RecurrenceDays = [],
            MaxOccurrences = 10
        });
        var dailyWithEnd = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Daily,
            RecurrenceEndDate = monday.AddDays(2),
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
        var emptyWeek = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Weekly,
            RecurrenceDays = [DayOfWeek.Wednesday],
            MaxOccurrences = 1
        });

        // Act
        // Assert
        using (Assert.EnterMultipleScope())
        {
            dailySequential.Should().ContainSingle();
            dailyWithEnd.Count.Should().BeGreaterThan(1);
            singleWeek.Should().ContainSingle();
            emptyWeek.Should().ContainSingle();
        }
    }

    // Cenário: Excel com merge, sem merge e propriedade ignorada no resolver.
    // Objetivo: cobrir GetMergeCell null/count e IgnorableSerializer ramo não ignorado.
    [Test]
    public async Task ExcelAndSerializer_MergeAndKeepPaths_CoverRemainingBranches()
    {
        // Arrange
        Directory.CreateDirectory(_tempPath);
        var mergeOut = Path.Combine(_tempPath, "merge.xlsx");
        var plainOut = Path.Combine(_tempPath, "plain.xlsx");
        var excel = new SmartDigitalPsico.Core.SDK.Domain.Report.ExcelGeneratorOpenXmlAdapter();
        await excel.Generate(new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportWorkbookDataDto
        {
            Sheets =
            [
                new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportSheetDataDto
                {
                    Name = "Merged",
                    Rows = [new HundredRow { Label = "a", Secret = "hide" }],
                    MergeCellReferences = ["A1:B1"]
                },
                new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportSheetDataDto
                {
                    Name = "Plain",
                    Rows = [new HundredRow { Label = "b", Secret = "hide" }],
                    MergeCellReferences = null!
                }
            ]
        }, mergeOut);
        await excel.Generate(new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportWorkbookDataDto
        {
            Sheets = [new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportSheetDataDto { Name = "EmptyMerge", Rows = [new HundredRow { Label = "c" }], MergeCellReferences = [] }]
        }, plainOut);

        var resolver = new SmartDigitalPsico.Core.SDK.Domain.Helpers.IgnorableSerializerContractResolver(["Secret"]);
        var kept = Newtonsoft.Json.JsonConvert.SerializeObject(new HundredRow { Label = "x", Public = "y", Secret = "z" },
            new Newtonsoft.Json.JsonSerializerSettings { ContractResolver = resolver });

        // Act
        // Assert
        using (Assert.EnterMultipleScope())
        {
            File.Exists(mergeOut).Should().BeTrue();
            File.Exists(plainOut).Should().BeTrue();
            kept.Should().Contain("Public");
            kept.Should().NotContain("Secret");
        }
    }

    // Cenário: HelperValidation com pipe sem segunda parte e translate sem pipe.
    // Objetivo: cobrir ramos 48 e 71 de HelperValidation.
    [Test]
    public void HelperValidation_PipeAndTranslateEdges_CoverRemainingBranches()
    {
        // Arrange
        var singlePart = HelperValidation.GetErrorsMap(new ValidationResult(
            [new ValidationFailure("F", "OnlyKey_|") { ErrorCode = "legacy" }]))[0];
        var noUnderscore = HelperValidation.GetErrorsMap(new ValidationResult(
            [new ValidationFailure("F", "plain message") { ErrorCode = "legacy" }]))[0];
        var translated = HelperValidation.TranslateErroCode(new ErrorResponse
        {
            FullMessage = "OnlyKey_|",
            ErrorCode = "legacy"
        });

        // Act
        // Assert
        using (Assert.EnterMultipleScope())
        {
            singlePart.DefaultMessage.Should().BeEmpty();
            noUnderscore.ErrorCode.Should().Be("plain_message");
            translated.Message.Should().BeEmpty();
        }
    }

    // Cenário: validadores FluentValidation cobrem When true/false e overlap nullable.
    // Objetivo: fechar ramos restantes de schedule/calendar validators e TokenService.
    [Test]
    public async Task ValidatorsAndToken_RemainingWhenOverlapAndAlgBranches()
    {
        // Arrange
        var monday = DateTime.UtcNow.Date.AddDays(28).AddHours(9);
        while (monday.DayOfWeek != DayOfWeek.Monday)
            monday = monday.AddDays(1);

        var users = new Mock<IUserRepository>();
        users.Setup(r => r.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 9, Admin = false, TimeZone = "UTC" });
        users.Setup(r => r.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Medical = new Medical { Id = 9 }, TimeZone = "UTC" });
        users.Setup(r => r.FindByID(3)).Returns(Task.FromResult<User>(null!));

        var medicalRepo = new Mock<IMedicalRepository>();
        medicalRepo.Setup(r => r.FindByID(5)).ReturnsAsync(new Medical
        {
            WorkingDays = [monday.DayOfWeek],
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(18)
        });
        medicalRepo.Setup(r => r.Exists(It.IsAny<long>())).ReturnsAsync(true);
        medicalRepo.Setup(r => r.FindByCustomWhere(It.IsAny<System.Linq.Expressions.Expression<Func<Medical, bool>>>()))
            .ReturnsAsync([new Medical { WorkingDays = [monday.DayOfWeek], StartWorkingTime = TimeSpan.FromHours(8), EndWorkingTime = TimeSpan.FromHours(18) }]);

        var scheduleRepo = new Mock<IScheduleCalendarRepository>();
        scheduleRepo.Setup(r => r.GetConflictingItemsAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync([]);

        var scheduleKeys = new Mock<IScheduleKeyPolicy>();
        scheduleKeys.SetupGet(p => p.TenantKey).Returns("tenant");
        scheduleKeys.Setup(p => p.BuildOwnerKey(It.IsAny<long>())).Returns("owner");

        var calendarValidator = new MedicalCalendarValidator(medicalRepo.Object, users.Object, scheduleRepo.Object);
        var itemValidator = new ScheduleItemValidator(medicalRepo.Object);
        var overlapValidator = new ScheduleItemValidationContextValidator();
        var calendarItemValidator = new ScheduleCalendarItemValidator();
        var scheduleFields = new MedicalCalendarScheduleFieldsValidator();
        var calendarList = new MedicalCalendarListValidator(users.Object);
        var listValidator = new HundredRecordsListValidator(users.Object);
        var recordValidator = new HundredRecordValidator(users.Object);
        var patientFileList = new PatientFileSelectListValidator(users.Object);
        var medicalBase = new MedicalBaseValidator<MedicalCalendar>(medicalRepo.Object, Mock.Of<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalCalendar>>(), users.Object);

        const string secret = "0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef";
        var wrongAlg = new JwtSecurityTokenHandler().WriteToken(new JwtSecurityToken(
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret)), SecurityAlgorithms.HmacSha256)));
        var tokenService = new TokenService(new SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto { Secret = secret, Issuer = "i", Audience = "a", Minutes = 1 });

        var beforeHours = await InvokeBool(calendarValidator, "BeInWorkingHours", 5L, monday.Date.AddHours(7));
        var validTimed = await scheduleFields.ValidateAsync(new MedicalCalendar
        {
            Title = "Ok",
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!,
            RecurrenceType = ERecurrenceCalendarType.None,
            RecurrenceCount = 1
        });
        var validItem = await itemValidator.ValidateAsync(new ScheduleItem
        {
            MedicalId = 5,
            PatientId = 1,
            Title = "Ok",
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!
        });
        var validCalendarItem = await calendarItemValidator.ValidateAsync(new ScheduleCalendarItem
        {
            Title = "Ok",
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!
        });
        var overlapExistingNull = await overlapValidator.ValidateAsync(new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday.AddHours(2), EndDateTime = monday.AddHours(3) },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday, EndDateTime = null }]
        });
        var overlapNewNull = await overlapValidator.ValidateAsync(new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday, EndDateTime = null },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday.AddHours(2), EndDateTime = monday.AddHours(3) }]
        });
        var listNullUser = await listValidator.ValidateAsync(new RecordsList<Patient> { UserIdLogged = 3, Records = [new Patient()] });
        var listOwnerMatch = await listValidator.ValidateAsync(new RecordsList<Patient>
        {
            UserIdLogged = 1,
            Records = [new Patient { CreatedUser = new User { Id = 1 } }]
        });
        var recordOwnerMatch = await recordValidator.ValidateAsync(new Record<Patient>
        {
            UserIdLogged = 1,
            RecordEntity = new Patient { CreatedUser = new User { Id = 1 } }
        });
        var calendarListDenied = await calendarList.ValidateAsync(new RecordsList<MedicalCalendar>
        {
            UserIdLogged = 2,
            Records = [new MedicalCalendar { CreatedUserId = 1, MedicalId = 9 }]
        });
        var patientFileMatch = await patientFileList.ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 2,
            Records = [new PatientFile { CreatedUser = new User { Id = 2 }, Patient = new Patient { MedicalId = 9 } }]
        });
        var baseModifySkip = await medicalBase.MedicalModify(new MedicalCalendar { Id = 0, MedicalId = 9 }, 0, 2);
        var criteriaValidator = new ScheduleCriteriaDtoValidator(scheduleRepo.Object, Mock.Of<IPatientRepository>(), medicalRepo.Object, scheduleKeys.Object);
        var outsideHours = await InvokeBool(criteriaValidator, "BeWithinWorkingHours", new ScheduleCriteriaDto
        {
            MedicalId = 5,
            PatientId = 1,
            AppointmentDateTime = monday.Date.AddHours(7),
            TimeZone = "UTC"
        }, CancellationToken.None);

        // Act
        // Assert
        using (Assert.EnterMultipleScope())
        {
            beforeHours.Should().BeFalse();
            validTimed.Errors.Should().NotContain(e => e.ErrorMessage.Contains("BeforeEnd"));
            validItem.Errors.Should().NotContain(e => e.ErrorMessage.Contains("BeforeEnd"));
            validCalendarItem.Errors.Should().NotContain(e => e.ErrorMessage.Contains("BeforeEnd"));
            overlapExistingNull.IsValid.Should().BeTrue();
            overlapNewNull.IsValid.Should().BeTrue();
            listNullUser.IsValid.Should().BeFalse();
            listOwnerMatch.IsValid.Should().BeTrue();
            recordOwnerMatch.IsValid.Should().BeTrue();
            calendarListDenied.IsValid.Should().BeFalse();
            patientFileMatch.IsValid.Should().BeTrue();
            baseModifySkip.Should().BeTrue();
            outsideHours.Should().BeFalse();
            tokenService.Invoking(s => s.GetPrincipalFromExpiredToken(wrongAlg)).Should().Throw<SecurityTokenException>();
        }
    }

    private static async Task<bool> InvokeBool(object target, string methodName, params object?[] arguments)
    {
        var method = target.GetType()
            .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
            .First(m => m.Name == methodName && m.GetParameters().Length == arguments.Length);
        return await (Task<bool>)method.Invoke(target, arguments)!;
    }

    private enum HundredDescribedEnum
    {
        [System.ComponentModel.Description("Human value")] Value,
        Plain
    }

    private sealed class HundredRow
    {
        public string Label { get; init; } = string.Empty;
        public string Public { get; init; } = string.Empty;
        public string Secret { get; init; } = string.Empty;
    }

    // Cenário: assembly override e ramos finais de overlap/LogAppHelper/Token.
    // Objetivo: fechar últimos gaps de branch Domain.
    [Test]
    public async Task FinalDomainBranchPush_LogAppOverlapAndToken_CoversRemainingPaths()
    {
        // Arrange
        LogAppHelper.ProductAssemblyOverrideForTests = typeof(BranchCoverageHundredPercentTests).Assembly;
        try
        {
            var info = LogAppHelper.GetInformationVersionProduct();
        // Act
            // Assert
            info.Name.Should().Contain("SmartDigitalPsico.Domain.Test");
        }
        finally
        {
            LogAppHelper.ProductAssemblyOverrideForTests = null;
        }

        var monday = DateTime.UtcNow.Date.AddDays(35).AddHours(10);
        var overlapValidator = new ScheduleItemValidationContextValidator();
        var noOverlapBothNull = await overlapValidator.ValidateAsync(new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday, EndDateTime = null },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday.AddHours(5), EndDateTime = null }]
        });
        var overlapBothEnds = await overlapValidator.ValidateAsync(new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday, EndDateTime = monday.AddHours(2) },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday.AddHours(1), EndDateTime = monday.AddHours(3) }]
        });

        var itemValidator = new ScheduleItemValidator(Mock.Of<IMedicalRepository>());
        var failLessThan = await itemValidator.ValidateAsync(new ScheduleItem
        {
            MedicalId = 1,
            PatientId = 1,
            Title = "Bad",
            StartDateTime = monday.AddHours(3),
            EndDateTime = monday.AddHours(1),
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!
        });

        const string secret = "0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef";
        var validToken = new TokenService(new SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto { Secret = secret, Issuer = "i", Audience = "a", Minutes = 1 })
            .GenerateAccessToken([new Claim("sub", "1")]);
        var principal = new TokenService(new SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto { Secret = secret, Issuer = "i", Audience = "a", Minutes = 1 })
            .GetPrincipalFromExpiredToken(validToken);

        var dailyContinue = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Daily,
            RecurrenceCount = 3,
            RecurrenceEndDate = monday.AddDays(5),
            MaxOccurrences = 10
        });
        var stopWeek = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Weekly,
            RecurrenceDays = [monday.DayOfWeek],
            MaxOccurrences = 5
        });

        using (Assert.EnterMultipleScope())
        {
            noOverlapBothNull.IsValid.Should().BeTrue();
            overlapBothEnds.IsValid.Should().BeFalse();
            failLessThan.Errors.Should().Contain(e => e.ErrorMessage.Contains("BeforeEnd"));
            principal.Identity.Should().NotBeNull();
            dailyContinue.Count.Should().BeGreaterThan(1);
            stopWeek.Should().ContainSingle();
        }
    }

    private sealed class HundredRecordsListValidator : RecordsListValidator<Patient>
    {
        public HundredRecordsListValidator(IUserRepository userRepository) : base(userRepository) { }
    }

    private sealed class HundredRecordValidator : RecordValidator<Patient>
    {
        public HundredRecordValidator(IUserRepository userRepository) : base(userRepository) { }
    }
}
