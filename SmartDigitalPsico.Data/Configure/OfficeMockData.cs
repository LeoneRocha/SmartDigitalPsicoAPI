using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Configure
{
    public class OfficeMockData : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> modelBuilder)
        {
            modelBuilder.HasData(GetMock());
        }
        public static Office[] GetMock()
        {  
            return [
               new Office { Id = 1, CreatedDate = DataHelper.GetDateTimeNow(), Enable = true, Description = "Psicólogo", Language = CultureConstants.LanguagePTBR },
               new Office { Id = 2, CreatedDate = DataHelper.GetDateTimeNow(), Enable = true, Description = "Psicóloga", Language = CultureConstants.LanguagePTBR },
               new Office { Id = 3, CreatedDate = DataHelper.GetDateTimeNow(), Enable = true, Description = "Clínico", Language = CultureConstants.LanguagePTBR },
            ];
        }
    }
}