using System.Runtime.Serialization;

namespace SmartDigitalPsico.Domain.Helpers
{
    [Serializable]
    public class AppWarningException : Exception
    {
        protected AppWarningException()
        {
        }

        public AppWarningException(string? message) : base(message)
        {
        }

        public AppWarningException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
        public AppWarningException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}