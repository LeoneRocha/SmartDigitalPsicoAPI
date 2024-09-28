using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public class SpecialtyMockData : EntityBaseConfiguration<Specialty>
    {
        public SpecialtyMockData(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<Specialty> modelBuilder)
        {
            modelBuilder.HasData(GetMock());
        }
        public static Specialty[] GetMock()
        {
            return [
                new Specialty { Id = 1, Enable = true, CreatedDate = DataHelper.GetDateTimeNow(), Description = "Psicologia Clínica", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 2, Enable = true, CreatedDate = DataHelper.GetDateTimeNow(), Description = "Psicologia Social", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 3, Enable = true, CreatedDate = DataHelper.GetDateTimeNow(), Description = "Psicologia educacional", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 4, Enable = true, CreatedDate = DataHelper.GetDateTimeNow(), Description = "Psicologia Esportiva ", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 5, Enable = true, CreatedDate = DataHelper.GetDateTimeNow(), Description = "Psicologia organizacional", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 6, Enable = true, CreatedDate = DataHelper.GetDateTimeNow(), Description = "Psicologia hospitalar", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 7, Enable = true, CreatedDate = DataHelper.GetDateTimeNow(), Description = "Psicologia do trânsito", Language = CultureConstants.LanguagePTBR }
                ];
        }
    }
}