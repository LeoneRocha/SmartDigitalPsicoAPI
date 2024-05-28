using SmartDigitalPsico.Data.ConfigureFluentAPI.Mock;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class MedicalMockHelper
    {
        public static Medical[] GetMock()
        {
            return MedicalMockData.GetMock();
        }
    }
}
