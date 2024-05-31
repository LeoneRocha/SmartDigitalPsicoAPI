using Bogus;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class PatientFileMockHelper
    { 
        public static PatientFile[] GetMockFromBogus()
        {
            var faker = new Faker<PatientFile>("pt_BR")
                .RuleFor(m => m.CreatedUserId, 2) 
                .RuleFor(m => m.Description, f => f.Lorem.Sentence())
                .RuleFor(m => m.FileName, f => f.System.FileName())
                .RuleFor(m => m.FilePath, f => f.System.DirectoryPath())
                .RuleFor(m => m.FileData, f => f.Random.Bytes(1024))  
                .RuleFor(m => m.FileExtension, f => f.System.FileExt())
                .RuleFor(m => m.FileContentType, f => f.PickRandom("application/pdf", "image/jpeg", "text/plain"))
                .RuleFor(m => m.FileSizeKB, f => f.Random.Long(100, 1024))
                .RuleFor(m => m.TypeLocationSaveFile, f => f.PickRandom<ETypeLocationSaveFiles>());

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
