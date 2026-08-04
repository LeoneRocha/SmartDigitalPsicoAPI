using FluentValidation;
using Moq;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.Test.TestSupport;

namespace SmartDigitalPsico.Service.Test.DataEntity.Generic;

[TestFixture]
public class ReportBaseServiceTests
{
    // Cenário: ReportBaseService é construído e recebe UserId.
    // Objetivo: cobrir ctor e SetUserId.
    [Test]
    public void ReportBaseService_SetUserId_StoresIdentifier()
    {
        // Arrange
        var ctx = new ServiceTestContext();
        var probe = new ProbeReport(
            ctx.SharedServices,
            ctx.Config,
            ctx.SharedRepositories,
            Mock.Of<IGenderRepository>(),
            Mock.Of<IValidator<Gender>>());

        // Act
        probe.SetUserId(5);

        // Assert
        probe.ExposedUserId.Should().Be(5);
    }

    private sealed class ProbeReport : ReportBaseService<Gender, IGenderRepository>
    {
        public ProbeReport(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IGenderRepository entityRepository,
            IValidator<Gender> entityValidator)
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
        }

        public long ExposedUserId => UserId;
    }
}
