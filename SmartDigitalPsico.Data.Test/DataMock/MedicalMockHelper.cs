using Bogus;
using SmartDigitalPsico.Data.ConfigureFluentAPI.Mock;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class MedicalMockHelper
    {
        public static Medical[] GetMock()
        {
            return MedicalMockData.GetMock();
        } 

        public static Medical[] GetMockFromBogus()
        {
            var faker = new Faker<Medical>("pt_BR")
                .RuleFor(p => p.Name, f => f.Person.FirstName)
                .RuleFor(p => p.Email, f => f.Person.Email)
                .RuleFor(m => m.Accreditation, f => f.Lorem.Sentence())
                .RuleFor(m => m.TypeAccreditation, f => f.PickRandom<ETypeAccreditation>())
                .RuleFor(m => m.SecurityKey, f => f.Random.AlphaNumeric(10))
                .RuleFor(m => m.OfficeId, f => 1)
                .RuleFor(m => m.UserId, 2)
                .RuleFor(p => p.CreatedUserId, 1)                
                .RuleFor(m => m.ModifyUserId, f => f.Random.Long());

            var data1 = faker.Generate(); 
            var data2 = faker.Generate(); 
            var data3 = faker.Generate(); 

            return new[] { data1, data2, data3 };
        }
    }
}
