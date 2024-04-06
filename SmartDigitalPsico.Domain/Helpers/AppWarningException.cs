using System.Runtime.Serialization;

namespace SmartDigitalPsico.Domain.Helpers
{
    [Serializable]
    internal class AppWarningException : Exception
    {
        public AppWarningException()
        {
        }

        public AppWarningException(string? message) : base(message)
        {
        }

        public AppWarningException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AppWarningException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}