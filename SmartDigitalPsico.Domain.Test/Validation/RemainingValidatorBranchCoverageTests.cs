using Moq;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.Validation.Principals.Calendar;

namespace SmartDigitalPsico.Domain.Test.Validation;

[TestFixture]
public class RemainingValidatorBranchCoverageTests
{
    // Cenário: o repositório lança exceção ao buscar o usuário logado.
    // Objetivo: cobrir o catch dos validators de lista/one e retornar falha de permissão.
    [Test]
    public async Task ListAndOneValidators_RepositoryThrows_ReturnsPermissionFailure()
    {
        // Arrange
        var userRepository = new Mock<IUserRepository>();
        userRepository.Setup(x => x.FindByID(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException("db"));

        var patientList = new PatientSelectListValidator(userRepository.Object);
        var patientFileList = new PatientFileSelectListValidator(userRepository.Object);
        var medicalCalendarList = new MedicalCalendarListValidator(userRepository.Object);
        var patientOne = new PatientSelectOneValidator(userRepository.Object);

        var patientRecords = new RecordsList<Patient>
        {
            UserIdLogged = 1,
            Records = [new Patient { Id = 1, MedicalId = 9, CreatedUser = new User { Id = 1 } }]
        };
        var patientFileRecords = new RecordsList<PatientFile>
        {
            UserIdLogged = 1,
            Records = [new PatientFile { Id = 1, Patient = new Patient { MedicalId = 9 }, CreatedUser = new User { Id = 1 } }]
        };
        var calendarRecords = new RecordsList<MedicalCalendar>
        {
            UserIdLogged = 1,
            Records = [new MedicalCalendar { Id = 1, MedicalId = 9, CreatedUser = new User { Id = 1 } }]
        };
        var oneRecord = new Record<Patient>
        {
            UserIdLogged = 1,
            RecordEntity = new Patient { Id = 1, CreatedUser = new User { Id = 1 } }
        };

        // Act
        var patientResult = await patientList.ValidateAsync(patientRecords);
        var fileResult = await patientFileList.ValidateAsync(patientFileRecords);
        var calendarResult = await medicalCalendarList.ValidateAsync(calendarRecords);
        var oneResult = await patientOne.ValidateAsync(oneRecord);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            patientResult.IsValid.Should().BeFalse();
            fileResult.IsValid.Should().BeFalse();
            calendarResult.IsValid.Should().BeFalse();
            oneResult.IsValid.Should().BeFalse();
        }
    }

    // Cenário: registros de paciente com permissão válida do médico logado.
    // Objetivo: cobrir o ramo TrueForAll com CreatedUser preenchido.
    [Test]
    public async Task PatientSelectListValidator_MatchingMedicalAndCreator_IsValid()
    {
        // Arrange
        var userRepository = new Mock<IUserRepository>();
        userRepository.Setup(x => x.FindByID(7)).ReturnsAsync(new User { Id = 7, MedicalId = 99 });
        var validator = new PatientSelectListValidator(userRepository.Object);
        var list = new RecordsList<Patient>
        {
            UserIdLogged = 7,
            Records =
            [
                new Patient { Id = 1, MedicalId = 99, CreatedUser = new User { Id = 7 } },
                new Patient { Id = 2, MedicalId = 99, CreatedUser = new User { Id = 7 } }
            ]
        };

        // Act
        var result = await validator.ValidateAsync(list);

        // Assert
        result.IsValid.Should().BeTrue();
    }

    // Cenário: lista de patient files com permissão válida.
    // Objetivo: cobrir TrueForAll em BasePatientSelectListValidator.
    [Test]
    public async Task PatientFileSelectListValidator_MatchingPatientMedical_IsValid()
    {
        // Arrange
        var userRepository = new Mock<IUserRepository>();
        userRepository.Setup(x => x.FindByID(3)).ReturnsAsync(new User { Id = 3, MedicalId = 11 });
        var validator = new PatientFileSelectListValidator(userRepository.Object);
        var list = new RecordsList<PatientFile>
        {
            UserIdLogged = 3,
            Records =
            [
                new PatientFile
                {
                    Id = 1,
                    Patient = new Patient { MedicalId = 11 },
                    CreatedUser = new User { Id = 3 }
                }
            ]
        };

        // Act
        var result = await validator.ValidateAsync(list);

        // Assert
        result.IsValid.Should().BeTrue();
    }

    // Cenário: usuário admin acessa registros de outro criador.
    // Objetivo: cobrir ramo Admin em RecordsListValidator.
    [Test]
    public async Task RecordsListValidator_AdminUserBypassesCreatorCheck_IsValid()
    {
        // Arrange
        var repository = new Mock<IUserRepository>();
        repository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true, MedicalId = 9 });
        var validator = new RecordsListValidatorForBranchCoverage(repository.Object);

        // Act
        var result = await validator.ValidateAsync(new RecordsList<Patient>
        {
            UserIdLogged = 1,
            Records = [new Patient { CreatedUser = new User { Id = 99 } }]
        });

        // Assert
        result.IsValid.Should().BeTrue();
    }

    // Cenário: repositório retorna usuário nulo para a lista base.
    // Objetivo: cobrir userLogged == null em RecordsListValidator.
    [Test]
    public async Task RecordsListValidator_NullUserLogged_ReturnsFalse()
    {
        // Arrange
        var repository = new Mock<IUserRepository>();
        repository.Setup(x => x.FindByID(1)).Returns(Task.FromResult<User>(null!));
        var validator = new RecordsListValidatorForBranchCoverage(repository.Object);

        // Act
        var result = await validator.ValidateAsync(new RecordsList<Patient>
        {
            UserIdLogged = 1,
            Records = [new Patient { CreatedUser = new User { Id = 1 } }]
        });

        // Assert
        result.IsValid.Should().BeFalse();
    }

    // Cenário: paciente sem CreatedUser preenchido.
    // Objetivo: cobrir CreatedUser nulo em PatientSelectListValidator.
    [Test]
    public async Task PatientSelectListValidator_NullCreatedUser_ReturnsFalse()
    {
        // Arrange
        var repository = new Mock<IUserRepository>();
        repository.Setup(x => x.FindByID(7)).ReturnsAsync(new User { Id = 7, MedicalId = 99 });
        var validator = new PatientSelectListValidator(repository.Object);

        // Act
        var result = await validator.ValidateAsync(new RecordsList<Patient>
        {
            UserIdLogged = 7,
            Records = [new Patient { MedicalId = 99, CreatedUser = null! }]
        });

        // Assert
        result.IsValid.Should().BeFalse();
    }

    // Cenário: MedicalId do registro diverge do usuário logado.
    // Objetivo: cobrir mismatch de MedicalId em PatientSelectListValidator.
    [Test]
    public async Task PatientSelectListValidator_MedicalIdMismatch_ReturnsFalse()
    {
        // Arrange
        var repository = new Mock<IUserRepository>();
        repository.Setup(x => x.FindByID(7)).ReturnsAsync(new User { Id = 7, MedicalId = 99 });
        var validator = new PatientSelectListValidator(repository.Object);

        // Act
        var result = await validator.ValidateAsync(new RecordsList<Patient>
        {
            UserIdLogged = 7,
            Records = [new Patient { MedicalId = 55, CreatedUser = new User { Id = 7 } }]
        });

        // Assert
        result.IsValid.Should().BeFalse();
    }

    // Cenário: arquivo de paciente sem vínculo Patient.
    // Objetivo: cobrir Patient nulo em BasePatientSelectListValidator.
    [Test]
    public async Task PatientFileSelectListValidator_NullPatient_ReturnsFalse()
    {
        // Arrange
        var repository = new Mock<IUserRepository>();
        repository.Setup(x => x.FindByID(3)).ReturnsAsync(new User { Id = 3, MedicalId = 11 });
        var validator = new PatientFileSelectListValidator(repository.Object);

        // Act
        var result = await validator.ValidateAsync(new RecordsList<PatientFile>
        {
            UserIdLogged = 3,
            Records = [new PatientFile { Patient = null!, CreatedUser = new User { Id = 3 } }]
        });

        // Assert
        result.IsValid.Should().BeFalse();
    }

    // Cenário: lista de arquivos médicos com permissão válida.
    // Objetivo: cobrir TrueForAll positivo em MedicalFileSelectListValidator.
    [Test]
    public async Task MedicalFileSelectListValidator_MatchingMedicalAndCreator_IsValid()
    {
        // Arrange
        var repository = new Mock<IUserRepository>();
        repository.Setup(x => x.FindByID(4)).ReturnsAsync(new User { Id = 4, MedicalId = 20 });
        var validator = new SmartDigitalPsico.Domain.Validation.Contratcs.MedicalFileSelectListValidator(repository.Object);

        // Act
        var result = await validator.ValidateAsync(new RecordsList<MedicalFile>
        {
            UserIdLogged = 4,
            Records = [new MedicalFile { MedicalId = 20, CreatedUser = new User { Id = 4 } }]
        });

        // Assert
        result.IsValid.Should().BeTrue();
    }

    // Cenário: MedicalId diverge na lista de arquivos médicos.
    // Objetivo: cobrir mismatch em MedicalFileSelectListValidator.
    [Test]
    public async Task MedicalFileSelectListValidator_MedicalIdMismatch_ReturnsFalse()
    {
        // Arrange
        var repository = new Mock<IUserRepository>();
        repository.Setup(x => x.FindByID(4)).ReturnsAsync(new User { Id = 4, MedicalId = 20 });
        var validator = new SmartDigitalPsico.Domain.Validation.Contratcs.MedicalFileSelectListValidator(repository.Object);

        // Act
        var result = await validator.ValidateAsync(new RecordsList<MedicalFile>
        {
            UserIdLogged = 4,
            Records = [new MedicalFile { MedicalId = 21, CreatedUser = new User { Id = 4 } }]
        });

        // Assert
        result.IsValid.Should().BeFalse();
    }

    // Cenário: one-validator com usuário admin.
    // Objetivo: cobrir ramo admin em RecordValidator.
    [Test]
    public async Task PatientSelectOneValidator_AdminUser_IsValid()
    {
        // Arrange
        var userRepository = new Mock<IUserRepository>();
        userRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });
        var validator = new PatientSelectOneValidator(userRepository.Object);
        var record = new Record<Patient>
        {
            UserIdLogged = 1,
            RecordEntity = new Patient { Id = 9, CreatedUser = new User { Id = 99 } }
        };

        // Act
        var result = await validator.ValidateAsync(record);

        // Assert
        result.IsValid.Should().BeTrue();
    }

    private sealed class RecordsListValidatorForBranchCoverage : SmartDigitalPsico.Domain.Validation.Contratcs.RecordsListValidator<Patient>
    {
        public RecordsListValidatorForBranchCoverage(IUserRepository userRepository) : base(userRepository)
        {
        }
    }
}
