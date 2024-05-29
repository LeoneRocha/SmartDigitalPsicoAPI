using Bogus;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class PatientRecordMockHelper
    {

        public static PatientRecord[] GetMockFromBogus()
        {
            var faker = new Faker<PatientRecord>("pt_BR")
                .RuleFor(p => p.CreatedUserId, 2)
                .RuleFor(p => p.Description, f => f.Lorem.Sentence())
                .RuleFor(p => p.Annotation, f => f.Lorem.Paragraph())
                .RuleFor(p => p.AnnotationDate, f => f.Date.Past());

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
