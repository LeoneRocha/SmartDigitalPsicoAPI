using SmartDigitalPsico.Domain.EntityModels;

using SmartDigitalPsico.Data.Repository;
using SmartDigitalPsico.Data.Context.Mock;
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
