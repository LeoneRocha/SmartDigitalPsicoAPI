using FluentValidation;
using Microsoft.Extensions.Configuration;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Service.Report.Entity;
using SmartDigitalPsico.Service.Test.TestSupport;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Test.Report.Entity;

[TestFixture]
public class PatientReportServiceTests
{
    // Cenário: busca de detalhes de paciente inexistente.
    // Objetivo: retornar falha sem lançar exceções.
    [Test]
    public async Task GetPatientDetailsByIdAsync_PatientNotFound_ReturnsFailure()
    {
        // Arrange
        var context = new PatientReportServiceContext();
        context.PatientRepository.Setup(x => x.GetPatientDetailsByIdAsync(10)).ReturnsAsync((Patient)null!);

        // Act
        var result = await context.Service.GetPatientDetailsByIdAsync(10);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: usuário sem permissão tenta acessar detalhes do paciente.
    // Objetivo: bloquear o acesso.
    [Test]
    public async Task GetPatientDetailsByIdAsync_UserWithoutPermission_ReturnsPermissionFailure()
    {
        // Arrange
        var context = new PatientReportServiceContext();

        // Act
        context.Service.SetUserId(1);
        var patient = new Patient { Id = 10, CreatedUser = new User { Id = 2 } };
        context.PatientRepository.Setup(x => x.GetPatientDetailsByIdAsync(10)).ReturnsAsync(patient);
        context.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = false });

        var result = await context.Service.GetPatientDetailsByIdAsync(10);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: usuário administrador acessa detalhes de paciente com registros.
    // Objetivo: retornar o DTO mapeado com as anotações descriptografadas.
    [Test]
    public async Task GetPatientDetailsByIdAsync_AdminUser_ReturnsMappedDataWithDecryptedAnnotations()
    {
        // Arrange
        var context = new PatientReportServiceContext();

        // Act
        context.Service.SetUserId(1);
        var medical = new Medical { Id = 3, SecurityKey = "key123" };
        var patient = new Patient
        {
            Id = 10,
            CreatedUser = new User { Id = 2 },
            Medical = medical,
            PatientRecords = new List<PatientRecord> { new() { Annotation = "cipher-text", Description = "Nota" } }
        };
        context.PatientRepository.Setup(x => x.GetPatientDetailsByIdAsync(10)).ReturnsAsync(patient);
        context.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });
        context.Context.Crypto.Setup(x => x.Decrypt("key123", "cipher-text")).Returns("plain-text");

        var result = await context.Service.GetPatientDetailsByIdAsync(10);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.PatientRecords.Should().ContainSingle(r => r.Annotation == "plain-text");
        }
    }

    // Cenário: exceção inesperada durante a busca de detalhes do paciente.
    // Objetivo: capturar a exceção e retornar falha controlada.
    [Test]
    public async Task GetPatientDetailsByIdAsync_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var context = new PatientReportServiceContext();
        context.PatientRepository.Setup(x => x.GetPatientDetailsByIdAsync(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.Service.GetPatientDetailsByIdAsync(11);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: download de relatório para um paciente que não foi encontrado.
    // Objetivo: retornar um resultado vazio sem lançar exceções.
    [Test]
    public async Task DownloadReportPatientDetailsById_PatientNotFound_ReturnsEmptyFileResult()
    {
        // Arrange
        var context = new PatientReportServiceContext();
        context.PatientRepository.Setup(x => x.GetPatientDetailsByIdAsync(99)).ReturnsAsync((Patient)null!);

        // Act
        var result = await context.Service.DownloadReportPatientDetailsById(99, EReportOutputType.Pdf);

        // Assert
        result.Should().NotBeNull();
        result.ContentType.Should().Be("application/octet-stream");
    }

    // Cenário: download de relatório PDF com geração bem-sucedida.
    // Objetivo: copiar arquivo gerado e retornar FileContentResult válido.
    [Test]
    public async Task DownloadReportPatientDetailsById_ValidPatientPdf_ReturnsFileContent()
    {
        // Arrange
        var context = new PatientReportServiceContext();

        // Act
        context.Service.SetUserId(1);

        var patient = new Patient
        {
            Id = 30,
            CreatedUser = new User { Id = 1 },
            Medical = new Medical { SecurityKey = "key" },
            PatientRecords = [],
            PatientAdditionalInformations = [],
            PatientHospitalizationInformations = [],
            PatientMedicationInformations = []
        };
        context.PatientRepository.Setup(x => x.GetPatientDetailsByIdAsync(30)).ReturnsAsync(patient);
        context.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });
        var tempFile = Path.GetTempFileName();
        await File.WriteAllTextAsync(tempFile, "pdf-content");

        // Assert
        context.PdfReportService.Setup(x => x.Generate(It.IsAny<SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto>()))
            .ReturnsAsync(tempFile);
        var configuration = new Mock<IConfiguration>();
        configuration.Setup(x => x["AppSettings:ResourcesTemp"]).Returns(Path.GetTempPath());
        context.Context.ConfigMock.SetupGet(x => x.Configuration).Returns(configuration.Object);

        try
        {
            var result = await context.Service.DownloadReportPatientDetailsById(30, EReportOutputType.Pdf);

            result.Should().NotBeNull();
            result.ContentType.Should().NotBeNullOrWhiteSpace();
        }
        finally
        {
            if (File.Exists(tempFile)) File.Delete(tempFile);
        }
    }

    // Cenário: download de relatório Excel com geração bem-sucedida.
    // Objetivo: copiar arquivo gerado e retornar FileContentResult válido.
    [Test]
    public async Task DownloadReportPatientDetailsById_ValidPatientExcel_ReturnsFileContent()
    {
        // Arrange
        var context = new PatientReportServiceContext();

        // Act
        context.Service.SetUserId(1);

        var patient = new Patient
        {
            Id = 31,
            CreatedUser = new User { Id = 1 },
            Medical = new Medical { SecurityKey = "key" },
            PatientRecords = [],
            PatientAdditionalInformations = [],
            PatientHospitalizationInformations = [],
            PatientMedicationInformations = []
        };
        context.PatientRepository.Setup(x => x.GetPatientDetailsByIdAsync(31)).ReturnsAsync(patient);
        context.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });
        var tempFile = Path.GetTempFileName();
        await File.WriteAllTextAsync(tempFile, "excel-content");

        // Assert
        context.ExcelGeneratorService.Setup(x => x.Generate(It.IsAny<SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportWorkbookDataDto>()))
            .ReturnsAsync(tempFile);
        var configuration = new Mock<IConfiguration>();
        configuration.Setup(x => x["AppSettings:ResourcesTemp"]).Returns(Path.GetTempPath());
        context.Context.ConfigMock.SetupGet(x => x.Configuration).Returns(configuration.Object);

        try
        {
            var result = await context.Service.DownloadReportPatientDetailsById(31, EReportOutputType.Excel);

            result.Should().NotBeNull();
            result.ContentType.Should().NotBeNullOrWhiteSpace();
        }
        finally
        {
            if (File.Exists(tempFile)) File.Delete(tempFile);
        }
    }

    // Cenário: tipo de relatório inválido após obter dados do paciente.
    // Objetivo: retornar arquivo vazio sem lançar exceção.
    [Test]
    public async Task DownloadReportPatientDetailsById_UnknownOutputType_ReturnsEmptyFile()
    {
        // Arrange
        var context = new PatientReportServiceContext();

        // Act
        context.Service.SetUserId(1);
        var patient = new Patient { Id = 32, CreatedUser = new User { Id = 1 }, Medical = new Medical { SecurityKey = "key" } };
        context.PatientRepository.Setup(x => x.GetPatientDetailsByIdAsync(32)).ReturnsAsync(patient);
        context.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });

        var result = await context.Service.DownloadReportPatientDetailsById(32, (EReportOutputType)999);

        // Assert
        result.ContentType.Should().Be("application/octet-stream");
    }

    // Cenário: download de relatório em Excel com falha no processamento de arquivo.
    // Objetivo: capturar a exceção internamente e retornar um resultado vazio.
    [Test]
    public async Task DownloadReportPatientDetailsById_ValidPatient_HandlesFileGenerationGracefully()
    {
        // Arrange
        var context = new PatientReportServiceContext();

        // Act
        context.Service.SetUserId(1);
        var patient = new Patient { Id = 20, CreatedUser = new User { Id = 1 }, Medical = new Medical { SecurityKey = "key" } };
        context.PatientRepository.Setup(x => x.GetPatientDetailsByIdAsync(20)).ReturnsAsync(patient);
        context.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });
        context.ExcelGeneratorService.Setup(x => x.Generate(It.IsAny<SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportWorkbookDataDto>()))
            .ThrowsAsync(new InvalidOperationException("disk error"));

        var result = await context.Service.DownloadReportPatientDetailsById(20, EReportOutputType.Excel);

        // Assert
        result.Should().NotBeNull();
    }

    private sealed class PatientReportServiceContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<IPatientRepository> PatientRepository { get; } = new();
        public Mock<IMedicalRepository> MedicalRepository { get; } = new();
        public Mock<IPatientRecordRepository> PatientRecordRepository { get; } = new();
        public Mock<IValidator<PatientRecord>> Validator { get; } = new();
        public Mock<IPatientRepositories> PatientRepositories { get; } = new();
        public Mock<IPatientRecordServiceConfig> Config { get; } = new();
        public Mock<IReportServiceConfig> ReportServiceConfig { get; } = new();
        public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorService> ExcelGeneratorService { get; } = new();
        public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportService> PdfReportService { get; } = new();
        public PatientReportService Service { get; }

        public PatientReportServiceContext()
        {
            PatientRepositories.SetupGet(x => x.MedicalRepository).Returns(MedicalRepository.Object);
            PatientRepositories.SetupGet(x => x.PatientRecordRepository).Returns(PatientRecordRepository.Object);
            PatientRepositories.SetupGet(x => x.PatientRepository).Returns(PatientRepository.Object);
            PatientRepositories.SetupGet(x => x.SharedRepositories).Returns(Context.SharedRepositories);

            Config.SetupGet(x => x.SharedServices).Returns(Context.SharedServices);
            Config.SetupGet(x => x.SharedDependenciesConfig).Returns(Context.Config);
            Config.SetupGet(x => x.SharedRepositories).Returns(Context.SharedRepositories);
            Config.SetupGet(x => x.EntityValidator).Returns(Validator.Object);

            ReportServiceConfig.SetupGet(x => x.ExcelGeneratorService).Returns(ExcelGeneratorService.Object);
            ReportServiceConfig.SetupGet(x => x.PdfReportService).Returns(PdfReportService.Object);

            Service = new PatientReportService(PatientRepositories.Object, Config.Object, ReportServiceConfig.Object);
        }
    }
}
