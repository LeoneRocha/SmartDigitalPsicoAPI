using SmartDigitalPsico.Service.Audit;
using FluentValidation;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using Serilog;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Service.Application;
using SmartDigitalPsico.Service.Gender;
using SmartDigitalPsico.Service.Leaves;
using SmartDigitalPsico.Service.Notification;
using SmartDigitalPsico.Service.Office;
using SmartDigitalPsico.Service.RoleGroup;
using SmartDigitalPsico.Service.Specialty;
using SmartDigitalPsico.Service.User;

using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.EntityModels;

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
public class AuditDataSelectiveEntityLogServiceTests
{
    // Cenário: Save concluído sem exceção.
    // Objetivo: cobrir saída normal do try (await Create bem-sucedido).
    [Test]
    public async Task Save_CreateSucceeds_CompletesWithoutLoggingError()
    {
        // Arrange
        var logger = new Mock<IAppLogger>();
        var sharedConfig = new Mock<ISharedDependenciesConfig>();
        sharedConfig.SetupGet(x => x.Logger).Returns(logger.Object);
        var service = new SuccessfulAuditDataSelectiveEntityLogService(
            Mock.Of<ISharedServices>(),
            sharedConfig.Object,
            Mock.Of<ISharedRepositories>(),
            Mock.Of<IAuditDataSelectiveEntityLogRepository>(),
            Mock.Of<IValidator<AuditDataSelectiveEntityLog>>());

        // Act
        await service.Save(
            new Patient { Id = 1, Name = "Old", ModifyUser = new User { Name = "doc" } },
            new Patient { Id = 1, Name = "New", ModifyUser = new User { Name = "doc" } },
            "Update",
            ["ModifyDate"]);

        // Assert
        logger.Verify(x => x.Error(It.IsAny<Exception>(), It.IsAny<string>()), Times.Never);
    }

    // Cenário: Create virtual lança após montar audit entry.
    // Objetivo: cobrir catch com auditEntry != null (Information + Error).
    [Test]
    public async Task Save_CreateThrows_LogsInformationAndError()
    {
        // Arrange
        var logger = new Mock<IAppLogger>();
        var sharedConfig = new Mock<ISharedDependenciesConfig>();
        sharedConfig.SetupGet(x => x.Logger).Returns(logger.Object);
        var service = new ThrowingAuditDataSelectiveEntityLogService(
            Mock.Of<ISharedServices>(),
            sharedConfig.Object,
            Mock.Of<ISharedRepositories>(),
            Mock.Of<IAuditDataSelectiveEntityLogRepository>(),
            Mock.Of<IValidator<AuditDataSelectiveEntityLog>>());

        // Act
        await service.Save(
            new Patient { Id = 1, Name = "Old", ModifyUser = new User { Name = "doc" } },
            new Patient { Id = 1, Name = "New", ModifyUser = new User { Name = "doc" } },
            "Update",
            ["ModifyDate"]);

        // Assert
        logger.Verify(x => x.Error(It.IsAny<Exception>(), "Error writing log"), Times.Once);
    }

    private sealed class SuccessfulAuditDataSelectiveEntityLogService : AuditDataSelectiveEntityLogService
    {
        public SuccessfulAuditDataSelectiveEntityLogService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IAuditDataSelectiveEntityLogRepository entityRepository,
            IValidator<AuditDataSelectiveEntityLog> entityValidator)
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
        }

        public override Task<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<GetAuditDataSelectiveEntityLogDto>> Create(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
            => Task.FromResult(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<GetAuditDataSelectiveEntityLogDto> { Success = true });
    }

    private sealed class ThrowingAuditDataSelectiveEntityLogService : AuditDataSelectiveEntityLogService
    {
        public ThrowingAuditDataSelectiveEntityLogService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IAuditDataSelectiveEntityLogRepository entityRepository,
            IValidator<AuditDataSelectiveEntityLog> entityValidator)
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
        }

        public override Task<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<GetAuditDataSelectiveEntityLogDto>> Create(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
            => throw new InvalidOperationException("create-fail");
    }
}

