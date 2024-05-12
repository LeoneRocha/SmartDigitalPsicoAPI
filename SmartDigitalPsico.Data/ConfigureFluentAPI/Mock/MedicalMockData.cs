using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Mock
{
    public class MedicalMockData : IEntityTypeConfiguration<Medical>
    {
        public void Configure(EntityTypeBuilder<Medical> modelBuilder)
        {
            modelBuilder.HasData(GetMock()); 
        }
        public static Medical[] GetMock()
        {
            var newAddMedical = new Medical
            {
                Id = 1,
                Name = "Medical MOCK ",
                Email = "medical@sistemas.com",
                CreatedDate = DataHelper.GetDateTimeNow(),
                Enable = true,
                LastAccessDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                Accreditation = "123456",
                TypeAccreditation = ETypeAccreditation.CRM,
                OfficeId = 1,
                CreatedUserId = 1, 
            };

            return [
                 newAddMedical
            ];
        }
    }
}