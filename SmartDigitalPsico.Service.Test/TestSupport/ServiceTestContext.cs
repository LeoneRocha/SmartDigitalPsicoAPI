using AutoMapper;
using Microsoft.Extensions.Configuration;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using Serilog;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Mapper;
using SmartDigitalPsico.Domain.Resiliency;

namespace SmartDigitalPsico.Service.Test.TestSupport;

/// <summary>
/// Contexto compartilhado de dependências mockadas para os testes comportamentais de Service.
/// Usa o AutoMapperProfile real para evitar centenas de Setups manuais de IMapper.Map.
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

    public IMapper Mapper { get; }
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
        Mapper = mapperConfiguration.CreateMapper();

        ConfigMock.SetupGet(x => x.Mapper).Returns(Mapper);
        ConfigMock.SetupGet(x => x.Logger).Returns(Logger.Object);
        ConfigMock.SetupGet(x => x.PolicyConfig).Returns(new ResiliencePolicyConfig());
        ConfigMock.SetupGet(x => x.Configuration).Returns(new ConfigurationBuilder().Build());
    }
}
