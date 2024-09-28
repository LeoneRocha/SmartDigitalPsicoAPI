using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public class MedicalSpecialtyMockData : EntityBaseConfiguration<MedicalSpecialty>
    {
        public MedicalSpecialtyMockData(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<MedicalSpecialty> modelBuilder)
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

            return [
                medical1
            ];
        }
    }
}