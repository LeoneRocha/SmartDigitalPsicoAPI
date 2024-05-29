using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Mock
{
    public class MedicalSpecialtyMockData : IEntityTypeConfiguration<MedicalSpecialty>
    {
        public void Configure(EntityTypeBuilder<MedicalSpecialty> modelBuilder)
        {
            modelBuilder.HasData(GetMock()); 
        }
        public static MedicalSpecialty[] GetMock()
        {
            var medical1 = new MedicalSpecialty
            { 
                MedicalId = 1,
                SpecialtyId = 1,
            };

            var medical2 = new MedicalSpecialty
            {
                MedicalId = 2,
                SpecialtyId = 2,
            };

            var medical3 = new MedicalSpecialty
            {
                MedicalId = 3,
                SpecialtyId = 3,
            };

            return [
                medical1, medical2, medical3,
            ];
        }
    }
}