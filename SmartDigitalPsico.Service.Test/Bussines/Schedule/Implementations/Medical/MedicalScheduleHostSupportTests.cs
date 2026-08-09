using FluentValidation.Results;
using Moq;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Service.Test.TestSupport;

namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Implementations.Medical;

[TestFixture]
public class MedicalScheduleHostSupportTests
{
    // Cenário: helpers de host com usuário, tradução e validação.
    // Objetivo: cobrir SetUserId, TranslateErrors, ValidateEntityAsync, MapNewEntity e DTOs estáticos.
    [Test]
    public async Task HostSupportHelpers_UserValidationMapping_CoverStaticResponses()
    {
        // Arrange
        var ctx = new MedicalScheduleTestContext();
        ctx.HostSupport.SetUserId(42);
        ctx.EntityValidator.Setup(v => v.ValidateAsync(It.IsAny<MedicalCalendar>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(
            [
                new ValidationFailure("X", "y") { ErrorCode = "E", ErrorMessage = "y" }
            ]));

        // Act
        var translated = await ctx.HostSupport.TranslateErrors(
        [
            new global::SmartDigitalPsico.Core.SDK.Domain.VO.ErrorResponse { ErrorCode = "E1", DefaultMessage = "msg", Name = "N", FullMessage = "full" }
        ]);
        var invalid = await ctx.HostSupport.ValidateEntityAsync(new MedicalCalendar { Id = 1 });
        var entity = ctx.HostSupport.MapNewEntity(new AddMedicalCalendarDto
        {
            PatientId = 1,
            MedicalId = 2,
            Title = "Consulta",
            StartDateTime = DateTime.UtcNow.AddDays(1)
        });
        var okDto = MedicalScheduleHostSupport.OkDto(new GetMedicalCalendarDto { Id = 9 }, "ok");
        var failDto = MedicalScheduleHostSupport.FailDto(null, null);
        var okBool = MedicalScheduleHostSupport.OkBool(true, "ok");
        var failBool = MedicalScheduleHostSupport.FailBool(null);
        var loc = await ctx.HostSupport.Loc("k", "fallback");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            ctx.HostSupport.UserId.Should().Be(42);
            ctx.HostSupport.Mapper.Should().NotBeNull();
            ctx.HostSupport.Logger.Should().NotBeNull();
            ctx.HostSupport.UserRepository.Should().NotBeNull();
            ctx.HostSupport.PatientRepository.Should().NotBeNull();
            translated.Should().ContainSingle(e => e.Name == "N" && e.Message == "msg");
            invalid.Success.Should().BeFalse();
            invalid.Errors.Should().NotBeEmpty();
            entity.CreatedUserId.Should().Be(42);
            entity.PatientId.Should().Be(1);
            entity.MedicalId.Should().Be(2);
            entity.TokenRecurrence.Should().NotBeNullOrWhiteSpace();
            okDto.Success.Should().BeTrue();
            failDto.Success.Should().BeFalse();
            failDto.Message.Should().BeEmpty();
            okBool.Data.Should().BeTrue();
            failBool.Success.Should().BeFalse();
            loc.Should().Be("fallback");
        }
    }

    // Cenário: MapNewEntity recebe TokenRecurrence já preenchido.
    // Objetivo: preservar o token existente.
    [Test]
    public void MapNewEntity_ExistingToken_KeepsToken()
    {
        // Arrange

        // Act
        var ctx = new MedicalScheduleTestContext();
        ctx.HostSupport.SetUserId(1);
        var dto = new AddMedicalCalendarDto
        {
            PatientId = 1,
            MedicalId = 2,
            Title = "Consulta",
            StartDateTime = DateTime.UtcNow.AddDays(1),
            TokenRecurrence = "keep-me"
        };

        var entity = ctx.HostSupport.MapNewEntity(dto);

        // Assert
        entity.TokenRecurrence.Should().Be("keep-me");
    }
}
