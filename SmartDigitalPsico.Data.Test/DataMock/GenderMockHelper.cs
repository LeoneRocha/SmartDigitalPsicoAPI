using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class GenderMockHelper
    {
        public static Gender[] GetMock()
        {
            return GenderMockData.GetMock();
        }
    }
}
