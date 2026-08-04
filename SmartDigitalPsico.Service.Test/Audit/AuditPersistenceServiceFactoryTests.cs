using Microsoft.Extensions.DependencyInjection;
using Moq;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Service.Audit;
using SmartDigitalPsico.Service.Configure.Domain;

namespace SmartDigitalPsico.Service.Test.Audit;

[TestFixture]
public class AuditPersistenceServiceFactoryTests
{
    // Cenário: factory resolve implementações registradas por tipo.
    // Objetivo: cobrir switch de CreateService para Database, AzureTable e Log.
    [TestCase(EAuditServiceType.Database, typeof(AuditPersistenceDataBaseService))]
    [TestCase(EAuditServiceType.AzureTable, typeof(AuditPersistenceAzureTableService))]
    [TestCase(EAuditServiceType.Log, typeof(AuditPersistenceLogService))]
    public void CreateService_RegisteredType_ReturnsExpectedImplementation(EAuditServiceType type, Type expected)
    {
        // Arrange
        var services = new ServiceCollection();
        ServicesDomainAudit.AddDependencies(services);
        services.AddSingleton(Mock.Of<IMemoryCacheRepository>());
        services.AddSingleton<Serilog.ILogger>(_ => Mock.Of<Serilog.ILogger>());
        services.AddLogging();
        using var provider = services.BuildServiceProvider();

        // Act
        var factory = provider.GetRequiredService<IAuditPersistenceServiceFactory>();

        // Assert
        var result = factory.CreateService(type);

        result.Should().BeOfType(expected);
    }

    // Cenário: tipo de auditoria inválido.
    // Objetivo: lançar ArgumentException.
    [Test]
    public void CreateService_InvalidType_ThrowsArgumentException()
    {
        // Arrange
        var services = new ServiceCollection();
        ServicesDomainAudit.AddDependencies(services);
        using var provider = services.BuildServiceProvider();

        // Act
        var factory = provider.GetRequiredService<IAuditPersistenceServiceFactory>();

        // Assert
        var action = () => factory.CreateService((EAuditServiceType)999);

        action.Should().Throw<ArgumentException>();
    }
}
