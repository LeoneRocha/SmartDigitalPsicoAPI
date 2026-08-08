using System.Reflection;
using System.Text.Json;
using Moq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.DTO.Security;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Report;
using SmartDigitalPsico.Domain.Security;
using SmartDigitalPsico.Domain.Validation.Contratcs;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.Principals.Calendar;
using SmartDigitalPsico.Domain.Validation.Principals.Schedule;
using SmartDigitalPsico.Domain.Validation.Schedule;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SmartDigitalPsico.Domain.Test.Coverage;

[TestFixture]
public class DomainBranchFinalPushTests
{
    // Cenário: When LessThan com IsAllDay true/false.
    // Objetivo: cobrir ambos os lados do predicado When nos validators de agenda.
    [Test]
    public async Task ScheduleValidators_AllDayAndTimed_CoverWhenBranches()
    {
        // Arrange
        var day = DateTime.UtcNow.Date;
        while (day.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
        {
            day = day.AddDays(1);
        }

        var allDay = new ScheduleCalendarItem
        {
            Title = "All day",
            StartDateTime = day,
            EndDateTime = day.AddDays(1),
            IsAllDay = true,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceCount = 1
        };
        var timed = new ScheduleCalendarItem
        {
            Title = "Timed",
            StartDateTime = day.AddHours(9),
            EndDateTime = day.AddHours(10),
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceCount = 1
        };
        var medicalAllDay = new MedicalCalendar
        {
            Title = "All day",
            StartDateTime = allDay.StartDateTime,
            EndDateTime = allDay.EndDateTime,
            IsAllDay = true,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceCount = 1
        };
        var medicalTimed = new MedicalCalendar
        {
            Title = "Timed",
            StartDateTime = timed.StartDateTime,
            EndDateTime = timed.EndDateTime,
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceCount = 1
        };
        var timedNoEnd = new ScheduleCalendarItem
        {
            Title = "No end",
            StartDateTime = day.AddHours(9),
            EndDateTime = null,
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceCount = 1
        };
        var medicalRepo = new Mock<IMedicalRepository>();
        medicalRepo.Setup(x => x.FindByID(1)).ReturnsAsync(new Medical
        {
            Id = 1,
            WorkingDays = Enum.GetValues<DayOfWeek>(),
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(18)
        });
        var scheduleItemValidator = new ScheduleItemValidator(medicalRepo.Object);
        var scheduleItem = new ScheduleItem
        {
            Title = "Timed",
            MedicalId = 1,
            PatientId = 2,
            StartDateTime = timed.StartDateTime,
            EndDateTime = timed.EndDateTime,
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!
        };
        var scheduleItemAllDay = new ScheduleItem
        {
            Title = "All day",
            MedicalId = 0,
            PatientId = 2,
            StartDateTime = allDay.StartDateTime,
            EndDateTime = allDay.EndDateTime,
            IsAllDay = true,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!
        };

        // Act
        var calendarAllDay = await new ScheduleCalendarItemValidator().ValidateAsync(allDay);
        var calendarTimed = await new ScheduleCalendarItemValidator().ValidateAsync(timed);
        var calendarNoEnd = await new ScheduleCalendarItemValidator().ValidateAsync(timedNoEnd);
        var medicalAllDayResult = await new MedicalCalendarScheduleFieldsValidator().ValidateAsync(medicalAllDay);
        var medicalTimedResult = await new MedicalCalendarScheduleFieldsValidator().ValidateAsync(medicalTimed);
        var medicalNoEnd = await new MedicalCalendarScheduleFieldsValidator().ValidateAsync(new MedicalCalendar
        {
            Title = "No end",
            StartDateTime = day.AddHours(9),
            EndDateTime = null,
            IsAllDay = false,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceCount = 1
        });
        var itemTimed = await scheduleItemValidator.ValidateAsync(scheduleItem);
        var itemAllDay = await scheduleItemValidator.ValidateAsync(scheduleItemAllDay);
        medicalRepo.Setup(x => x.FindByID(1)).Returns(Task.FromResult<Medical>(null!));
        var itemMissingMedical = await scheduleItemValidator.ValidateAsync(scheduleItem);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            calendarAllDay.IsValid.Should().BeTrue();
            calendarTimed.IsValid.Should().BeTrue();
            calendarNoEnd.IsValid.Should().BeFalse();
            medicalAllDayResult.IsValid.Should().BeTrue();
            medicalTimedResult.IsValid.Should().BeTrue();
            medicalNoEnd.IsValid.Should().BeFalse();
            itemTimed.IsValid.Should().BeTrue();
            itemAllDay.IsValid.Should().BeTrue();
            itemMissingMedical.IsValid.Should().BeFalse();
        }
    }

    // Cenário: overlap context com NewItem nulo e ExistingItems vazios.
    // Objetivo: cobrir ramos de NoTimeSlotOverlap.
    [Test]
    public async Task ScheduleItemValidationContextValidator_NullNewItemAndEmptyExisting_IsValid()
    {
        // Arrange
        var validator = new ScheduleItemValidationContextValidator();
        var empty = new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = DateTime.UtcNow, EndDateTime = DateTime.UtcNow.AddHours(1) },
            ExistingItems = []
        };
        var nullNew = new ScheduleItemValidationContext
        {
            NewItem = null!,
            ExistingItems =
            [
                new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = DateTime.UtcNow, EndDateTime = DateTime.UtcNow.AddHours(1) }
            ]
        };

        // Act
        var emptyResult = await validator.ValidateAsync(empty);
        var nullNewResult = await validator.ValidateAsync(nullNew);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            emptyResult.IsValid.Should().BeTrue();
            nullNewResult.IsValid.Should().BeTrue();
        }
    }

    // Cenário: RecordsListValidator e BasePatientSelectListValidator com CreatedUser/Patient nulos.
    // Objetivo: cobrir TrueForAll com null-conditional falso.
    [Test]
    public async Task ListValidators_NullCreatedUserAndPatient_ReturnPermissionFailure()
    {
        // Arrange
        var repository = new Mock<IUserRepository>();
        repository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 9, Admin = false });
        var baseList = new TestRecordsListValidator(repository.Object);
        var patientFileList = new PatientFileSelectListValidator(repository.Object);

        // Act
        var nullCreated = await baseList.ValidateAsync(new RecordsList<Patient>
        {
            UserIdLogged = 1,
            Records = [new Patient { Id = 1, MedicalId = 9, CreatedUser = null }]
        });
        var nullPatient = await patientFileList.ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 1,
            Records = [new PatientFile { Id = 1, Patient = null, CreatedUser = new User { Id = 1 } }]
        });
        var emptyBase = await baseList.ValidateAsync(new RecordsList<Patient> { UserIdLogged = 1, Records = [] });
        repository.Setup(x => x.FindByID(2)).Returns(Task.FromResult<User>(null!));
        var nullUser = await baseList.ValidateAsync(new RecordsList<Patient>
        {
            UserIdLogged = 2,
            Records = [new Patient { Id = 1, CreatedUser = new User { Id = 1 } }]
        });
        repository.Setup(x => x.FindByID(3)).ReturnsAsync(new User { Id = 3, MedicalId = 9, Admin = true });
        var adminBypass = await baseList.ValidateAsync(new RecordsList<Patient>
        {
            UserIdLogged = 3,
            Records = [new Patient { Id = 1, MedicalId = 9, CreatedUser = new User { Id = 999 } }]
        });
        var patientMatch = await patientFileList.ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 1,
            Records =
            [
                new PatientFile
                {
                    Id = 1,
                    Patient = new Patient { Id = 2, MedicalId = 9 },
                    CreatedUser = new User { Id = 1 }
                }
            ]
        });
        var patientMedicalMismatch = await patientFileList.ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 1,
            Records =
            [
                new PatientFile
                {
                    Id = 1,
                    Patient = new Patient { Id = 2, MedicalId = 99 },
                    CreatedUser = new User { Id = 1 }
                }
            ]
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            nullCreated.IsValid.Should().BeFalse();
            nullPatient.IsValid.Should().BeFalse();
            emptyBase.IsValid.Should().BeTrue();
            nullUser.IsValid.Should().BeFalse();
            adminBypass.IsValid.Should().BeTrue();
            patientMatch.IsValid.Should().BeTrue();
            patientMedicalMismatch.IsValid.Should().BeFalse();
        }
    }

    // Cenário: SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.IgnorableSerializerContractResolver com PropertyName nulo e propriedade ignorada.
    // Objetivo: cobrir CreateProperty ramos.
    [Test]
    public void IgnorableSerializerContractResolver_NullAndIgnoredPropertyNames_CoverBranches()
    {
        // Arrange
        var resolver = new SmartDigitalPsico.Domain.Helpers.IgnorableSerializerContractResolver(["Secret"]);
        var settings = new JsonSerializerSettings { ContractResolver = resolver };
        var json = JsonConvert.SerializeObject(new FinalRow { Label = "x", Public = "y", Secret = "z" }, settings);
        resolver.ApplyIgnoreRulesForTests(new Newtonsoft.Json.Serialization.JsonProperty { PropertyName = "Secret" });
        resolver.ApplyIgnoreRulesForTests(new Newtonsoft.Json.Serialization.JsonProperty { PropertyName = "Public" });

        // Assert
        // Act
        json.Should().Contain("Label").And.NotContain("Secret");
    }

    // Cenário: LogAppHelper ResolveProductAssembly com override e sem entry assembly.
    // Objetivo: cobrir ?? GetEntryAssembly / GetExecutingAssembly.
    [Test]
    public void LogAppHelper_ResolveProductAssembly_OverrideAndFallbacks()
    {
        // Arrange
        var previous = LogAppHelper.ProductAssemblyOverrideForTests;
        var previousEntry = LogAppHelper.EntryAssemblyProviderForTests;
        var previousFallback = LogAppHelper.EntryAssemblyFallbackForTests;
        var previousForceHost = LogAppHelper.ForceNullHostEnvironmentForTests;
        try
        {
            LogAppHelper.ProductAssemblyOverrideForTests = typeof(LogAppHelper).Assembly;
            var withOverride = LogAppHelper.GetAssemblyVersion();
            LogAppHelper.ProductAssemblyOverrideForTests = null;
            LogAppHelper.EntryAssemblyProviderForTests = () => null;
            LogAppHelper.EntryAssemblyFallbackForTests = () => typeof(DomainBranchFinalPushTests).Assembly;
            var withFallback = LogAppHelper.GetAssemblyVersion();
            LogAppHelper.EntryAssemblyProviderForTests = null;
            LogAppHelper.EntryAssemblyFallbackForTests = () => null;
            var withEntryAssembly = LogAppHelper.GetAssemblyVersion();
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", null);
            LogAppHelper.ForceNullHostEnvironmentForTests = true;
            var info = LogAppHelper.GetInformationVersionProduct();

        // Assert
            // Act
            using (Assert.EnterMultipleScope())
            {
                withOverride.Should().NotBeNullOrEmpty();
                withFallback.Should().NotBeNullOrEmpty();
                withEntryAssembly.Should().NotBeNullOrEmpty();
                info.EnvironmentName.Should().Be("Undefined");
            }
        }
        finally
        {
            LogAppHelper.ProductAssemblyOverrideForTests = previous;
            LogAppHelper.EntryAssemblyProviderForTests = previousEntry;
            LogAppHelper.EntryAssemblyFallbackForTests = previousFallback;
            LogAppHelper.ForceNullHostEnvironmentForTests = previousForceHost;
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");
        }
    }

    // Cenário: token JWT com algoritmo inválido.
    // Objetivo: cobrir ramo SecurityTokenException em GetPrincipalFromExpiredToken.
    [Test]
    public void TokenService_GetPrincipalFromExpiredToken_InvalidAlg_Throws()
    {
        // Arrange
        var config = new SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Security.TokenConfigurationDto
        {
            Issuer = "issuer",
            Audience = "audience",
            Secret = "a sufficiently long signing secret for jwt tests 123456"
        };
        var service = new TokenService(config);
        var handler = new JwtSecurityTokenHandler();
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.Secret));
        var token = handler.CreateEncodedJwt(new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity([new Claim(ClaimTypes.Name, "u")]),
            NotBefore = DateTime.UtcNow.AddMinutes(-10),
            Expires = DateTime.UtcNow.AddMinutes(-5),
            Issuer = config.Issuer,
            Audience = config.Audience,
            SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
        });

        // Act
        var act = () => service.GetPrincipalFromExpiredToken(token);

        // Assert
        act.Should().Throw<SecurityTokenException>();
    }

    // Cenário: LogAppHelper, SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.EnumDescriptionConverter e RecurrenceMaterializer com ramos finais.
    // Objetivo: fechar branches restantes de assembly, enum e recorrência.
    [Test]
    public void DomainBranchFinalGaps_LogAppValidatorsRecurrenceEnum_CloseRemainingBranches()
    {
        // Arrange
        var previousEntry = LogAppHelper.EntryAssemblyProviderForTests;
        var previousFallback = LogAppHelper.EntryAssemblyFallbackForTests;
        var previousForceHost = LogAppHelper.ForceNullHostEnvironmentForTests;
        try
        {
            LogAppHelper.ProductAssemblyOverrideForTests = null;
            LogAppHelper.EntryAssemblyProviderForTests = () => null;
            LogAppHelper.EntryAssemblyFallbackForTests = () => typeof(DomainBranchFinalPushTests).Assembly;
        // Act
            // Assert
            LogAppHelper.GetAssemblyVersion().Should().NotBeNullOrEmpty();

            LogAppHelper.ForceNullHostEnvironmentForTests = true;
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", null);
            LogAppHelper.GetInformationVersionProduct().EnvironmentName.Should().Be("Undefined");

            var converter = new SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.EnumDescriptionConverter<FinalDescribedEnum>();
            var bytes = Encoding.UTF8.GetBytes("\"Human\"");
            var reader = new Utf8JsonReader(bytes);
            reader.Read();
            converter.Read(ref reader, typeof(FinalDescribedEnum), new JsonSerializerOptions()).Should().Be(FinalDescribedEnum.Value);

            var fromDescription = typeof(SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.EnumDescriptionConverter<FinalDescribedEnum>)
                .GetMethod("TryGetEnumValueFromDescription", BindingFlags.NonPublic | BindingFlags.Static)!;
            var fromName = typeof(SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.EnumDescriptionConverter<FinalDescribedEnum>)
                .GetMethod("TryGetEnumValueFromName", BindingFlags.NonPublic | BindingFlags.Static)!;
            var otherField = typeof(OtherDescribedEnum).GetField(nameof(OtherDescribedEnum.Value))!;
            ((bool)fromDescription.Invoke(null, [otherField, "OtherHuman", null])!).Should().BeFalse();
            ((bool)fromName.Invoke(null, [otherField, nameof(OtherDescribedEnum.Value), null])!).Should().BeFalse();

            var monday = DateTime.UtcNow.Date.AddDays(50).AddHours(9);
            RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
            {
                StartDateTime = monday, EndDateTime = monday.AddHours(1), RecurrenceType = ERecurrenceCalendarType.Daily,
                RecurrenceCount = 2, MaxOccurrences = 10
            }).Count.Should().BeGreaterThan(1);
            RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
            {
                StartDateTime = monday, EndDateTime = monday.AddHours(1), RecurrenceType = ERecurrenceCalendarType.Daily,
                RecurrenceEndDate = monday.AddDays(2), MaxOccurrences = 10
            }).Count.Should().BeGreaterThan(1);
            RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
            {
                StartDateTime = monday, EndDateTime = monday.AddHours(1), RecurrenceType = ERecurrenceCalendarType.Daily,
                MaxOccurrences = 2
            }).Should().ContainSingle();

            var stopWeek = typeof(RecurrenceMaterializer).GetMethod("ShouldStopAfterSingleWeek", BindingFlags.NonPublic | BindingFlags.Static)!;
            var emptyItems = new List<RecurrenceInterval>();
            var unbounded = new RecurrenceMaterializeRequest { MaxOccurrences = 5 };
            ((bool)stopWeek.Invoke(null, [unbounded, emptyItems])!).Should().BeFalse();
            emptyItems.Add(new RecurrenceInterval { StartDateTime = monday, EndDateTime = monday.AddHours(1) });
            ((bool)stopWeek.Invoke(null, [unbounded, emptyItems])!).Should().BeTrue();
            var boundedByCount = new RecurrenceMaterializeRequest { RecurrenceCount = 2, MaxOccurrences = 5 };
            ((bool)stopWeek.Invoke(null, [boundedByCount, emptyItems])!).Should().BeFalse();
            var boundedByEnd = new RecurrenceMaterializeRequest { RecurrenceEndDate = monday.AddDays(1), MaxOccurrences = 5 };
            ((bool)stopWeek.Invoke(null, [boundedByEnd, emptyItems])!).Should().BeFalse();
        }
        finally
        {
            LogAppHelper.EntryAssemblyProviderForTests = previousEntry;
            LogAppHelper.EntryAssemblyFallbackForTests = previousFallback;
            LogAppHelper.ForceNullHostEnvironmentForTests = previousForceHost;
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");
        }
    }

    // Cenário: validadores de agenda com LessThan e horário de trabalho.
    // Objetivo: cobrir ramos When restantes de data e WorkingHours.
    [Test]
    public async Task DomainBranchFinalGaps_WhenLessThanAndWorkingHours_CloseRemainingBranches()
    {
        // Arrange
        var start = DateTime.UtcNow.Date.AddHours(10);
        var badTimed = new ScheduleCalendarItem
        {
            Title = "Bad", StartDateTime = start.AddHours(2), EndDateTime = start.AddHours(1), IsAllDay = false
        };
        var noEnd = new ScheduleCalendarItem
        {
            Title = "No end", StartDateTime = start, EndDateTime = null, IsAllDay = false
        };
        var badMedical = new MedicalCalendar
        {
            Title = "Bad", StartDateTime = start.AddHours(2), EndDateTime = start.AddHours(1), IsAllDay = false,
            Status = EStatusCalendar.Confirmed, TimeZone = "UTC", RecurrenceCount = 0
        };

        // Act
        // Assert
        (await new ScheduleCalendarItemValidator().ValidateAsync(badTimed)).IsValid.Should().BeFalse();
        (await new ScheduleCalendarItemValidator().ValidateAsync(noEnd)).IsValid.Should().BeFalse();
        (await new MedicalCalendarScheduleFieldsValidator().ValidateAsync(badMedical)).IsValid.Should().BeFalse();

        var medicalRepo = new Mock<IMedicalRepository>();
        medicalRepo.Setup(x => x.FindByID(5)).ReturnsAsync(new Medical
        {
            Id = 5, WorkingDays = [DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday],
            StartWorkingTime = TimeSpan.FromHours(8), EndWorkingTime = TimeSpan.FromHours(18)
        });
        var itemValidator = new ScheduleItemValidator(medicalRepo.Object);
        (await itemValidator.ValidateAsync(new ScheduleItem
        {
            MedicalId = 5, PatientId = 1, Title = "Early", StartDateTime = start.Date.AddHours(6), EndDateTime = start.Date.AddHours(7),
            IsAllDay = false, Status = EStatusCalendar.Confirmed, TimeZone = "UTC", RecurrenceDays = null!
        })).IsValid.Should().BeFalse();
        (await itemValidator.ValidateAsync(new ScheduleItem
        {
            MedicalId = 0, PatientId = 1, Title = "No end", StartDateTime = start, EndDateTime = null,
            IsAllDay = false, Status = EStatusCalendar.Confirmed, TimeZone = "UTC", RecurrenceDays = null!
        })).Errors.Should().NotContain(e => e.ErrorCode.Contains("StartDateTime.LessThan"));
    }

    // Cenário: MedicalBaseValidator e PatientFileSelectListValidator em limites.
    // Objetivo: cobrir create/modify e listas de paciente com usuário/médico.
    [Test]
    public async Task DomainBranchFinalGaps_MedicalBaseAndPatientList_CloseRemainingBranches()
    {
        // Arrange
        var medicalRepo = new Mock<IMedicalRepository>();
        var entityRepo = new Mock<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalCalendar>>();
        var userRepo = new Mock<IUserRepository>();
        userRepo.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Medical = new Medical { Id = 5 } });
        var validator = new TestMedicalBaseValidator(medicalRepo.Object, entityRepo.Object, userRepo.Object);
        // Act
        // Assert
        (await validator.MedicalCreated(new MedicalCalendar { Id = 9, MedicalId = 5 }, 0, 1)).Should().BeTrue();

        var repository = new Mock<IUserRepository>();
        repository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9 });
        var patientList = new PatientFileSelectListValidator(repository.Object);
        (await patientList.ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 2,
            Records = [new PatientFile { CreatedUser = new User { Id = 3 }, Patient = new Patient { MedicalId = 9 } }]
        })).IsValid.Should().BeFalse();
        (await patientList.ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 2,
            Records = [new PatientFile { CreatedUser = null, Patient = new Patient { MedicalId = 9 } }]
        })).IsValid.Should().BeFalse();
        (await patientList.ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 2,
            Records = [new PatientFile { CreatedUser = new User { Id = 2 }, Patient = new Patient { MedicalId = 9 } }]
        })).IsValid.Should().BeTrue();
    }

    // Cenário: LogAppHelper sem entry assembly e Excel AddHeaderRow nulo.
    // Objetivo: cobrir fallbacks de versão e caminho nulo do cabeçalho.
    [Test]
    public void DomainBranchFinalGaps_LogAppExcelNullPaths_CloseRemainingBranches()
    {
        // Arrange
        var previousForceEntry = LogAppHelper.ForceNullEntryAssemblyForTests;
        var previousOverride = LogAppHelper.ProductAssemblyOverrideForTests;
        var previousEntry = LogAppHelper.EntryAssemblyProviderForTests;
        var previousFallback = LogAppHelper.EntryAssemblyFallbackForTests;
        try
        {
            LogAppHelper.ProductAssemblyOverrideForTests = null;
            LogAppHelper.EntryAssemblyProviderForTests = null;
            LogAppHelper.EntryAssemblyFallbackForTests = null;
            LogAppHelper.ForceNullEntryAssemblyForTests = true;
        // Act
            // Assert
            LogAppHelper.GetAssemblyVersion().Should().NotBeNullOrEmpty();
        }
        finally
        {
            LogAppHelper.ForceNullEntryAssemblyForTests = previousForceEntry;
            LogAppHelper.ProductAssemblyOverrideForTests = previousOverride;
            LogAppHelper.EntryAssemblyProviderForTests = previousEntry;
            LogAppHelper.EntryAssemblyFallbackForTests = previousFallback;
        }

        var addHeader = typeof(SmartDigitalPsicoAPI.Core.SDK.Domain.Report.ExcelGeneratorOpenXmlAdapter)
            .GetMethod("AddHeaderRow", BindingFlags.NonPublic | BindingFlags.Static)!;
        var sheet = new DocumentFormat.OpenXml.Spreadsheet.SheetData();
        addHeader.Invoke(null, [null, new List<string>(), sheet]);
        addHeader.Invoke(null, [new FinalRow { Label = "hdr" }, new List<string>(), sheet]);
        sheet.ChildElements.Should().NotBeEmpty();
    }

    // Cenário: TokenService com HMAC-SHA512 e factory padrão/override.
    // Objetivo: obter principal de token expirado com algoritmo válido.
    [Test]
    public void TokenService_GetPrincipalFromExpiredToken_ValidHmac512_Succeeds()
    {
        // Arrange
        const string secret = "0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef";
        var service = new TokenService(new SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Security.TokenConfigurationDto { Secret = secret, Issuer = "i", Audience = "a", Minutes = 1 });
        var token = service.GenerateAccessToken([new Claim("sub", "1")]);
        // Act
        // Assert
        service.GetPrincipalFromExpiredToken(token).Identity.Should().NotBeNull();
        TokenService.TokenHandlerFactoryForTests = () => new JwtSecurityTokenHandler();
        try
        {
            service.GetPrincipalFromExpiredToken(token).Identity.Should().NotBeNull();
        }
        finally
        {
            TokenService.TokenHandlerFactoryForTests = null;
        }
    }

    // Cenário: TokenService recebe token que não é JwtSecurityToken.
    // Objetivo: lançar SecurityTokenException no ramo de validação.
    [Test]
    public void TokenService_GetPrincipalFromExpiredToken_NonJwtSecurityToken_Throws()
    {
        // Arrange
        var previous = TokenService.TokenHandlerFactoryForTests;
        try
        {
            TokenService.TokenHandlerFactoryForTests = () => new NonJwtTokenHandler();
            var service = new TokenService(new SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Security.TokenConfigurationDto
            {
                Secret = "0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef",
                Issuer = "i",
                Audience = "a",
                Minutes = 1
            });
            var act = () => service.GetPrincipalFromExpiredToken("any");

            // Act
            // Assert
            act.Should().Throw<SecurityTokenException>();
        }
        finally
        {
            TokenService.TokenHandlerFactoryForTests = previous;
        }
    }

    // Cenário: MedicalBaseValidator em create e modify com entidades nulas/divergentes.
    // Objetivo: cobrir todos os retornos booleanos dos helpers de permissão.
    [Test]
    public async Task MedicalBaseValidator_CreateAndModifyBranches_AreCovered()
    {
        // Arrange
        var medicalRepo = new Mock<IMedicalRepository>();
        medicalRepo.Setup(x => x.Exists(It.IsAny<long>())).ReturnsAsync(true);
        var entityRepo = new Mock<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalCalendar>>();
        entityRepo.Setup(x => x.Exists(It.IsAny<long>())).ReturnsAsync(false);
        var userRepo = new Mock<IUserRepository>();
        userRepo.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Medical = new Medical { Id = 5 } });
        var validator = new TestMedicalBaseValidator(medicalRepo.Object, entityRepo.Object, userRepo.Object);

        // Act
        // Assert
        (await validator.MedicalCreated(new MedicalCalendar { Id = 0, MedicalId = 5 }, 0, 1)).Should().BeTrue();
        (await validator.MedicalCreated(new MedicalCalendar { Id = 0, MedicalId = 9 }, 0, 1)).Should().BeFalse();
        (await validator.MedicalCreated(null!, 0, 1)).Should().BeTrue();
        (await validator.MedicalModify(new MedicalCalendar { Id = 3, MedicalId = 5 }, 0, 1)).Should().BeTrue();
        (await validator.MedicalModify(new MedicalCalendar { Id = 0, MedicalId = 9 }, 0, 1)).Should().BeTrue();
        (await validator.MedicalModify(null!, 0, 1)).Should().BeTrue();
    }

    // Cenário: ScheduleItemValidator com horários dentro e fora do expediente.
    // Objetivo: cobrir retornos de WorkingHours nos ramos MustAsync.
    [Test]
    public async Task ScheduleItemValidator_WorkingHoursReturnBranches_AreCovered()
    {
        // Arrange
        var medicalRepo = new Mock<IMedicalRepository>();
        medicalRepo.Setup(x => x.FindByID(5)).ReturnsAsync(new Medical
        {
            Id = 5,
            WorkingDays = [DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday],
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(18)
        });
        var validator = new ScheduleItemValidator(medicalRepo.Object);
        var start = DateTime.UtcNow.Date.AddHours(10);
        var inHours = await validator.ValidateAsync(new ScheduleItem
        {
            MedicalId = 5, PatientId = 1, Title = "Ok", StartDateTime = start, EndDateTime = start.AddHours(1),
            IsAllDay = false, Status = EStatusCalendar.Confirmed, TimeZone = "UTC", RecurrenceDays = null!
        });
        var outOfHours = await validator.ValidateAsync(new ScheduleItem
        {
            MedicalId = 5, PatientId = 1, Title = "Late", StartDateTime = start.Date.AddHours(20), EndDateTime = start.Date.AddHours(21),
            IsAllDay = false, Status = EStatusCalendar.Confirmed, TimeZone = "UTC", RecurrenceDays = null!
        });
        var endPastWorking = await validator.ValidateAsync(new ScheduleItem
        {
            MedicalId = 5, PatientId = 1, Title = "Long", StartDateTime = start, EndDateTime = start.Date.AddHours(20),
            IsAllDay = false, Status = EStatusCalendar.Confirmed, TimeZone = "UTC", RecurrenceDays = null!
        });
        // Act
        // Assert
        inHours.Errors.Should().NotContain(e => e.ErrorMessage.Contains("WorkingHours"));
        outOfHours.Errors.Should().Contain(e => e.ErrorMessage.Contains("WorkingHours"));
        endPastWorking.Errors.Should().Contain(e => e.ErrorMessage.Contains("WorkingHours"));
    }

    // Cenário: ScheduleItemValidationContextValidator com overlap, sem overlap e nulos.
    // Objetivo: cobrir todos os ramos de conflito de agenda.
    [Test]
    public async Task ScheduleItemValidationContextValidator_AllOverlapBranches_AreCovered()
    {
        // Arrange
        var monday = DateTime.UtcNow.Date.AddDays(45).AddHours(10);
        var validator = new ScheduleItemValidationContextValidator();
        var overlap = await validator.ValidateAsync(new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday, EndDateTime = monday.AddHours(2) },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday.AddHours(1), EndDateTime = monday.AddHours(3) }]
        });
        var noOverlap = await validator.ValidateAsync(new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday, EndDateTime = monday.AddHours(1) },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday.AddHours(2), EndDateTime = monday.AddHours(3) }]
        });
        var nullExisting = await validator.ValidateAsync(new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday, EndDateTime = monday.AddHours(1) },
            ExistingItems = null!
        });
        var existingNullEnd = await validator.ValidateAsync(new ScheduleItemValidationContext
        {
            NewItem = new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday, EndDateTime = monday.AddHours(2) },
            ExistingItems = [new ScheduleItem { MedicalId = 1, PatientId = 1, StartDateTime = monday.AddHours(1), EndDateTime = null }]
        });
        // Act
        // Assert
        overlap.IsValid.Should().BeFalse();
        noOverlap.IsValid.Should().BeTrue();
        nullExisting.IsValid.Should().BeTrue();
        existingNullEnd.IsValid.Should().BeTrue();
    }

    // Cenário: SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.EnumDescriptionConverter, RecurrenceMaterializer e LogAppHelper finais.
    // Objetivo: fechar branches restantes de descrição, recorrência e assembly.
    [Test]
    public void EnumConverter_RecurrenceAndLogApp_FinalBranches()
    {
        // Arrange
        LogAppHelper.EntryAssemblyProviderForTests = () => typeof(DomainBranchFinalPushTests).Assembly;
        try
        {
        // Act
            // Assert
            LogAppHelper.GetAssemblyVersion().Should().NotBeNullOrEmpty();
        }
        finally
        {
            LogAppHelper.EntryAssemblyProviderForTests = null;
        }

        var converter = new SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.EnumDescriptionConverter<FinalDescribedEnum>();
        var fromDescription = typeof(SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.EnumDescriptionConverter<FinalDescribedEnum>)
            .GetMethod("TryGetEnumValueFromDescription", BindingFlags.NonPublic | BindingFlags.Static)!;
        var fromName = typeof(SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.EnumDescriptionConverter<FinalDescribedEnum>)
            .GetMethod("TryGetEnumValueFromName", BindingFlags.NonPublic | BindingFlags.Static)!;
        var field = typeof(FinalDescribedEnum).GetField(nameof(FinalDescribedEnum.Value))!;
        var argsDesc = new object?[] { field, "Wrong", null };
        var argsName = new object?[] { field, nameof(FinalDescribedEnum.Value), null };
        var plainField = typeof(FinalDescribedEnum).GetField(nameof(FinalDescribedEnum.Plain))!;
        var argsPlainDesc = new object?[] { plainField, "Human", null };
        ((bool)fromDescription.Invoke(null, argsPlainDesc)!).Should().BeFalse();
        var argsWrongName = new object?[] { plainField, "PlainWrong", null };
        ((bool)fromName.Invoke(null, argsWrongName)!).Should().BeFalse();

        var monday = DateTime.UtcNow.Date.AddDays(40).AddHours(9);
        RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday, EndDateTime = monday.AddHours(1), RecurrenceType = ERecurrenceCalendarType.Daily,
            RecurrenceCount = 2, RecurrenceEndDate = monday.AddDays(3), MaxOccurrences = 10
        }).Count.Should().BeGreaterThan(1);
        RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday, EndDateTime = monday.AddHours(1), RecurrenceType = ERecurrenceCalendarType.Daily, MaxOccurrences = 2
        }).Should().ContainSingle();
        RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday, EndDateTime = monday.AddHours(1), RecurrenceType = ERecurrenceCalendarType.Weekly,
            RecurrenceDays = [monday.DayOfWeek], MaxOccurrences = 10
        }).Should().ContainSingle();
    }

    private enum FinalDescribedEnum
    {
        [System.ComponentModel.Description("Human")] Value,
        Plain
    }

    private enum OtherDescribedEnum
    {
        [System.ComponentModel.Description("OtherHuman")] Value
    }

    private sealed class NonJwtTokenHandler : JwtSecurityTokenHandler
    {
        public override ClaimsPrincipal ValidateToken(string token, TokenValidationParameters validationParameters, out SecurityToken validatedToken)
        {
            validatedToken = new DummySecurityToken();
            return new ClaimsPrincipal(new ClaimsIdentity([new Claim("sub", "1")]));
        }
    }

    private sealed class DummySecurityToken : SecurityToken
    {
        public override string Id => "dummy";
        public override string Issuer => "i";
        public override SecurityKey SecurityKey => null!;
        public override SecurityKey SigningKey { get; set; } = null!;
        public override DateTime ValidFrom => DateTime.UtcNow.AddHours(-1);
        public override DateTime ValidTo => DateTime.UtcNow.AddHours(1);
    }

    private sealed class FinalRow
    {
        public string Label { get; init; } = string.Empty;
        public string Public { get; init; } = string.Empty;
        public string Secret { get; init; } = string.Empty;
    }

    private sealed class TestMedicalBaseValidator : SmartDigitalPsico.Domain.Validation.Base.MedicalBaseValidator<MedicalCalendar>
    {
        public TestMedicalBaseValidator(IMedicalRepository medicalRepository, SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalCalendar> entityRepository, IUserRepository userRepository)
            : base(medicalRepository, entityRepository, userRepository) { }
    }

    private sealed class TestRecordsListValidator : RecordsListValidator<Patient>
    {
        public TestRecordsListValidator(IUserRepository userRepository) : base(userRepository)
        {
        }
    }
}
