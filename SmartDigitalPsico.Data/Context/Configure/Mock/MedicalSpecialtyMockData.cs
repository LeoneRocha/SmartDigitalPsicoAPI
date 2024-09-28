using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class MedicalSpecialtyMockData  
    { 
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