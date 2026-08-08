using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Core.SDK.Domain.Contracts;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Core.SDK.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Core.SDK.Tests.Service.DataEntity.Generic;

[TestFixture]
public class EntityBaseServiceTests
{
    [Test]
    public async Task Create_ValidItem_PersistsAndReturnsMappedResult()
    {
        var context = new ServiceContext();
        var item = new AddDto();
        var entity = new TestEntity { Name = "ok" };
        context.Mapper.Setup(x => x.Map<TestEntity>(item)).Returns(entity);
        context.Validator.Setup(x => x.ValidateAsync(entity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Create(entity)).ReturnsAsync(entity);
        context.Mapper.Setup(x => x.Map<ResultDto>(entity)).Returns(new ResultDto { Name = "ok" });

        var result = await context.Service.Create(item);

        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Name.Should().Be("ok");
            entity.Enable.Should().BeTrue();
        }
        context.Repository.Verify(x => x.Create(entity), Times.Once);
    }

    [Test]
    public async Task Create_InvalidItem_ReturnsValidationFailureWithoutPersisting()
    {
        var context = new ServiceContext();
        var item = new AddDto();
        var entity = new TestEntity();
        context.Mapper.Setup(x => x.Map<TestEntity>(item)).Returns(entity);
        context.Validator.Setup(x => x.ValidateAsync(entity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult([new ValidationFailure("Name", "Required_Key|obrigatório")
            {
                ErrorCode = "RequiredValidator"
            }]));

        var result = await context.Service.Create(item);

        result.Success.Should().BeFalse();
        result.Errors.Should().NotBeEmpty();
        context.Repository.Verify(x => x.Create(It.IsAny<TestEntity>()), Times.Never);
    }

    [Test]
    public async Task Create_InvalidPolicy_ReturnsGenericFailureAndLogsError()
    {
        var context = new ServiceContext(policyName: "invalid");
        var result = await context.Service.Create(new AddDto());
        result.Success.Should().BeFalse();
        result.Errors.Should().ContainSingle(x => x.Name == "Create");
        context.Logger.Verify(x => x.Error(
            It.IsAny<Exception>(),
            It.IsAny<string>(),
            It.IsAny<string>(),
            It.IsAny<DateTime>()), Times.Once);
    }

    [Test]
    public async Task Update_ExistingValidEntity_UpdatesAndReturnsResult()
    {
        var context = new ServiceContext();
        var item = new UpdateDto { Id = 24, Name = "Masculino" };
        var entity = new TestEntity { Id = item.Id, Name = item.Name };
        context.Repository.Setup(x => x.Exists(item.Id)).ReturnsAsync(true);
        context.Mapper.Setup(x => x.Map<TestEntity>(item)).Returns(entity);
        context.Validator.Setup(x => x.ValidateAsync(entity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);
        context.Mapper.Setup(x => x.Map<ResultDto>(entity)).Returns(new ResultDto { Id = item.Id, Name = item.Name });

        var result = await context.Service.Update(item);

        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Id.Should().Be(item.Id);
        }
    }

    [Test]
    public async Task Update_MissingEntity_ContinuesToValidationAndUpdate()
    {
        var context = new ServiceContext();
        var item = new UpdateDto { Id = 23, Name = "Outro" };
        var entity = new TestEntity { Id = item.Id };
        context.Repository.Setup(x => x.Exists(item.Id)).ReturnsAsync(false);
        context.Mapper.Setup(x => x.Map<TestEntity>(item)).Returns(entity);
        context.Validator.Setup(x => x.ValidateAsync(entity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);
        context.Mapper.Setup(x => x.Map<ResultDto>(entity)).Returns(new ResultDto { Id = item.Id });

        var result = await context.Service.Update(item);
        result.Success.Should().BeTrue();
        context.Repository.Verify(x => x.Update(entity), Times.Once);
    }

    [Test]
    public async Task Delete_ExistingAndMissing_BehaveAsExpected()
    {
        var context = new ServiceContext();
        context.Repository.Setup(x => x.Exists(4)).ReturnsAsync(true);
        context.Repository.Setup(x => x.Delete(4)).ReturnsAsync(true);
        context.Repository.Setup(x => x.Exists(5)).ReturnsAsync(false);

        var deleted = await context.Service.Delete(4);
        var missing = await context.Service.Delete(5);

        using (Assert.EnterMultipleScope())
        {
            deleted.Success.Should().BeTrue();
            missing.Success.Should().BeFalse();
        }
        context.Repository.Verify(x => x.Delete(4), Times.Once);
        context.Repository.Verify(x => x.Delete(5), Times.Never);
    }

    [Test]
    public async Task FindAll_FindById_Exists_GetCount_EnableOrDisable_Succeed()
    {
        var context = new ServiceContext();
        var entity = new TestEntity { Id = 1, Name = "a" };
        context.Repository.Setup(x => x.FindAll()).ReturnsAsync([entity]);
        context.Mapper.Setup(x => x.Map<ResultDto>(entity)).Returns(new ResultDto { Id = 1, Name = "a" });
        context.Repository.Setup(x => x.FindByID(1)).ReturnsAsync(entity);
        context.Repository.Setup(x => x.Exists(1)).ReturnsAsync(true);
        context.Repository.Setup(x => x.GetCount(It.IsAny<System.Linq.Expressions.Expression<Func<TestEntity, bool>>>())).ReturnsAsync(3);
        context.Repository.Setup(x => x.EnableOrDisable(1)).ReturnsAsync(true);

        var all = await context.Service.FindAll();
        var byId = await context.Service.FindByID(1);
        var exists = await context.Service.Exists(1);
        var count = await context.Service.GetCount();
        var enable = await context.Service.EnableOrDisable(1);
        context.Service.SetUserId(99);

        using (Assert.EnterMultipleScope())
        {
            all.Success.Should().BeTrue();
            all.Data.Should().ContainSingle();
            byId.Success.Should().BeTrue();
            byId.Data!.Name.Should().Be("a");
            exists.Data.Should().BeTrue();
            count.Data.Should().Be(3);
            enable.Success.Should().BeTrue();
            context.Service.ExposedUserId.Should().Be(99);
        }
    }

    [Test]
    public async Task EnableOrDisable_MissingEntity_ReturnsNotFound()
    {
        var context = new ServiceContext();
        context.Repository.Setup(x => x.Exists(99)).ReturnsAsync(false);
        var result = await context.Service.EnableOrDisable(99);
        result.Success.Should().BeFalse();
        context.Repository.Verify(x => x.EnableOrDisable(It.IsAny<long>()), Times.Never);
    }

    [Test]
    public async Task GetLocalizationErros_WithAndWithoutErrors_TranslatesMessages()
    {
        var context = new ServiceContext();
        var empty = await context.Service.ExposeGetLocalizationErros([]);
        var translated = await context.Service.ExposeGetLocalizationErros(
        [
            new ErrorResponse { Name = "X", ErrorCode = "Code", DefaultMessage = "def", FullMessage = "full" }
        ]);

        using (Assert.EnterMultipleScope())
        {
            empty.Should().BeEmpty();
            translated.Should().ContainSingle(e => e.Message == "def" && e.Name == "X");
        }
    }

    [Test]
    public async Task Operations_WithInvalidPolicy_ReturnFailures()
    {
        var context = new ServiceContext(policyName: "invalid");
        var delete = await context.Service.Delete(1);
        var update = await context.Service.Update(new UpdateDto { Id = 1 });
        var findAll = await context.Service.FindAll();
        var findById = await context.Service.FindByID(1);
        var count = await context.Service.GetCount();
        var enable = await context.Service.EnableOrDisable(1);
        var exists = await context.Service.Exists(1);
        var validate = await context.Service.Validate(new TestEntity());

        using (Assert.EnterMultipleScope())
        {
            delete.Success.Should().BeFalse();
            update.Success.Should().BeFalse();
            findAll.Success.Should().BeFalse();
            findById.Success.Should().BeFalse();
            count.Success.Should().BeFalse();
            enable.Success.Should().BeFalse();
            exists.Success.Should().BeFalse();
            validate.Success.Should().BeFalse();
        }
    }

    private sealed class ServiceContext
    {
        public Mock<IEntityBaseRepository<TestEntity>> Repository { get; } = new();
        public Mock<IValidator<TestEntity>> Validator { get; } = new();
        public Mock<IMapper> Mapper { get; } = new();
        public Mock<IAppLogger> Logger { get; } = new();
        public ProbeEntityBaseService Service { get; }

        public ServiceContext(string policyName = "")
        {
            var cache = new Mock<ICacheService>();
            var policy = new Mock<IResiliencePolicyConfig>();
            policy.SetupProperty(x => x.PolicyName, policyName);
            policy.SetupProperty(x => x.RetryCount, 0);
            policy.SetupProperty(x => x.RetryDelayInSeconds, 0);

            Service = new ProbeEntityBaseService(
                Mapper.Object,
                Logger.Object,
                cache.Object,
                policy.Object,
                Repository.Object,
                Validator.Object);
        }
    }

    private sealed class ProbeEntityBaseService : EntityBaseService<TestEntity, ResultDto>
    {
        public ProbeEntityBaseService(
            IMapper mapper,
            IAppLogger logger,
            ICacheService cacheService,
            IResiliencePolicyConfig policyConfig,
            IEntityBaseRepository<TestEntity> entityRepository,
            IValidator<TestEntity> entityValidator)
            : base(mapper, logger, cacheService, policyConfig, entityRepository, entityValidator)
        {
        }

        public long ExposedUserId => UserId;

        public Task<List<ErrorResponse>> ExposeGetLocalizationErros(List<ErrorResponse> errors)
            => GetLocalizationErros(errors);
    }

    public sealed class TestEntity : EntityBase
    {
        public string Name { get; set; } = string.Empty;
    }

    public sealed class ResultDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public sealed class AddDto : IEntityDtoAdd
    {
    }

    public sealed class UpdateDto : IEntityDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
