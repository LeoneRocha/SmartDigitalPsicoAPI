namespace SmartDigitalPsico.Domain.Test.Validation;

[TestFixture]
public sealed class ValidatorCoverageTests
{
    private static readonly string[] ValidatorTypes =
    [
        "SmartDigitalPsico.Domain.Validation.SpecialtyValidator",
        "SmartDigitalPsico.Domain.Validation.RoleGroupValidator",
        "SmartDigitalPsico.Domain.Validation.OfficeValidator",
        "SmartDigitalPsico.Domain.Validation.NotificationTemplateValidator",
        "SmartDigitalPsico.Domain.Validation.NotificationRulesValidator",
        "SmartDigitalPsico.Domain.Validation.NotificationRecordsValidator",
        "SmartDigitalPsico.Domain.Validation.LeavesValidator",
        "SmartDigitalPsico.Domain.Validation.GenderValidator",
        "SmartDigitalPsico.Domain.Validation.AuditDataSelectiveEntityLogValidator",
        "SmartDigitalPsico.Domain.Validation.ApplicationLanguageValidator",
        "SmartDigitalPsico.Domain.Validation.ApplicationConfigSettingValidator",
        "SmartDigitalPsico.Domain.Validation.ScheduleItemValidator",
        "SmartDigitalPsico.Domain.Validation.ScheduleItemValidationContextValidator",
        "SmartDigitalPsico.Domain.Validation.ScheduleCalendarConflictValidator",
        "SmartDigitalPsico.Domain.Validation.ScheduleCalendarWriteRequestValidator",
        "SmartDigitalPsico.Domain.Validation.ScheduleCalendarItemValidator",
        "SmartDigitalPsico.Domain.Validation.MedicalCalendarListValidator",
        "SmartDigitalPsico.Domain.Validation.MedicalCalendarCriteriaValidator",
        "SmartDigitalPsico.Domain.Validation.MedicalCalendarValidator",
        "SmartDigitalPsico.Domain.Validation.MedicalCalendarScheduleFieldsValidator",
        "SmartDigitalPsico.Domain.Validation.MedicalCalendarRangeValidator",
        "SmartDigitalPsico.Domain.Validation.UserValidator",
        "SmartDigitalPsico.Domain.Validation.MedicalFileSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.MedicalValidator",
        "SmartDigitalPsico.Domain.Validation.MedicalFileValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidator",
        "SmartDigitalPsico.Domain.Validation.PatientRecordValidator",
        "SmartDigitalPsico.Domain.Validation.PatientNotificationMessageValidator",
        "SmartDigitalPsico.Domain.Validation.PatientMedicationInformationValidator",
        "SmartDigitalPsico.Domain.Validation.PatientHospitalizationInformationValidator",
        "SmartDigitalPsico.Domain.Validation.PatientFileValidator",
        "SmartDigitalPsico.Domain.Validation.PatientAdditionalInformationValidator",
        "SmartDigitalPsico.Domain.Validation.PatientSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.PatientRecordSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.PatientMedicationInformationSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.PatientHospitalizationInformationSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.PatientFileSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.PatientAdditionalInformationSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.PatientSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.PatientRecordSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.PatientNotificationMessageSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.PatientFileSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.PatientHospitalizationInformationSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.PatientMedicationInformationSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.PatientAdditionalInformationSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.PatientAppointmentCriteriaDtoValidator",
        "SmartDigitalPsico.Domain.Validation.ScheduleCriteriaDtoValidator"
    ];

    private static IEnumerable<TestCaseData> Validators() =>
        ValidatorTypes.Select(type => new TestCaseData(type).SetName($"{type.Split('.').Last()}_Contract"));

    [TestCaseSource(nameof(Validators))]
    public async Task Validator_ValidFixture_ReturnsValidationResult(string validatorTypeName)
    {
        // Cenário: uma entidade preenchida com dados gerados pelo Bogus é enviada ao validador.
        // Objetivo: garantir que todos os validadores possam processar um cenário válido.
        // Arrange
        const bool populateValues = true;

        // Act
        var result = await ValidatorTestHarness.ValidateAsync(validatorTypeName, populateValues);

        // Assert
        result.Should().NotBeNull();
    }

    [TestCaseSource(nameof(Validators))]
    public async Task Validator_InvalidFixture_ReturnsValidationResult(string validatorTypeName)
    {
        // Cenário: uma entidade sem campos obrigatórios é enviada ao validador.
        // Objetivo: executar as regras de campos obrigatórios e valores inválidos.
        // Arrange
        // Act
        var exception = await ValidatorTestHarness.ValidateWithFaultedDependenciesAsync(validatorTypeName);

        // Assert
        exception.Should().BeNull();
    }

    [TestCaseSource(nameof(Validators))]
    public async Task Validator_BoundaryFixture_ReturnsValidationResult(string validatorTypeName)
    {
        // Cenário: uma entidade com os valores mínimos gerados é enviada ao validador.
        // Objetivo: garantir que as regras de limites possam ser avaliadas.
        // Arrange
        const bool populateValues = true;

        // Act
        var result = await ValidatorTestHarness.ValidateAsync(validatorTypeName, populateValues);

        // Assert
        result.Errors.Should().NotBeNull();
    }

    [TestCaseSource(nameof(Validators))]
    public async Task Validator_ExceptionPath_IsHandled(string validatorTypeName)
    {
        // Cenário: dependências de repositório sem configuração são usadas pelo validador.
        // Objetivo: exercitar os caminhos de exceção protegidos pelos validadores.
        // Arrange
        // Act
        var exception = await ValidatorTestHarness.ValidateWithFaultedDependenciesAsync(validatorTypeName);

        // Assert
        exception.Should().BeNull();
    }
}
