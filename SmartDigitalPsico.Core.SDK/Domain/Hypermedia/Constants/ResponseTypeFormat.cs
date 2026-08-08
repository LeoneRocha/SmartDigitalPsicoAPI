namespace SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants
{
    /// <summary>
    /// Formatos de content-type padrão para links hypermedia.
    /// </summary>
    public static class ResponseTypeFormat
    {
        private const string ApplicationJson = "application/json";

        public const string DefaultGet = ApplicationJson;
        public const string DefaultPost = ApplicationJson;
        public const string DefaultPut = ApplicationJson;
        public const string DefaultPatch = ApplicationJson;
    }
}
