using SmartDigitalPsico.Data.ConfigureFluentAPI.Mock;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class UserMockHelper
    {
        public static User[] GetMock()
        {
            return UserMockData.GetMock();
        } 
    }
}
