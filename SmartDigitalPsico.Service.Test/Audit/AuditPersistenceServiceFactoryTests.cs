using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Service.Audit;
using SmartDigitalPsico.Service.Configure.Domain;

using SmartDigitalPsico.Domain.Interfaces.Audit;
namespace SmartDigitalPsico.Service.Test.Audit;
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;

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
        services.AddSingleton(Mock.Of<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>());
        services.AddSingleton<IAppLogger>(_ => Mock.Of<IAppLogger>());
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
