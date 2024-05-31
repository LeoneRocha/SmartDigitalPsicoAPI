using Bogus;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class MedicalFileMockHelper
    { 
        public static MedicalFile[] GetMockFromBogus()
        {
            var faker = new Faker<MedicalFile>("pt_BR")
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
            data1.MedicalId = 1;
            var data2 = faker.Generate();
            data2.MedicalId = 1;
            var data3 = faker.Generate();
            data3.MedicalId = 2;

            return [data1, data2, data3];
        }

    }
}
