using System.Globalization;
using Microsoft.Extensions.Localization;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.DTO;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Core.SDK.Tests.Domain.Helpers;

[TestFixture]
public class DateAndCultureHelperTests
{
    [Test]
    public void DateHelper_FormattingAndTimeZones_ReturnExpectedValues()
    {
        var date = new DateTime(2025, 2, 3, 4, 5, 6, DateTimeKind.Utc);

        using (Assert.EnterMultipleScope())
        {
            DateHelper.ConvertSecondsToTimeString(3661).Should().Be("01:01:01");
            DateHelper.GetDateTimeCustomFormat(date).Should().Be("03/02/2025 04:05:06");
            DateHelper.GetDateTimeNowFromUtc().Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(2));
            DateHelper.GetDateTimeNowWithTimeZone(string.Empty).Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));
            DateHelper.GetDateTimeNowWithTimeZone("UTC").Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(2));
            DateHelper.ApplyTimeZone(date, "UTC").Should().Be(date);
            DateHelper.GetDateTimeNowBrazil().Should().BeBefore(DateTime.UtcNow.AddHours(1));
            DateHelper.GetDateTimeNowToLog().Should().BeBefore(DateTime.UtcNow.AddHours(1));
        }

        DateHelper.SetCulture("en-US");
        CultureInfo.CurrentCulture.Name.Should().Be("en-US");
        DateHelper.SetCulture("pt-BR");
    }

    [Test]
    public void CultureDateTimeHelper_ValidAndFailingInputs_ReturnsExpectedValues()
    {
        var localizer = new Mock<IStringLocalizer<DateAndCultureHelperTests>>();
        localizer.Setup(x => x["welcome"]).Returns(new LocalizedString("welcome", "Bem-vinda"));

        var cultures = CultureDateTimeHelper.GetCultures();
        var translated = CultureDateTimeHelper.TranslateCulture([new CultureDisplayDto { Id = "pt-BR" }]);

        using (Assert.EnterMultipleScope())
        {
            CultureDateTimeHelper.GetTimeZonesIds().Should().NotBeEmpty();
            cultures.Select(x => x.Id).Should().Contain(["en-US", "pt-BR", "es-ES"]);
            translated.Should().ContainSingle().Which.Name.Should().Be("pt-BR");
            CultureDateTimeHelper.GetNameAndCulture("welcome").Should().Be("welcome");
            CultureDateTimeHelper.GetNameAndCulture(null!).Should().BeEmpty();
            CultureDateTimeHelper.GetKeyLocalizationRecordFormat("welcome", "pt-BR").Should().Be("welcome");
            CultureDateTimeHelper.GetKeyLocalizationRecordFormat(null!, null!).Should().BeEmpty();
            CultureDateTimeHelper.GetLocalizer(localizer.Object, "welcome").Should().Be("Bem-vinda");
            CultureDateTimeHelper.GetLocalizer<DateAndCultureHelperTests>(null!, "missing").Should().Be("NotFoundLocalization");
            CultureDateTimeHelper.GetTimeZoneBrazil().Should().NotBeNullOrWhiteSpace();
            CultureDateTimeHelper.GetCultureBrazil().Should().Be("pt-BR");
        }
    }
}
