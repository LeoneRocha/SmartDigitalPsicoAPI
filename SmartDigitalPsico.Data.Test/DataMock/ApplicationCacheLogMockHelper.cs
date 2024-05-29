using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class ApplicationCacheLogMockHelper
    {
        public static ApplicationCacheLog[] GetMock()
        {
            return [
               new ApplicationCacheLog {
                    Id = 1, Enable = true, 
                   CreatedDate = DataHelper.GetDateTimeNow(),
                   CacheId = Guid.NewGuid().ToString(), 
                   CacheKey ="unit_test", 
                   DateTimeSlidingExpiration =  DataHelper.GetDateTimeNow().AddMinutes(1),
                   LastAccessDate = DataHelper.GetDateTimeNow(),
                   ModifyDate = DataHelper.GetDateTimeNow()                   
                }
           ];
        }
    }
}
