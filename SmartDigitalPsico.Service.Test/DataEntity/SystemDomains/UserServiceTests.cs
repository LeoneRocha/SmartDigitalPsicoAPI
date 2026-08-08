using System.Security.Claims;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.DTO.User.ADD;
using SmartDigitalPsico.Domain.DTO.User.GET;
using SmartDigitalPsico.Domain.DTO.User.UPDATE;
using SmartDigitalPsico.Domain.DTO.User.Common;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Service.Test.TestSupport;

namespace SmartDigitalPsico.Service.Test.DataEntity.SystemDomains;

[TestFixture]
public class UserServiceTests
{
    // Cenário: login com usuário inexistente.
    // Objetivo: retornar falha sem gerar token.
    [Test]
    public async Task Login_UserNotFound_ReturnsFailure()
    {
        // Arrange
        var context = new UserServiceContext();
        context.Context.UserRepository.Setup(x => x.FindByLogin("john")).Returns(Task.FromResult<User?>(null));

        // Act
        var result = await context.Service.Login("john", "secret");

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: login com senha incorreta.
    // Objetivo: retornar falha de senha sem gerar token.
    [Test]
    public async Task Login_WrongPassword_ReturnsFailure()
    {
        // Arrange
        var context = new UserServiceContext();
        SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreatePasswordHash("correct-password", out var hash, out var salt);
        var user = new User { Id = 1, Login = "john", PasswordHash = hash, PasswordSalt = salt };
        context.Context.UserRepository.Setup(x => x.FindByLogin("john")).ReturnsAsync(user);

        // Act
        var result = await context.Service.Login("john", "wrong-password");

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: login válido com credencial JWT habilitada.
    // Objetivo: gerar token e retornar dados autenticados.
    [Test]
    public async Task Login_ValidCredentialsWithJwt_ReturnsAuthenticatedData()
    {
        // Arrange
        var context = new UserServiceContext(typeApiCredential: global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeApiCredential.Jwt);
        SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreatePasswordHash("secret", out var hash, out var salt);
        var user = new User
        {
            Id = 10,
            Login = "john",
            Name = "John",
            PasswordHash = hash,
            PasswordSalt = salt,
            UserRoleGroups = new List<RoleGroupUser>()
        };
        context.Context.UserRepository.Setup(x => x.FindByLogin("john")).ReturnsAsync(user);
        context.TokenService.Setup(x => x.GenerateAccessToken(It.IsAny<IEnumerable<Claim>>())).Returns("access-token");
        context.TokenService.Setup(x => x.GenerateRefreshToken()).Returns("refresh-token");
        context.Context.UserRepository.Setup(x => x.RefreshUserInfo(user)).ReturnsAsync(user);
        context.TokenSessionService.Setup(x => x.GetSessionAsync(10)).Returns(Task.FromResult<UserTokenSession?>(null));
        context.TokenSessionService.Setup(x => x.SaveSessionAsync(It.IsAny<UserTokenSession>())).Returns(Task.CompletedTask);
        context.TokenConfiguration.SetupGet(x => x.Minutes).Returns(30);
        context.TokenConfiguration.SetupGet(x => x.DaysToExpiry).Returns(7);

        // Act
        var result = await context.Service.Login("john", "secret");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().NotBeNull();
            result.Data!.TokenAuth.Should().NotBeNull();
            result.Data.TokenAuth!.Authenticated.Should().BeTrue();
        }
    }

    // Cenário: login válido reutilizando sessão de token ainda vigente.
    // Objetivo: atualizar a sessão existente em vez de criar outra.
    [Test]
    public async Task Login_ValidCredentialsWithActiveSession_UpdatesExistingSession()
    {
        // Arrange
        var context = new UserServiceContext(typeApiCredential: global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeApiCredential.Jwt);
        SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreatePasswordHash("secret", out var hash, out var salt);
        var user = new User { Id = 11, Login = "mary", Name = "Mary", PasswordHash = hash, PasswordSalt = salt };
        context.Context.UserRepository.Setup(x => x.FindByLogin("mary")).ReturnsAsync(user);
        context.TokenService.Setup(x => x.GenerateAccessToken(It.IsAny<IEnumerable<Claim>>())).Returns("access-token-2");
        context.TokenService.Setup(x => x.GenerateRefreshToken()).Returns("refresh-token-2");
        context.Context.UserRepository.Setup(x => x.RefreshUserInfo(user)).ReturnsAsync(user);
        context.TokenSessionService.Setup(x => x.GetSessionAsync(11)).ReturnsAsync(new UserTokenSession
        {
            UserId = 11,
            ExpiresAt = DateTime.UtcNow.AddHours(1)
        });
        context.TokenConfiguration.SetupGet(x => x.Minutes).Returns(30);
        context.TokenConfiguration.SetupGet(x => x.DaysToExpiry).Returns(7);

        // Act
        var result = await context.Service.Login("mary", "secret");

        // Assert
        result.Success.Should().BeTrue();

        context.TokenSessionService.Verify(x => x.SaveSessionAsync(It.IsAny<UserTokenSession>()), Times.Never);
    }

    // Cenário: registro de usuário válido.
    // Objetivo: mapear, validar e persistir o novo usuário.
    [Test]
    public async Task Register_ValidData_CreatesUserAndReturnsSuccess()
    {
        // Arrange
        var context = new UserServiceContext();
        var registerDto = new UserRegisterDto { Name = "New User", Email = "new@user.com", Login = "newuser", Password = "Secret123" };
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Context.UserRepository.Setup(x => x.Create(It.IsAny<User>()))
            .ReturnsAsync((User u) => { u.Id = 55; return u; });

        // Act
        var result = await context.Service.Register(registerDto);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().NotBeNull();
        }
    }

    // Cenário: registro de usuário com dados inválidos.
    // Objetivo: bloquear a persistência retornando os erros de validação.
    [Test]
    public async Task Register_InvalidData_ReturnsValidationFailure()
    {
        // Arrange
        var context = new UserServiceContext();
        var registerDto = new UserRegisterDto { Name = "", Email = "invalid", Login = "x", Password = "123" };
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult([new ValidationFailure("Email", "Email inválido") { ErrorCode = "EmailInvalid" }]));

        // Act
        var result = await context.Service.Register(registerDto);

        // Assert
        result.Success.Should().BeFalse();

        context.Context.UserRepository.Verify(x => x.Create(It.IsAny<User>()), Times.Never);
    }

    // Cenário: criação de usuário administrativo com grupos de papel válidos.
    // Objetivo: persistir o usuário, vincular papéis e enviar o e-mail de acesso.
    [Test]
    public async Task Create_ValidDataWithRoleGroups_CreatesUserAndSendsEmail()
    {
        // Arrange
        var context = new UserServiceContext();
        var addDto = new UserRegisterDto { Name = "Admin User", Email = "admin@user.com", Login = "adminuser", Password = "Secret123", RoleGroupsIds = [1, 2] };
        var roleGroups = new List<RoleGroup> { new() { Id = 1, Description = "Manager" } };
        context.RoleGroupRepository.Setup(x => x.FindByIDs(It.IsAny<List<long>>())).ReturnsAsync(roleGroups);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Context.UserRepository.Setup(x => x.Create(It.IsAny<User>()))
            .ReturnsAsync((User u) => { u.Id = 66; return u; });
        context.Context.UserRepository.Setup(x => x.Update(It.IsAny<User>())).ReturnsAsync((User u) => u);
        context.Context.UserRepository.Setup(x => x.FindByID(66)).ReturnsAsync(new User { Id = 66 });
        context.Context.ApplicationConfigSettingRepository.Setup(x => x.FindAll())
            .ReturnsAsync([new ApplicationConfigSetting { UrlRootManager = "https://app.local" }]);
        context.Context.NotificationTemplate.Setup(x => x.GetNotificationTemplatesAsync(It.IsAny<string>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<GetNotificationTemplateDto> { Success = false });

        // Act
        var result = await context.Service.Create(addDto);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().NotBeNull();
        }
        context.Context.UserRepository.Verify(x => x.Update(It.IsAny<User>()), Times.Once);
    }

    // Cenário: criação de usuário sem grupos de papel.
    // Objetivo: persistir o usuário sem tentar vinculá-lo a papéis.
    [Test]
    public async Task Create_ValidDataWithoutRoleGroups_CreatesUserWithoutLinkingRoles()
    {
        // Arrange
        var context = new UserServiceContext();
        var addDto = new UserRegisterDto { Name = "Basic User", Email = "basic@user.com", Login = "basicuser", Password = "Secret123" };
        context.RoleGroupRepository.Setup(x => x.FindByIDs(It.IsAny<List<long>>())).ReturnsAsync([]);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Context.UserRepository.Setup(x => x.Create(It.IsAny<User>()))
            .ReturnsAsync((User u) => { u.Id = 77; return u; });
        context.Context.ApplicationConfigSettingRepository.Setup(x => x.FindAll())
            .ReturnsAsync([new ApplicationConfigSetting { UrlRootManager = "https://app.local" }]);
        context.Context.NotificationTemplate.Setup(x => x.GetNotificationTemplatesAsync(It.IsAny<string>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<GetNotificationTemplateDto> { Success = false });

        // Act
        var result = await context.Service.Create(addDto);

        // Assert
        result.Success.Should().BeTrue();

        context.Context.UserRepository.Verify(x => x.Update(It.IsAny<User>()), Times.Never);
    }

    // Cenário: criação de usuário dispara e-mail de acesso com template válido.
    // Objetivo: notificar via serviço de envio quando o template existir.
    [Test]
    public async Task Create_ValidTemplate_SendsAccessEmailNotification()
    {
        // Arrange
        var context = new UserServiceContext();
        var addDto = new UserRegisterDto { Name = "Notify User", Email = "notify@user.com", Login = "notifyuser", Password = "Secret123" };
        context.RoleGroupRepository.Setup(x => x.FindByIDs(It.IsAny<List<long>>())).ReturnsAsync([]);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Context.UserRepository.Setup(x => x.Create(It.IsAny<User>()))
            .ReturnsAsync((User u) => { u.Id = 88; return u; });
        context.Context.ApplicationConfigSettingRepository.Setup(x => x.FindAll())
            .ReturnsAsync([new ApplicationConfigSetting { UrlRootManager = "https://app.local" }]);
        context.Context.NotificationTemplate.Setup(x => x.GetNotificationTemplatesAsync(It.IsAny<string>()))
            .ReturnsAsync(new global::SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<GetNotificationTemplateDto>
            {
                Success = true,
                Data = new GetNotificationTemplateDto { Subject = "Welcome", Body = "Hello" }
            });
        context.Context.SendNotification.Setup(x => x.SendNotificationAsync(
                It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO>(), ENotificationServiceType.Email, It.IsAny<Dictionary<string, string>>()))
            .Returns(Task.CompletedTask);

        // Act
        var result = await context.Service.Create(addDto);

        // Assert
        result.Success.Should().BeTrue();

        context.Context.SendNotification.Verify(x => x.SendNotificationAsync(
            It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO>(), ENotificationServiceType.Email, It.IsAny<Dictionary<string, string>>()), Times.Once);
    }

    // Cenário: atualização de usuário inexistente.
    // Objetivo: retornar falha sem alterar dados.
    [Test]
    public async Task Update_MissingUser_ReturnsFailure()
    {
        // Arrange
        var context = new UserServiceContext();
        context.Context.UserRepository.Setup(x => x.FindByID(999)).Returns(Task.FromResult<User>(null!));

        // Act
        var result = await context.Service.Update(new UpdateUserDto { Id = 999 });

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: atualização de usuário existente com nova senha e grupos de papel.
    // Objetivo: atualizar dados, hash de senha e vínculos de papel.
    [Test]
    public async Task Update_ExistingUserWithPasswordAndRoleGroups_UpdatesSuccessfully()
    {
        // Arrange
        var context = new UserServiceContext();
        var entity = new User { Id = 5, Name = "Old", Email = "old@x.com" };
        context.Context.UserRepository.Setup(x => x.FindByID(5)).ReturnsAsync(entity);
        context.RoleGroupRepository.Setup(x => x.FindByIDs(It.IsAny<List<long>>())).ReturnsAsync([new RoleGroup { Id = 3 }]);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Context.UserRepository.Setup(x => x.Update(entity)).ReturnsAsync(entity);

        var updateDto = new UpdateUserDto
        {
            Id = 5,
            Name = "New Name",
            Email = "new@x.com",
            Password = "NewPassword1",
            Role = "Admin",
            MedicalId = 3,
            RoleGroupsIds = [3]
        };

        // Act
        var result = await context.Service.Update(updateDto);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            entity.Name.Should().Be("New Name");
            entity.MedicalId.Should().Be(3);
            entity.UserRoleGroups.Should().ContainSingle();
        }
    }

    // Cenário: atualização de usuário sem grupos de papel retornados.
    // Objetivo: manter fluxo padrão sem alterar os vínculos existentes.
    [Test]
    public async Task Update_ExistingUserWithoutRoleGroupMatches_KeepsExistingLinks()
    {
        // Arrange
        var context = new UserServiceContext();
        var entity = new User { Id = 6, Name = "Old" };
        context.Context.UserRepository.Setup(x => x.FindByID(6)).ReturnsAsync(entity);
        context.RoleGroupRepository.Setup(x => x.FindByIDs(It.IsAny<List<long>>())).ReturnsAsync([]);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Context.UserRepository.Setup(x => x.Update(entity)).ReturnsAsync(entity);

        // Act
        var result = await context.Service.Update(new UpdateUserDto { Id = 6, Name = "Updated" });

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: exceção inesperada durante a atualização.
    // Objetivo: capturar a exceção e retornar falha controlada.
    [Test]
    public async Task Update_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var context = new UserServiceContext();
        context.Context.UserRepository.Setup(x => x.FindByID(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.Service.Update(new UpdateUserDto { Id = 7 });

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: usuário existe na base.
    // Objetivo: confirmar existência via repositório.
    [Test]
    public async Task UserExists_ExistingLogin_ReturnsTrue()
    {
        // Arrange
        var context = new UserServiceContext();
        context.Context.UserRepository.Setup(x => x.UserExists("john")).ReturnsAsync(true);

        // Act
        var exists = await context.Service.UserExists("john");

        // Assert
        exists.Should().BeTrue();
    }

    // Cenário: logout de usuário inexistente.
    // Objetivo: retornar falha com mensagem de usuário não encontrado.
    [Test]
    public async Task Logout_MissingUser_ReturnsUserNotFound()
    {
        // Arrange
        var context = new UserServiceContext();
        context.Context.UserRepository.Setup(x => x.UserExists("ghost")).ReturnsAsync(false);

        // Act
        var result = await context.Service.Logout("ghost");

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: logout de usuário existente.
    // Objetivo: retornar mensagem de logout, mantendo sucesso como falso conforme contrato atual.
    [Test]
    public async Task Logout_ExistingUser_ReturnsLogoutMessage()
    {
        // Arrange
        var context = new UserServiceContext();
        context.Context.UserRepository.Setup(x => x.UserExists("john")).ReturnsAsync(true);

        // Act
        var result = await context.Service.Logout("john");

        // Assert
        result.Success.Should().BeFalse();
        result.Message.Should().NotBeNullOrWhiteSpace();
    }

    // Cenário: atualização de perfil de usuário inexistente.
    // Objetivo: retornar falha sem persistir alterações.
    [Test]
    public async Task UpdateProfile_MissingUser_ReturnsFailure()
    {
        // Arrange
        var context = new UserServiceContext();
        context.Context.UserRepository.Setup(x => x.FindByID(123)).Returns(Task.FromResult<User>(null!));

        // Act
        var result = await context.Service.UpdateProfile(new UpdateUserProfileDto { Id = 123 });

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: atualização de perfil válida com nova senha.
    // Objetivo: atualizar dados de perfil e hash de senha.
    [Test]
    public async Task UpdateProfile_ValidData_UpdatesProfileSuccessfully()
    {
        // Arrange
        var context = new UserServiceContext();
        var entity = new User { Id = 8, Name = "Old Profile" };
        context.Context.UserRepository.Setup(x => x.FindByID(8)).ReturnsAsync(entity);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<User>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.Context.UserRepository.Setup(x => x.Update(entity)).ReturnsAsync(entity);

        // Act
        var result = await context.Service.UpdateProfile(new UpdateUserProfileDto
        {
            Id = 8,
            Name = "New Profile",
            Email = "profile@x.com",
            Password = "NewPass1",
            Language = "pt-BR",
            TimeZone = "America/Sao_Paulo"
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            entity.Name.Should().Be("New Profile");
        }
    }

    // Cenário: busca de usuário existente por ID com grupos de papel vinculados.
    // Objetivo: mapear DTO e preencher grupos de papel a partir dos vínculos.
    [Test]
    public async Task FindByID_ExistingUserWithRoleGroups_ReturnsMappedDtoWithRoleGroups()
    {
        // Arrange
        var context = new UserServiceContext();
        var roleGroup = new RoleGroup { Id = 1, Description = "Manager", RolePolicyClaimCode = "Manager" };
        var entity = new User
        {
            Id = 9,
            Name = "Someone",
            UserRoleGroups = new List<RoleGroupUser> { new() { RoleGroup = roleGroup } }
        };
        context.Context.UserRepository.Setup(x => x.FindByID(9)).ReturnsAsync(entity);

        // Act
        var result = await context.Service.FindByID(9);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().NotBeNull();
            result.Data!.RoleGroups.Should().ContainSingle(x => x.RolePolicyClaimCode == "Manager");
        }
    }

    // Cenário: busca de usuário existente sem vínculos, mas com papel simples e admin.
    // Objetivo: aplicar fallback de papel e incluir grupo administrativo.
    [Test]
    public async Task FindByID_ExistingAdminWithoutRoleLinks_AppliesFallbackAndAdminGroup()
    {
        // Arrange
        var context = new UserServiceContext();
        var entity = new User { Id = 12, Name = "Admin", Role = "Manager", Admin = true, UserRoleGroups = new List<RoleGroupUser>() };
        context.Context.UserRepository.Setup(x => x.FindByID(12)).ReturnsAsync(entity);

        // Act
        var result = await context.Service.FindByID(12);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.RoleGroups.Should().Contain(x => x.RolePolicyClaimCode == "Manager");
            result.Data!.RoleGroups.Should().Contain(x => x.RolePolicyClaimCode == "Admin");
        }
    }

    // Cenário: busca de usuário inexistente por ID.
    // Objetivo: retornar sucesso sem dados.
    [Test]
    public async Task FindByID_MissingUser_ReturnsSuccessWithoutData()
    {
        // Arrange
        var context = new UserServiceContext();
        context.Context.UserRepository.Setup(x => x.FindByID(404)).Returns(Task.FromResult<User>(null!));

        // Act
        var result = await context.Service.FindByID(404);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().BeNull();
        }
    }

    // Cenário: token expirado sem principal válido.
    // Objetivo: retornar token não autenticado quando o token não puder ser lido.
    [Test]
    public async Task ValidateCredentialsToken_InvalidPrincipal_ReturnsUnauthenticatedToken()
    {
        // Arrange
        var context = new UserServiceContext();
        context.TokenService.Setup(x => x.GetPrincipalFromExpiredToken(It.IsAny<string>())).Returns((ClaimsPrincipal)null!);
        context.TokenConfiguration.SetupGet(x => x.Minutes).Returns(10);

        // Act
        var result = await context.Service.validateCredentials(new TokenVO(true, "c", "e", "access", "refresh"));

        // Assert
        result.Should().NotBeNull();
    }

    // Cenário: token válido cuja identidade não corresponde a um usuário numérico.
    // Objetivo: manter o fluxo padrão sem atualizar tokens de refresh.
    [Test]
    public async Task ValidateCredentialsToken_NonNumericIdentity_ReturnsRefreshedTimestampToken()
    {
        // Arrange
        var context = new UserServiceContext();
        var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, "not-a-number") }, "TestAuth");
        var principal = new ClaimsPrincipal(identity);
        context.TokenService.Setup(x => x.GetPrincipalFromExpiredToken(It.IsAny<string>())).Returns(principal);
        context.TokenConfiguration.SetupGet(x => x.Minutes).Returns(15);

        // Act
        var result = await context.Service.validateCredentials(new TokenVO(true, "c", "e", "access", "refresh"));

        // Assert
        result.Authenticated.Should().BeTrue();
    }

    // Cenário: refresh token válido com principal numérico.
    // Objetivo: renovar access/refresh tokens e persistir usuário.
    [Test]
    public async Task ValidateCredentialsToken_ValidRefreshToken_RenewsTokens()
    {
        // Arrange
        var context = new UserServiceContext();
        var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, "15") }, "TestAuth");
        var principal = new ClaimsPrincipal(identity);
        var user = new User
        {
            Id = 15,
            RefreshToken = "valid-refresh",
            RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(1)
        };
        context.TokenService.Setup(x => x.GetPrincipalFromExpiredToken("access")).Returns(principal);
        context.Context.UserRepository.Setup(x => x.FindByID(15)).ReturnsAsync(user);
        context.TokenService.Setup(x => x.GenerateAccessToken(principal.Claims)).Returns("new-access");
        context.TokenService.Setup(x => x.GenerateRefreshToken()).Returns("new-refresh");
        context.Context.UserRepository.Setup(x => x.RefreshUserInfo(user)).ReturnsAsync(user);
        context.TokenConfiguration.SetupGet(x => x.Minutes).Returns(20);

        // Act
        var result = await context.Service.validateCredentials(new TokenVO(true, "c", "e", "access", "valid-refresh"));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Authenticated.Should().BeTrue();
            result.AccessToken.Should().Be("new-access");
            result.RefreshToken.Should().Be("new-refresh");
            user.RefreshToken.Should().Be("new-refresh");
        }
    }

    // Cenário: refresh token expirado ou inválido.
    // Objetivo: retornar token não autenticado.
    [Test]
    public async Task ValidateCredentialsToken_ExpiredRefreshToken_ReturnsUnauthenticated()
    {
        // Arrange
        var context = new UserServiceContext();
        var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, "16") }, "TestAuth");
        var principal = new ClaimsPrincipal(identity);
        var user = new User
        {
            Id = 16,
            RefreshToken = "stale-refresh",
            RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(-1)
        };
        context.TokenService.Setup(x => x.GetPrincipalFromExpiredToken("access")).Returns(principal);
        context.Context.UserRepository.Setup(x => x.FindByID(16)).ReturnsAsync(user);
        context.TokenConfiguration.SetupGet(x => x.Minutes).Returns(10);

        // Act
        var result = await context.Service.validateCredentials(new TokenVO(true, "c", "e", "access", "stale-refresh"));

        // Assert
        result.Authenticated.Should().BeFalse();
    }

    private sealed class UserServiceContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<IRoleGroupRepository> RoleGroupRepository { get; } = new();
        public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ITokenConfigurationDto> TokenConfiguration { get; } = new();
        public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.ITokenService> TokenService { get; } = new();
        public Mock<ITokenSessionPersistenceService> TokenSessionService { get; } = new();
        public Mock<IValidator<User>> Validator { get; } = new();
        public UserService Service { get; }

        public UserServiceContext(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeApiCredential typeApiCredential = global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeApiCredential.Jwt)
        {
            var authConfig = Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.AuthConfigurationDto { IsEnable = true, TypeApiCredential = typeApiCredential });

            Service = new UserService(
                Context.SharedServices,
                Context.Config,
                Context.SharedRepositories,
                RoleGroupRepository.Object,
                TokenConfiguration.Object,
                TokenService.Object,
                authConfig,
                Validator.Object,
                TokenSessionService.Object);
        }
    }
}
