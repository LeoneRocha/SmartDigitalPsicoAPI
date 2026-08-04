using Moq;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical;
using SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical.Actions;
using SmartDigitalPsico.Service.Test.TestSupport;

namespace SmartDigitalPsico.Service.Test.Bussines.Schedule.Implementations.Medical.Actions;

[TestFixture]
public class MedicalScheduleDeleteServiceTests
{
    // Cenário: exclusão unitária com sucesso.
    // Objetivo: cobrir DeleteSingleAsync feliz.
    [Test]
    public async Task DeleteOneOrRecurrence_SingleSuccess_ReturnsOk()
    {
        // Arrange
        var ctx = CreateContext(out var query, out var delete, out var sut);
        query.Setup(x => x.GetByIdAsync(10)).ReturnsAsync(new ServiceResponse<ScheduleCalendar?>
        {
            Success = true,
            Data = new ScheduleCalendar { Id = 10, OwnerKey = MedicalScheduleKeys.ForMedical(3), UniqueToken = "u1" }
        });
        delete.Setup(x => x.DeleteByIdAsync(10)).ReturnsAsync(new ServiceResponse<bool> { Success = true });

        // Act
        var result = await sut.DeleteOneOrRecurrence(new DeleteMedicalCalendarDto { Id = 10, MedicalId = 3, DeleteSeries = false });

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: exclusão de série com permissão e falha de delete.
    // Objetivo: cobrir DeleteSeriesAsync sucesso e FailBool de delete.
    [Test]
    public async Task DeleteOneOrRecurrence_SeriesPaths_CoverPermissionAndDeleteResults()
    {
        // Arrange
        var ctx = CreateContext(out var query, out var delete, out var sut);
        query.Setup(x => x.GetByTokenAsync("tok")).ReturnsAsync(new ServiceResponse<ScheduleCalendar?>
        {
            Success = true,
            Data = new ScheduleCalendar { Id = 11, OwnerKey = MedicalScheduleKeys.ForMedical(3), UniqueToken = "u2" }
        });
        delete.Setup(x => x.DeleteByTokenFilteredAsync(It.IsAny<ScheduleDeleteTokenRequest>()))
            .ReturnsAsync(new ServiceResponse<bool> { Success = true });

        // Act
        var ok = await sut.DeleteOneOrRecurrence(new DeleteMedicalCalendarDto
        {
            MedicalId = 3,
            DeleteSeries = true,
            TokenRecurrence = "tok"
        });

        delete.Setup(x => x.DeleteByTokenFilteredAsync(It.IsAny<ScheduleDeleteTokenRequest>()))
            .ReturnsAsync(new ServiceResponse<bool> { Success = false, Message = "fail" });
        var failDelete = await sut.DeleteOneOrRecurrence(new DeleteMedicalCalendarDto
        {
            MedicalId = 3,
            DeleteSeries = true,
            TokenRecurrence = "tok"
        });

        query.Setup(x => x.GetByTokenAsync("tok2")).ReturnsAsync(new ServiceResponse<ScheduleCalendar?>
        {
            Success = true,
            Data = new ScheduleCalendar { Id = 12, OwnerKey = MedicalScheduleKeys.ForMedical(99), UniqueToken = "u3" }
        });
        var denied = await sut.DeleteOneOrRecurrence(new DeleteMedicalCalendarDto
        {
            MedicalId = 3,
            DeleteSeries = true,
            TokenRecurrence = "tok2"
        });

        query.Setup(x => x.GetByTokenAsync("missing")).ReturnsAsync(new ServiceResponse<ScheduleCalendar?> { Success = true, Data = null });
        delete.Setup(x => x.DeleteByTokenFilteredAsync(It.IsAny<ScheduleDeleteTokenRequest>()))
            .ReturnsAsync(new ServiceResponse<bool> { Success = true });
        var packageNullOk = await sut.DeleteOneOrRecurrence(new DeleteMedicalCalendarDto
        {
            MedicalId = 3,
            DeleteSeries = true,
            TokenRecurrence = "missing"
        });

        var packageNullDenied = await sut.DeleteOneOrRecurrence(new DeleteMedicalCalendarDto
        {
            MedicalId = 99,
            DeleteSeries = true,
            TokenRecurrence = "missing"
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            ok.Success.Should().BeTrue();
            failDelete.Success.Should().BeFalse();
            denied.Success.Should().BeFalse();
            packageNullOk.Success.Should().BeTrue();
            packageNullDenied.Success.Should().BeFalse();
            ctx.HostSupport.UserId.Should().Be(1);
        }
    }

    // Cenário: single not found, permission fail, delete fail e user null.
    // Objetivo: cobrir ramos restantes e catch.
    [Test]
    public async Task DeleteOneOrRecurrence_SingleFailuresAndMissingUser_ReturnFailures()
    {
        // Arrange
        var ctx = CreateContext(out var query, out var delete, out var sut);
        query.Setup(x => x.GetByIdAsync(1)).ReturnsAsync(new ServiceResponse<ScheduleCalendar?> { Success = false });

        // Act
        var missing = await sut.DeleteOneOrRecurrence(new DeleteMedicalCalendarDto { Id = 1, MedicalId = 3 });

        query.Setup(x => x.GetByIdAsync(2)).ReturnsAsync(new ServiceResponse<ScheduleCalendar?>
        {
            Success = true,
            Data = new ScheduleCalendar { Id = 2, OwnerKey = MedicalScheduleKeys.ForMedical(99), UniqueToken = "u" }
        });
        var denied = await sut.DeleteOneOrRecurrence(new DeleteMedicalCalendarDto { Id = 2, MedicalId = 3 });

        query.Setup(x => x.GetByIdAsync(3)).ReturnsAsync(new ServiceResponse<ScheduleCalendar?>
        {
            Success = true,
            Data = new ScheduleCalendar { Id = 3, OwnerKey = MedicalScheduleKeys.ForMedical(3), UniqueToken = "u" }
        });
        delete.Setup(x => x.DeleteByIdAsync(3)).ReturnsAsync(new ServiceResponse<bool> { Success = false, Message = "x" });
        var failDelete = await sut.DeleteOneOrRecurrence(new DeleteMedicalCalendarDto { Id = 3, MedicalId = 3 });

        ctx.Context.UserRepository.Setup(x => x.FindByID(1)).Returns(Task.FromResult<User>(null!));

        var missingUser = await sut.DeleteOneOrRecurrence(new DeleteMedicalCalendarDto { Id = 3, MedicalId = 3 });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            missing.Success.Should().BeFalse();
            denied.Success.Should().BeFalse();
            failDelete.Success.Should().BeFalse();
            missingUser.Success.Should().BeFalse();
        }
    }

    private static MedicalScheduleTestContext CreateContext(
        out Mock<IScheduleQueryService> query,
        out Mock<IScheduleDeleteService> delete,
        out MedicalScheduleDeleteService sut)
    {
        var ctx = new MedicalScheduleTestContext();
        ctx.HostSupport.SetUserId(1);
        ctx.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 3 });
        query = new Mock<IScheduleQueryService>();
        delete = new Mock<IScheduleDeleteService>();
        sut = new MedicalScheduleDeleteService(ctx.HostSupport, query.Object, delete.Object, ctx.NotificationAdapter);
        sut.SetUserId(1);
        return ctx;
    }
}
