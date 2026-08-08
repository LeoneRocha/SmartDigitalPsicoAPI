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
                   CreatedDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc(),
                   CacheId = Guid.NewGuid().ToString(), 
                   CacheKey ="unit_test", 
                   DateTimeSlidingExpiration =  SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc().AddMinutes(1),
                   LastAccessDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc(),
                   ModifyDate = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc()                   
                }
           ];
        }
    }
}
