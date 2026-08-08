using FluentValidation;
using Moq;
using Serilog;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;

namespace SmartDigitalPsico.Service.Test.Audit;

[TestFixture]
public class AuditDataSelectiveEntityLogServiceTests
{
    // Cenário: Save concluído sem exceção.
    // Objetivo: cobrir saída normal do try (await Create bem-sucedido).
    [Test]
    public async Task Save_CreateSucceeds_CompletesWithoutLoggingError()
    {
        // Arrange
        var logger = new Mock<ILogger>();
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
        var logger = new Mock<ILogger>();
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

        public override Task<global::SmartDigitalPsicoAPI.Core.SDK.Domain.VO.ServiceResponse<GetAuditDataSelectiveEntityLogDto>> Create(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
            => Task.FromResult(new global::SmartDigitalPsicoAPI.Core.SDK.Domain.VO.ServiceResponse<GetAuditDataSelectiveEntityLogDto> { Success = true });
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

        public override Task<global::SmartDigitalPsicoAPI.Core.SDK.Domain.VO.ServiceResponse<GetAuditDataSelectiveEntityLogDto>> Create(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
            => throw new InvalidOperationException("create-fail");
    }
}

