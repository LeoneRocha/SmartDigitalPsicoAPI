using Bogus;
using Bogus.DataSets;
using Serilog;
using SmartDigitalPsico.Data.ConfigureFluentAPI.Mock;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Security;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.User;
using System.Data;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class UserMockHelper
    {
        public static User[] GetMock()
        {
            return UserMockData.GetMock();
        }
        public static User[] GetMockFromBogus()
        {
            SecurityHelper.CreatePasswordHash("mockteste", out byte[] passwordHash, out byte[] passwordSalt);

            var faker = new Faker<User>("pt_BR")
                .RuleFor(u => u.Id, f => f.Random.Long())
                .RuleFor(u => u.Name, f => f.Person.FirstName)
                .RuleFor(u => u.Email, f => f.Person.Email)
                .RuleFor(u => u.Login, f => f.Internet.UserName())
                .RuleFor(u => u.PasswordHash, passwordHash)
                .RuleFor(u => u.PasswordSalt, passwordSalt)
                .RuleFor(u => u.Role, f => f.PickRandom("Admin", "Medical", "Patient", "Staff", "Pendente"))
                .RuleFor(u => u.Language, CultureDateTimeHelper.GetCultureBrazil())
                .RuleFor(u => u.TimeZone, CultureDateTimeHelper.GetTimeZoneBrazil())
                .RuleFor(u => u.RefreshToken, f => f.Random.AlphaNumeric(32))
                .RuleFor(u => u.RefreshTokenExpiryTime, f => f.Date.Future());

            var user1 = faker.Generate();
            user1.Role = "Admin";
            user1.MedicalId = 1;
            var user2 = faker.Generate();
            user2.Role = "Medical";
            user2.MedicalId = 1; 

            var user3 = faker.Generate();

            return [user1, user2, user3];
        }
    }
}