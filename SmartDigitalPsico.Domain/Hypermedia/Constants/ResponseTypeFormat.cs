using SmartDigitalPsico.Domain.Constants;

namespace SmartDigitalPsico.Domain.Hypermedia.Constants
{
    public static class ResponseTypeFormat
    { 
        public const string DefaultGet = AppConfigConstants.ApplicationContentJon;
        public const string DefaultPost = AppConfigConstants.ApplicationContentJon;
        public const string DefaultPut = AppConfigConstants.ApplicationContentJon;
        public const string DefaultPatch = AppConfigConstants.ApplicationContentJon;
    }
}
