using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class ApplicationCacheLogMockHelper
    {
        public static ApplicationCacheLog[] GetMock()
        {
            return [
               new ApplicationCacheLog {
                    Id = 1, Enable = true, 
                   CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc(),
                   CacheId = Guid.NewGuid().ToString(), 
                   CacheKey ="unit_test", 
                   DateTimeSlidingExpiration =  SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc().AddMinutes(1),
                   LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc(),
                   ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc()                   
                }
           ];
        }
    }
}
