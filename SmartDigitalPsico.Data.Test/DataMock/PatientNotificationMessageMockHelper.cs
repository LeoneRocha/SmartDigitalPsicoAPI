using Bogus;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class PatientNotificationMessageMockHelper
    { 
        public static PatientNotificationMessage[] GetMockFromBogus()
        {
            var faker = new Faker<PatientNotificationMessage>("pt_BR")
                .RuleFor(p => p.MessagePatient, f => f.Lorem.Sentence())
                .RuleFor(p => p.IsReaded, f => f.Random.Bool())
                .RuleFor(p => p.ReadingDate, f => f.Date.Past())
                .RuleFor(p => p.Notified, f => f.Random.Bool())
                .RuleFor(p => p.NotifiedDate, f => f.Date.Past())
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