using Bogus;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class PatientAdditionalInformationMockHelper
    {
        public static PatientAdditionalInformation[] GetMockFromBogus()
        {
            var faker = new Faker<PatientAdditionalInformation>("pt_BR")
                .RuleFor(p => p.FollowUp_Psychiatric, f => f.Lorem.Sentence())
                .RuleFor(p => p.FollowUp_Neurological, f => f.Lorem.Sentence())
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