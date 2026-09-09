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
                   CreatedDate = SmartCoreHub.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc(),
                   CacheId = Guid.NewGuid().ToString(),
                   CacheKey ="unit_test",
                   DateTimeSlidingExpiration =  SmartCoreHub.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc().AddMinutes(1),
                   LastAccessDate = SmartCoreHub.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc(),
                   ModifyDate = SmartCoreHub.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc()
                }
           ];
        }
    }
}
