using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;
using AutoMapper;
using FluentValidation;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using Serilog;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Core.SDK.Domain.Resiliency;
using SmartDigitalPsico.Service.DataEntity.General;
using SmartDigitalPsico.Service.DataEntity.Principals;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;

namespace SmartDigitalPsico.Service.Test.DataEntity;

[TestFixture]
public class RemainingDataEntityServiceTests
{
    // Cenário: serviços de domínio sem comportamento especializado são criados.
    // Objetivo: cobrir a composição das dependências e os construtores de serviços base.
    [Test]
    public void Constructors_BaseDomainServices_CreatesServices()
    {
        // Arrange

        // Act
        var dependencies = new Dependencies();

        var services = new object[]
        {
            new SpecialtyService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<ISpecialtyRepository>(), Mock.Of<IValidator<Specialty>>()),
            new RoleGroupService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<IRoleGroupRepository>(), Mock.Of<IValidator<RoleGroup>>()),
            new OfficeService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<IOfficeRepository>(), Mock.Of<IValidator<Office>>()),
            new LeavesService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<ILeavesRepository>(), Mock.Of<IApplicationLanguageRepository>(), Mock.Of<IValidator<Leaves>>()),
            new ApplicationConfigSettingService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<IApplicationConfigSettingRepository>(), Mock.Of<IApplicationLanguageRepository>(), Mock.Of<IValidator<ApplicationConfigSetting>>()),
            new ApplicationLanguageService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<IApplicationLanguageRepository>(), Mock.Of<IValidator<ApplicationLanguage>>()),
            new NotificationRulesService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<INotificationRulesRepository>(), Mock.Of<IApplicationLanguageRepository>(), Mock.Of<IValidator<NotificationRule>>()),
            new NotificationTemplateService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<INotificationTemplateRepository>(), Mock.Of<IApplicationLanguageRepository>(), Mock.Of<IValidator<NotificationTemplate>>()),
            new NotificationRecordsService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<INotificationRecordsRepository>(), Mock.Of<IApplicationLanguageRepository>(), Mock.Of<IValidator<NotificationRecord>>(), Mock.Of<INotificationRulesService>())
        };

        // Assert
        services.Should().NotContainNulls();
    }

    // Cenário: serviços principais recebem suas dependências obrigatórias.
    // Objetivo: garantir que os construtores preservem a composição da camada DataEntity.
    [Test]
    public void Constructors_PrincipalServices_CreatesServices()
    {
        // Arrange

        // Act
        var dependencies = new Dependencies();

        var services = new object[]
        {
            new MedicalService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<IMedicalRepository>(), Mock.Of<ISpecialtyRepository>(), Mock.Of<IValidator<Medical>>()),
            new PatientService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<IPatientRepository>(), Mock.Of<IValidator<Patient>>()),
            new PatientNotificationMessageService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<IPatientNotificationMessageRepository>(), Mock.Of<IPatientRepository>(), Mock.Of<IValidator<PatientNotificationMessage>>()),
            new PatientMedicationInformationService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<IPatientMedicationInformationRepository>(), Mock.Of<IValidator<PatientMedicationInformation>>()),
            new PatientHospitalizationInformationService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<IPatientHospitalizationInformationRepository>(), Mock.Of<IValidator<PatientHospitalizationInformation>>()),
            new PatientAdditionalInformationService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<IPatientAdditionalInformationRepository>(), Mock.Of<IUserRepository>(), Mock.Of<IValidator<PatientAdditionalInformation>>()),
            new MedicalFileService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<IMedicalFileRepository>(), Mock.Of<IValidator<MedicalFile>>(), Mock.Of<IFileManager>()),
            new PatientFileService(dependencies.Services, dependencies.Config, dependencies.Repositories, Mock.Of<IPatientFileRepository>(), Mock.Of<IValidator<PatientFile>>(), Mock.Of<IFileManager>(), Mock.Of<IPatientRepository>())
        };

        // Assert
        services.Should().NotContainNulls();
    }

    // Cenário: uma consulta de notificação não localiza template.
    // Objetivo: não disparar mensagem quando não há configuração disponível.
    [Test]
    public async Task NotifyAsync_TemplateMissing_DoesNotSendNotification()
    {
        // Arrange
        var dependencies = new Dependencies();
        var templates = new Mock<INotificationTemplateService>();
        templates.Setup(value => value.GetNotificationTemplatesAsync(It.IsAny<string>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<SmartDigitalPsico.Domain.DTO.Domains.GetDTOs.GetNotificationTemplateDto>());
        dependencies.ServicesMock.SetupGet(value => value.NotificationTemplateService).Returns(templates.Object);
        var service = new MedicalCalenderNotificationService(dependencies.Services);

        // Act
        await service.NotifyAsync(new MedicalCalendar { Title = "Consulta" }, SmartDigitalPsico.Domain.Enuns.EMedicalCalendarActionType.Scheduled);

        // Assert
        dependencies.ServicesMock.VerifyGet(value => value.SendNotificationService, Times.Never);
    }

    private sealed class Dependencies
    {
        public ISharedServices Services { get; }
        public ISharedDependenciesConfig Config { get; }
        public ISharedRepositories Repositories { get; }
        public Mock<ISharedServices> ServicesMock { get; } = new();

        public Dependencies()
        {
            var cache = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService>();
            ServicesMock.SetupGet(value => value.CacheService).Returns(cache.Object);
            Services = ServicesMock.Object;

            var repositories = new Mock<ISharedRepositories>();
            repositories.SetupGet(value => value.ApplicationLanguageRepository).Returns(Mock.Of<IApplicationLanguageRepository>());
            repositories.SetupGet(value => value.UserRepository).Returns(Mock.Of<IUserRepository>());
            Repositories = repositories.Object;

            var config = new Mock<ISharedDependenciesConfig>();
            config.SetupGet(value => value.Mapper).Returns(Mock.Of<IAppMapper>());
            config.SetupGet(value => value.Logger).Returns(Mock.Of<IAppLogger>());
            config.SetupGet(value => value.PolicyConfig).Returns(new ResiliencePolicyConfig());
            Config = config.Object;
        }
    }
}
