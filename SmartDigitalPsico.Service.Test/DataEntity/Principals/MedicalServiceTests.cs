using SmartDigitalPsico.Service;
using FluentValidation;
using FluentValidation.Results;
using Moq;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.DTO.Medical.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.GET;
using SmartDigitalPsico.Domain.DTO.Medical.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.Common;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Service;
using SmartDigitalPsico.Service;
using SmartDigitalPsico.Service.Test.TestSupport;

using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Specialty;
using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Test.DataEntity.Principals;
    using User = global::SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = global::SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = global::SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = global::SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = global::SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = global::SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = global::SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = global::SmartDigitalPsico.Domain.EntityModels.Specialty;
                                

[TestFixture]
public class MedicalServiceTests
{
    // Cenário: criação de médico válido com especialidades.
    // Objetivo: persistir o médico, vincular especialidades e retornar sucesso.
    [Test]
    public async Task Create_ValidMedicalWithSpecialties_PersistsAndLinksSpecialties()
    {
        // Arrange
        var context = new MedicalServiceContext();
        var addDto = new AddMedicalDto
        {
            Name = "Dr. House",
            Email = "HOUSE@CLINIC.COM",
            Accreditation = "CRM12345",
            OfficeId = 1,
            SpecialtiesIds = [1, 2]
        };
        context.SpecialtyRepository.Setup(x => x.FindByIDs(addDto.SpecialtiesIds)).ReturnsAsync([new Specialty { Id = 1, Description = "Cardio" }]);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<Medical>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Create(It.IsAny<Medical>())).ReturnsAsync((Medical m) => { m.Id = 20; return m; });
        context.Repository.Setup(x => x.Update(It.IsAny<Medical>())).ReturnsAsync((Medical m) => m);
        context.Repository.Setup(x => x.FindByID(20)).ReturnsAsync(new Medical { Id = 20, Name = "Dr. House", MedicalSpecialties = new List<MedicalSpecialty>() });

        // Act
        var result = await context.Service.Create(addDto);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().NotBeNull();
        }
        context.Repository.Verify(x => x.Update(It.IsAny<Medical>()), Times.Once);
    }

    // Cenário: atualização de médico inexistente.
    // Objetivo: manter o contrato atual (resposta default sem dados) sem persistir nada.
    [Test]
    public async Task Update_MissingMedical_ReturnsDefaultResponseWithoutPersisting()
    {
        // Arrange
        var context = new MedicalServiceContext();
        context.Repository.Setup(x => x.FindByID(404)).Returns(Task.FromResult<Medical>(null!));

        // Act
        var result = await context.Service.Update(new UpdateMedicalDto { Id = 404 });

        // Assert
        result.Data.Should().BeNull();

        context.Repository.Verify(x => x.Update(It.IsAny<Medical>()), Times.Never);
    }

    // Cenário: atualização de médico existente com especialidades atualizadas.
    // Objetivo: atualizar dados, vincular novas especialidades e notificar por e-mail.
    [Test]
    public async Task Update_ExistingMedical_UpdatesAndSendsFallbackNotification()
    {
        // Arrange
        var context = new MedicalServiceContext();
        var entity = new Medical { Id = 21, Name = "Old", Email = "old@x.com", MedicalSpecialties = new List<MedicalSpecialty>() };
        context.Repository.Setup(x => x.FindByID(21)).ReturnsAsync(entity);
        context.SpecialtyRepository.Setup(x => x.FindByIDs(It.IsAny<List<long>>())).ReturnsAsync([new Specialty { Id = 3 }]);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<Medical>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);
        context.Context.NotificationTemplate.Setup(x => x.GetNotificationTemplatesAsync(It.IsAny<string>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<GetNotificationTemplateDto> { Success = false });
        context.Context.SendNotification.Setup(x => x.SendNotificationAsync(
                It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO>(),
                It.IsAny<SmartDigitalPsico.Core.SDK.Domain.Enuns.ENotificationServiceType>(),
                It.IsAny<Dictionary<string, string>>()))
            .Returns(Task.CompletedTask);

        var updateDto = new UpdateMedicalDto
        {
            Id = 21,
            Name = "New",
            Email = "NEW@X.COM",
            Accreditation = "CRM999",
            OfficeId = 2,
            SpecialtiesIds = [3]
        };

        // Act
        var result = await context.Service.Update(updateDto);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            entity.Name.Should().Be("New");
            entity.Email.Should().Be("new@x.com");
        }
        context.Context.SendNotification.Verify(x => x.SendNotificationAsync(
            It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO>(),
            It.IsAny<SmartDigitalPsico.Core.SDK.Domain.Enuns.ENotificationServiceType>(),
            It.IsAny<Dictionary<string, string>>()), Times.Once);
    }

    // Cenário: atualização com template de e-mail disponível.
    // Objetivo: enviar notificação usando template e tokens substituídos.
    [Test]
    public async Task Update_ExistingMedicalWithTemplate_SendsTemplateNotification()
    {
        // Arrange
        var context = new MedicalServiceContext();

        // Act
        context.Service.SetUserId(5);
        var entity = new Medical { Id = 22, Name = "Dr. Template", Email = "old@x.com", MedicalSpecialties = new List<MedicalSpecialty>() };
        context.Repository.Setup(x => x.FindByID(22)).ReturnsAsync(entity);
        context.SpecialtyRepository.Setup(x => x.FindByIDs(It.IsAny<List<long>>())).ReturnsAsync([]);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<Medical>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);
        context.UserRepository.Setup(x => x.FindByID(5)).ReturnsAsync(new User { Id = 5, Name = "Admin User" });
        context.Context.NotificationTemplate.Setup(x => x.GetNotificationTemplatesAsync(It.IsAny<string>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<GetNotificationTemplateDto>
            {
                Success = true,
                Data = new GetNotificationTemplateDto { Subject = "Updated", Body = "Body {{MedicalName}}" }
            });
        context.Context.SendNotification.Setup(x => x.SendNotificationAsync(
                It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO>(),
                It.IsAny<SmartDigitalPsico.Core.SDK.Domain.Enuns.ENotificationServiceType>(),
                It.IsAny<Dictionary<string, string>>()))
            .Returns(Task.CompletedTask);

        var result = await context.Service.Update(new UpdateMedicalDto
        {
            Id = 22,
            Name = "Dr. Template Updated",
            Email = "NEW@X.COM",
            Accreditation = "CRM111",
            OfficeId = 1,
            SpecialtiesIds = []
        });

        // Assert
        result.Success.Should().BeTrue();

        context.Context.SendNotification.Verify(x => x.SendNotificationAsync(
            It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO>(),
            SmartDigitalPsico.Core.SDK.Domain.Enuns.ENotificationServiceType.Email,
            It.Is<Dictionary<string, string>>(d => d["MedicalName"] == "Dr. Template Updated")), Times.Once);
    }

    // Cenário: falha na notificação dispara fallback por e-mail.
    // Objetivo: enviar e-mail de fallback quando template lança exceção.
    [Test]
    public async Task Update_NotificationThrows_SendsFallbackEmail()
    {
        // Arrange
        var context = new MedicalServiceContext();
        var entity = new Medical { Id = 23, Name = "Dr. Fail", Email = "a@b.com", MedicalSpecialties = new List<MedicalSpecialty>() };
        context.Repository.Setup(x => x.FindByID(23)).ReturnsAsync(entity);
        context.SpecialtyRepository.Setup(x => x.FindByIDs(It.IsAny<List<long>>())).ReturnsAsync([]);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<Medical>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);
        context.Context.NotificationTemplate.Setup(x => x.GetNotificationTemplatesAsync(It.IsAny<string>()))
            .ThrowsAsync(new InvalidOperationException("template error"));
        context.Context.SendNotification.Setup(x => x.SendNotificationAsync(
                It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO>(),
                It.IsAny<SmartDigitalPsico.Core.SDK.Domain.Enuns.ENotificationServiceType>(),
                It.IsAny<Dictionary<string, string>>()))
            .Returns(Task.CompletedTask);

        // Act
        var result = await context.Service.Update(new UpdateMedicalDto
        {
            Id = 23,
            Name = "Dr. Fail Updated",
            Email = "c@d.com",
            Accreditation = "CRM222",
            OfficeId = 1,
            SpecialtiesIds = []
        });

        // Assert
        result.Success.Should().BeTrue();

        context.Context.SendNotification.Verify(x => x.SendNotificationAsync(
            It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO>(),
            SmartDigitalPsico.Core.SDK.Domain.Enuns.ENotificationServiceType.Email,
            It.IsAny<Dictionary<string, string>>()), Times.Once);
    }

    // Cenário: remoção de médico.
    // Objetivo: delegar para habilitar/desabilitar em vez de excluir definitivamente.
    [Test]
    public async Task Delete_ExistingMedical_DelegatesToEnableOrDisable()
    {
        // Arrange
        var context = new MedicalServiceContext();
        context.Repository.Setup(x => x.Exists(30)).ReturnsAsync(true);
        context.Repository.Setup(x => x.EnableOrDisable(30)).ReturnsAsync(true);

        // Act
        var result = await context.Service.Delete(30);

        // Assert
        result.Success.Should().BeTrue();

        context.Repository.Verify(x => x.EnableOrDisable(30), Times.Once);
    }

    // Cenário: consulta de todos os médicos sem permissão de administrador.
    // Objetivo: bloquear a consulta com falha de autorização.
    [Test]
    public async Task FindAll_NonAdminUser_ReturnsPermissionDenied()
    {
        // Arrange
        var context = new MedicalServiceContext();

        // Act
        context.Service.SetUserId(1);
        context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = false });

        var result = await context.Service.FindAll();

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: consulta de todos os médicos com usuário administrador.
    // Objetivo: retornar a lista completa de médicos.
    [Test]
    public async Task FindAll_AdminUser_ReturnsMedicalsList()
    {
        // Arrange
        var context = new MedicalServiceContext();

        // Act
        context.Service.SetUserId(2);
        context.UserRepository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, Admin = true });
        context.Repository.Setup(x => x.FindAll()).ReturnsAsync([new Medical { Id = 1, MedicalSpecialties = new List<MedicalSpecialty>() }]);

        var result = await context.Service.FindAll();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().ContainSingle();
        }
    }

    // Cenário: usuário autenticado não encontrado ao validar acesso administrativo.
    // Objetivo: bloquear a consulta por usuário inválido.
    [Test]
    public async Task FindAll_UnknownUser_ReturnsFailure()
    {
        // Arrange
        var context = new MedicalServiceContext();

        // Act
        context.Service.SetUserId(999);
        context.UserRepository.Setup(x => x.FindByID(999)).Returns(Task.FromResult<User>(null!));

        var result = await context.Service.FindAll();

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: consulta de médico por ID sem permissão administrativa.
    // Objetivo: bloquear a consulta.
    [Test]
    public async Task FindByID_NonAdminUser_ReturnsPermissionDenied()
    {
        // Arrange
        var context = new MedicalServiceContext();

        // Act
        context.Service.SetUserId(3);
        context.UserRepository.Setup(x => x.FindByID(3)).ReturnsAsync(new User { Id = 3, Admin = false });

        var result = await context.Service.FindByID(50);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: consulta de médico por ID com permissão administrativa e registro existente.
    // Objetivo: mapear especialidades vinculadas ao médico.
    [Test]
    public async Task FindByID_AdminUserWithExistingMedical_ReturnsMappedSpecialties()
    {
        // Arrange
        var context = new MedicalServiceContext();

        // Act
        context.Service.SetUserId(4);
        context.UserRepository.Setup(x => x.FindByID(4)).ReturnsAsync(new User { Id = 4, Admin = true });
        var specialty = new Specialty { Id = 8, Description = "Neuro", Enable = true };
        var medical = new Medical
        {
            Id = 50,
            MedicalSpecialties = new List<MedicalSpecialty> { new() { Specialty = specialty } }
        };
        context.Repository.Setup(x => x.FindByID(50)).ReturnsAsync(medical);

        var result = await context.Service.FindByID(50);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Specialties.Should().ContainSingle(s => s.Description == "Neuro");
        }
    }

    private sealed class MedicalServiceContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<IMedicalRepository> Repository { get; } = new();
        public Mock<ISpecialtyRepository> SpecialtyRepository { get; } = new();
        public Mock<IValidator<Medical>> Validator { get; } = new();
        public Mock<IUserRepository> UserRepository => Context.UserRepository;
        public MedicalService Service { get; }

        public MedicalServiceContext()
        {
            Service = new MedicalService(
                Context.SharedServices,
                Context.Config,
                Context.SharedRepositories,
                Repository.Object,
                SpecialtyRepository.Object,
                Validator.Object);
        }
    }
}
