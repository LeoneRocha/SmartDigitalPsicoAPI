using SmartDigitalPsico.Service.Audit;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Core.SDK.Infrastructure.Mapping;
using SmartDigitalPsico.Domain.Mapper;
using SmartDigitalPsico.Core.SDK.Domain.Resiliency;

using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.User;
namespace SmartDigitalPsico.Service.Test.TestSupport;
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;

/// <summary>
/// Contexto compartilhado de dependências mockadas para os testes comportamentais de Service.
/// Usa o AutoMapperProfile real (via IAppMapper) para evitar centenas de Setups manuais.
/// </summary>
public sealed class ServiceTestContext
{
    public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService> Cache { get; } = new();
    public Mock<IApplicationLanguageService> Language { get; } = new();
    public Mock<ISendNotificationService> SendNotification { get; } = new();
    public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ICryptoService> Crypto { get; } = new();
    public Mock<INotificationTemplateService> NotificationTemplate { get; } = new();
    public Mock<ISharedServices> SharedServicesMock { get; } = new();
    public ISharedServices SharedServices => SharedServicesMock.Object;

    public Mock<IUserRepository> UserRepository { get; } = new();
    public Mock<IApplicationLanguageRepository> ApplicationLanguageRepository { get; } = new();
    public Mock<IApplicationConfigSettingRepository> ApplicationConfigSettingRepository { get; } = new();
    public Mock<ISharedRepositories> SharedRepositoriesMock { get; } = new();
    public ISharedRepositories SharedRepositories => SharedRepositoriesMock.Object;

    public IAppMapper Mapper { get; }
    public Mock<IAppLogger> Logger { get; } = new();
    public Mock<ISharedDependenciesConfig> ConfigMock { get; } = new();
    public ISharedDependenciesConfig Config => ConfigMock.Object;

    public ServiceTestContext()
    {
        Language.Setup(x => x.GetLocalization<ISharedResource>(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService>()))
            .ReturnsAsync((string _, string fallback, SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService _) => fallback);

        SharedServicesMock.SetupGet(x => x.CacheService).Returns(Cache.Object);
        SharedServicesMock.SetupGet(x => x.ApplicationLanguageService).Returns(Language.Object);
        SharedServicesMock.SetupGet(x => x.SendNotificationService).Returns(SendNotification.Object);
        SharedServicesMock.SetupGet(x => x.CryptoService).Returns(Crypto.Object);
        SharedServicesMock.SetupGet(x => x.NotificationTemplateService).Returns(NotificationTemplate.Object);

        SharedRepositoriesMock.SetupGet(x => x.UserRepository).Returns(UserRepository.Object);
        SharedRepositoriesMock.SetupGet(x => x.ApplicationLanguageRepository).Returns(ApplicationLanguageRepository.Object);
        SharedRepositoriesMock.SetupGet(x => x.ApplicationConfigSettingRepository).Returns(ApplicationConfigSettingRepository.Object);

        var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>(), Microsoft.Extensions.Logging.Abstractions.NullLoggerFactory.Instance);
        Mapper = new AutoMapperAppMapperAdapter(mapperConfiguration.CreateMapper());

        ConfigMock.SetupGet(x => x.Mapper).Returns(Mapper);
        ConfigMock.SetupGet(x => x.Logger).Returns(Logger.Object);
        ConfigMock.SetupGet(x => x.PolicyConfig).Returns(new ResiliencePolicyConfig());
        ConfigMock.SetupGet(x => x.Configuration).Returns(new ConfigurationBuilder().Build());
    }
}
