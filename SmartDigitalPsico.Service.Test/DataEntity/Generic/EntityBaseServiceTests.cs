using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using Serilog;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Resiliency;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;

namespace SmartDigitalPsico.Service.Test.DataEntity.Generic;

[TestFixture]
public class EntityBaseServiceTests
{
    // Cenário: um registro válido é criado.
    // Objetivo: mapear, validar, persistir e retornar o DTO criado.
    [Test]
    public async Task Create_ValidItem_PersistsAndReturnsMappedResult()
    {
        // Arrange
        var context = new ServiceContext();
        var item = new AddGenderDto { Description = "Feminino", Language = "pt-BR" };
        var entity = new Gender { Description = item.Description, Language = item.Language };
        context.Mapper.Setup(x => x.Map<Gender>(item)).Returns(entity);
        context.Validator.Setup(x => x.ValidateAsync(entity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Create(entity)).ReturnsAsync(entity);
        context.Mapper.Setup(x => x.Map<GetGenderDto>(entity))
            .Returns(new GetGenderDto { Description = item.Description, Language = item.Language });

        // Act
        var result = await context.Service.Create(item);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Description.Should().Be("Feminino");
            entity.Enable.Should().BeTrue();
            entity.CreatedDate.Should().NotBe(DateTime.MinValue);
        }
        context.Repository.Verify(x => x.Create(entity), Times.Once);
    }

    // Cenário: a validação de criação falha.
    // Objetivo: impedir a persistência e devolver os erros traduzidos.
    [Test]
    public async Task Create_InvalidItem_ReturnsValidationFailureWithoutPersisting()
    {
        // Arrange
        var context = new ServiceContext();
        var item = new AddGenderDto { Description = string.Empty };
        var entity = new Gender();
        context.Mapper.Setup(x => x.Map<Gender>(item)).Returns(entity);
        context.Validator.Setup(x => x.ValidateAsync(entity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult([new ValidationFailure("Description", "Descrição obrigatória")
            {
                ErrorCode = "RequiredValidator"
            }]));

        // Act
        var result = await context.Service.Create(item);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Errors.Should().ContainSingle();
        }
        context.Repository.Verify(x => x.Create(It.IsAny<Gender>()), Times.Never);
    }

    // Cenário: ocorre uma exceção durante a criação.
    // Objetivo: converter a exceção em resposta de erro e registrar o evento.
    [Test]
    public async Task Create_InvalidPolicy_ReturnsGenericFailureAndLogsError()
    {
        // Arrange
        var context = new ServiceContext(policyName: "invalid");

        // Act
        var result = await context.Service.Create(new AddGenderDto());

        // Assert
        result.Success.Should().BeFalse();
        result.Errors.Should().ContainSingle(x => x.Name == "Create");

        context.Logger.Verify(x => x.Error(
            It.IsAny<Exception>(),
            It.IsAny<string>(),
            It.IsAny<object[]>()), Times.Once);
    }

    // Cenário: a atualização aponta para registro inexistente.
    // Objetivo: documentar o fluxo atual, que continua para validação e persistência.
    [Test]
    public async Task Update_MissingEntity_ContinuesToValidationAndUpdate()
    {
        // Arrange
        var context = new ServiceContext();
        var item = new UpdateGenderDto { Id = 23, Description = "Outro" };
        var entity = new Gender { Id = item.Id };
        context.Repository.Setup(x => x.Exists(item.Id)).ReturnsAsync(false);
        context.Mapper.Setup(x => x.Map<Gender>(item)).Returns(entity);
        context.Validator.Setup(x => x.ValidateAsync(entity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());

        // Act
        var result = await context.Service.Update(item);

        // Assert
        result.Success.Should().BeTrue("a implementação atual ainda valida e atualiza após o ramo de inexistência");

        context.Repository.Verify(x => x.Update(entity), Times.Once);
    }

    // Cenário: a atualização é válida.
    // Objetivo: validar e persistir a entidade atualizada.
    [Test]
    public async Task Update_ExistingValidEntity_UpdatesAndReturnsResult()
    {
        // Arrange
        var context = new ServiceContext();
        var item = new UpdateGenderDto { Id = 24, Description = "Masculino" };
        var entity = new Gender { Id = item.Id, Description = item.Description };
        context.Repository.Setup(x => x.Exists(item.Id)).ReturnsAsync(true);
        context.Mapper.Setup(x => x.Map<Gender>(item)).Returns(entity);
        context.Validator.Setup(x => x.ValidateAsync(entity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);
        context.Mapper.Setup(x => x.Map<GetGenderDto>(entity)).Returns(new GetGenderDto { Id = item.Id, Description = item.Description });

        // Act
        var result = await context.Service.Update(item);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Id.Should().Be(item.Id);
            entity.ModifyDate.Should().NotBe(DateTime.MinValue);
        }
    }

    // Cenário: o registro existe e é removido.
    // Objetivo: excluir e registrar o contrato atual da resposta.
    [Test]
    public async Task Delete_ExistingEntity_DeletesEntity()
    {
        // Arrange
        var context = new ServiceContext();
        context.Repository.Setup(x => x.Exists(4)).ReturnsAsync(true);
        context.Repository.Setup(x => x.Delete(4)).ReturnsAsync(true);

        // Act
        var result = await context.Service.Delete(4);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeFalse("Delete não atribui o retorno do repositório a Data");
        }
        context.Repository.Verify(x => x.Delete(4), Times.Once);
    }

    // Cenário: o registro a excluir não existe.
    // Objetivo: retornar não encontrado sem excluir.
    [Test]
    public async Task Delete_MissingEntity_ReturnsNotFound()
    {
        // Arrange
        var context = new ServiceContext();
        context.Repository.Setup(x => x.Exists(5)).ReturnsAsync(false);

        // Act
        var result = await context.Service.Delete(5);

        // Assert
        result.Success.Should().BeFalse();

        context.Repository.Verify(x => x.Delete(It.IsAny<long>()), Times.Never);
    }

    // Cenário: uma consulta traz múltiplos registros.
    // Objetivo: mapear todos os registros retornados.
    [Test]
    public async Task FindAll_RepositoryReturnsEntities_ReturnsMappedList()
    {
        // Arrange
        var context = new ServiceContext();
        var entities = new List<Gender> { new() { Id = 1 }, new() { Id = 2 } };
        context.Repository.Setup(x => x.FindAll()).ReturnsAsync(entities);
        context.Mapper.Setup(x => x.Map<GetGenderDto>(It.IsAny<Gender>()))
            .Returns((Gender entity) => new GetGenderDto { Id = entity.Id });

        // Act
        var result = await context.Service.FindAll();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().HaveCount(2);
        }
    }

    // Cenário: uma consulta localiza registro por ID.
    // Objetivo: mapear e retornar o registro encontrado.
    [Test]
    public async Task FindByID_ExistingEntity_ReturnsMappedEntity()
    {
        // Arrange
        var context = new ServiceContext();
        var entity = new Gender { Id = 8, Description = "Não binário" };
        context.Repository.Setup(x => x.FindByID(8)).ReturnsAsync(entity);
        context.Mapper.Setup(x => x.Map<GetGenderDto>(entity)).Returns(new GetGenderDto { Id = 8, Description = entity.Description });

        // Act
        var result = await context.Service.FindByID(8);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Description.Should().Be("Não binário");
        }
    }

    // Cenário: uma consulta por ID não encontra registro.
    // Objetivo: retornar sucesso sem dados conforme o contrato genérico atual.
    [Test]
    public async Task FindByID_MissingEntity_ReturnsSuccessWithoutData()
    {
        // Arrange
        var context = new ServiceContext();
        context.Repository.Setup(x => x.FindByID(9)).ReturnsAsync((Gender)null!);

        // Act
        var result = await context.Service.FindByID(9);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeNull();
        }
    }

    // Cenário: a validação possui erro.
    // Objetivo: traduzir e retornar o erro do validator.
    [Test]
    public async Task Validate_InvalidEntity_ReturnsTranslatedErrors()
    {
        // Arrange
        var context = new ServiceContext();
        var entity = new Gender();
        context.Validator.Setup(x => x.ValidateAsync(entity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult([new ValidationFailure("Language", "Idioma inválido") { ErrorCode = "LanguageInvalid" }]));

        // Act
        var result = await context.Service.Validate(entity);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Errors.Should().ContainSingle(x => x.Name == "Language");
            result.Message.Should().NotBeNullOrWhiteSpace();
        }
    }

    // Cenário: a validação é bem-sucedida.
    // Objetivo: confirmar o estado válido da entidade.
    [Test]
    public async Task Validate_ValidEntity_ReturnsSuccess()
    {
        // Arrange
        var context = new ServiceContext();
        var entity = new Gender { Description = "Feminino" };
        context.Validator.Setup(x => x.ValidateAsync(entity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());

        // Act
        var result = await context.Service.Validate(entity);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: alternância de estado para registro existente.
    // Objetivo: delegar a operação ao repositório.
    [Test]
    public async Task EnableOrDisable_ExistingEntity_ReturnsRepositoryResult()
    {
        // Arrange
        var context = new ServiceContext();
        context.Repository.Setup(x => x.Exists(11)).ReturnsAsync(true);
        context.Repository.Setup(x => x.EnableOrDisable(11)).ReturnsAsync(true);

        // Act
        var result = await context.Service.EnableOrDisable(11);

        // Assert
        result.Success.Should().BeTrue();

        context.Repository.Verify(x => x.EnableOrDisable(11), Times.Once);
    }

    // Cenário: a contagem é consultada e o usuário é configurado.
    // Objetivo: retornar a contagem e preservar o identificador do usuário.
    [Test]
    public async Task GetCount_RepositoryReturnsCount_ReturnsCountAndStoresUserId()
    {
        // Arrange
        var context = new ServiceContext();
        context.Repository.Setup(x => x.GetCount(It.IsAny<System.Linq.Expressions.Expression<Func<Gender, bool>>>()))
            .ReturnsAsync(7);

        // Act
        context.Service.SetUserId(99);

        var result = await context.Service.GetCount();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().Be(7);
            context.Service.ExposedUserId.Should().Be(99);
        }
    }

    // Cenário: Exists consulta o repositório com sucesso.
    // Objetivo: retornar Data=true e Success=true.
    [Test]
    public async Task Exists_RepositoryReturnsTrue_ReturnsSuccess()
    {
        // Arrange
        var context = new ServiceContext();
        context.Repository.Setup(x => x.Exists(1)).ReturnsAsync(true);

        // Act
        var result = await context.Service.Exists(1);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeTrue();
        }
    }

    // Cenário: Exists falha por política inválida.
    // Objetivo: cobrir o catch e retornar falha genérica.
    [Test]
    public async Task Exists_InvalidPolicy_ReturnsGenericFailure()
    {
        // Arrange
        var context = new ServiceContext(policyName: "invalid");

        // Act
        var result = await context.Service.Exists(1);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: Delete/Update/FindAll/FindByID/GetCount/EnableOrDisable/Validate falham por política.
    // Objetivo: cobrir todos os blocos catch do SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService.
    [Test]
    public async Task MutationAndQueryMethods_InvalidPolicy_ReturnGenericFailures()
    {
        // Arrange
        var context = new ServiceContext(policyName: "invalid");
        context.Mapper.Setup(x => x.Map<Gender>(It.IsAny<object>())).Returns(new Gender());
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<Gender>(), It.IsAny<CancellationToken>()))
            .ThrowsAsync(new InvalidOperationException("validator"));

        // Act
        var delete = await context.Service.Delete(1);
        var update = await context.Service.Update(new UpdateGenderDto { Id = 1 });
        var findAll = await context.Service.FindAll();
        var findById = await context.Service.FindByID(1);
        var count = await context.Service.GetCount();
        var enable = await context.Service.EnableOrDisable(1);
        var validate = await context.Service.Validate(new Gender());

        // Assert
        using (Assert.EnterMultipleScope())
        {
            delete.Success.Should().BeFalse();
            update.Success.Should().BeFalse();
            findAll.Success.Should().BeFalse();
            findById.Success.Should().BeFalse();
            count.Success.Should().BeFalse();
            enable.Success.Should().BeFalse();
            validate.Success.Should().BeFalse();
        }
    }

    // Cenário: EnableOrDisable para registro inexistente.
    // Objetivo: retornar não encontrado sem alterar estado.
    [Test]
    public async Task EnableOrDisable_MissingEntity_ReturnsNotFound()
    {
        // Arrange
        var context = new ServiceContext();
        context.Repository.Setup(x => x.Exists(99)).ReturnsAsync(false);

        // Act
        var result = await context.Service.EnableOrDisable(99);

        // Assert
        result.Success.Should().BeFalse();

        context.Repository.Verify(x => x.EnableOrDisable(It.IsAny<long>()), Times.Never);
    }

    // Cenário: lista de erros é traduzida via GetLocalizationErros.
    // Objetivo: cobrir o helper protegido com lista vazia e com itens.
    [Test]
    public async Task GetLocalizationErros_WithAndWithoutErrors_TranslatesMessages()
    {
        // Arrange
        var context = new ServiceContext();

        // Act
        var empty = await context.Service.ExposeGetLocalizationErros([]);
        var translated = await context.Service.ExposeGetLocalizationErros(
        [
            new global::SmartDigitalPsico.Core.SDK.Domain.VO.ErrorResponse { Name = "X", ErrorCode = "Code", DefaultMessage = "def", FullMessage = "full" }
        ]);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            empty.Should().BeEmpty();
            translated.Should().ContainSingle(e => e.Message == "def" && e.Name == "X");
        }
    }

    private sealed class ServiceContext
    {
        public Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<Gender>> Repository { get; } = new();
        public Mock<IValidator<Gender>> Validator { get; } = new();
        public Mock<IAppMapper> Mapper { get; } = new();
        public Mock<IAppLogger> Logger { get; } = new();
        public ProbeEntityBaseService Service { get; }

        public ServiceContext(string policyName = "")
        {
            var cache = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService>();
            var language = new Mock<IApplicationLanguageService>();
            language.Setup(x => x.GetLocalization<ISharedResource>(It.IsAny<string>(), It.IsAny<string>(), cache.Object))
                .ReturnsAsync((string _, string fallback, SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService _) => fallback);

            var sharedServices = new Mock<ISharedServices>();
            sharedServices.SetupGet(x => x.CacheService).Returns(cache.Object);
            sharedServices.SetupGet(x => x.ApplicationLanguageService).Returns(language.Object);

            var policy = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig>();
            policy.SetupGet(x => x.PolicyName).Returns(policyName);
            var dependencies = new Mock<ISharedDependenciesConfig>();
            dependencies.SetupGet(x => x.Mapper).Returns(Mapper.Object);
            dependencies.SetupGet(x => x.Logger).Returns(Logger.Object);
            dependencies.SetupGet(x => x.PolicyConfig).Returns(policy.Object);

            Service = new ProbeEntityBaseService(
                sharedServices.Object,
                dependencies.Object,
                Mock.Of<ISharedRepositories>(),
                Repository.Object,
                Validator.Object);
        }
    }

    private sealed class ProbeEntityBaseService : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<Gender, GetGenderDto>
    {
        public ProbeEntityBaseService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig dependencies,
            ISharedRepositories repositories,
            global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<Gender> repository,
            IValidator<Gender> validator)
            : base(sharedServices, dependencies, repositories, repository, validator)
        {
        }

        public long ExposedUserId => UserId;

        public Task<List<global::SmartDigitalPsico.Core.SDK.Domain.VO.ErrorResponse>> ExposeGetLocalizationErros(List<global::SmartDigitalPsico.Core.SDK.Domain.VO.ErrorResponse> errors)
            => GetLocalizationErros(errors);
    }
}

[TestFixture]
public class GenderServiceTests
{
    // Cenário: o cache está desabilitado.
    // Objetivo: consultar o repositório pelo fluxo base.
    [Test]
    public async Task FindAll_CacheDisabled_ReturnsRepositoryData()
    {
        // Arrange
        var context = new GenderServiceContext(cacheEnabled: false);
        context.Repository.Setup(x => x.FindAll()).ReturnsAsync([new Gender { Id = 1 }]);
        context.Mapper.Setup(x => x.Map<GetGenderDto>(It.IsAny<Gender>()))
            .Returns((Gender entity) => new GetGenderDto { Id = entity.Id });

        // Act
        var result = await context.Service.FindAll();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().ContainSingle(x => x.Id == 1);
        }
        context.Repository.Verify(x => x.FindAll(), Times.Once);
    }

    // Cenário: o cache está habilitado, mas não contém a consulta.
    // Objetivo: buscar a fonte e gravar a resposta em cache.
    [Test]
    public async Task FindAll_CacheMiss_LoadsRepositoryAndStoresCache()
    {
        // Arrange
        var context = new GenderServiceContext(cacheEnabled: true);
        context.Repository.Setup(x => x.FindAll()).ReturnsAsync([new Gender { Id = 2 }]);
        context.Mapper.Setup(x => x.Map<GetGenderDto>(It.IsAny<Gender>()))
            .Returns((Gender entity) => new GetGenderDto { Id = entity.Id });
        context.Cache.Setup(x => x.TryGet<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetGenderDto>>>(
                It.IsAny<string>(), out It.Ref<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetGenderDto>>>.IsAny))
            .Returns(false);
        context.Cache.Setup(x => x.GetSlidingExpiration()).Returns(DateTime.UtcNow.AddMinutes(5));
        context.Cache.Setup(x => x.Set(It.IsAny<string>(), It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetGenderDto>>>()))
            .Returns(true);

        // Act
        var result = await context.Service.FindAll();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().ContainSingle(x => x.Id == 2);
        }
        context.Cache.Verify(x => x.Set("FindAll_GetGenderVO", It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetGenderDto>>>()), Times.Once);
    }

    // Cenário: a resposta já está armazenada no cache.
    // Objetivo: devolver dados cacheados sem consultar o repositório.
    [Test]
    public async Task FindAll_CacheHit_ReturnsCachedDataWithoutRepositoryCall()
    {
        // Arrange
        var context = new GenderServiceContext(cacheEnabled: true);
        var cached = new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetGenderDto>>(
            new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<List<GetGenderDto>> { Data = [new GetGenderDto { Id = 3 }], Success = true },
            "FindAll_GetGenderVO",
            DateTime.UtcNow.AddMinutes(5));
        context.Cache.Setup(x => x.TryGet<global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<List<GetGenderDto>>>(
                "FindAll_GetGenderVO", out cached))
            .Returns(true);

        // Act
        var result = await context.Service.FindAll();

        // Assert
        result.Data.Should().ContainSingle(x => x.Id == 3);

        context.Repository.Verify(x => x.FindAll(), Times.Never);
    }

    // Cenário: o gênero procurado existe.
    // Objetivo: retornar o DTO especializado.
    [Test]
    public async Task FindByID_ExistingGender_ReturnsMappedResult()
    {
        // Arrange
        var context = new GenderServiceContext(cacheEnabled: false);
        var gender = new Gender { Id = 4, Description = "Feminino" };
        context.Repository.Setup(x => x.FindByID(4)).ReturnsAsync(gender);
        context.Mapper.Setup(x => x.Map<GetGenderDto>(gender)).Returns(new GetGenderDto { Id = 4, Description = "Feminino" });

        // Act
        var result = await context.Service.FindByID(4);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Description.Should().Be("Feminino");
        }
    }

    // Cenário: gênero inexistente.
    // Objetivo: retornar falha de registro não encontrado.
    [Test]
    public async Task FindByID_MissingGender_ReturnsNotFound()
    {
        // Arrange
        var context = new GenderServiceContext(cacheEnabled: false);
        context.Repository.Setup(x => x.FindByID(404)).Returns(Task.FromResult<Gender>(null!));

        // Act
        var result = await context.Service.FindByID(404);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: atualização de gênero inexistente.
    // Objetivo: retornar falha sem persistir.
    [Test]
    public async Task Update_MissingGender_ReturnsNotFound()
    {
        // Arrange
        var context = new GenderServiceContext(cacheEnabled: false);
        context.Repository.Setup(x => x.Exists(50)).ReturnsAsync(false);

        // Act
        var result = await context.Service.Update(new UpdateGenderDto { Id = 50, Description = "X", Enable = true, Language = "en-US" });

        // Assert
        result.Success.Should().BeFalse();

        context.Repository.Verify(x => x.Update(It.IsAny<Gender>()), Times.Never);
    }

    // Cenário: atualização válida de gênero existente.
    // Objetivo: persistir alterações e retornar DTO atualizado.
    [Test]
    public async Task Update_ExistingGender_UpdatesSuccessfully()
    {
        // Arrange
        var context = new GenderServiceContext(cacheEnabled: false);
        var entity = new Gender { Id = 51, Description = "Old", Enable = true, Language = "en-US" };
        context.Repository.Setup(x => x.Exists(51)).ReturnsAsync(true);
        context.Repository.Setup(x => x.FindByID(51)).ReturnsAsync(entity);
        context.Validator.Setup(x => x.ValidateAsync(entity, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);
        context.Mapper.Setup(x => x.Map<GetGenderDto>(entity)).Returns(new GetGenderDto { Id = 51, Description = "New" });

        // Act
        var result = await context.Service.Update(new UpdateGenderDto { Id = 51, Description = "New", Enable = true, Language = "en-US" });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            entity.Description.Should().Be("New");
        }
    }

    private sealed class GenderServiceContext
    {
        public Mock<IGenderRepository> Repository { get; } = new();
        public Mock<IAppMapper> Mapper { get; } = new();
        public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService> Cache { get; } = new();
        public Mock<IValidator<Gender>> Validator { get; } = new();
        public GenderService Service { get; }

        public GenderServiceContext(bool cacheEnabled)
        {
            var language = new Mock<IApplicationLanguageService>();
            language.Setup(x => x.GetLocalization<ISharedResource>(It.IsAny<string>(), It.IsAny<string>(), Cache.Object))
                .ReturnsAsync((string _, string fallback, SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService _) => fallback);
            Cache.Setup(x => x.IsEnable()).Returns(cacheEnabled);

            var services = new Mock<ISharedServices>();
            services.SetupGet(x => x.CacheService).Returns(Cache.Object);
            services.SetupGet(x => x.ApplicationLanguageService).Returns(language.Object);

            var config = new Mock<ISharedDependenciesConfig>();
            config.SetupGet(x => x.Mapper).Returns(Mapper.Object);
            config.SetupGet(x => x.Logger).Returns(Mock.Of<IAppLogger>());
            config.SetupGet(x => x.PolicyConfig).Returns(new ResiliencePolicyConfig());

            Service = new GenderService(
                services.Object,
                config.Object,
                Mock.Of<ISharedRepositories>(),
                Repository.Object,
                Validator.Object);
        }
    }
}

