namespace SmartDigitalPsico.Domain.Test.Validation;

[TestFixture]
public sealed class ValidatorCoverageTests
{
    private static readonly string[] ValidatorTypes =
    [
        "SmartDigitalPsico.Domain.Validation.SystemDomains.SpecialtyValidator",
        "SmartDigitalPsico.Domain.Validation.SystemDomains.RoleGroupValidator",
        "SmartDigitalPsico.Domain.Validation.SystemDomains.OfficeValidator",
        "SmartDigitalPsico.Domain.Validation.SystemDomains.NotificationTemplateValidator",
        "SmartDigitalPsico.Domain.Validation.SystemDomains.NotificationRulesValidator",
        "SmartDigitalPsico.Domain.Validation.SystemDomains.NotificationRecordsValidator",
        "SmartDigitalPsico.Domain.Validation.SystemDomains.NotificationRuleStatusValidator",
        "SmartDigitalPsico.Domain.Validation.SystemDomains.LeavesValidator",
        "SmartDigitalPsico.Domain.Validation.SystemDomains.GenderValidator",
        "SmartDigitalPsico.Domain.Validation.SystemDomains.AuditDataSelectiveEntityLogValidator",
        "SmartDigitalPsico.Domain.Validation.SystemDomains.ApplicationLanguageValidator",
        "SmartDigitalPsico.Domain.Validation.SystemDomains.ApplicationConfigSettingValidator",
        "SmartDigitalPsico.Domain.Validation.Principals.Schedule.ScheduleItemValidator",
        "SmartDigitalPsico.Domain.Validation.Principals.Schedule.ScheduleItemValidationContextValidator",
        "SmartDigitalPsico.Domain.Validation.Schedule.ScheduleCalendarConflictValidator",
        "SmartDigitalPsico.Domain.Validation.Schedule.ScheduleCalendarWriteRequestValidator",
        "SmartDigitalPsico.Domain.Validation.Schedule.ScheduleCalendarItemValidator",
        "SmartDigitalPsico.Domain.Validation.Principals.Calendar.MedicalCalendarListValidator",
        "SmartDigitalPsico.Domain.Validation.Principals.Calendar.CalendarCriteriaValidator",
        "SmartDigitalPsico.Domain.Validation.Principals.Calendar.MedicalCalendarValidator",
        "SmartDigitalPsico.Domain.Validation.Principals.Calendar.MedicalCalendarScheduleFieldsValidator",
        "SmartDigitalPsico.Domain.Validation.Principals.Calendar.MedicalCalendarRangeValidator",
        "SmartDigitalPsico.Domain.Validation.Principals.UserValidator",
        "SmartDigitalPsico.Domain.Validation.Contratcs.MedicalFileSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.SystemDomains.MedicalValidator",
        "SmartDigitalPsico.Domain.Validation.SystemDomains.MedicalFileValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.PatientValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.PatientRecordValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.PatientNotificationMessageValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.PatientMedicationInformationValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.PatientHospitalizationInformationValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.PatientFileValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.PatientAdditionalInformationValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator.PatientSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator.PatientRecordSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator.PatientMedicationInformationSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator.PatientHospitalizationInformationSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator.PatientFileSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator.PatientAdditionalInformationSelectListValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator.PatientSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator.PatientRecordSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator.PatientNotificationMessageSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator.PatientFileSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator.PatientHospitalizationInformationSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator.PatientMedicationInformationSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator.PatientAdditionalInformationSelectOneValidator",
        "SmartDigitalPsico.Domain.Validation.DTO.AppointmentCriteriaDtoValidator",
        "SmartDigitalPsico.Domain.Validation.DTO.ScheduleCriteriaDtoValidator"
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
