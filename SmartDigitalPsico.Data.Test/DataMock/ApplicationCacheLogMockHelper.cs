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
                   CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                   CacheId = Guid.NewGuid().ToString(), 
                   CacheKey ="unit_test", 
                   DateTimeSlidingExpiration =  DateHelper.GetDateTimeNowFromUtc().AddMinutes(1),
                   LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
                   ModifyDate = DateHelper.GetDateTimeNowFromUtc()                   
                }
           ];
        }
    }
}
