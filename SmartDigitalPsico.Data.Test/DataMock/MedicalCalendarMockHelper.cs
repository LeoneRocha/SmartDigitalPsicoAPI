using Bogus;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class MedicalCalendarMockHelper
    {
        public static MedicalCalendar[] GetMockFromBogus()
        {
            var faker = new Faker<MedicalCalendar>("pt_BR")
             .RuleFor(mc => mc.Title, f => f.Lorem.Sentence())
             .RuleFor(mc => mc.StartDate, f => f.Date.Future())
             .RuleFor(mc => mc.EndDate, f => f.Date.Future())
             .RuleFor(mc => mc.AllDay, f => f.Random.Bool())
             .RuleFor(mc => mc.Status, f => f.PickRandom<EStatusCalendar>())
             .RuleFor(mc => mc.ColorCategory, f => f.Commerce.Color())
             .RuleFor(mc => mc.Url, f => f.Internet.Url())
             .RuleFor(mc => mc.PushedCalendar, f => f.Random.Bool())
             .RuleFor(mc => mc.TimeZone, f => CultureDateTimeHelper.GetTimeZoneBrazil())
             .RuleFor(mc => mc.CreatedUserId, f => f.Random.Long())
             .RuleFor(mc => mc.ModifyUserId, f => f.Random.Long())
             .RuleFor(mc => mc.CreatedDate, f => f.Date.Future())
             .RuleFor(mc => mc.ModifyDate, f => f.Date.Future())
             .RuleFor(mc => mc.LastAccessDate, f => f.Date.Future());

            var data1 = faker.Generate();
            var data2 = faker.Generate();
            var data3 = faker.Generate();

            return [data1, data2, data3];
        }
    }
}
