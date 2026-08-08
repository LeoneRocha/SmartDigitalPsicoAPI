using SmartDigitalPsico.Service.Audit;
using FluentValidation;
using Moq;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Service.Common;
using SmartDigitalPsico.Service.Test.TestSupport;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Gender;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Test.DataEntity.Generic;
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;

[TestFixture]
public class ReportBaseServiceTests
{
    // Cenário: ReportBaseService é construído e recebe UserId.
    // Objetivo: cobrir ctor e SetUserId.
    [Test]
    public void ReportBaseService_SetUserId_StoresIdentifier()
    {
        // Arrange

        // Act
        var ctx = new ServiceTestContext();
        var probe = new ProbeReport(
            ctx.SharedServices,
            ctx.Config,
            ctx.SharedRepositories,
            Mock.Of<IGenderRepository>(),
            Mock.Of<IValidator<Gender>>());

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
