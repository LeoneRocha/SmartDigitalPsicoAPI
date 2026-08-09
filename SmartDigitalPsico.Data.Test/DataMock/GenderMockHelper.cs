using SmartDigitalPsico.Domain.EntityModels;

using SmartDigitalPsico.Data.Repository;
using SmartDigitalPsico.Data.Context.Mock;
using SmartDigitalPsico.Data.Context.Configure;
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
