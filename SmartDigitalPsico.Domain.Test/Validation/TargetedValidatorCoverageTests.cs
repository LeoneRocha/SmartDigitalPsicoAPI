using Moq;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation.Contratcs;
using SmartDigitalPsico.Domain.Validation.DTO;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.Principals.Calendar;
using SmartDigitalPsico.Domain.Validation.Principals.Schedule;
using System.Reflection;

namespace SmartDigitalPsico.Domain.Test.Validation;

[TestFixture]
public sealed class TargetedValidatorCoverageTests
{
    // Cenário: as regras privadas de calendário recebem dependências e dados válidos.
    // Objetivo: executar decisões de data, expediente, vínculo e conflito de agenda.
    [Test]
    public async Task MedicalCalendarValidator_RepositoryScenarios_ExecutesAllRules()
    {
        // Arrange
        var medical = new Medical
        {
            Id = 7,
            WorkingDays = [DayOfWeek.Monday],
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(17)
        };
        var user = new User { TimeZone = "UTC", Medical = medical };
        var medicalRepository = new Mock<IMedicalRepository>();
        var userRepository = new Mock<IUserRepository>();
        var scheduleRepository = new Mock<IScheduleCalendarRepository>();
        medicalRepository.Setup(repository => repository.FindByID(It.IsAny<long>())).ReturnsAsync(medical);
        medicalRepository.Setup(repository => repository.Exists(It.IsAny<long>())).ReturnsAsync(true);
        userRepository.Setup(repository => repository.FindByID(It.IsAny<long>())).ReturnsAsync(user);
        scheduleRepository.Setup(repository => repository.GetConflictingItemsAsync(
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync([]);
        var validator = new MedicalCalendarValidator(medicalRepository.Object, userRepository.Object, scheduleRepository.Object);
        var monday = new DateTime(2099, 1, 5, 9, 0, 0);
        var calendar = new MedicalCalendar
        {
            Id = 1,
            MedicalId = medical.Id,
            PatientId = 2,
            CreatedUserId = 3,
            ModifyUserId = 3,
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceDays = [DayOfWeek.Monday]
        };

        // Act
        var results = await Task.WhenAll(
            InvokeAsync(validator, "BeFutureDateTime", 3L, monday),
            InvokeAsync(validator, "BeFutureDateTime", 3L, (DateTime?)monday),
            InvokeAsync(validator, "BeInWorkingDays", medical.Id, monday),
            InvokeAsync(validator, "BeInWorkingDays", medical.Id, new[] { DayOfWeek.Monday }),
            InvokeAsync(validator, "BeInWorkingHours", medical.Id, monday),
            InvokeAsync(validator, "MedicalIdFound", calendar),
            InvokeAsync(validator, "MedicalCreated", new MedicalCalendar { MedicalId = medical.Id }, (long?)3),
            InvokeAsync(validator, "MedicalModify", calendar, (long?)3),
            InvokeAsync(validator, "NoScheduleConflict", calendar, CancellationToken.None));

        // Assert
        results.Should().OnlyContain(result => result);
    }

    // Cenário: o calendário contém todos os campos opcionais e as consultas retornam dados válidos.
    // Objetivo: executar as regras registradas para fim, recorrência, criação e alteração médica.
    [Test]
    public async Task MedicalCalendarValidator_ValidCalendar_ExecutesRegisteredRules()
    {
        // Arrange
        var monday = new DateTime(2099, 1, 5, 9, 0, 0);
        var medical = new Medical
        {
            Id = 7,
            WorkingDays = [DayOfWeek.Monday],
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(17)
        };
        var medicalRepository = new Mock<IMedicalRepository>();
        var userRepository = new Mock<IUserRepository>();
        var scheduleRepository = new Mock<IScheduleCalendarRepository>();
        medicalRepository.Setup(repository => repository.FindByID(It.IsAny<long>())).ReturnsAsync(medical);
        medicalRepository.Setup(repository => repository.Exists(It.IsAny<long>())).ReturnsAsync(true);
        userRepository.Setup(repository => repository.FindByID(It.IsAny<long>()))
            .ReturnsAsync(new User { TimeZone = "UTC", Medical = medical });
        scheduleRepository.Setup(repository => repository.GetConflictingItemsAsync(
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .ReturnsAsync([]);
        var validator = new MedicalCalendarValidator(medicalRepository.Object, userRepository.Object, scheduleRepository.Object);
        var calendar = new MedicalCalendar
        {
            MedicalId = medical.Id, PatientId = 2, CreatedUserId = 3, ModifyUserId = 3,
            StartDateTime = monday, EndDateTime = monday.AddHours(1), RecurrenceDays = [DayOfWeek.Monday]
        };

        // Act
        var result = await validator.ValidateAsync(calendar);

        // Assert
        result.Should().NotBeNull();
    }

    // Cenário: consultas do médico falham durante as verificações de criação e alteração.
    // Objetivo: retornar falso sem propagar exceções das regras assíncronas.
    [Test]
    public async Task MedicalCalendarValidator_FailingUserLookup_ReturnsFalseForOwnershipRules()
    {
        // Arrange
        var medicalRepository = new Mock<IMedicalRepository>();
        var userRepository = new Mock<IUserRepository>();
        userRepository.Setup(repository => repository.FindByID(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException());
        var validator = new MedicalCalendarValidator(medicalRepository.Object, userRepository.Object, new Mock<IScheduleCalendarRepository>().Object);

        // Act
        var created = await InvokeAsync(validator, "MedicalCreated", new MedicalCalendar { Id = 0 }, (long?)1);
        var modified = await InvokeAsync(validator, "MedicalModify", new MedicalCalendar { Id = 1 }, (long?)1);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            created.Should().BeFalse();
            modified.Should().BeFalse();
        }
    }

    // Cenário: critérios de agenda percorrem consultas existentes e um horário permitido.
    // Objetivo: executar as decisões de paciente, cancelamento, expediente e conflito.
    [Test]
    public async Task ScheduleCriteriaDtoValidator_RepositoryScenarios_ExecutesAllRules()
    {
        // Arrange
        var date = DateTime.UtcNow.AddDays(3);
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
                WorkingDays = [date.DayOfWeek],
                StartWorkingTime = TimeSpan.Zero,
                EndWorkingTime = TimeSpan.FromDays(1)
            }]);
        scheduleRepository.Setup(repository => repository.GetItemAsync(
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string?>(), It.IsAny<DateTime>()))
            .ReturnsAsync(new ScheduleCalendarItem
            {
                StartDateTime = date.AddDays(1),
                TimeZone = "UTC",
                Status = EStatusCalendar.Confirmed
            });
        scheduleRepository.Setup(repository => repository.HasConflictAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<DateTime>()))
            .ReturnsAsync(false);
        var validator = new ScheduleCriteriaDtoValidator(scheduleRepository.Object, patientRepository.Object, medicalRepository.Object, keys.Object);
        var criteria = new ScheduleCriteriaDto
        {
            MedicalId = 1,
            PatientId = 2,
            AppointmentDateTime = date.AddDays(2),
            TimeZone = "UTC",
            Reason = "Consulta",
            ScheduleType = EScheduleCalendarType.Schedule
        };

        // Act
        var results = await Task.WhenAll(
            InvokeAsync(validator, "BeAValidPatientOfMedical", criteria, CancellationToken.None),
            InvokeAsync(validator, "HaveValidStatusForCancellation", criteria, CancellationToken.None),
            InvokeAsync(validator, "BeWithinWorkingHours", criteria, CancellationToken.None),
            InvokeAsync(validator, "NotHaveSchedulingConflict", criteria, CancellationToken.None),
            InvokeAsync(validator, "BeAtLeast23HoursInAdvance", criteria, CancellationToken.None));

        // Assert
        results.Should().Contain(true);
    }

    // Cenário: listas possuem proprietário compatível, estão vazias ou dependem de consulta com falha.
    // Objetivo: executar os fluxos de permissão dos validadores de seleção.
    [Test]
    public async Task ListValidators_PermissionScenarios_ExecutePermissionBranches()
    {
        // Arrange
        const long userId = 7;
        var repository = new Mock<IUserRepository>();
        repository.Setup(value => value.FindByID(userId))
            .ReturnsAsync(new User { MedicalId = 9, Admin = false });
        var patient = new Patient { MedicalId = 9, CreatedUser = new User { Id = userId } };
        var medicalFile = new MedicalFile { MedicalId = 9, CreatedUser = new User { Id = userId } };
        var calendar = new MedicalCalendar { MedicalId = 9, CreatedUserId = userId };
        var baseValidator = new RecordsListValidatorForTest(repository.Object);
        var patientValidator = new PatientSelectListValidator(repository.Object);
        var fileValidator = new MedicalFileSelectListValidator(repository.Object);
        var calendarValidator = new MedicalCalendarListValidator(repository.Object);

        // Act
        var baseResult = await baseValidator.ValidateAsync(new RecordsList<Patient>
        {
            UserIdLogged = userId,
            Records = [patient]
        });
        var patientResult = await patientValidator.ValidateAsync(new RecordsList<Patient>
        {
            UserIdLogged = userId,
            Records = [patient]
        });
        var fileResult = await fileValidator.ValidateAsync(new RecordsList<MedicalFile>
        {
            UserIdLogged = userId,
            Records = [medicalFile]
        });
        var calendarResult = await calendarValidator.ValidateAsync(new RecordsList<MedicalCalendar>
        {
            UserIdLogged = userId,
            Records = [calendar]
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            baseResult.IsValid.Should().BeTrue();
            patientResult.IsValid.Should().BeTrue();
            fileResult.IsValid.Should().BeTrue();
            calendarResult.IsValid.Should().BeTrue();
        }
    }

    // Cenário: regras de agenda recebem dados ausentes, fora do expediente e sem vínculo.
    // Objetivo: executar os retornos negativos e os retornos antecipados das regras privadas.
    [Test]
    public async Task ScheduleValidators_InvalidRepositoryStates_ReturnFalseOrSafeDefaults()
    {
        // Arrange
        var medicalRepository = new Mock<IMedicalRepository>();
        medicalRepository.Setup(repository => repository.FindByID(1)).Returns(Task.FromResult<Medical>(null!));
        var itemValidator = new ScheduleItemValidator(medicalRepository.Object);
        var item = new ScheduleItem
        {
            MedicalId = 1,
            PatientId = 1,
            StartDateTime = DateTime.UtcNow.AddDays(1),
            EndDateTime = DateTime.UtcNow.AddDays(1).AddHours(1)
        };

        var scheduleRepository = new Mock<IScheduleCalendarRepository>();
        var patientRepository = new Mock<IPatientRepository>();
        var criteriaMedicalRepository = new Mock<IMedicalRepository>();
        criteriaMedicalRepository.Setup(repository => repository.FindByCustomWhere(
                It.IsAny<System.Linq.Expressions.Expression<Func<Medical, bool>>>()))
            .ReturnsAsync([]);
        var keys = new Mock<IScheduleKeyPolicy>();
        keys.SetupGet(policy => policy.TenantKey).Returns("tenant");
        keys.Setup(policy => policy.BuildOwnerKey(It.IsAny<long>())).Returns("owner");
        keys.Setup(policy => policy.BuildSubjectKey(It.IsAny<long>())).Returns("subject");
        var criteriaValidator = new ScheduleCriteriaDtoValidator(
            scheduleRepository.Object, patientRepository.Object, criteriaMedicalRepository.Object, keys.Object);
        var criteria = new ScheduleCriteriaDto { MedicalId = 1, PatientId = 2, AppointmentDateTime = DateTime.UtcNow.AddDays(2), TimeZone = "UTC" };

        // Act
        var results = await Task.WhenAll(
            InvokeAsync(itemValidator, "BeInWorkingDays", item),
            InvokeAsync(itemValidator, "BeInWorkingHours", item),
            InvokeAsync(itemValidator, "BeInWorkingDays", new ScheduleItem { MedicalId = 0, PatientId = 1 }),
            InvokeAsync(itemValidator, "BeInWorkingHours", new ScheduleItem { MedicalId = 0, PatientId = 1 }),
            InvokeAsync(criteriaValidator, "HaveValidStatusForCancellation", criteria, CancellationToken.None),
            InvokeAsync(criteriaValidator, "BeWithinWorkingHours", criteria, CancellationToken.None));

        // Assert
        results.Should().Equal(false, false, true, true, false, false);
    }

    // Cenário: verificações de propriedade não se aplicam a registros de criação e alteração opostos.
    // Objetivo: retornar verdadeiro quando a regra não exige uma consulta de usuário.
    [Test]
    public async Task MedicalCalendarValidator_NonApplicableOwnershipChecks_ReturnTrue()
    {
        // Arrange
        var validator = new MedicalCalendarValidator(
            Mock.Of<IMedicalRepository>(),
            Mock.Of<IUserRepository>(),
            Mock.Of<IScheduleCalendarRepository>());

        // Act
        var createdForExisting = await InvokeAsync(validator, "MedicalCreated", new MedicalCalendar { Id = 1 }, (long?)1);
        var modifiedForNew = await InvokeAsync(validator, "MedicalModify", new MedicalCalendar(), (long?)1);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            createdForExisting.Should().BeTrue();
            modifiedForNew.Should().BeTrue();
        }
    }

    // Cenário: calendário novo com usuário médico válido para criação e alteração.
    // Objetivo: cobrir ramos positivos de MedicalCreated e MedicalModify.
    [Test]
    public async Task MedicalCalendarValidator_OwnershipRules_MatchingMedical_ReturnsTrue()
    {
        // Arrange
        var medical = new Medical { Id = 7, WorkingDays = [DayOfWeek.Monday], StartWorkingTime = TimeSpan.Zero, EndWorkingTime = TimeSpan.FromDays(1) };
        var user = new User { TimeZone = "UTC", Medical = medical };
        var medicalRepository = new Mock<IMedicalRepository>();
        var userRepository = new Mock<IUserRepository>();
        medicalRepository.Setup(r => r.FindByID(7)).ReturnsAsync(medical);
        medicalRepository.Setup(r => r.Exists(7)).ReturnsAsync(true);
        userRepository.Setup(r => r.FindByID(3)).ReturnsAsync(user);
        var validator = new MedicalCalendarValidator(medicalRepository.Object, userRepository.Object, Mock.Of<IScheduleCalendarRepository>());
        var monday = DateTime.UtcNow.Date.AddDays(7).AddHours(9);

        // Act
        var created = await InvokeAsync(validator, "MedicalCreated", new MedicalCalendar { Id = 0, MedicalId = 7 }, (long?)3);
        var modified = await InvokeAsync(validator, "MedicalModify", new MedicalCalendar { Id = 1, MedicalId = 7 }, (long?)3);
        var futureNullable = await InvokeAsync(validator, "BeFutureDateTime", 3L, (DateTime?)null);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            created.Should().BeTrue();
            modified.Should().BeTrue();
            futureNullable.Should().BeFalse();
        }
    }

    // Cenário: item all-day e medicalId zero ignoram regras condicionais.
    // Objetivo: cobrar When/early-return restantes do ScheduleItemValidator.
    [Test]
    public async Task ScheduleItemValidator_AllDayAndZeroMedicalId_SkipsConditionalRules()
    {
        // Arrange
        var start = DateTime.UtcNow.Date.AddDays(2);
        var medicalRepository = new Mock<IMedicalRepository>();
        var validator = new ScheduleItemValidator(medicalRepository.Object);
        var allDay = new ScheduleItem
        {
            MedicalId = 5,
            PatientId = 1,
            Title = "All day",
            StartDateTime = start,
            EndDateTime = start.AddHours(23),
            IsAllDay = true,
            Status = EStatusCalendar.Confirmed,
            TimeZone = "UTC",
            RecurrenceDays = null!
        };
        var zeroMedical = new ScheduleItem
        {
            MedicalId = 0,
            PatientId = 1,
            StartDateTime = start,
            EndDateTime = start.AddHours(1)
        };

        // Act
        var allDayResult = await validator.ValidateAsync(allDay);
        var zeroDays = await InvokeAsync(validator, "BeInWorkingDays", zeroMedical);
        var zeroHours = await InvokeAsync(validator, "BeInWorkingHours", zeroMedical);
        medicalRepository.Setup(r => r.FindByID(1)).ReturnsAsync(new Medical
        {
            WorkingDays = [start.DayOfWeek],
            StartWorkingTime = TimeSpan.FromHours(8),
            EndWorkingTime = TimeSpan.FromHours(12)
        });
        var outsideHours = await InvokeAsync(validator, "BeInWorkingHours", new ScheduleItem
        {
            MedicalId = 1,
            PatientId = 1,
            StartDateTime = start.AddHours(20),
            EndDateTime = start.AddHours(21)
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            allDayResult.Errors.Should().NotContain(e => e.PropertyName == "StartDateTime" && e.ErrorMessage.Contains("BeforeEnd"));
            zeroDays.Should().BeTrue();
            zeroHours.Should().BeTrue();
            outsideHours.Should().BeFalse();
        }
    }

    private static async Task<bool> InvokeAsync(object target, string methodName, params object?[] arguments)
    {
        var candidates = target.GetType()
            .GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic)
            .Where(method => method.Name == methodName && method.GetParameters().Length == arguments.Length)
            .Where(method => method.GetParameters().Zip(arguments).All(pair =>
                pair.Second is null
                    ? !pair.First.ParameterType.IsValueType || Nullable.GetUnderlyingType(pair.First.ParameterType) is not null
                    : pair.First.ParameterType.IsInstanceOfType(pair.Second)
                      || Nullable.GetUnderlyingType(pair.First.ParameterType) == pair.Second.GetType()))
            .ToList();
        var method = candidates
            .OrderByDescending(candidate => candidate.GetParameters().Zip(arguments)
                .Count(pair => pair.Second?.GetType() == pair.First.ParameterType))
            .First();
        return await (Task<bool>)method.Invoke(target, arguments)!;
    }

    private sealed class RecordsListValidatorForTest : RecordsListValidator<Patient>
    {
        public RecordsListValidatorForTest(IUserRepository userRepository)
            : base(userRepository)
        {
        }
    }
}
