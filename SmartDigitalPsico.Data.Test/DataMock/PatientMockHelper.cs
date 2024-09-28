using Bogus;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class PatientMockHelper
    {
        public static Patient[] GetMock()
        {
            return PatientMockData.GetMock();
        }

        public static Patient[] GetMockFromBogus()
        {
            var faker = new Faker<Patient>("pt_BR")
                .RuleFor(p => p.CreatedUserId, 2)
                .RuleFor(p => p.MedicalId, 1)
                .RuleFor(p => p.GenderId, f => f.Random.Long(1, 2))                
                .RuleFor(p => p.Name, f => f.Person.FirstName)
                .RuleFor(p => p.Email, f => f.Person.Email)
                .RuleFor(p => p.DateOfBirth, f => f.Person.DateOfBirth)
                .RuleFor(p => p.Profession, f => f.Company.CompanyName())
                .RuleFor(p => p.Cpf, f => f.Random.Replace("###.###.###-##"))
                .RuleFor(p => p.Rg, f => f.Random.Replace("##.###.###-#"))
                .RuleFor(p => p.Education, f => f.PickRandom("High School", "College", "Master's", "Ph.D."))
                .RuleFor(p => p.MaritalStatus, f => f.PickRandom<EMaritalStatus>())
                .RuleFor(p => p.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(p => p.AddressStreet, f => f.Address.StreetAddress())
                .RuleFor(p => p.AddressNeighborhood, f => f.Address.County())
                .RuleFor(p => p.AddressCity, f => f.Address.City())
                .RuleFor(p => p.AddressState, f => f.Address.State())
                .RuleFor(p => p.AddressCep, f => f.Address.ZipCode("######-###"))
                .RuleFor(p => p.EmergencyContactName, f => f.Person.FullName)
                .RuleFor(p => p.EmergencyContactPhoneNumber, f => f.Phone.PhoneNumber());

            var data1 = faker.Generate();
            var data2 = faker.Generate();
            var data3 = faker.Generate();

            return [data1, data2, data3];
        }
    }
}
