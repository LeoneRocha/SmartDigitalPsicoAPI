using Bogus;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class PatientMedicationInformationMockHelper
    {   
        public static PatientMedicationInformation[] GetMockFromBogus()
        {
            var faker = new Faker<PatientMedicationInformation>("pt_BR")
                .RuleFor(p => p.Description, f => f.Lorem.Sentence())
                .RuleFor(p => p.StartDate, f => f.Date.Past())
                .RuleFor(p => p.EndDate, f => f.Date.Future())
                .RuleFor(p => p.Dosage, f => f.Random.Words())
                .RuleFor(p => p.Posology, f => f.Random.Words())
                .RuleFor(p => p.MainDrug, f => f.Commerce.ProductName())
                .RuleFor(p => p.CreatedUserId, 2)
                .RuleFor(p => p.ModifyUserId, f => f.Random.Long());

            var data1 = faker.Generate();
            data1.PatientId = 1;
            var data2 = faker.Generate();
            data2.PatientId = 1;
            var data3 = faker.Generate();
            data3.PatientId = 2;


            return [data1, data2, data3];
        } 
    }
} 